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
                string id = userorder.Rows[index].Cells[2].Text;
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
                string id = userorder.Rows[index].Cells[2].Text;
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
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt2", "setTimeout( function(){alert('很抱歉，所選商品數量已達庫存上限');},0);", true);
                        }
                        else
                        {
                            SqlConnection connection2 = new SqlConnection(orderdetail_data);
                            string sql2 = $"update OrderDetail set qty = '{qty}' where ID=N'{id}'";
                            SqlCommand command2 = new SqlCommand(sql2, connection2);
                            connection2.Open();
                            command2.ExecuteNonQuery();
                            connection2.Close();                            
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
    }
}