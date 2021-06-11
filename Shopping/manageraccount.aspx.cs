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
using System.Drawing;

namespace Shopping
{
    public partial class manageraccount : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        public void reviewAccount()
        {
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Customers";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("picture");
            dt.Columns.Add("account");
            dt.Columns.Add("password");
            dt.Columns.Add("name");
            dt.Columns.Add("phone");
            dt.Columns.Add("email");
            dt.Columns.Add("address");
            dt.Columns.Add("discount");
            dt.Columns.Add("access");
            dt.Columns.Add("initdate");
            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];
                row["picture"] = ResolveUrl($"{read[1]}");
                row["account"] = read[2];
                row["password"] = read[3];
                row["name"] = read[4];
                row["phone"] = read[5];
                row["email"] = read[6];
                row["address"] = read[7];
                row["discount"] = read[8];
                row["access"] = read[9];
                row["initdate"] = read[10];
                dt.Rows.Add(row);
            }
            useraccount.DataSource = dt;
            useraccount.DataBind();
            connection.Close();

        }

        public void changecocolor()
        {
            hintColumn.ForeColor = Color.Black;
            hintID2.ForeColor = Color.Black;
            hintID.ForeColor = Color.Black;
            hintAccess.ForeColor = Color.Black;
            hintDiscount.ForeColor = Color.Black;
            hintRegion.ForeColor = Color.Black;
            hintCity.ForeColor = Color.Black;
            hintEmail.ForeColor = Color.Black;
            hintPhone.ForeColor = Color.Black;
            hintAll.ForeColor = Color.Black;
        }

       

        public void cleanbt1()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            DataView dvc = (DataView)this.SqlDataSourceCity.Select(new DataSourceSelectArguments());

            DataView dvs = (DataView)this.SqlDataSourceAccess.Select(new DataSourceSelectArguments());
            DDLCity.Items.Clear();
            DDLCity.Items.Add("請選擇縣市");
            DDLCity.DataSource = dvc;
            DDLCity.DataTextField = "city";
            DDLCity.DataBind();

            DDLAccess.Items.Clear();
            DDLAccess.Items.Add("請選擇權限");
            DDLAccess.DataSource = dvs;
            DDLAccess.DataTextField = "Cols";
            DDLAccess.DataBind();
        }
        public void cleanbt1r()
        {
            DataView dvr = (DataView)this.SqlDataSourceRegion.Select(new DataSourceSelectArguments());
            DDLRegion.Items.Clear();
            DDLRegion.Items.Add("請選擇區域");
            DDLRegion.DataSource = dvr;
            DDLRegion.DataTextField = "region";
            DDLRegion.DataBind();
        }

        public void cleanbt2()
        {
            DataView dv = (DataView)this.SqlDataSourceAccountID.Select(new DataSourceSelectArguments());
            DDLDeleteAccount.Items.Clear();
            DDLDeleteAccount.Items.Add("請選擇");
            DDLDeleteAccount.DataSource = dv;
            DDLDeleteAccount.DataTextField = "ID";
            DDLDeleteAccount.DataBind();
        }
        public void cleanbt3()
        {
            DataView dv = (DataView)this.SqlDataSourceAccountID.Select(new DataSourceSelectArguments());
            DDLUpdateAccount.Items.Clear();
            DDLUpdateAccount.Items.Add("請選擇");
            DDLUpdateAccount.DataSource = dv;
            DDLUpdateAccount.DataTextField = "ID";
            DDLUpdateAccount.DataBind();
            DataView dv2 = (DataView)this.SqlDataSourceUpdateCol.Select(new DataSourceSelectArguments());
            DDLUpdateCol.Items.Clear();
            DDLUpdateCol.Items.Add("請選擇");
            DDLUpdateCol.DataSource = dv2;
            DDLUpdateCol.DataTextField = "Cols";
            DDLUpdateCol.DataBind();
            TextBox9.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            hintAccount.Text = "";
            hintPassword.Text = "";
            hintPhone.Text = "";
            hintEmail.Text = "";
            hintDiscount.Text = "";
            hintCity.Text = "";
            hintRegion.Text = "";
            hintPicture.Text = "";
            hintAccess.Text = "";
            hintID.Text = "選擇即將刪除的accountID";
            hintID2.Text = "選擇即將更新的accountID";
            hintColumn.Text = "選擇即將更新的欄位";
            hintAll.Text = "輸入更新的值";
            changecocolor();
            
            if (!IsPostBack)
            {
                reviewAccount();
                cleanbt1();
                cleanbt2();
                cleanbt3();
            }
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection2a = Connect(s_data);
            string sql2a = $"select * from Customers where account='{TextBox1.Text}'";  //為了找尋account是否重複
            string sql2p = $"select * from Customers where phone='{TextBox4.Text}' And Access='Yes' ";   //為了找尋phone是否重複
            string sql2e = $"select * from Customers where email='{TextBox5.Text}'And Access='Yes'";   //為了找尋email是否重複
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
                                        if (DDLCity.SelectedItem.Text != "請選擇縣市")
                                        {
                                            if(DDLRegion.SelectedItem.Text != "請選擇區域")
                                            {
                                                if (discountCheck == true || TextBox10.Text == "")
                                                {
                                                    if (DDLAccess.SelectedItem.Text != "請選擇權限")
                                                    {
                                                        string sql2 = $"insert into [Customers](picture,account,password,name,phone,email,address,discount,access) values('{TextBox6.Text}','{TextBox1.Text}','{TextBox2.Text}',N'{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}',N'{DDLCity.Text + DDLRegion.Text + TextBox11.Text}','{TextBox10.Text}','{DDLAccess.Text}')";
                                                        SqlConnection connection2 = Connect(s_data);
                                                        SqlCommand command2 = new SqlCommand(sql2, connection2);
                                                        connection2.Open();
                                                        command2.ExecuteNonQuery();
                                                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt1", "setTimeout( function(){alert('輸入成功');},0);", true);
                                                        connection2.Close();
                                                        reviewAccount();
                                                        cleanbt1();
                                                        cleanbt2();
                                                        cleanbt3();
                                                    }
                                                    else
                                                    {
                                                        hintAccess.ForeColor = Color.Red;
                                                        hintAccess.Text = "請選擇項目";
                                                    }
                                                }
                                                else
                                                {
                                                    hintDiscount.ForeColor = Color.Red;
                                                    hintDiscount.Text = "discount需為數字或空白 請確認";
                                                }
                                            }
                                            else
                                            {
                                                hintRegion.ForeColor = Color.Red;
                                                hintRegion.Text = "請選擇項目";
                                            }
                                        }
                                        else
                                        {
                                            hintCity.ForeColor = Color.Red;
                                            hintCity.Text = "請選擇項目";
                                        }
                                    }
                                    else
                                    {
                                        hintEmail.ForeColor = Color.Red;
                                        hintEmail.Text = "email輸入規則錯誤 請重新輸入";
                                    }

                                }
                                else
                                {
                                    hintPhone.ForeColor = Color.Red;
                                    hintPhone.Text = "phone輸入規則錯誤 請重新輸入";
                                }

                            }
                            else
                            {
                                hintPhone.ForeColor = Color.Red;
                                hintPassword.Text = "password需包含英文字母和數字 請重新輸入";
                            }
                        }
                        else
                        {
                            hintAccount.ForeColor = Color.Red;
                            hintAccount.Text = "account需包含英文字母和數字 請重新輸入";
                        }

                    }
                    else
                    {
                        hintEmail.ForeColor = Color.Red;
                        hintEmail.Text = "email重複或未填 請重新輸入";
                        connection2e.Close();
                    }
                }
                else
                {
                    hintPhone.ForeColor = Color.Red;
                    hintPhone.Text = "phone重複或未填 請重新輸入";
                    connection2p.Close();
                }
            }
            else
            {
                hintAccount.ForeColor = Color.Red;
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
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt2", "setTimeout( function(){alert('刪除成功');},0);", true);
                connection3.Close();
                reviewAccount();
                cleanbt2();
                cleanbt3();
            }
            else
            {
                hintID.ForeColor = Color.Red;
                hintID.Text = "請選擇項目";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        { 
            bool discountCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool phoneCheck = Regex.IsMatch(TextBox9.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox9.Text, @"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})*$");
            string sql6 = $"update Customers SET {DDLUpdateCol.Text}= N'{TextBox9.Text}' where ID='{DDLUpdateAccount.Text}'";
            SqlConnection connection6 = Connect(s_data);
            string sql7 = $"select * from Customers where {DDLUpdateCol.Text}='{TextBox9.Text}'";
            string sql8 = $"select * from Customers where {DDLUpdateCol.Text}='{TextBox9.Text}' And Access='Yes'";
            bool accountpasswordCheck1 = Regex.IsMatch(TextBox9.Text, @"\d+");
            bool accountpasswordCheck2 = Regex.IsMatch(TextBox9.Text, @"[a-zA-Z]+");
           

            if (DDLUpdateAccount.SelectedItem.Text != "請選擇") 
            {
                if (DDLUpdateCol.SelectedItem.Text != "請選擇") 
                {
                    if (DDLUpdateCol.Text == "account")
                    {
                        SqlConnection connection7 = Connect(s_data);
                        SqlCommand command7 = new SqlCommand(sql7, connection7);
                        connection7.Open();
                        SqlDataReader Reader2 = command7.ExecuteReader();
                        if (Reader2.HasRows)
                        {
                            hintAll.ForeColor = Color.Red;
                            hintAll.Text = "account重複 請重新輸入";
                        }
                        else
                        {
                            if (accountpasswordCheck1 == true && accountpasswordCheck2 == true)
                            {
                                SqlCommand command6 = new SqlCommand(sql6, connection6);
                                connection6.Open();
                                command6.ExecuteNonQuery();
                                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                connection6.Close();
                                reviewAccount();
                                cleanbt3();

                            }
                            else
                            {
                                hintAll.ForeColor = Color.Red;
                                hintAll.Text = "account需包含英文字母和數字 請重新輸入";
                            }
                        }
                        connection7.Close();
                    }
                    else if (DDLUpdateCol.Text == "phone" || DDLUpdateCol.Text == "email")
                    {
                        SqlConnection connection8 = Connect(s_data);
                        SqlCommand command8 = new SqlCommand(sql8, connection8);
                        connection8.Open();
                        SqlDataReader Reader3 = command8.ExecuteReader();
                        if (Reader3.HasRows)
                        {
                            hintAll.ForeColor = Color.Red;
                            hintAll.Text = "phone/email重複 請重新輸入";
                        }
                        else
                        {
                            if (DDLUpdateCol.Text == "phone")
                            {
                                if (phoneCheck == true)
                                {
                                    SqlCommand command6 = new SqlCommand(sql6, connection6);
                                    connection6.Open();
                                    command6.ExecuteNonQuery();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    connection6.Close();
                                    reviewAccount();
                                    cleanbt3();
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
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
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    connection6.Close();
                                    reviewAccount();
                                    cleanbt3();
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "email格式錯誤 請重新輸入";
                                }
                            }
                        }
                        connection8.Close();

                    }
                    else if (DDLUpdateCol.Text == "password")
                    {
                        if (accountpasswordCheck1 == true && accountpasswordCheck2 == true)
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                            connection6.Close();
                            reviewAccount();
                            cleanbt3();
                        }
                        else
                        {
                            hintAll.ForeColor = Color.Red;
                            hintAll.Text = "password需包含英文字母和數字 請重新輸入";
                        }
                    }
                    else if (DDLUpdateCol.Text == "discount")
                    {
                        if (discountCheck == true || TextBox9.Text == "")
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                            connection6.Close();
                            reviewAccount();
                            cleanbt3();
                        }
                        else
                        {
                            hintAll.ForeColor = Color.Red;
                            hintAll.Text = "請輸入數字";
                        }
                    }

                    else
                    {
                        SqlCommand command6 = new SqlCommand(sql6, connection6);
                        connection6.Open();
                        command6.ExecuteNonQuery();
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                        connection6.Close();
                        reviewAccount();
                        cleanbt3();
                    }
                }
                else
                {
                    hintColumn.ForeColor = Color.Red;
                    hintColumn.Text = "請選擇項目";
                    
                }
            }
            
            else
            {
                hintID2.ForeColor = Color.Red;
                hintID2.Text = "請選擇項目";
                
            }
   
        }

        protected void DDLCity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            DDLRegion.Items.Clear(); 
            DDLRegion.Items.Add("請選擇區域");
   
        }
    }
}