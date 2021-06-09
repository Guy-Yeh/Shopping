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
            if (Request.Cookies["quantity"] == null)
                Response.Cookies["quantity"].Value = "0";

            if (Request.Cookies["cart"] != null)
                Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            else
                Label1.Text = " 總金額：" + "0";
            SqlConnection connection = new SqlConnection(picture_data);
            string sql = $"select * from Products where productName =N'{Session["product"]}' ";
            SqlCommand command1 = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read1 = command1.ExecuteReader();
            if (read1.HasRows)
            {
                if (read1.Read())
                {
                    Label4.Text = read1[1].ToString();
                    Image1.ImageUrl = read1[2].ToString();
                    Label2.Text = read1[5].ToString();
                }
            }
            connection.Close();

            if (IsPostBack)
            {
                string sq2 = $"select * from Products where productName =N'{Session["product"]}' and category=N'{DropDownList1.SelectedItem.Text}'";
                SqlCommand command2 = new SqlCommand(sq2, connection);
                connection.Open();
                SqlDataReader read2 = command2.ExecuteReader();
                if (read2.HasRows)
                {
                    if (read2.Read())
                    {
                        Label4.Text = read2[1].ToString();
                        Image1.ImageUrl = read2[2].ToString();
                        Label2.Text = read2[5].ToString();
                    }
                }
                connection.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["buy"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-2);
                Response.Cookies.Set(cookie);
            }
            Response.Cookies["cart"].Value = "0";
            Response.Redirect("product");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            SqlConnection connection = new SqlConnection(picture_data);
            string sq1 = $"select ID from Products where productName =N'{Session["product"]}' and category=N'{DropDownList1.SelectedItem.Text}'";
            SqlCommand command1 = new SqlCommand(sq1, connection);
            connection.Open();
            SqlDataReader read1 = command1.ExecuteReader();
            if (read1.HasRows)
            {
                if (read1.Read())
                {
                    if (Request.Cookies["buy"] != null)
                        usecookie.Values.Add(Request.Cookies["buy"].Values);
                    usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", $"{read1[0].ToString()}");
                    Response.AppendCookie(usecookie);
                    Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
                }
            }
            connection.Close();
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label2.Text)).ToString();
            Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("product");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }
    }
}