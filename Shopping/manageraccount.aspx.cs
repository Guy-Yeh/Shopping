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
        public void reviewAccount()
        {
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Customers";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            useraccount.DataSource = read;
            useraccount.DataBind();
            connection.Close();

        }



        protected void Page_Load(object sender, EventArgs e)
        {
            hintAccount.Text = "";
            hintPassword.Text = "";
            hintPhone.Text = "";
            hintEmail.Text = "";
            hintDiscount.Text = "";
            hintID.Text = "選擇即將刪除的accountID";
            hintID2.Text = "選擇即將更新的accountID";
            hintColumn.Text = "選擇即將更新的欄位";
            hintAll.Text = "輸入更新的值";
            reviewAccount();
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
           
            bool accountCheck1 = Regex.IsMatch(TextBox1.Text, @"\d+");
            bool accountCheck2 = Regex.IsMatch(TextBox1.Text, @"[a-zA-Z]+");
            bool passwordCheck1 = Regex.IsMatch(TextBox2.Text, @"\d+");
            bool passwordCheck2 = Regex.IsMatch(TextBox2.Text, @"[a-zA-Z]+");
            bool phoneCheck = Regex.IsMatch(TextBox4.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox5.Text, @"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})*$");
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
                        if (accountCheck1 == true && accountCheck2 == true)
                        {
                            if (passwordCheck1 == true && passwordCheck2 == true)
                            {
                                if (phoneCheck == true)
                                {
                                    if (emailCheck == true)
                                    {
                                        if (discountCheck == true || TextBox10.Text == "")
                                        {
                                            if (TextBox10.Text == "")
                                            {
                                                string sql2 = $"insert into [Customers](account,password,name,phone,email,address,discount) values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}','{TextBox11.Text}','')";
                                                SqlConnection connection2 = Connect(s_data);
                                                SqlCommand command2 = new SqlCommand(sql2, connection2);
                                                connection2.Open();
                                                command2.ExecuteNonQuery();
                                                MessageBox.Show("輸入成功");
                                                connection2.Close();
                                                reviewAccount();
                                            }
                                            else
                                            {
                                                string sql2 = $"insert into [Customers](account,password,name,phone,email,address,discount) values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}','{TextBox11.Text}','{TextBox10.Text}')";
                                                SqlConnection connection2 = Connect(s_data);
                                                SqlCommand command2 = new SqlCommand(sql2, connection2);
                                                connection2.Open();
                                                command2.ExecuteNonQuery();
                                                MessageBox.Show("輸入成功");
                                                connection2.Close();
                                                reviewAccount();
                                            }
                                        }
                                        else
                                        {
                                            hintDiscount.Text = "discount需為數字或空白 請確認";
                                        }
                                    }
                                    else
                                    {
                                        hintEmail.Text = "email輸入規則錯誤 請重新輸入";
                                    }

                                }
                                else
                                {
                                    hintPhone.Text = "phone輸入規則錯誤 請重新輸入";
                                }

                            }
                            else
                            {
                                hintPassword.Text = "password需包含英文字母和數字 請重新輸入";
                            }
                        }
                        else
                        {
                            hintAccount.Text = "account需包含英文字母和數字 請重新輸入";
                        }

                    }
                    else
                    {
                        hintEmail.Text = "email重複或未填 請重新輸入";
                        connection2e.Close();
                    }
                }
                else
                {
                    hintPhone.Text = "phone重複或未填 請重新輸入";
                    connection2p.Close();
                }
            }
            else
            {
                hintAccount.Text = "account重複或未填 請重新輸入";
                connection2a.Close();
            }


           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            string sql3 = $"delete from Customers where ID='{DDLDeleteAccount.Text}'";

            if (DDLDeleteAccount.SelectedItem.Text!="請選擇")
            {
                SqlConnection connection3 = Connect(s_data);
                SqlCommand command3 = new SqlCommand(sql3, connection3);
                connection3.Open();
                command3.ExecuteNonQuery();
                MessageBox.Show("刪除成功");
                connection3.Close();
                reviewAccount();
            }
            else
            {
                hintID.Text = "請選擇項目";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        { 
            bool discountCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool phoneCheck = Regex.IsMatch(TextBox9.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox9.Text, @"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})*$");
            string sql6 = $"update Customers SET {DDLUpdateCol.Text}='{TextBox9.Text}' where ID='{DDLUpdateAccount.Text}'";
            SqlConnection connection6 = Connect(s_data);
            string sql7 = $"select * from Customers where {DDLUpdateCol.Text}='{TextBox9.Text}'";

            if (DDLUpdateAccount.SelectedItem.Text != "請選擇") 
            {
                if (DDLUpdateCol.SelectedItem.Text != "請選擇") 
                {
                    if(DDLUpdateCol.Text== "account" || DDLUpdateCol.Text == "phone" || DDLUpdateCol.Text== "email")
                    {
                        SqlConnection connection7 = Connect(s_data);
                        SqlCommand command7 = new SqlCommand(sql7, connection7);
                        connection7.Open();
                        SqlDataReader Reader2 = command7.ExecuteReader();
                        if (Reader2.HasRows)
                        {
                            hintAll.Text = "Account/Phone/Email重複 請重新輸入";
                        }
                        else
                        {
                            
                            if (DDLUpdateCol.Text == "phone")
                            {
                                if (phoneCheck == true)
                                {
                                    
                                    
                                    reviewAccount();
                                }
                                else
                                {
                                    hintAll.Text = "phone格式錯誤 請重新輸入";
                                }
                            }
                            else if (DDLUpdateCol.Text == "email")
                            {
                                if (emailCheck == true)
                                {
                                    SqlCommand command6 = new SqlCommand(sql6, connection6);
                                    connection6.Open();
                                    command6.ExecuteNonQuery();
                                    MessageBox.Show("更新成功");
                                    connection6.Close();
                                    reviewAccount();
                                }
                                else
                                {
                                    hintAll.Text = "email格式錯誤 請重新輸入";
                                }
                            }
                            else
                            {
                                SqlCommand command6 = new SqlCommand(sql6, connection6);
                                connection6.Open();
                                command6.ExecuteNonQuery();
                                MessageBox.Show("更新成功");
                                connection6.Close();
                                reviewAccount();
                            }
                        }
                        connection7.Close();
                    }
                    else if (DDLUpdateCol.Text == "discount")
                    {
                        if (discountCheck == true || TextBox9.Text == "")
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            MessageBox.Show("更新成功");
                            connection6.Close();
                            reviewAccount();
                        }
                        else
                        {
                            hintAll.Text = "請輸入數字";
                        }
                    }
                    else
                    {
                        SqlCommand command6 = new SqlCommand(sql6, connection6);
                        connection6.Open();
                        command6.ExecuteNonQuery();
                        MessageBox.Show("更新成功");
                        connection6.Close();
                        reviewAccount();
                    }
                }
                else
                {
                    hintColumn.Text = "請選擇項目";
                }
            }
            
            else
            {
                hintID2.Text = "請選擇項目";
            }
   
        }
    }
}