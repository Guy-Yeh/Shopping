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
            if (Session["loginstatus"] != null)
            {
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
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq12 = $"select sum(productPrice) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
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
            if (Session["loginstatus"] != null)
            {
                SqlConnection connection = new SqlConnection(orderdetail_data);
                string sql = $"delete from OrderDetail where customerAccount=N'{Session["loginstatus"]}'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("product");
                /*HttpCookie cookie = Request.Cookies["buy"];
                if (cookie != null)
                {
                    cookie.Expires = DateTime.Now.AddDays(-2);
                    Response.Cookies.Set(cookie);
                }
                Response.Cookies["cart"].Value = "0";
                Response.Redirect("product");*/
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
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
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
            /*HttpCookie usecookie = new HttpCookie("buy");
            SqlConnection connection = new SqlConnection(picture_data);
            string sq1 = $"select ID from Products where productName =N'{Session["product"]}' and category=N'{DropDownList1.SelectedItem.Text}'";
            SqlCommand command1 = new SqlCommand(sq1, connection);
            connection.Open();
            SqlDataReader read1 = command1.ExecuteReader();
            if (read1.HasRows)
            {
                if (read1.Read())
                {
                    if (Request.Cookies["buy"] != null)
                        usecookie.Values.Add(Request.Cookies["buy"].Values);
                    usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", $"{read1[0].ToString()}");
                    Response.AppendCookie(usecookie);
                    Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
                }
            }
            connection.Close();
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label2.Text)).ToString();
            Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
            Response.Redirect("product");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }
    }
}