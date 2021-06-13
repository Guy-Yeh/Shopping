using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{

    public partial class shoppingcar : Page
    {
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string orders_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;
        public bool reviewSerial()
        {
            Random rnd = new Random();
            string ser = "";
            for (int i = 0; i < 10; i++)    //編成serial number
            {
                int serialrnd = rnd.Next(0, 10);
                ser += serialrnd.ToString();
            }
            SqlConnection connection1 =new SqlConnection(orders_data);
            string sql1 = $"select * from Orders where serial='{ser}'";  //為了找尋serial是否重複
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            connection1.Open();
            SqlDataReader Read1 = command1.ExecuteReader();
            bool f = Read1.HasRows;
            connection1.Close();
            return f;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
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
                }
            }
            connection.Close();
            SqlConnection connection2 = new SqlConnection(orderdetail_data);
            string sq12 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
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

        protected void userorder_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = (userorder.Rows[e.RowIndex].Cells[2].Text.Trim()).ToString();
            SqlConnection connection = new SqlConnection(orderdetail_data);
            string sql = $"delete from OrderDetail where ID=N'{id}'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("shoppingcar");
        }
        protected void userorder_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {
                int qty = 0;
                int index = Convert.ToInt32(e.CommandArgument);
                string id = userorder.Rows[index].Cells[2].Text;
                SqlConnection connection1 = new SqlConnection(orderdetail_data);
                string sql1 = $"select qty from OrderDetail where ID=N'{id}'";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.Read())
                {
                    qty = Convert.ToInt32(read1[0]);
                    qty = qty + 1;

                    SqlConnection connection2 = new SqlConnection(orderdetail_data);
                    string sql2 = $"update OrderDetail set qty = '{qty}' where ID=N'{id}'";
                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    connection2.Close();
                    connection1.Close();
                }                   
            }
            else if (e.CommandName == "Subtract")
            {
                int qty = 0;
                int index = Convert.ToInt32(e.CommandArgument);
                string id = userorder.Rows[index].Cells[2].Text;
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
                    }
                }
            }
            Response.Redirect("shoppingcar");
        }
    }
}