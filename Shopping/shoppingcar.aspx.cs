using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{

    public partial class shoppingcar : Page
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

            if (Request.Cookies["buy"] != null) {
                for (int i = 0; i < Convert.ToInt32(Request.Cookies["quantity"].Value); i++)
                {
                    TableRow r1 = new TableRow();
                    SqlConnection connection = new SqlConnection(picture_data);
                    string sq1 = $"select * from Products where ID ='{Request.Cookies["buy"][$"{i}"]}' ";
                    System.Data.SqlClient.SqlCommand command1 = new SqlCommand(sq1, connection);
                    connection.Open();
                    SqlDataReader read1 = command1.ExecuteReader();

                    if (read1.HasRows)
                    {
                        if (read1.Read())
                        {
                            TableCell c1 = new TableCell();
                            Image image = new Image();
                            image.Height = 120  ;
                            image.Width = 100 ;
                            image.ImageUrl = $"{ read1[2].ToString() }";
                            c1.Controls.Add(image);
                            r1.Cells.Add(c1);
                            TableCell c2 = new TableCell();
                            c2.Controls.Add(new LiteralControl($"{read1[1].ToString()}"));
                            r1.Cells.Add(c2);
                            TableCell c3 = new TableCell();
                            c3.Controls.Add(new LiteralControl($"{read1[3].ToString()}"));
                            r1.Cells.Add(c3);
                            TableCell c4 = new TableCell();
                            c4.Controls.Add(new LiteralControl($"1"));
                            r1.Cells.Add(c4);
                            TableCell c5 = new TableCell();
                            c5.Controls.Add(new LiteralControl($"{read1[5].ToString()}"));
                            r1.Cells.Add(c5);
                            TableCell c6 = new TableCell();
                            Button button = new Button();
                            button.Text = "刪除";
                            c6.Controls.Add(button);
                            r1.Cells.Add(c6);
                        }
                    }                   
                    Table1.Rows.Add(r1);
                    connection.Close();
                }
                TableRow r2 = new TableRow();
                TableCell c7 = new TableCell();
                c7.Controls.Add(new LiteralControl("總金額："));
                r2.Cells.Add(c7);
                TableCell c8 = new TableCell();
                c8.Controls.Add(new LiteralControl());
                r2.Cells.Add(c8);
                TableCell c9 = new TableCell();
                c9.Controls.Add(new LiteralControl());
                r2.Cells.Add(c9);
                TableCell c10 = new TableCell();
                c10.Controls.Add(new LiteralControl());
                r2.Cells.Add(c10);
                TableCell c11 = new TableCell();
                c11.Controls.Add(new LiteralControl(Request.Cookies["cart"].Value));
                r2.Cells.Add(c11);
                TableCell c12 =new TableCell();
                c12.Controls.Add(new LiteralControl());
                r2.Cells.Add(c12);
                Table1.Rows.Add(r2);

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
            Response.Redirect("shoppingcar");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment");
        }
    }
}