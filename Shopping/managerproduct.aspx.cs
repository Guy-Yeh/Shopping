using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;


namespace Shopping
{
    public partial class managerproduct : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"select * from Products";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            product.DataSource = read;
            product.DataBind();
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s_data2 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
            SqlConnection connection2 = new SqlConnection(s_data2);
            //string sql2 = $"insert into [Products](productName,picture,category,inventory,price) values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}')";
            string sql2 = $"insert into [Products](productName,picture,category,inventory,price) values(@pn,@pc,@c,@i,@pr)";
            SqlCommand Command2 = new SqlCommand(sql2, connection2);
            connection2.Open();
            
            try
            {
                Command2.Parameters.Add("@pn", SqlDbType.NVarChar);
                Command2.Parameters["@pn"].Value = TextBox1.Text;
                Command2.Parameters.Add("@pc", SqlDbType.NVarChar);
                Command2.Parameters["@pc"].Value = TextBox2.Text;
                Command2.Parameters.Add("@c", SqlDbType.NVarChar);
                Command2.Parameters["@c"].Value = TextBox3.Text;
                Command2.Parameters.Add("@i", SqlDbType.Int);
                Command2.Parameters.Add("@pr", SqlDbType.Int);
                Command2.Parameters["@i"].Value = Convert.ToInt32(TextBox4.Text);
                Command2.Parameters["@pr"].Value = Convert.ToInt32(TextBox5.Text);
                Command2.ExecuteNonQuery();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pls enter number");
            }
           
            connection2.Close();
        }
    }
}