using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class product: Page
    {
        string customers_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
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
                    }
                }
                connection2.Close();
            }
            //登錄判定
            if (Session["loginstatus"] != null)
            {
                Button4.Text = "會員資料";
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
                string sql = $"select * from Products where productName =N'{Session["product"]}' and category=N'{DropDownList1.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 2.商品圖片 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[2].ToString();
                        array[2] = read1[3].ToString();
                        array[3] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sql2 = $"select qty from OrderDetail where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是'";
                SqlCommand command2 = new SqlCommand(sql2, connection2);
                connection2.Open();
                SqlDataReader read2 = command2.ExecuteReader();
                if (read2.Read())
                {
                    string sql3 = $"update OrderDetail set qty={Convert.ToInt32(read2[0]) + 1} where productName =N'{array[0]}' and productColor=N'{array[2]}' and cart=N'是'";
                    connection2.Close();
                    connection2.Open();
                    SqlCommand command3 = new SqlCommand(sql3, connection2);
                    command3.ExecuteNonQuery();
                    connection2.Close();
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
            Response.Redirect("product");
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
    }
}