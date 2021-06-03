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
            if (Request.Cookies["buy"] != null) {
                for (int i = 0; i < Convert.ToInt32(Request.Cookies["quantity"].Value); i++)
                {
                    TableRow r = new TableRow();

                    SqlConnection connection = new SqlConnection(picture_data);
                    connection.Open();
                    string sq1 = $"select * from Products where ID ='{ Request.Cookies["buy"][$"{i}"]}' ";
                    System.Data.SqlClient.SqlCommand command1 = new SqlCommand(sq1, connection);
                    SqlDataReader read1 = command1.ExecuteReader();
                    if (read1.HasRows)
                    {
                        if (read1.Read())
                        {
                            TableCell c1 = new TableCell();
                            c1.Controls.Add(new LiteralControl($"{read1[2].ToString()}"));
                            r.Cells.Add(c1);
                            TableCell c2 = new TableCell();
                            c2.Controls.Add(new LiteralControl($"{read1[1].ToString()}"));
                            r.Cells.Add(c2);
                            TableCell c3 = new TableCell();
                            c3.Controls.Add(new LiteralControl($"{read1[3].ToString()}"));
                            r.Cells.Add(c3);
                            TableCell c4 = new TableCell();
                            c4.Controls.Add(new LiteralControl($"1"));
                            r.Cells.Add(c4);
                            TableCell c5 = new TableCell();
                            c5.Controls.Add(new LiteralControl($"{read1[5].ToString()}"));
                            r.Cells.Add(c5);
                        }
                    }
                    
                    Table1.Rows.Add(r);
                    connection.Close();
                }
            }
            int numrows = 2;
            int numcells = 5;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl("呈現的內容"));
                    r.Cells.Add(c);
                }
                Table1.Rows.Add(r);
            }

        }
    }
}