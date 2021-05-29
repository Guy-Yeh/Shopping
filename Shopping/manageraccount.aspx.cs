using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;

namespace Shopping
{
    public partial class manageraccount : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hintAccount.Text = "";
            hintPassword.Text = "";
            hintPhone.Text = "";
            hintEmail.Text = "";
            hintDiscount.Text = "";
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"select * from Customers";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            useraccount.DataSource = read;
            useraccount.DataBind();
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s_data2 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
            SqlConnection connection2 = new SqlConnection(s_data2);
            string sql2a = $"select * from Customers where account='{TextBox1.Text}'";
            string sql2p = $"select * from Customers where phone='{TextBox4.Text}'";
            string sql2e = $"select * from Customers where email='{TextBox5.Text}'";
            SqlCommand command2a = new SqlCommand(sql2a, connection2);
            connection2.Open();
            SqlDataReader Reader2a = command2a.ExecuteReader();
           

            bool phoneCheck = Regex.IsMatch(TextBox4.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox5.Text, @"@gmail.com");
            bool discountCheck = Regex.IsMatch(TextBox10.Text, @"\d");

            if (Reader2a.HasRows == false && TextBox1.Text!="")
            {
                connection2.Close();
                SqlCommand command2p = new SqlCommand(sql2p, connection2);
                connection2.Open();
                SqlDataReader Reader2p = command2p.ExecuteReader();
               
                if (Reader2p.HasRows == false && TextBox4.Text != "")
                {
                    connection2.Close();
                    SqlCommand command2e = new SqlCommand(sql2e, connection2);
                    connection2.Open();
                    SqlDataReader Reader2e = command2e.ExecuteReader();
                    
                    if (Reader2e.HasRows == false && TextBox5.Text != "")
                    {
                        connection2.Close();
                        if (phoneCheck == true)
                        {
                            if (emailCheck == true)
                            {
                                if (discountCheck == true || TextBox10.Text == "")
                                {
                                    if (TextBox10.Text == "")
                                    {
                                        string sql2 = $"insert into [Customers](account,password,name,phone,email,discount) values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}','')";
                                        SqlCommand command2 = new SqlCommand(sql2, connection2);
                                        connection2.Open();
                                        command2.ExecuteNonQuery();
                                        MessageBox.Show("Input Successfully");
                                        connection2.Close();
                                    }
                                    else
                                    {
                                        string sql2 = $"insert into [Customers](account,password,name,phone,email,discount) values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}','{TextBox10.Text}')";
                                        SqlCommand command2 = new SqlCommand(sql2, connection2);
                                        connection2.Open();
                                        command2.ExecuteNonQuery();
                                        MessageBox.Show("Input Successfully");
                                        connection2.Close();
                                    }
                                }
                                else
                                {
                                    hintDiscount.Text = "Discount should be blank or number, please check";
                                }
                            }
                            else
                            {
                                hintEmail.Text = "Phone rule is worng, please check";
                            }

                        }
                        else
                        {
                            hintPhone.Text = "Phone rule is worng, please check";
                        }
                        
                    }
                    else
                    {
                        hintEmail.Text = "Email repeat or is blank, please change email";
                        connection2.Close();
                    }
                }
                else
                {
                    hintPhone.Text = "Phone repeat or is blank, please change phone";
                    connection2.Close();
                }
            }
            else
            {
                hintAccount.Text = "Account repeat or is blank, please change account";
                connection2.Close();
            }


           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s_data3 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
            SqlConnection connection3 = new SqlConnection(s_data3);
            string sql3 = $"delete from Customers where ID='{TextBox6.Text}'";

            bool IDCheck = Regex.IsMatch(TextBox6.Text, @"\d");
            string s_data4 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
            SqlConnection connection4 = new SqlConnection(s_data4);
            string sql4 = $"select * from Customers where ID='{TextBox6.Text}'";
            SqlCommand command4 = new SqlCommand(sql4, connection4);
            connection4.Open();
            SqlDataReader Reader = command4.ExecuteReader();

            if (Reader.HasRows)
            {

                SqlCommand command3 = new SqlCommand(sql3, connection3);
                connection3.Open();
                command3.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully");
                connection3.Close();
            }
            else if (IDCheck == true)
            {
                hintID.Text = "There is no productID number in database";
            }
            else
            {
                hintID.Text = "Please enter number";
            }
            connection4.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}