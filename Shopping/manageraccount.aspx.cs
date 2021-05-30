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
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect= new SqlConnection(x);
            return connect;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            hintAccount.Text = "";
            hintPassword.Text = "";
            hintPhone.Text = "";
            hintEmail.Text = "";
            hintDiscount.Text = "";
            hintID.Text = "Enter productID you want to delete";
            hintID2.Text = "Enter table ID number";
            hintColumn.Text = "Enter table column item";
            hintAll.Text = "Enter update value";
            SqlConnection connection = Connect(s_data);
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
            SqlConnection connection2a = Connect(s_data);
            string sql2a = $"select * from Customers where account='{TextBox1.Text}'";  //為了找尋account是否重複
            string sql2p = $"select * from Customers where phone='{TextBox4.Text}'";   //為了找尋phone是否重複
            string sql2e = $"select * from Customers where email='{TextBox5.Text}'";   //為了找尋email是否重複
            SqlCommand command2a = new SqlCommand(sql2a, connection2a);
            connection2a.Open();
            SqlDataReader Reader2a = command2a.ExecuteReader();
           

            bool phoneCheck = Regex.IsMatch(TextBox4.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox5.Text, @"@gmail.com");
            bool discountCheck = Regex.IsMatch(TextBox10.Text, @"\d");

            if (Reader2a.HasRows == false && TextBox1.Text!="")
            {
                connection2a.Close();
                SqlConnection connection2p = Connect(s_data);
                SqlCommand command2p = new SqlCommand(sql2p, connection2p);
                connection2p.Open();
                SqlDataReader Reader2p = command2p.ExecuteReader();
               
                if (Reader2p.HasRows == false && TextBox4.Text != "")
                {
                    
                    connection2p.Close();
                    SqlConnection connection2e = Connect(s_data);
                    SqlCommand command2e = new SqlCommand(sql2e, connection2e);
                    connection2e.Open();
                    SqlDataReader Reader2e = command2e.ExecuteReader();
                    
                    if (Reader2e.HasRows == false && TextBox5.Text != "")
                    {
                        connection2e.Close();
                        if (phoneCheck == true)
                        {
                            if (emailCheck == true)
                            {
                                if (discountCheck == true || TextBox10.Text == "")
                                {
                                    if (TextBox10.Text == "")
                                    {
                                        string sql2 = $"insert into [Customers](account,password,name,phone,email,discount) values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}','')";
                                        SqlConnection connection2 = Connect(s_data);
                                        SqlCommand command2 = new SqlCommand(sql2, connection2);
                                        connection2.Open();
                                        command2.ExecuteNonQuery();
                                        MessageBox.Show("Input Successfully");
                                        connection2.Close();
                                    }
                                    else
                                    {
                                        string sql2 = $"insert into [Customers](account,password,name,phone,email,discount) values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}','{TextBox10.Text}')";
                                        SqlConnection connection2 = Connect(s_data);
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
                        connection2e.Close();
                    }
                }
                else
                {
                    hintPhone.Text = "Phone repeat or is blank, please change phone";
                    connection2p.Close();
                }
            }
            else
            {
                hintAccount.Text = "Account repeat or is blank, please change account";
                connection2a.Close();
            }


           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            string sql3 = $"delete from Customers where ID='{TextBox6.Text}'";

            SqlConnection connection4 = Connect(s_data);
            bool IDCheck = Regex.IsMatch(TextBox6.Text, @"\d");
            string sql4 = $"select * from Customers where ID='{TextBox6.Text}'";
            SqlCommand command4 = new SqlCommand(sql4, connection4);
            connection4.Open();
            SqlDataReader Reader = command4.ExecuteReader();

            if (Reader.HasRows)
            {
                SqlConnection connection3 = Connect(s_data);
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
            SqlConnection connection5 = Connect(s_data);
            string sql5 = $"select * from Customers where ID='{TextBox7.Text}'";
            SqlCommand command5 = new SqlCommand(sql5, connection5);
            connection5.Open();
            SqlDataReader Reader = command5.ExecuteReader();

            var customerCols = new List<string> { "account", "password", "name", "phone", "email","discount" };
            bool checkcol = false;
            foreach (string customerCol in customerCols)
            {
                if (TextBox8.Text == customerCol)
                {
                    checkcol = true;
                    break;
                }
            }

            bool IDCheck = Regex.IsMatch(TextBox7.Text, @"\d");
            bool discountCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool phoneCheck = Regex.IsMatch(TextBox9.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox9.Text, @"@gmail.com");
            string sql6 = $"update Customers SET {TextBox8.Text}='{TextBox9.Text}' where ID='{TextBox7.Text}'";
            SqlConnection connection6 = Connect(s_data);
            string sql7 = $"select * from Customers where {TextBox8.Text}='{TextBox9.Text}'";

            if (Reader.HasRows) 
            {
                if (checkcol == true) //確認輸入的Column有在database裡面
                {
                    if(TextBox8.Text== "account" || TextBox8.Text == "phone" || TextBox8.Text== "email")
                    {
                        SqlConnection connection7 = Connect(s_data);
                        SqlCommand command7 = new SqlCommand(sql7, connection7);
                        connection7.Open();
                        SqlDataReader Reader2 = command7.ExecuteReader();
                        if (Reader2.HasRows)
                        {
                            hintAll.Text = "Account/Phone/Email repeat, please change";
                        }
                        else
                        {
                            
                            if (TextBox8.Text == "phone")
                            {
                                if (phoneCheck == true)
                                {
                                    
                                    SqlCommand command6 = new SqlCommand(sql6, connection6);
                                    connection6.Open();
                                    command6.ExecuteNonQuery();
                                    MessageBox.Show("Update Successfully");
                                    connection6.Close();
                                }
                                else
                                {
                                    hintAll.Text = "Format of phone is worng, please change phone";
                                }
                            }
                            else if (TextBox8.Text == "email")
                            {
                                if (emailCheck == true)
                                {
                                    SqlCommand command6 = new SqlCommand(sql6, connection6);
                                    connection6.Open();
                                    command6.ExecuteNonQuery();
                                    MessageBox.Show("Update Successfully");
                                    connection6.Close();
                                }
                                else
                                {
                                    hintAll.Text = "Format of email is wrong, please change email";
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
                        connection7.Close();
                    }
                    else if (TextBox8.Text == "discount")
                    {
                        if (discountCheck == true || TextBox9.Text == "")
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            MessageBox.Show("Update Successfully");
                            connection6.Close();
                        }
                        else
                        {
                            hintAll.Text = "Pls enter number";
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
                else
                {
                    hintColumn.Text = "There is no your col in database";
                }
            }
            else if (IDCheck == true)
            {
                hintID2.Text = "There is no productID number in database";
            }
            else
            {
                hintID2.Text = "Please enter number";
            }
            connection5.Close();
        }
    }
}