using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping
{
    public partial class product: Page
    {
        string customers_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        
    protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["productName"] != null)
            {
                Session["product"] = Request.QueryString["productName"];
            }
            if (Session["product"] == null)
            {
                Response.Redirect("index");
            }
            if (!IsPostBack)
            {
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'{Session["product"]}' ";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        Label4.Text = read1[1].ToString();
                        Image1.ImageUrl = read1[2].ToString();
                        Label2.Text = read1[5].ToString();
                        Label5.Text ="尚餘庫存：" + read1[4].ToString();
                    }
                }
                connection1.Close();
            }
            else
            {
                SqlConnection connection2 = new SqlConnection(product_data);
                string sq2 = $"select * from Products where productName =N'{Session["product"]}' and category=N'{DropDownList1.SelectedItem.Text}'";
                SqlCommand command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                SqlDataReader read2 = command2.ExecuteReader();
                if (read2.HasRows)
                {
                    if (read2.Read())
                    {
                        Label4.Text = read2[1].ToString();
                        Image1.ImageUrl = read2[2].ToString();
                        Label2.Text = read2[5].ToString();
                        Label5.Text = "尚餘庫存：" + read2[4].ToString();
                    }
                }
                connection2.Close();
            }
            //登錄判定
            if (Session["loginstatus"] != null)
            {
                Button4.Text = "會員資料";
                Button3.Text = "登出";
                SqlConnection connection1 = new SqlConnection(customers_data);
                string sq11 = $"select account from Customers";
                SqlCommand command1 = new SqlCommand(sq11, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {

                    }
                }
                connection1.Close();
                //連線至orderdetail
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq12 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                //如果購物車內有商品將商品總金額顯示於Label1
                SqlCommand command2 = new SqlCommand(sq12, connection2);
                connection2.Open();
                SqlDataReader read2 = command2.ExecuteReader();
                if (read2.HasRows)
                {
                    if (read2.Read())
                    {
                        Label1.Text = "消費金額：" + read2[0].ToString();
                    }
                }
                connection2.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //判定登錄
            if (Session["loginstatus"] != null)
            {
                //連線至orderdetail
                SqlConnection connection = new SqlConnection(orderdetail_data);
                //如果購物車內有商品則刪除該帳號的購物車商品
                string sql = $"delete from OrderDetail where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("product");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //產生變數承接欲購買商品數量
            int buy = 0;
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                buy = Convert.ToInt32(DropDownList2.SelectedValue);
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'{Session["product"]}' and category=N'{DropDownList1.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //陣列分別存入商品資料的 1.商品名稱 2.商品圖片 3.商品顏色 5.商品價格
                    array[0] = read1[1].ToString();
                    array[1] = read1[2].ToString();
                    array[2] = read1[3].ToString();
                    array[3] = read1[5].ToString();
                    //連線到orderdetail確認購物車內是否有該商品
                    SqlConnection connection2 = new SqlConnection(orderdetail_data);
                    string sql2 = $"select qty from OrderDetail where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                    connection2.Open();
                    SqlDataReader read2 = command2.ExecuteReader();
                    //如果商品已經在購物車內
                    if (read2.Read())
                    {
                        //如果購物車內的商品數量加上欲購買的商品數量還未超過庫存
                        if (Convert.ToInt32(read2[0]) + buy <= Convert.ToInt32(read1[4]))
                        {
                            string sql3 = $"update OrderDetail set qty='{(Convert.ToInt32(read2[0]) + buy)}' where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
                            connection2.Close();
                            connection2.Open();
                            SqlCommand command3 = new SqlCommand(sql3, connection2);
                            command3.ExecuteNonQuery();
                            connection2.Close();
                        }
                        //購物車內的商品數量超出庫存
                        else
                        {
                            //MessageBox.Show("購物車內的數量已達庫存上限");
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('購物車內的數量已達庫存上限');},1000);", true);

                        }
                    }
                    else
                    {
                        //如果購買數量小於庫存
                        if (buy <= Convert.ToInt32(read1[4]))
                        {
                            connection2.Close();
                            connection2.Open();
                            string sql4 = $"insert into [OrderDetail](customerAccount,productPicture,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productPicture,@productName,@productColor,@productPrice,@qty,@cart)";
                            SqlCommand Command4 = new SqlCommand(sql4, connection2);
                            Command4.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                            Command4.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                            Command4.Parameters.Add("@productPicture", SqlDbType.NVarChar);
                            Command4.Parameters["@productPicture"].Value = array[1];
                            Command4.Parameters.Add("@productName", SqlDbType.NVarChar);
                            Command4.Parameters["@productName"].Value = array[0];
                            Command4.Parameters.Add("@productColor", SqlDbType.NVarChar);
                            Command4.Parameters["@productColor"].Value = array[2];
                            Command4.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                            Command4.Parameters["@productPrice"].Value = array[3];
                            Command4.Parameters.Add("@qty", SqlDbType.Int);
                            Command4.Parameters["@qty"].Value = buy;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                            connection2.Close();
                        }
                        else
                        {
                            //MessageBox.Show("很抱歉，這個顏色目前已經庫存不足");
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經庫存不足');},1000);", true);

                        }
                    }
                }
                connection1.Close();
                //連線至orderdetail
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                //如果購物車內有商品將商品總金額顯示於Label1
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.HasRows)
                {
                    if (read5.Read())
                    {
                        Label1.Text = "消費金額：" + read5[0].ToString();
                    }
                }
                connection5.Close();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                Response.Redirect(@"Customer/CustomerDetail");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("register");
            }
            else
            {
                Session.Remove("loginstatus");
                Response.Redirect("product");
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", @"setTimeout( function(){alert('–  退換貨政策  –" +
                @"\n丹丹服飾提供七日鑑賞期體驗。請注意鑑賞期並非試用期，請保持商品狀態維持全新，並保留完整包裝，" +
                @"\n1.退換貨：如果您收到的商品，商品有瑕疵或與原先訂購商品不符，或有其他退貨 / 換貨需求，請在 7 天內聯絡客服確認。" +
                @"\n（若無法於期限內提出退換貨要求，恕無法提供退換貨服務請見諒）" +
                @"\n2.退換貨注意事項：退換貨的商品必須回復原狀，即需保留完整外包裝袋、包裝盒。" +
                @"\n3.下列情形可能影響您的退換貨權限：。" +
                @"\n在您收到商品當下，務必仔細確認商品完整及符合訂購內容。" +
                @"\n其他逾越檢查之必要或可歸責於您之事由，致商品有毀損、滅失或變更者。" +
                @"\n4.若您已取得紙本發票，請於退換貨時一併附上。" +
                @"\n5.當您申請退換貨後，請主動向貨運人員索取單據，並保留至退換貨完成，以利日後查詢。" +
                @"\n感謝您的合作，如有任何疑問歡迎直接與客服人員聯繫。" +
                @"\n客服信箱：vs.for.test2021@gmail.com');},1000);", true);
        }
    }
}