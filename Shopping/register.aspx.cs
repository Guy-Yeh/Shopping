using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Shopping
{
    public partial class register : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        protected void Page_Load(object sender, EventArgs e)
        {           
            errorText.Text = "";
            if (IsPostBack)
            {
                passwordText.Attributes.Add("value", passwordText.Text);
            }
            if (Session["loginstatus"] != null)
            {
                Response.Redirect("index");
            }
        }

        
        protected void registerButton_Click(object sender, EventArgs e)
        {
            if ((accountText.Text==null || accountText.Text=="")||
                (passwordText.Text == null || passwordText.Text == "") ||
                (passwordCheckText.Text == null || passwordCheckText.Text == "") ||
                (nameText.Text == null || nameText.Text == "") ||
                //(identityText.Text == null || identityText.Text == "") ||
                (phoneText.Text == null || phoneText.Text == "") ||
                (emailText.Text == null || emailText.Text == "" )||
                (addressText.Text == null || addressText.Text == ""))
            {
                errorText.Text = "*輸入資訊不得為空";
                return;
            }
                        
            string emailchange = emailText.Text.ToLower();
            string accchange = accountText.Text.ToLower();

            //輸入項目規則 (正規表示)
            bool accRule = Regex.IsMatch(accountText.Text, @"[\w-]{6,15}"); //6-15字元英數混和字串 (不分大小寫)
            bool passwordRule = Regex.IsMatch(passwordText.Text, @"[\w-]{7,20}"); //7-20字元英數混和字串
            //bool identityRule = Regex.IsMatch(identityText.Text, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$"); //身分證基礎驗證
            bool phoneRule = Regex.IsMatch(phoneText.Text, @"^09[0-9]{8}$"); //手機號碼驗證
            bool emailRule = Regex.IsMatch(emailchange, @"^[a-z0-9_\.-]+\@[\da-z\.-]+\.[a-z\.]{2,6}$"); //email驗證
            bool nameRule = Regex.IsMatch(nameText.Text, @"^[\u4e00 - \u9fa5_a - zA - Z0 - 9]{2,10} +$"); //

            //檢查有無違反規則
            if (accRule == false)
            {
                errorText.Text = "*帳號輸入格式不正確";
                accountText.Text = "";
                return;
            }
            if (passwordRule == false)
            {
                errorText.Text = "*密碼輸入格式不正確";
                passwordText.Text = "";
                passwordText.Attributes.Add("value", passwordText.Text);
                return;
            }
            /*
            if (identityRule == false)
            {
                errorText.Text = "*身分證輸入格式不正確";
                identityText.Text = "";
                return;
            }
            */
            if (phoneRule == false)
            {
                errorText.Text = "*電話輸入格式不正確";
                phoneText.Text = "";
                return;
            }
            if (emailRule == false)
            {
                errorText.Text = "*email輸入格式不正確";
                emailText.Text = "";
                return;
            }
            if (nameRule == false)
            {
                errorText.Text = "*姓名輸入格式不正確";
                nameText.Text = "";
                return;
            }

            //密碼確認檢查
            if (passwordText.Text != passwordCheckText.Text)
            {
                errorText.Text = "*密碼不一致";
                passwordText.Text = "";
                passwordText.Attributes.Add("value", passwordText.Text);
                passwordCheckText.Text = "";
                return;
            }
            //驗證碼檢查 (無區分大小寫)
            if (verificationText.Text.ToLower() != ((string)Session["ValidateNum"]).ToLower())
            {
                errorText.Text = "*驗證碼不正確";
                return;
            }

            //檢查與料庫資料是否重複
            SqlConnection connection = new SqlConnection(s_data);
            string accCheck = $"select * from Customers where account ='" + accountText.Text + "'";
            string phoneCheck = $"select * from Customers where phone ='" + phoneText.Text + "'";
            string emailCheck = $"select * from Customers where email ='" + emailText.Text + "'";
            //string identityCheck = $"select * from Customers where [identity] ='" + identityText.Text + "'";
            SqlCommand Command_acc = new SqlCommand(accCheck, connection);
            SqlCommand Command_phone = new SqlCommand(phoneCheck, connection);
            SqlCommand Command_email = new SqlCommand(emailCheck, connection);
            //SqlCommand Command_identity = new SqlCommand(identityCheck, connection);

            connection.Open();
            SqlDataReader Reader_acc = Command_acc.ExecuteReader();            
            if (Reader_acc.HasRows)
            {
                errorText.Text = "*帳號已註冊過";
                connection.Close();
                accountText.Text = "";
                return;
            }
            connection.Close();
            /*
            connection.Open();
            SqlDataReader Reader_identity = Command_identity.ExecuteReader();
            if (Reader_identity.HasRows)
            {
                errorText.Text = "*身分證已註冊過";
                connection.Close();
                emailText.Text = "";
                return;
            }
            connection.Close();
            */
            connection.Open();
            SqlDataReader Reader_phone = Command_phone.ExecuteReader();
            if (Reader_phone.HasRows)
            {
                errorText.Text = "*電話已註冊過";
                connection.Close();
                phoneText.Text = "";
                return;
            }
            connection.Close();
            connection.Open();
            SqlDataReader Reader_email = Command_email.ExecuteReader();
            if (Reader_email.HasRows)
            {
                errorText.Text = "*email已註冊過";
                connection.Close();
                emailText.Text = "";
                return;
            }
            connection.Close();
            

            //寫入會員資料
            string acc_sql = $"insert into [dbo].[Customers](account,password,name,phone,email,access,discount,address) values (@account,@passwd,@name,@phone,@email,@access,@discount,@address)";
            connection.Open();
            SqlCommand Command2 = new SqlCommand(acc_sql, connection);
            Command2.Parameters.Add("@account", SqlDbType.NVarChar);
            Command2.Parameters["@account"].Value = accchange;

            Command2.Parameters.Add("@passwd", SqlDbType.NVarChar);
            Command2.Parameters["@passwd"].Value = passwordText.Text;

            Command2.Parameters.Add("@name", SqlDbType.NVarChar);
            Command2.Parameters["@name"].Value = nameText.Text;

            //Command2.Parameters.Add("@identity", SqlDbType.NVarChar);
            //Command2.Parameters["@identity"].Value = identityText.Text;

            Command2.Parameters.Add("@phone", SqlDbType.NVarChar);
            Command2.Parameters["@phone"].Value = phoneText.Text;

            Command2.Parameters.Add("@email", SqlDbType.NVarChar);
            Command2.Parameters["@email"].Value = emailchange;

            Command2.Parameters.Add("@access", SqlDbType.NVarChar);
            Command2.Parameters["@access"].Value = "Yes";

            Command2.Parameters.Add("@discount", SqlDbType.Int);
            Command2.Parameters["@discount"].Value = 0;

            Command2.Parameters.Add("@address", SqlDbType.NVarChar);
            Command2.Parameters["@address"].Value = addressText.Text;

            Command2.ExecuteNonQuery();
            connection.Close();

            //如有勾選"註冊後登入"則給予登入中狀態
            if (logingcheck.Checked)
            {
                Session["loginstatus"] = accountText.Text;
                Response.Redirect("index");
            }
            errorText.Text = "建立成功";
            Response.Redirect("login");



            //verificationText.Text = (string)Session["ValidateNum"]; //驗證碼測試
            //Response.Redirect("loging");
        }

        protected void loginLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("login");
        }

        protected void registerLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("register");
        }

        
    }
}