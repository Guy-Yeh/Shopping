using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping
{

    public partial class shoppingcar : Page
    {
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string orders_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            Button4.Text = "會員資料";
            Button3.Text = "登出";
            SqlConnection connection = new SqlConnection(orderdetail_data);
            string sq1 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand command1 = new SqlCommand(sq1, connection);
            connection.Open();
            SqlDataReader read1 = command1.ExecuteReader();
            if (read1.HasRows)
            {
                if (read1.Read())
                {
                    Label4.Text = read1[0].ToString();
                    Label1.Text = "消費金額：" + read1[0].ToString();
                    Button2.Visible = true;
                }
                else
                {
                    Button2.Visible = false;
                }
            }
            connection.Close();       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] != null)
            {
                SqlConnection connection = new SqlConnection(orderdetail_data);
                string sql = $"delete from OrderDetail where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("shoppingcar");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment");
        }

        protected void userorder_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="Delete") 
            {
                int index = Convert.ToInt32(e.CommandArgument);
                //string id = userorder.Rows[index].Cells[2].Text;
                string id = ((Label)userorder.Rows[Convert.ToInt32(index)].FindControl("Label1")).Text;
                SqlConnection connection = new SqlConnection(orderdetail_data);
                string sql = $"delete from OrderDetail where ID=N'{id}'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("shoppingcar");
            }
            else if (e.CommandName == "Add")
            {
                int qty = 0;
                int index = Convert.ToInt32(e.CommandArgument);
                string id = ((Label)userorder.Rows[Convert.ToInt32(index)].FindControl("Label1")).Text;
                Label label2= (Label)userorder.Rows[Convert.ToInt32(index)].FindControl("Label2");
                SqlConnection connection1 = new SqlConnection(orderdetail_data);
                string sql1 = $"select * from OrderDetail where ID=N'{id}'";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    qty = Convert.ToInt32(read1[7]);
                    qty = qty + 1;
                    SqlConnection connection3 = new SqlConnection(product_data);
                    string sql3 = $"select inventory from Products where productName=N'{read1[4].ToString()}' and category=N'{read1[5].ToString()}'";
                    SqlCommand command3 = new SqlCommand(sql3, connection3);
                    connection3.Open();
                    SqlDataReader read3 = command3.ExecuteReader();
                    if (read3.Read())
                    {
                        if (qty > Convert.ToInt32(read3[0]))
                        {
                            //MessageBox.Show("很抱歉，所選商品數量已達庫存上限'");
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，所選商品數量已達庫存上限');},1000);", true);
                        }
                        else
                        {
                            SqlConnection connection2 = new SqlConnection(orderdetail_data);
                            string sql2 = $"update OrderDetail set qty = '{qty}' where ID=N'{id}'";
                            SqlCommand command2 = new SqlCommand(sql2, connection2);
                            connection2.Open();
                            command2.ExecuteNonQuery();
                            connection2.Close();
                            label2.Text = qty.ToString();
                        }
                    }
                    connection3.Close();
                }
                connection1.Close();
            }
            else if (e.CommandName == "Subtract")
            {
                int qty = 0;
                int index = Convert.ToInt32(e.CommandArgument);
                string id = ((Label)userorder.Rows[Convert.ToInt32(index)].FindControl("Label1")).Text;
                Label label2 = (Label)userorder.Rows[Convert.ToInt32(index)].FindControl("Label2");
                SqlConnection connection1 = new SqlConnection(orderdetail_data);
                string sql1 = $"select qty from OrderDetail where ID=N'{id}'";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    qty = Convert.ToInt32(read1[0]);
                    qty = qty - 1;
                    if (qty == 0)
                    {
                        SqlConnection connection = new SqlConnection(orderdetail_data);
                        string sql = $"delete from OrderDetail where ID=N'{id}'";
                        SqlCommand command = new SqlCommand(sql, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        Response.Redirect("shoppingcar");
                    }
                    else
                    {
                        SqlConnection connection2 = new SqlConnection(orderdetail_data);
                        string sql2 = $"update OrderDetail set qty = '{qty}' where ID=N'{id}'";
                        SqlCommand command2 = new SqlCommand(sql2, connection2);
                        connection2.Open();
                        command2.ExecuteNonQuery();
                        connection2.Close();
                        connection1.Close();
                        label2.Text = qty.ToString();
                    }
                }
            }
            SqlConnection connection4 = new SqlConnection(orderdetail_data);
            string sq14 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand command4 = new SqlCommand(sq14, connection4);
            connection4.Open();
            SqlDataReader read4 = command4.ExecuteReader();
            if (read4.HasRows)
            {
                if (read4.Read())
                {
                    Label4.Text = read4[0].ToString();
                    Label1.Text = "消費金額：" + read4[0].ToString();
                    Button2.Visible = true;
                }
                else
                {
                    Button2.Visible = false;
                }
            }
            connection4.Close();
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
                Response.Redirect("index");
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