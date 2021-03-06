using Shopping.Models;
using Shopping.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping
{
    public partial class index : Page
    {
        string customers_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string show_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ShowPictureConnectionString"].ConnectionString;


        //字串承接商品名用於幻燈片圖片跳轉(1-3)，另外用於中間商品圖片跳轉
        string slideshow1 = "";
        string slideshow2 = "";
        string slideshow3 = "";
        string slideshow4 = "";
        string slideshow5 = "";
        string slideshow6 = "";
        string slideshow7 = "";
        string slideshow8 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["loginstatus"] = "1";
            //驗證是否登錄
            if (Session["loginstatus"] != null)
            {
                //loginstatus = Session["loginstatus"].ToString();
                Button12.Text = "會員資料";
                Button11.Text = "登出";
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq12 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command2 = new SqlCommand(sq12, connection2);
                connection2.Open();
                SqlDataReader read2 = command2.ExecuteReader();
                if (read2.Read())
                {
                    Label1.Text = "消費金額：" + read2[0].ToString();
                }
                connection2.Close();
            }
            SqlConnection connection1 = new SqlConnection(show_data);
            string sq11 = $"select a.picture,a.productName,b.price from ShowPicture AS a inner join Products AS b on a.productName=b.productName where (a.show='1')";
            SqlCommand command1 = new SqlCommand(sq11, connection1);
            connection1.Open();
            SqlDataReader read1 = command1.ExecuteReader();
            if (read1.Read())
            {
                ImageButton2.ImageUrl = read1[0].ToString();
                Label2.Text = read1[1].ToString();
                Label3.Text = "售價：" + read1[2].ToString();
                slideshow1 = read1[1].ToString();
                ImageButton10.ImageUrl = read1[0].ToString();
            }
            connection1.Close();                            
            //帶入幻燈片商品名稱,圖片
            SqlConnection connection3 = new SqlConnection(show_data);
            string sq13 = $"select a.picture,a.productName,b.price from ShowPicture AS a inner join Products AS b on a.productName=b.productName where (a.show='2')";
            SqlCommand command3 = new SqlCommand(sq13, connection3);
            connection3.Open();
            SqlDataReader read3 = command3.ExecuteReader();
            if (read3.Read())
            {
                ImageButton3.ImageUrl = read3[0].ToString();
                Label4.Text = read3[1].ToString();
                Label5.Text = "售價：" + read3[2].ToString();
                slideshow2 = read3[1].ToString();
                ImageButton11.ImageUrl = read3[0].ToString();
            }
            connection3.Close();
            SqlConnection connection4 = new SqlConnection(show_data);
            string sq14 = $"select a.picture,a.productName,b.price from ShowPicture AS a inner join Products AS b on a.productName=b.productName where (a.show='3')";
            SqlCommand command4 = new SqlCommand(sq14, connection4);
            connection4.Open();
            SqlDataReader read4 = command4.ExecuteReader();
            if (read4.Read())
            {
                ImageButton4.ImageUrl = read4[0].ToString();
                Label6.Text = read4[1].ToString();
                Label7.Text = "售價：" + read4[2].ToString();
                slideshow3 = read4[1].ToString();
                ImageButton12.ImageUrl = read4[0].ToString();
            }
            connection4.Close();
            SqlConnection connection5 = new SqlConnection(show_data);
            string sq15 = $"select a.picture,a.productName,b.price from ShowPicture AS a inner join Products AS b on a.productName=b.productName where (a.show='4')";
            SqlCommand command5 = new SqlCommand(sq15, connection5);
            connection5.Open();
            SqlDataReader read5 = command5.ExecuteReader();
            if (read5.Read())
            {
                ImageButton5.ImageUrl = read5[0].ToString();
                Label8.Text = read5[1].ToString();
                Label9.Text = "售價：" + read5[2].ToString();
                slideshow4 = read5[1].ToString();
            }
            connection5.Close();
            SqlConnection connection6 = new SqlConnection(show_data);
            string sq16 = $"select a.picture,a.productName,b.price from ShowPicture AS a inner join Products AS b on a.productName=b.productName where (a.show='5')";
            SqlCommand command6 = new SqlCommand(sq16, connection6);
            connection6.Open();
            SqlDataReader read6 = command6.ExecuteReader();
            if (read6.Read())
            {
                ImageButton6.ImageUrl = read6[0].ToString();
                Label10.Text = read6[1].ToString();
                Label11.Text = "售價：" + read6[2].ToString();
                slideshow5 = read6[1].ToString();
            }
            connection6.Close();
            SqlConnection connection7 = new SqlConnection(show_data);
            string sq17 = $"select a.picture,a.productName,b.price from ShowPicture AS a inner join Products AS b on a.productName=b.productName where (a.show='6')";
            SqlCommand command7 = new SqlCommand(sq17, connection7);
            connection7.Open();
            SqlDataReader read7 = command7.ExecuteReader();
            if (read7.Read())
            {
                ImageButton7.ImageUrl = read7[0].ToString();
                Label12.Text = read7[1].ToString();
                Label13.Text = "售價：" + read7[2].ToString();
                slideshow6 = read7[1].ToString();
            }
            connection7.Close();
            SqlConnection connection8 = new SqlConnection(show_data);
            string sq18 = $"select a.picture,a.productName,b.price from ShowPicture AS a inner join Products AS b on a.productName=b.productName where (a.show='7')";
            SqlCommand command8 = new SqlCommand(sq18, connection8);
            connection8.Open();
            SqlDataReader read8 = command8.ExecuteReader();
            if (read8.Read())
            {
                ImageButton8.ImageUrl = read8[0].ToString();
                Label14.Text = read8[1].ToString();
                Label15.Text = "售價：" + read8[2].ToString();
                slideshow7 = read8[1].ToString();
            }
            connection8.Close();
            SqlConnection connection9 = new SqlConnection(show_data);
            string sq19 = $"select a.picture,a.productName,b.price from ShowPicture AS a inner join Products AS b on a.productName=b.productName where (a.show='8')";
            SqlCommand command9 = new SqlCommand(sq19, connection9);
            connection9.Open();
            SqlDataReader read9 = command9.ExecuteReader();
            if (read9.Read())
            {
                ImageButton9.ImageUrl = read9[0].ToString();
                Label16.Text = read9[1].ToString();
                Label17.Text = "售價：" + read9[2].ToString();
                slideshow8 = read9[1].ToString();
            }
            connection9.Close();
        }

        [WebMethod]
        public static Models.ApiResultModel<List<indexModel>> indexproduct()
        {
            Common.Common common = new Common.Common();
            try
            {
                indexpro indexpro = new indexpro();
                List<indexModel> index = indexpro.indexproduct();

                return common.ThrowResult<List<indexModel>>(Enum.ApiStatusEnum.OK, string.Empty, index);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<List<indexModel>>(Enum.ApiStatusEnum.InternalServerError, ex.Message, null);
            }
        }

 

        protected void Button1_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'領造型線T' and category=N'{DropDownList1.SelectedValue}' ";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //如果庫存大於0
                    if (Convert.ToInt32(read1[4]) > 0)
                    {
                        //陣列分別存入商品資料的 1.商品名稱 2.商品圖片 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[2].ToString();
                        array[2] = read1[3].ToString();
                        array[3] = read1[5].ToString();
                        //連線到orderdetail確認購物車內是否有該商品
                        SqlConnection connection2 = new SqlConnection(orderdetail_data);
                        string sql2 = $"select qty from OrderDetail where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是'and customerAccount='{Session["loginstatus"]}'";
                        SqlCommand command2 = new SqlCommand(sql2, connection2);
                        connection2.Open();
                        SqlDataReader read2 = command2.ExecuteReader();
                        //如果商品已經在購物車內
                        if (read2.Read())
                        {
                            //如果購物車內的商品數量還未超過庫存
                            if (Convert.ToInt32(read2[0]) + 1 < Convert.ToInt32(read1[4]))
                            {
                                string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
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
                            Command4.Parameters["@qty"].Value = 1;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                        }
                        connection2.Close();
                    }
                    else
                    {
                        //MessageBox.Show("很抱歉，這個顏色目前已經沒有庫存了");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經沒有庫存了');},1000);", true);
                    }
                }
                connection1.Close();
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.Read())
                {
                    Label1.Text = "消費金額：" + read5[0].ToString();
                }
                connection5.Close();
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'袖滾配色t' and category=N'{DropDownList2.SelectedValue}' ";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //如果庫存大於0
                    if (Convert.ToInt32(read1[4]) > 0)
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
                            //如果購物車內的商品數量還未超過庫存
                            if (Convert.ToInt32(read2[0]) + 1 < Convert.ToInt32(read1[4]))
                            {
                                string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
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
                            Command4.Parameters["@qty"].Value = 1;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                        }
                        connection2.Close();
                    }
                    else
                    {
                        //MessageBox.Show("很抱歉，這個顏色目前已經沒有庫存了");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經沒有庫存了');},1000);", true);
                    }
                }
                connection1.Close();
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.Read())
                {
                    Label1.Text = "消費金額：" + read5[0].ToString();
                }
                connection5.Close();
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'剪裁T' and category=N'{DropDownList3.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //如果庫存大於0
                    if (Convert.ToInt32(read1[4]) > 0)
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
                            //如果購物車內的商品數量還未超過庫存
                            if (Convert.ToInt32(read2[0]) + 1 < Convert.ToInt32(read1[4]))
                            {
                                string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
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
                            Command4.Parameters["@qty"].Value = 1;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                        }
                        connection2.Close();
                    }
                    else
                    {
                        //MessageBox.Show("很抱歉，這個顏色目前已經沒有庫存了");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經沒有庫存了');},1000);", true);
                    }
                }
                connection1.Close();
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.Read())
                {
                    Label1.Text = "消費金額：" + read5[0].ToString();
                }
                connection5.Close();
            }
        }      
        protected void Button4_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'細肩露肩t' and category=N'{DropDownList4.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //如果庫存大於0
                    if (Convert.ToInt32(read1[4]) > 0)
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
                            //如果購物車內的商品數量還未超過庫存
                            if (Convert.ToInt32(read2[0]) + 1 < Convert.ToInt32(read1[4]))
                            {
                                string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
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
                            Command4.Parameters["@qty"].Value = 1;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                        }
                        connection2.Close();
                    }
                    else
                    {
                        //MessageBox.Show("很抱歉，這個顏色目前已經沒有庫存了");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經沒有庫存了');},1000);", true);
                    }
                }
                connection1.Close();
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.Read())
                {
                    Label1.Text = "消費金額：" + read5[0].ToString();
                }
                connection5.Close();
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'胸抓摺衫' and category=N'{DropDownList5.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //如果庫存大於0
                    if (Convert.ToInt32(read1[4]) > 0)
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
                            //如果購物車內的商品數量還未超過庫存
                            if (Convert.ToInt32(read2[0]) + 1 < Convert.ToInt32(read1[4]))
                            {
                                string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
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
                            Command4.Parameters["@qty"].Value = 1;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                        }
                        connection2.Close();
                    }
                    else
                    {
                        //MessageBox.Show("很抱歉，這個顏色目前已經沒有庫存了");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經沒有庫存了');},1000);", true);
                    }
                }
                connection1.Close();
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.Read())
                {
                    Label1.Text = "消費金額：" + read5[0].ToString();
                }
                connection5.Close();
            }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'格紋澎袖衫' and category=N'{DropDownList6.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //如果庫存大於0
                    if (Convert.ToInt32(read1[4]) > 0)
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
                            //如果購物車內的商品數量還未超過庫存
                            if (Convert.ToInt32(read2[0]) + 1 < Convert.ToInt32(read1[4]))
                            {
                                string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
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
                            Command4.Parameters["@qty"].Value = 1;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                        }
                        connection2.Close();
                    }
                    else
                    {
                        //MessageBox.Show("很抱歉，這個顏色目前已經沒有庫存了");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經沒有庫存了');},1000);", true);
                    }
                }
                connection1.Close();
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.Read())
                {
                    Label1.Text = "消費金額：" + read5[0].ToString();
                }
                connection5.Close();
            }
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'中抓摺雪紡衫' and category=N'{DropDownList7.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //如果庫存大於0
                    if (Convert.ToInt32(read1[4]) > 0)
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
                            //如果購物車內的商品數量還未超過庫存
                            if (Convert.ToInt32(read2[0]) + 1 < Convert.ToInt32(read1[4]))
                            {
                                string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
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
                            Command4.Parameters["@qty"].Value = 1;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                        }
                        connection2.Close();
                    }
                    else
                    {
                        //MessageBox.Show("很抱歉，這個顏色目前已經沒有庫存了");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經沒有庫存了');},1000);", true);
                    }
                }
                connection1.Close();
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.Read())
                {
                    Label1.Text = "消費金額：" + read5[0].ToString();
                }
                connection5.Close();
            }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[4];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'滾邊寬袖衫' and category=N'{DropDownList8.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    //如果庫存大於0
                    if (Convert.ToInt32(read1[4]) > 0)
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
                            //如果購物車內的商品數量還未超過庫存
                            if (Convert.ToInt32(read2[0]) + 1 < Convert.ToInt32(read1[4]))
                            {
                                string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是' and customerAccount='{Session["loginstatus"]}'";
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
                            Command4.Parameters["@qty"].Value = 1;
                            Command4.Parameters.Add("@cart", SqlDbType.NVarChar);
                            Command4.Parameters["@cart"].Value = "是";
                            Command4.ExecuteNonQuery();
                        }
                        connection2.Close();
                    }
                    else
                    {
                        //MessageBox.Show("很抱歉，這個顏色目前已經沒有庫存了");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('很抱歉，這個顏色目前已經沒有庫存了');},1000);", true);
                    }
                }
                connection1.Close();
                SqlConnection connection5 = new SqlConnection(orderdetail_data);
                string sq15 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command5 = new SqlCommand(sq15, connection5);
                connection5.Open();
                SqlDataReader read5 = command5.ExecuteReader();
                if (read5.Read())
                {
                    Label1.Text = "消費金額：" + read5[0].ToString();
                }
                connection5.Close();
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] != null)
            {
                SqlConnection connection = new SqlConnection(orderdetail_data);
                string sql = $"delete from OrderDetail where customerAccount=N'{Session["loginstatus"]}'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("index");
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow1;
            Response.Redirect("product");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow2;
            Response.Redirect("product");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow3;
            Response.Redirect("product");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow4;
            Response.Redirect("product");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow5;
            Response.Redirect("product");
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow6;
            Response.Redirect("product");
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow7;
            Response.Redirect("product");
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow8;
            Response.Redirect("product");
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }

        protected void Button12_Click(object sender, EventArgs e)
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

        protected void Button11_Click(object sender, EventArgs e)
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

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {               
                Response.Redirect(@"Customer/Chat");
            }
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow1;
            Response.Redirect("product");
        }

        protected void ImageButton11_Click1(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow2;
            Response.Redirect("product");
        }

        protected void ImageButton12_Click1(object sender, ImageClickEventArgs e)
        {
            Session["product"] = slideshow3;
            Response.Redirect("product");
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "領造型線T";
            Response.Redirect("product");
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "袖滾配色t";
            Response.Redirect("product");
        }
    }
}