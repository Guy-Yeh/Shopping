using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class login : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logingButton1_Click(object sender, EventArgs e)
        {
            if ((logingaccTextBox.Text == null || logingaccTextBox.Text == "") ||
                (logingpasswdTextBox.Text == null || logingpasswdTextBox.Text == ""))
            {
                errorText.Text = "*輸入資訊不得為空";
                return;
            }
            SqlConnection connection = new SqlConnection(s_data);
            string accCheck = $"select * from Customers where account ='" + logingaccTextBox.Text + "'";
            //string emailCheck = $"select * from Customers where email ='" + logingaccTextBox.Text + "'";
            SqlCommand Command_acc = new SqlCommand(accCheck, connection);
            //SqlCommand Command_email = new SqlCommand(emailCheck, connection);
            connection.Open();
            SqlDataReader Reader_acc = Command_acc.ExecuteReader();
            
            if (Reader_acc.HasRows)
            {
                while (Reader_acc.Read())
                {
                    string sqlPass = Reader_acc["password"].ToString();
                    if (sqlPass == logingpasswdTextBox.Text)
                    {
                        Session["loginstatus"] = logingaccTextBox.Text;                        
                        Response.Redirect("index");
                    }
                    else
                    {
                        errorText.Text = "*帳號或密碼錯誤";                        
                    }
                }
            }
            else
            {
                errorText.Text = "*帳號或密碼錯誤";
                
            }

            connection.Close();



            //Response.Redirect("register");
        }

        protected void forgetLinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("forget");
        }

        protected void registerButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("register");
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