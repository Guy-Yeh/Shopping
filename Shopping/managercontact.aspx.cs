using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping
{
    public partial class managercontact : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ChatConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Chat where response IS NULL";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            usercontact.DataSource = read;
            usercontact.DataBind();
            connection.Close();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection2 = Connect(s_data);
            string sql2 = $"update Chat SET response='{Request.Form["contactresponse"].ToString()}' where ID='{int.Parse(Request.Form["contactID"])}'";
            SqlCommand command2 = new SqlCommand(sql2, connection2);
            connection2.Open();
            command2.ExecuteNonQuery();
            MessageBox.Show("回覆成功");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection3 = Connect(s_data);
            string sql3 = $"select * from Chat where account = '{Request.Form["searchaccount"].ToString()}'";
            SqlCommand command3 = new SqlCommand(sql3, connection3);
            connection3.Open();
            SqlDataReader read = command3.ExecuteReader();
            usercontact.DataSource = read;
            usercontact.DataBind();
            connection3.Close();
            MessageBox.Show("搜尋成功");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection4 = Connect(s_data);
            string sql4 = $"select * from Chat";
            SqlCommand command = new SqlCommand(sql4, connection4);
            connection4.Open();
            SqlDataReader read = command.ExecuteReader();
            usercontact.DataSource = read;
            usercontact.DataBind();
            connection4.Close();
            MessageBox.Show("顯示全部成功");
        }
    }
}