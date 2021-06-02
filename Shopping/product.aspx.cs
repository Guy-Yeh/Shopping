using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class product: Page
    {
        string picture_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["cart"] != null)
                Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            else
                Label1.Text = " 總金額：" + "0";
            SqlConnection connection = new SqlConnection(picture_data);
            string sql = $"select picture from Products where productName =N'{Session["product"]}' ";
            SqlCommand command1 = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read1 = command1.ExecuteReader();
            if (read1.HasRows)
            {
                if (read1.Read())
                    Image1.ImageUrl = read1[0].ToString();
            }

            connection.Close();
            if (IsPostBack)
            {
                string sq2 = $"select picture from Products where productName =N'{Session["product"]}' and category=N'{DropDownList1.SelectedItem.Text}'";
                SqlCommand command2 = new SqlCommand(sq2, connection);
                connection.Open();
                SqlDataReader read2 = command2.ExecuteReader();
                if (read2.HasRows)
                {
                    if (read2.Read())
                        Image1.ImageUrl = read2[0].ToString();
                }

                connection.Close();

            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = "0";
            Response.Redirect("index");
        }
    }
}