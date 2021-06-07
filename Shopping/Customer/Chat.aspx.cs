using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            reviewChat();

        }

        public void reviewChat() {
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Chat";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            chatGridView.DataSource = read;
            chatGridView.DataBind();
            connection.Close();
        }

        protected void keyin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connect(s_data);
            string sql = $"insert into Chat (message) values ('{Request.Form["costomerTextBox"].ToString()}')";
 
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            reviewChat();
            MessageBox.Show("回覆成功");
        }
    }
}