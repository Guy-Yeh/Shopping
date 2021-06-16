using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping.Customer
{
    public partial class Chat : System.Web.UI.Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ChatConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        public static string loginstatus = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        //Session["loginstatus"] = "Amber";

            try
            {
                if (Session["loginstatus"] != null)
                {
                    loginstatus = Session["loginstatus"].ToString();
                }
            }
            catch (Exception ex)
            {
                loginstatus = "";
            }
            if (!IsPostBack)
            {
                reviewChat();
            }
        }

        public void reviewChat() {
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Chat where account = @account";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            command.Parameters.Add("@account", SqlDbType.NVarChar).Value = loginstatus;
            sqlDataAdapter.SelectCommand = command;
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            chatGridView.DataSource = read;
            chatGridView.DataBind();
            connection.Close();
        }

        protected void keyin_Click(object sender, EventArgs e)
        {
            string costomerTalk = Request.Form["costomerTextBox"].ToString();
            if (string.IsNullOrEmpty(costomerTalk.Trim()))
            {
                MessageBox.Show("請輸入文字");
            }
            else {
                SqlConnection connection = Connect(s_data);
                string sql = $"insert into Chat (account,message) values (@account,@message) ";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                command.Parameters.Add("@account", SqlDbType.NVarChar).Value = loginstatus;
                command.Parameters.Add("@message", SqlDbType.NVarChar).Value = costomerTalk;
                sqlDataAdapter.SelectCommand = command;
                connection.Open();
                //command.ExecuteNonQuery();
                SqlDataReader read = command.ExecuteReader();
                chatGridView.DataSource = read;
                chatGridView.DataBind();

                connection.Close();

                MessageBox.Show("回覆成功");
                reviewChat();
            }
        }
    }
}