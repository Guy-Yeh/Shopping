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
using System.IO;
using System.Text;

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
            dt.Columns.Add("showpicture");
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

                if (read[1].ToString() == "" || read[1] is null)
                {
                    row["picture"] = @"/images/使用者照片/def.jpg";
                }
                else 
                {
                    row["picture"] = read[1];
                }
                row["showpicture"] = read[1].ToString().Replace("/images/使用者照片/", "");
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

        public void searchaccount(string a)
        {
            SqlConnection connection = Connect(s_data);
            SqlCommand command = new SqlCommand(a, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("picture");
            dt.Columns.Add("showpicture");
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

                if (read[1].ToString() == "" || read[1] is null)
                {
                    row["picture"] = @"/images/使用者照片/def.jpg";
                }
                else
                {
                    row["picture"] = read[1];
                }
                row["showpicture"] = read[1].ToString().Replace("/images/使用者照片/","");
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

        public void changecolor()
        {
            hintPicture.ForeColor = Color.Black;
            hintAccount.ForeColor = Color.Black;
            hintPassword.ForeColor = Color.Black;
            hintColumn.ForeColor = Color.Black;
            hintID2.ForeColor = Color.Black;
            hintID.ForeColor = Color.Black;
            hintAccess.ForeColor = Color.Black;
            hintRoad.ForeColor = Color.Black;
            hintDiscount.ForeColor = Color.Black;
            hintRegion.ForeColor = Color.Black;
            hintCity.ForeColor = Color.Black;
            hintEmail.ForeColor = Color.Black;
            hintPhone.ForeColor = Color.Black;
            hintAll.ForeColor = Color.Black;
            hintName.ForeColor = Color.Black;
            hintIDS.ForeColor = Color.Black;

        }

        public bool checkaccount(string a)
        {
            SqlConnection connection = Connect(s_data);
            string sql = $"select account from Customers where account='{a}'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            bool check = read.Read();
            connection.Close();
            return check;
        }
       

        public void cleanbt1()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
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
            DDLAccess.Items.Add("請選擇");
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
            //DataView dv = (DataView)this.SqlDataSourceAccount.Select(new DataSourceSelectArguments());
            //DDLDeleteAccount.Items.Clear();
            //DDLDeleteAccount.Items.Add("請選擇");
            //DDLDeleteAccount.DataSource = dv;
            //DDLDeleteAccount.DataTextField = "account";
            //DDLDeleteAccount.DataBind();
            TextBox6.Text = "";
        }

        

        public void cleanbt3()
        {
            //DataView dv = (DataView)this.SqlDataSourceAccount.Select(new DataSourceSelectArguments());
            //DDLUpdateAccount.Items.Clear();
            //DDLUpdateAccount.Items.Add("請選擇");
            //DDLUpdateAccount.DataSource = dv;
            //DDLUpdateAccount.DataTextField = "account";
            //DDLUpdateAccount.DataBind();
            TextBox8.Text = "";
            DataView dv2 = (DataView)this.SqlDataSourceUpdateCol.Select(new DataSourceSelectArguments());
            DDLUpdateCol.Items.Clear();
            DDLUpdateCol.Items.Add("請選擇");
            DDLUpdateCol.DataSource = dv2;
            DDLUpdateCol.DataTextField = "Cols";
            DDLUpdateCol.DataBind();
            TextBox9.Text = "";
        }

        
        public void cleanbt4()
        {
            //DataView dv = (DataView)this.SqlDataSourceAccount.Select(new DataSourceSelectArguments());
            //DDLSearchAccount.Items.Clear();
            //DDLSearchAccount.Items.Add("請選擇");
            //DDLSearchAccount.DataSource = dv;
            //DDLSearchAccount.DataTextField = "account";
            //DDLSearchAccount.DataBind();
            TextBox7.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["access"] != null && Session["access"] == "ok")
            //{

            //}
            //else
            //{
            //    Response.Redirect("manager");
            //}

            hintAccount.Text = "";
            hintPassword.Text = "";
            hintName.Text = "";
            hintPhone.Text = "";
            hintEmail.Text = "";
            hintRoad.Text = "";
            hintDiscount.Text = "";
            hintCity.Text = "";
            hintRegion.Text = "";
            hintPicture.Text = "非必選";
            hintAll.Text = "";
            hintAll.Text = "";
            hintAccess.Text = "請選擇權限";
            hintID.Text = "";
            hintID2.Text = "";
            hintColumn.Text = "選擇即將更新的欄位";
            hintIDS.Text = "";
            changecolor();
            
            if (!IsPostBack)
            {
                reviewAccount();
                cleanbt1();
                cleanbt2();
                cleanbt3();
                cleanbt4();
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {

            string sql2p = $"select * from Customers where phone='{TextBox4.Text}' And Access='Yes' ";   //為了找尋phone是否重複
            string sql2e = $"select * from Customers where email='{TextBox5.Text}'And Access='Yes'";   //為了找尋email是否重複
            bool accountCheck = Regex.IsMatch(TextBox1.Text, @"[\w-]{6,15}");
            bool passwordCheck = Regex.IsMatch(TextBox2.Text, @"[\w-]{7,20}");
            bool phoneCheck = Regex.IsMatch(TextBox4.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox5.Text, @"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})*$");
            bool discountCheck = Regex.IsMatch(TextBox10.Text, @"\d");           
            bool nameCheck = Regex.IsMatch(TextBox3.Text, @"^[A-Za-z\u4e00-\u9fa5]+$");
            
            
            SqlConnection connection2a = Connect(s_data);
            string sql2a = $"select * from Customers where account='{TextBox1.Text}'";  //為了找尋account是否重複
            SqlCommand command2a = new SqlCommand(sql2a, connection2a);
            connection2a.Open();
            SqlDataReader Reader2a = command2a.ExecuteReader();
            //
            if (Reader2a.HasRows == false && TextBox1.Text != "")
            {
                connection2a.Close();
                if (accountCheck)
                {
                    if (passwordCheck)
                    {
                        if (TextBox3.Text != "")
                        {
                            if (nameCheck)
                            {
                                if (Encoding.Default.GetByteCount(TextBox3.Text)>=4 && Encoding.Default.GetByteCount(TextBox3.Text)<=10)
                                {
                                    SqlConnection connection2p = Connect(s_data);
                                    SqlCommand command2p = new SqlCommand(sql2p, connection2p);
                                    connection2p.Open();
                                    SqlDataReader Reader2p = command2p.ExecuteReader();

                                    if (Reader2p.HasRows == false && TextBox4.Text != "")
                                    {
                                        connection2p.Close();
                                        if (phoneCheck)
                                        {
                                            SqlConnection connection2e = Connect(s_data);
                                            SqlCommand command2e = new SqlCommand(sql2e, connection2e);
                                            connection2e.Open();
                                            SqlDataReader Reader2e = command2e.ExecuteReader();

                                            if (Reader2e.HasRows == false && TextBox5.Text != "")
                                            {
                                                connection2e.Close();

                                                if (emailCheck)
                                                {
                                                    if (DDLCity.SelectedItem.Text != "請選擇縣市")
                                                    {
                                                        if (DDLRegion.SelectedItem.Text != "請選擇區域")
                                                        {
                                                            if (TextBox11.Text != "")
                                                            {
                                                                if (discountCheck || TextBox10.Text == "")
                                                                {
                                                                    if (DDLAccess.SelectedItem.Text != "請選擇")
                                                                    {

                                                                        HttpPostedFile myFile = FileUpload1.PostedFile;
                                                                        int nFileLen = myFile.ContentLength;
                                                                        if (FileUpload1.HasFile && nFileLen > 0)
                                                                        {
                                                                            string picturePath0 = $"/images/使用者照片/{TextBox1.Text}.jpg";
                                                                            string picturePath1 = $"/images/使用者照片/{TextBox1.Text}.jpg";
                                                                            string imgPath = Server.MapPath(picturePath1);
                                                                            FileUpload1.SaveAs(imgPath);

                                                                            string sql2 = $"insert into [Customers](picture,account,password,name,phone,email,address,discount,access) values( N'{picturePath0}','{TextBox1.Text.ToLower()}','{TextBox2.Text}',N'{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text.ToLower()}',N'{DDLCity.Text + DDLRegion.Text + TextBox11.Text}','{TextBox10.Text}','{DDLAccess.Text}')";
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
                                                                            cleanbt1r();
                                                                        }
                                                                        else
                                                                        {
                                                                            string sql2 = $"insert into [Customers](account,password,name,phone,email,address,discount,access) values('{TextBox1.Text.ToLower()}','{TextBox2.Text}',N'{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text.ToLower()}',N'{DDLCity.Text + DDLRegion.Text + TextBox11.Text}','{TextBox10.Text}','{DDLAccess.Text}')";
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
                                                                            cleanbt4();
                                                                            cleanbt1r();

                                                                        }
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
                                                                hintRoad.ForeColor = Color.Red;
                                                                hintRoad.Text = "address不得為空 請重新輸入";
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
                                                hintEmail.ForeColor = Color.Red;
                                                hintEmail.Text = "email重複或未填 請重新輸入";
                                                connection2e.Close();
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
                                        hintPhone.Text = "phone重複或未填 請重新輸入";
                                        connection2p.Close();
                                    }
                                }
                                else
                                {
                                    hintName.ForeColor = Color.Red;
                                    hintName.Text = "name需介於4-10個位元";
                                }
                            }
                            else
                            {
                                hintName.ForeColor = Color.Red;
                                hintName.Text = "name只能包含中文和英文";
                            }
                        }
                        else
                        {
                            hintName.ForeColor = Color.Red;
                            hintName.Text = "name不得為空";
                        }
                    }
                    else
                    {
                        hintPassword.ForeColor = Color.Red;
                        hintPassword.Text = "password需包含7-20個英文字母加數字 請重新輸入";
                    }
                }
                else
                {
                    hintAccount.ForeColor = Color.Red; 
                    hintAccount.Text = "account需包含6-15個英文字母加數字 請重新輸入";
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
            string sql3 = $"delete from Customers where account='{TextBox6.Text}'";
            if (TextBox6.Text != "")
            {
                if (checkaccount(TextBox6.Text))
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
                    cleanbt4();
                }
                else
                {
                    hintID.ForeColor = Color.Red;
                    hintID.Text = "account不存在 請重新輸入";
                }
            }
            else
            {
                hintID.ForeColor = Color.Red;
                hintID.Text = "account不得為空 請重新輸入";
            }

        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    string sql3 = $"delete from Customers where account='{DDLDeleteAccount.Text}'";

        //    if (DDLDeleteAccount.SelectedItem.Text!="請選擇")
        //    {
        //        SqlConnection connection3 = Connect(s_data);
        //        SqlCommand command3 = new SqlCommand(sql3, connection3);
        //        connection3.Open();
        //        command3.ExecuteNonQuery();
        //        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt2", "setTimeout( function(){alert('刪除成功');},0);", true);
        //        connection3.Close();
        //        reviewAccount();
        //        cleanbt2();
        //        cleanbt3();
        //        cleanbt4();
        //    }
        //    else
        //    {
        //        hintID.ForeColor = Color.Red;
        //        hintID.Text = "請選擇項目";
        //    }

        //}

        protected void Button3_Click(object sender, EventArgs e)
        {
            bool nameCheck = Regex.IsMatch(TextBox9.Text, @"^[A-Za-z\u4e00-\u9fa5]+$");
            bool discountCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool phoneCheck = Regex.IsMatch(TextBox9.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox9.Text, @"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})*$");
            string sql6 = $"update Customers SET {DDLUpdateCol.Text}= N'{TextBox9.Text}' where account='{TextBox8.Text}'";
            string sql6CS = $"update Customers SET {DDLUpdateCol.Text}= N'{TextBox9.Text.ToLower()}' where account='{TextBox8.Text}'";
            SqlConnection connection6 = Connect(s_data);
            SqlConnection connection6CS = Connect(s_data);
            string sql7 = $"select * from Customers where {DDLUpdateCol.Text}='{TextBox9.Text}'";
            string sql8 = $"select * from Customers where {DDLUpdateCol.Text}='{TextBox9.Text.ToLower()}' And Access='Yes'";
            bool accountCheck = Regex.IsMatch(TextBox9.Text, @"[\w-]{6,15}");
            bool passwordCheck = Regex.IsMatch(TextBox9.Text, @"[\w-]{7,20}");

            if (TextBox8.Text != "")
            {
                if (checkaccount(TextBox8.Text))
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
                                if (accountCheck)
                                {
                                    SqlCommand command6CS = new SqlCommand(sql6CS, connection6CS);
                                    connection6CS.Open();
                                    command6CS.ExecuteNonQuery();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    connection6CS.Close();
                                    reviewAccount();
                                    cleanbt2();
                                    cleanbt3();
                                    cleanbt4();
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "account需包含6-15個英文字母加數字 請重新輸入";
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
                                    if (phoneCheck)
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
                                else 
                                {
                                    if (emailCheck)
                                    {
                                        SqlCommand command6CS = new SqlCommand(sql6CS, connection6CS);
                                        connection6CS.Open();
                                        command6CS.ExecuteNonQuery();
                                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                        connection6CS.Close();
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
                            if (passwordCheck)
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
                                hintAll.Text = "password需包含7-20個英文字母加數字 請重新輸入";
                            }
                        }
                        else if (DDLUpdateCol.Text == "discount")
                        {
                            if (discountCheck || TextBox9.Text == "")
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

                        else if (DDLUpdateCol.Text == "name")
                        {
                            if (nameCheck)
                            {
                                if (Encoding.Default.GetByteCount(TextBox9.Text) >= 4 && Encoding.Default.GetByteCount(TextBox9.Text) <= 10)
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
                                    hintAll.Text = "name需介於4-10個位元";
                                }
                            }
                            else
                            {
                                hintAll.ForeColor = Color.Red;
                                hintAll.Text = "name只能包含中文和英文";
                            }
                        }

                        else if (DDLUpdateCol.Text == "picture")
                        {
                            if (TextBox9.Text != "")
                            {
                                string pc = @"images/使用者照片/";
                                string str = System.AppDomain.CurrentDomain.BaseDirectory;
                                bool checkroot = TextBox9.Text.Contains(pc);
                                string TT9 = (TextBox9.Text).Replace(@"/", @"\").Remove(0, 1);
                                if (checkroot)
                                {
                                    if (File.Exists($@"{str + TT9}"))
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
                                        hintAll.Text = "picture檔案不存在<br>請確認「使用者照片」資料夾<br>是否存在該檔案 ";
                                    }
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "picture路徑格式錯誤<br>格式:/images/使用者照片/你的檔名.jpg ";

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

                        else if (DDLUpdateCol.Text == "access")
                        {
                            if (TextBox9.Text == "Yes" || TextBox9.Text == "No")
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
                                hintAll.Text = "access只能修改為Yes或No 請重新輸入";
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
                    hintID2.Text = "account不存在 請重新輸入";
                }
            }
            else
            {
                hintID2.ForeColor = Color.Red;
                hintID2.Text = "account不得為空 請重新輸入";

            }
   
        }

        protected void DDLCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanbt1r();
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["access"] = "Not ok";
            Response.Redirect("manager");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string sql3 = $"select * from Customers where account='{TextBox7.Text}'";
            if (TextBox7.Text != "")
            {
                if (checkaccount(TextBox7.Text))
                {
                    searchaccount(sql3);                    
                    cleanbt4();
                }
                else
                {
                    hintIDS.ForeColor = Color.Red;
                    hintIDS.Text = "帳號不存在 請重新輸入";
                }
            }
            else
            {
                hintIDS.ForeColor = Color.Red;
                hintIDS.Text = "account不得為空 請重新輸入";
            }
        }

        //gridview刪除客戶資料
        protected void useraccount_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string ID = useraccount.DataKeys[e.RowIndex].Value.ToString();           
            SqlConnection connection = new SqlConnection(s_data);
            SqlCommand command = new SqlCommand($"delete from Customers where ID = '{ID}'", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            reviewAccount();
        }

       

        protected void useraccount_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            useraccount.EditIndex = -1;
            reviewAccount();
        }

        protected void useraccount_RowEditing(object sender, GridViewEditEventArgs e)
        {
            useraccount.EditIndex = e.NewEditIndex;
            reviewAccount();
        }

        protected void useraccount_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            bool nameCheck = Regex.IsMatch(TextBox9.Text, @"^[A-Za-z\u4e00-\u9fa5]+$");
            bool discountCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool phoneCheck = Regex.IsMatch(TextBox9.Text, @"^09[\d]{8}");
            bool emailCheck = Regex.IsMatch(TextBox9.Text, @"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})*$");
            string sql6 = $"update Customers SET {DDLUpdateCol.Text}= N'{TextBox9.Text}' where account='{TextBox8.Text}'";
            string sql6CS = $"update Customers SET {DDLUpdateCol.Text}= N'{TextBox9.Text.ToLower()}' where account='{TextBox8.Text}'";
            SqlConnection connection6 = Connect(s_data);
            SqlConnection connection6CS = Connect(s_data);
            string sql7 = $"select * from Customers where {DDLUpdateCol.Text}='{TextBox9.Text}'";
            string sql8 = $"select * from Customers where {DDLUpdateCol.Text}='{TextBox9.Text.ToLower()}' And Access='Yes'";
            bool accountCheck = Regex.IsMatch(TextBox9.Text, @"[\w-]{6,15}");
            bool passwordCheck = Regex.IsMatch(TextBox9.Text, @"[\w-]{7,20}");

            string ID = useraccount.DataKeys[e.RowIndex].Values[0].ToString();
            string access = ((TextBox)useraccount.Rows[e.RowIndex].FindControl("TextBox2")).Text;
           



            //string update = $"update Customers SET account= N'{TextBox9.Text}' where account='{TextBox8.Text}'";
      
            //string sqlSP = $"select picture from Customers where ID='{ID}'";
            //SqlConnection connectionSP = new SqlConnection(s_data);
            //SqlCommand commandSP = new SqlCommand(sqlSP, connectionSP);
            //connectionSP.Open();
            //SqlDataReader reader = commandSP.ExecuteReader();

        }

        

       



        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    string sql3 = $"select * from Customers where account='{DDLSearchAccount.Text}'";

        //    if (DDLSearchAccount.SelectedItem.Text != "請選擇")
        //    {
        //        searchaccount(sql3);
        //        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt4", "setTimeout( function(){alert('篩選成功');},0);", true);                                
        //        cleanbt4();
        //    }
        //    else
        //    {
        //        hintIDS.ForeColor = Color.Red;
        //        hintIDS.Text = "請選擇項目";
        //    }
        //}
    }
}