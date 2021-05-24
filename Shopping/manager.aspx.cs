using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class manager : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            plabel.Text = "";
            elabel.Text = "";
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ManagersConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"select * from Managers where account='{email.Text}'";
            SqlCommand Command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    if (password.Text == Reader["password"].ToString())
                    {
                        Session["access"]="ok";
                        Response.Redirect("managerhome");
                    }
                    else
                    {
                        plabel.Text = "密碼錯誤";
                    }

                }
            }
            else
            {
                elabel.Text = "查無帳號";
            }
            connection.Close();
        }
    }
}