using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string[] Datakeys = new string[3] { "ID", "serial", "customerAccount" };
            GridView1.DataKeyNames = Datakeys;
            //string ID = GridView1.DataKeys[e.RowIndex].Value.ToString();
            string name = GridView1.DataKeys[e.RowIndex][1].ToString();
            SqlConnection connection = new SqlConnection(s_data);
            SqlCommand command = new SqlCommand($"delete from OrderDetail where customerAccount = '{name}'", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            //Response.Redirect(Request.Url.ToString());
        }

        
    }
}