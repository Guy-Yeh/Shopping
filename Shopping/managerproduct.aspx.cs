using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Documents;

namespace Shopping
{
    public partial class managerproduct : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            hint1.Text = "";
            hint2.Text = "";
            SqlConnection connection = Connect(s_data);
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

            SqlConnection connection2 = Connect(s_data);
            string sql2 = $"insert into [Products](productName,picture,category,inventory,price) values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}')";
            //string sql2 = $"insert into [Products](productName,picture,category,inventory,price) values(@pn,@pc,@c,@i,@pr)";
            bool inventoryCheck = Regex.IsMatch(TextBox4.Text, @"\d");
            bool priceCheck = Regex.IsMatch(TextBox5.Text, @"\d");

            if (inventoryCheck == true)
            {
                if (priceCheck == true)
                {
                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Input Successfully");
                    connection2.Close();
                }
                else
                {
                    hint2.Text = "Please enter number";
                }
            }
            else
            {
                if (priceCheck == false)
                {
                    hint2.Text = "Please enter number";
                }
                hint1.Text = "Please enter number";
            }
            /*try
            {
                command2.Parameters.Add("@pn", SqlDbType.NVarChar);
                command2.Parameters["@pn"].Value = TextBox1.Text;
                command2.Parameters.Add("@pc", SqlDbType.NVarChar);
                command2.Parameters["@pc"].Value = TextBox2.Text;
                command2.Parameters.Add("@c", SqlDbType.NVarChar);
                command2.Parameters["@c"].Value = TextBox3.Text;
                command2.Parameters.Add("@i", SqlDbType.Int);
                command2.Parameters.Add("@pr", SqlDbType.Int);
                command2.Parameters["@i"].Value = Convert.ToInt32(TextBox4.Text);
                command2.Parameters["@pr"].Value = Convert.ToInt32(TextBox5.Text);
                command2.ExecuteNonQuery();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pls enter number");
            }*/
           
            //connection2.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection3 = Connect(s_data);
            string sql3 = $"delete from Products where ID='{TextBox6.Text}'";

            bool IDCheck = Regex.IsMatch(TextBox6.Text, @"\d");
            SqlConnection connection4 = Connect(s_data);
            string sql4 = $"select * from Products where ID='{TextBox6.Text}'";
            SqlCommand command4 = new SqlCommand(sql4, connection4);
            connection4.Open();
            SqlDataReader Reader = command4.ExecuteReader();

            if (Reader.HasRows)
            {
                
                SqlCommand command3 = new SqlCommand(sql3, connection3);
                connection3.Open();
                command3.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully");
                connection3.Close();
            }
            else if (IDCheck == true)
            {
                hint3.Text = "There is no productID number in database";
            }
            else
            {
                hint3.Text = "Please enter number";
            }
            connection4.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            SqlConnection connection5 = Connect(s_data);
            string sql5 = $"select * from Products where ID='{TextBox7.Text}'";
            SqlCommand command5 = new SqlCommand(sql5, connection5);
            connection5.Open();
            SqlDataReader Reader = command5.ExecuteReader();
            bool IDCheck = Regex.IsMatch(TextBox7.Text, @"\d");
            var productCols = new List<string> { "productName", "picture", "category", "inventory", "price" };
            bool checkcol = false;
            foreach (string productCol in productCols)
            {
                if (TextBox8.Text == productCol)
                {
                    checkcol = true;
                    break;
                }
            }
            bool text9Check = Regex.IsMatch(TextBox9.Text, @"\d");
            SqlConnection connection6 = Connect(s_data);
            string sql6 = $"update Products SET {TextBox8.Text}='{TextBox9.Text}' where ID='{TextBox7.Text}'";

            string s_data7 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
            SqlConnection connection7 = Connect(s_data);
            string sql7 = $"select * from Products where productName='{TextBox9.Text}'";
            

            if (Reader.HasRows) //確認有找到該ID
            {
                if (checkcol == true)
                {
                    if (TextBox8.Text == "inventory" || TextBox8.Text == "price")
                    {
                        if (text9Check == true)
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            MessageBox.Show("Update Successfully");
                            connection6.Close();
                        }
                        else
                        {
                            hint6.Text = "Pls enter number";
                        }
                    }
                    else if (TextBox8.Text == "productName") //輸入過程確保productName不重複 
                    {
                        SqlCommand command7 = new SqlCommand(sql7, connection7);
                        connection7.Open();
                        SqlDataReader Reader2 = command7.ExecuteReader();
                        if (Reader2.HasRows)
                        {
                            hint6.Text = "ProductName repeat, please change productname";
                        }
                        else
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            MessageBox.Show("Update Successfully");
                            connection6.Close();
                        }
                        connection7.Close();
                    }
                    else
                    {
                        SqlCommand command6 = new SqlCommand(sql6, connection6);
                        connection6.Open();
                        command6.ExecuteNonQuery();
                        MessageBox.Show("Update Successfully");
                        connection6.Close();
                    }
                }
                else
                {
                    hint5.Text = "There is no your col in database";
                }
            }
            else if (IDCheck == true)
            {
                hint4.Text = "There is no productID number in database";
            }
            else
            {
                hint4.Text = "Please enter number";
            }
            connection5.Close();

        }
    
    }
}