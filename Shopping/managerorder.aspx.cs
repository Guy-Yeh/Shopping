using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping
{
    public partial class managerorder : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;
        string s_data2 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            hintPrice.Text = "";
            hintQty.Text = "";
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Orders";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            userorder.DataSource = read;
            userorder.DataBind();
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection2s = Connect(s_data);
            string sql2s = $"select * from Orders where serial='{TextBox1.Text}'";  //為了找尋serial是否重複
            SqlCommand command2s = new SqlCommand(sql2s, connection2s);
            connection2s.Open();
            SqlDataReader Reader2s = command2s.ExecuteReader();

            Random rnd = new Random();
            while (Reader2s.HasRows == true || TextBox1.Text == "")
            {
                TextBox1.Text = "";
                for (int i = 0; i < 10; i++)    //編成serial number
                {
                    int serialrnd = rnd.Next(0, 10);
                    TextBox1.Text += serialrnd;
                }
            }
            connection2s.Close();

            bool qtyCheck = Regex.IsMatch(TextBox4.Text, @"\d");
            bool priceCheck = Regex.IsMatch(TextBox5.Text, @"\d");



            if (qtyCheck == true)
            {
                if (priceCheck == true)
                {
                    TextBox11.Text = (int.Parse(TextBox4.Text) * int.Parse(TextBox5.Text)).ToString();
                    string sql2 = $"insert into [Orders](serial,customerID,productName,qty,price,totalprice,status) values('{TextBox1.Text}','{DDLAddCustomerID.Text}','{DDLAddProductName.Text}','{TextBox4.Text}','{TextBox5.Text}','{TextBox11.Text}','{TextBox10.Text}')";
                    SqlConnection connection2 = Connect(s_data);
                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Input Successfully");
                    connection2.Close();
                }
                else
                {
                    hintPrice.Text = "Qty should be number, please check";
                }
            }

            else
            {
                hintQty.Text = "Qty should be number, please check";
            }
            
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sql3 = $"delete from Orders where ID='{DDLDeleteOrderID.Text}'";
            SqlConnection connection3 = Connect(s_data);
            SqlCommand command3 = new SqlCommand(sql3, connection3);
            connection3.Open();
            command3.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully");
            connection3.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
 
            bool numberCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool priceCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            string sql6 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}' where ID='{DDLUpdateOrderID.Text}'";
            SqlConnection connection6 = Connect(s_data);
            string sql7 = $"select * from Orders where {DDLUpdateOrderCols.Text}='{TextBox9.Text}'";
            string number;
            string number2;
            
            
            if (DDLUpdateOrderCols.Text == "serial")
            {
                        SqlConnection connection7 = Connect(s_data);
                        SqlCommand command7 = new SqlCommand(sql7, connection7);
                        connection7.Open();
                        SqlDataReader Reader2 = command7.ExecuteReader();
                        if (Reader2.HasRows)
                        {
                            hintAll.Text = "Serial repeat, please change";
                        }
                        else
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            MessageBox.Show("Update Successfully");
                            connection6.Close();
                        }
                        connection7.Open();
            }
            else if (DDLUpdateOrderCols.Text == "qty" || DDLUpdateOrderCols.Text == "price")
            {
                        if (numberCheck == true)
                        {
                            if (DDLUpdateOrderCols.Text == "qty")
                            {
                                
                                string sql8 = $"select price from Orders where ID='{DDLUpdateOrderID.Text}'";
                                SqlConnection connection8 = new SqlConnection(s_data);
                                SqlCommand command8 = new SqlCommand(sql8, connection8);
                                connection8.Open();
                                SqlDataReader Reader3 = command8.ExecuteReader();
                                //string number = Reader3[0].ToString();
                                //string number2 = Convert.ToString(int.Parse(number) * int.Parse(TextBox9.Text));
                                if (Reader3.Read())
                                {
                                    number = Reader3[0].ToString();
                                    number2 = Convert.ToString(int.Parse(number) * int.Parse(TextBox9.Text));
                                    string sql9 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}',totalprice='{number2}' where ID='{DDLUpdateOrderID.Text}'";
                                    SqlConnection connection9 = new SqlConnection(s_data);
                                    SqlCommand command9 = new SqlCommand(sql9, connection9);
                                    connection9.Open();
                                    command9.ExecuteNonQuery();
                                    MessageBox.Show("Update Successfully");
                                    connection8.Close();
                                    connection9.Close();
                                }
                                
                            }
                            else
                            {
                                
                                string sql8 = $"select qty from Orders where ID='{DDLUpdateOrderID.Text}'";
                                SqlConnection connection8 = new SqlConnection(s_data);
                                SqlCommand command8 = new SqlCommand(sql8, connection8);
                                connection8.Open();
                                SqlDataReader Reader3 = command8.ExecuteReader();
                                if (Reader3.Read())
                                {
                                    number = Reader3[0].ToString();
                                    number2 = Convert.ToString(int.Parse(number) * int.Parse(TextBox9.Text));
                                    string sql9 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}',totalprice='{number2}' where ID='{DDLUpdateOrderID.Text}'";
                                    SqlConnection connection9 = new SqlConnection(s_data);
                                    SqlCommand command9 = new SqlCommand(sql9, connection9);
                                    connection9.Open();
                                    command9.ExecuteNonQuery();
                                    MessageBox.Show("Update Successfully");
                                    connection8.Close();
                                    connection9.Close();
                                }
                            }


                        }
                        else
                        {
                            hintAll.Text = "Format of qty/price is worng, please enter number";
                        }
            }
            else
            {
                        SqlCommand command6 = new SqlCommand(sql6, connection6);
                        connection6.Open();
                        command6.ExecuteNonQuery();
                        MessageBox.Show("Update Successfully");
                        connection6.Close();
            }

            
            
        }
    }
}