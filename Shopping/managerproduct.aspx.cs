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

        public void reviewProduct()
        {
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Products" ;
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Columns.Add("ID");
             dt.Columns.Add("productName");
             dt.Columns.Add("picture");
             dt.Columns.Add("category");
             dt.Columns.Add("inventory");
             dt.Columns.Add("price");
             dt.Columns.Add("initdate");

             while (read.Read())
             {
                 DataRow row = dt.NewRow();
                 row["ID"] = read[0];
                 row["productName"] = read[1];
                 row["picture"] = ResolveUrl($"{read[2]}");
                 row["category"] = read[3];
                 row["inventory"] = read[4];
                 row["price"] = read[5];
                 row["initdate"] = read[6];
                 dt.Rows.Add(row);
             }
            product.DataSource = dt;
            
            product.DataBind();
            connection.Close();
        }
        public void DDLreconnect()
        {
            DDLDeleterProductID.Items.Clear();
            DDLDeleterProductID.Items.Add("請選擇");
            DDLUpdateProductID.Items.Clear();
            DDLUpdateProductID.Items.Add("請選擇");
            DataView dv = (DataView)this.SqlDataSourceProductsID.Select(new DataSourceSelectArguments());
            DDLDeleterProductID.DataSource = dv;
            DDLDeleterProductID.DataTextField = "ID";
            DDLDeleterProductID.DataBind();
            DDLUpdateProductID.DataSource = dv;
            DDLUpdateProductID.DataTextField = "ID";
            DDLUpdateProductID.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            hintPN.Text = "";
            hintPicture.Text = "";
            hintCategory.Text = "";
            hintInventory.Text = "";
            hintPrice.Text = "";
            hintID2.Text = "選擇即將更新的productID";
            hintColumn.Text = "選擇即將更新的欄位";
            hintValue.Text = "輸入更新的值";
            if (!IsPostBack)
            {
                reviewProduct();
                DDLreconnect();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection2 = Connect(s_data);
            string sql2 = $"insert into [Products](productName,picture,category,inventory,price) values(N'{TextBox1.Text}',N'{TextBox2.Text}',N'{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}')";
            //string sql2 = $"insert into [Products](productName,picture,category,inventory,price) values(@pn,@pc,@c,@i,@pr)";
            bool inventoryCheck = Regex.IsMatch(TextBox4.Text, @"\d");
            bool priceCheck = Regex.IsMatch(TextBox5.Text, @"\d");

            if (TextBox1.Text != "")
            {
                if (TextBox2.Text != "")
                {
                    if (TextBox3.Text != "")
                    {
                        if (inventoryCheck == true)
                        {
                            if (priceCheck == true)
                            {
                                SqlCommand command2 = new SqlCommand(sql2, connection2);
                                connection2.Open();
                                command2.ExecuteNonQuery();
                                MessageBox.Show("輸入成功");
                                connection2.Close();
                                reviewProduct();
                                DDLreconnect();
                            }
                            else
                            {
                                hintPrice.Text = "price需為數字 請重新輸入";
                            }
                        }
                        else
                        {
                            hintInventory.Text = "inventory需為數字 請重新輸入";
                        }
                    }
                    else
                    {
                        hintCategory.Text = "category不得為空";
                    }
                }
                else
                {
                    hintPicture.Text = "picture不得為空";
                }
            }
            else
            {
                hintPN.Text = "productName不得為空";
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
           
            if (DDLDeleterProductID.SelectedItem.Text!="請選擇")
            {
                SqlConnection connection3 = Connect(s_data);
                string sql3 = $"delete from Products where ID='{DDLDeleterProductID.Text}'";
                SqlCommand command3 = new SqlCommand(sql3, connection3);
                connection3.Open();
                command3.ExecuteNonQuery();
                MessageBox.Show("刪除成功");
                connection3.Close();
                reviewProduct();
                DDLreconnect();

            }
            else
            {
                hintID.Text = "請選擇項目";
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            bool numberCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            SqlConnection connection6 = Connect(s_data);
            string sql6 = $"update Products SET {DDLUpdateCols.Text} = N'{TextBox9.Text}' where ID='{DDLUpdateProductID.Text}'";
            

            if (DDLUpdateProductID.SelectedItem.Text != "請選擇") 
            {
                if (DDLUpdateCols.SelectedItem.Text != "請選擇")
                {
                    if (DDLUpdateCols.Text == "inventory" || DDLUpdateCols.Text == "price")
                    {
                        if (numberCheck == true)
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            MessageBox.Show("更新成功");
                            connection6.Close();
                            reviewProduct();
                        }
                        else
                        {
                            hintValue.Text = "inventory/price需為數字 請重新輸入";
                        }
                    }
                    
                    else
                    {
                        SqlCommand command6 = new SqlCommand(sql6, connection6);
                        connection6.Open();
                        command6.ExecuteNonQuery();
                        MessageBox.Show("更新成功");
                        connection6.Close();
                        reviewProduct();
                    }
                }
                else
                {
                    hintColumn.Text = "請選擇項目";
                }
            }
            else
            {
                hintID2.Text = "請選擇項目";
            }

        }
    
    }
}