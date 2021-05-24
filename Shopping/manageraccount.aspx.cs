using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Shopping
{
    public partial class manageraccount : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"select * from Customers";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            useraccount.DataSource = read;
            useraccount.DataBind();
            connection.Close();
        }
    }
}