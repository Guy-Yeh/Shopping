using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                 row["picture"] = read[2];
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
        

        public void cleanbt1()
        {
            TextBox1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        public void cleanbt2()
        {
            DataView dv = (DataView)this.SqlDataSourceProductsID.Select(new DataSourceSelectArguments());
            DDLDeleterProductID.Items.Clear();
            DDLDeleterProductID.Items.Add("請選擇");
            DDLDeleterProductID.DataSource = dv;
            DDLDeleterProductID.DataTextField = "ID";
            DDLDeleterProductID.DataBind();
        }
        public void cleanbt3()
        {
            DataView dv = (DataView)this.SqlDataSourceProductsID.Select(new DataSourceSelectArguments());
            DDLUpdateProductID.Items.Clear();
            DDLUpdateProductID.Items.Add("請選擇");
            DDLUpdateProductID.DataSource = dv;
            DDLUpdateProductID.DataTextField = "ID";
            DDLUpdateProductID.DataBind();
            DataView dv2 = (DataView)this.SqlDataSourceProductsCols.Select(new DataSourceSelectArguments());
            DDLUpdateCols.Items.Clear();
            DDLUpdateCols.Items.Add("請選擇");
            DDLUpdateCols.DataSource = dv2;
            DDLUpdateCols.DataTextField = "Cols";
            DDLUpdateCols.DataBind();
            TextBox9.Text = "";
        }

        public void changecocolor()
        {
            hintColumn.ForeColor = Color.Black;
            hintID2.ForeColor = Color.Black;
            hintID.ForeColor = Color.Black;
            hintPrice.ForeColor = Color.Black;
            hintInventory.ForeColor = Color.Black;
            hintCategory.ForeColor = Color.Black;
            hintPicture.ForeColor = Color.Black;
            hintPN.ForeColor = Color.Black;
            hintValue.ForeColor = Color.Black;
        }


        protected void Page_Load(object sender, EventArgs e)
        {

            hintPN.Text = "";
            hintPicture.Text = "";
            hintCategory.Text = "";
            hintInventory.Text = "";
            hintPrice.Text = "";
            hintValue.Text = "";
            hintID.Text = "選擇即將刪除的productID";
            hintID2.Text = "選擇即將更新的productID";
            hintColumn.Text = "選擇即將更新的欄位";

            changecocolor();
            if (!IsPostBack)
            {
                reviewProduct();
                cleanbt1();
                cleanbt2();
                cleanbt3();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection2 = Connect(s_data);
            
            //string sql2 = $"insert into [Products](productName,picture,category,inventory,price) values(@pn,@pc,@c,@i,@pr)";
            bool inventoryCheck = Regex.IsMatch(TextBox4.Text, @"\d");
            bool priceCheck = Regex.IsMatch(TextBox5.Text, @"\d");

            if (TextBox1.Text != "")
            {
                if (TextBox3.Text != "")
                {
                    if (inventoryCheck)
                    {
                        if (priceCheck)
                        {

                            if (FileUpload1.PostedFile != null)
                            {
                                HttpPostedFile myFile = FileUpload1.PostedFile;
                                int nFileLen = myFile.ContentLength;
                                if (FileUpload1.HasFile && nFileLen > 0)
                                {
                                    
                                    string picturePath1 = $@"images\衣服\{TextBox1.Text}_{TextBox3.Text}.jpg";
                                    string imgPath = Server.MapPath(picturePath1);
                                    FileUpload1.SaveAs(imgPath);

                                    string sql2 = $"insert into [Products](productName,picture,category,inventory,price) values(N'{TextBox1.Text}',N'{picturePath1}',N'{TextBox3.Text}','{TextBox4.Text}','{TextBox5.Text}')";
                                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                                    connection2.Open();
                                    command2.ExecuteNonQuery();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt1", "setTimeout( function(){alert('輸入成功');},0);", true);
                                    connection2.Close();
                                    reviewProduct();
                                    cleanbt1();
                                    cleanbt2();
                                    cleanbt3();
                                }
                                else
                                {
                                    hintPicture.ForeColor = Color.Red;
                                    hintPicture.Text = "picture尚未選擇 請選擇上傳圖片";
                                }
                            }
                            else
                            {
                                hintPicture.ForeColor = Color.Red;
                                hintPicture.Text = "picture尚未選擇 請選擇上傳圖片";
                            }
                        }
                        else
                        {
                            hintPrice.ForeColor = Color.Red;
                            hintPrice.Text = "price需為數字 請重新輸入";
                        }
                    }
                    else
                    {
                        hintInventory.ForeColor = Color.Red;
                        hintInventory.Text = "inventory需為數字 請重新輸入";
                    }
                }
                else
                {
                    hintCategory.ForeColor = Color.Red;
                    hintCategory.Text = "category不得為空";
                }
                
            }
            else
            {
                hintPN.ForeColor = Color.Red;
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
                connection3.Close();
                reviewProduct();
                cleanbt2();
                cleanbt3();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(),"bt2", "setTimeout( function(){alert('刪除成功');},0);", true);

            }
            else
            {
                hintID.ForeColor = Color.Red;
                hintID.Text = "請選擇項目";
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            bool categoryCheck = Regex.IsMatch(TextBox9.Text, @"^[\u4e00-\u9fa5]+$");
            bool numberCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            SqlConnection connection6 = Connect(s_data);
            string sql6 = $"update Products SET {DDLUpdateCols.Text} = N'{TextBox9.Text}' where ID='{DDLUpdateProductID.Text}'";
            

            if (DDLUpdateProductID.SelectedItem.Text != "請選擇") 
            {
                if (DDLUpdateCols.SelectedItem.Text != "請選擇")
                {
                    if (DDLUpdateCols.Text == "inventory")
                    {
                        if (numberCheck)
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                            connection6.Close();
                            reviewProduct();
                            cleanbt3();
                        }
                        else
                        {
                            hintValue.ForeColor = Color.Red;
                            hintValue.Text = "inventory需為數字 請重新輸入";
                        }
                    }

                    else if (DDLUpdateCols.Text == "price")
                    {
                        if (TextBox9.Text != "")
                        {
                            if (numberCheck)
                            {
                                string sqlCP = $"select productName from Products where ID='{DDLUpdateProductID.Text}'";
                                SqlConnection connectionCP = Connect(s_data);
                                SqlCommand commandCP = new SqlCommand(sqlCP, connectionCP);
                                connectionCP.Open();
                                SqlDataReader readerCP = commandCP.ExecuteReader();
                                if (readerCP.Read())
                                {
                                    string sql6CP = $"update Products SET {DDLUpdateCols.Text} = N'{TextBox9.Text}' where productName= N'{readerCP[0]}'";
                                    SqlCommand command6 = new SqlCommand(sql6CP, connection6);
                                    connection6.Open();
                                    command6.ExecuteNonQuery();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    connection6.Close();
                                    reviewProduct();
                                    cleanbt3();
                                }
                                connectionCP.Close();
                            }
                            else
                            {
                                hintValue.ForeColor = Color.Red;
                                hintValue.Text = "price需為數字 請重新輸入";
                            }
                        }
                        else
                        {
                            hintValue.ForeColor = Color.Red;
                            hintValue.Text = "price不得為空";
                        }
                    }

                    else if (DDLUpdateCols.Text == "category")
                    {
                        if (categoryCheck)
                        {
                            string sqlCC = $"select productName from Products where ID='{DDLUpdateProductID.Text}'";
                            SqlConnection connectionCC = Connect(s_data);
                            SqlCommand commandCC = new SqlCommand(sqlCC, connectionCC);
                            connectionCC.Open();
                            SqlDataReader readerCC = commandCC.ExecuteReader();
                            if (readerCC.Read())
                            {
                                string sqlCC2 = $"select * from Products where productName = N'{readerCC[0]}' and category= N'{TextBox9.Text}'";
                                SqlConnection connectionCC2 = Connect(s_data);
                                SqlCommand commandCC2 = new SqlCommand(sqlCC2, connectionCC2);
                                connectionCC2.Open();
                                SqlDataReader readerCC2 = commandCC2.ExecuteReader();
                                if (readerCC2.Read() == false)
                                {
                                    SqlCommand command6 = new SqlCommand(sql6, connection6);
                                    connection6.Open();
                                    command6.ExecuteNonQuery();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    connection6.Close();
                                    reviewProduct();
                                    cleanbt3();
                                }
                                else
                                {
                                    hintValue.ForeColor = Color.Red;
                                    hintValue.Text = "該種類產品已存在 請重新輸入";
                                }
                                connectionCC.Close();
                                connectionCC2.Close();
                            }
                        }
                        else
                        {
                            hintValue.ForeColor = Color.Red;
                            hintValue.Text = "category需為中文 請重新輸入";
                        }
                    }

                    else if (DDLUpdateCols.Text == "productName")
                    {
                        if (TextBox9.Text != "")
                        {

                            string sqlCC = $"select category from Products where ID='{DDLUpdateProductID.Text}'";
                            SqlConnection connectionCC = Connect(s_data);
                            SqlCommand commandCC = new SqlCommand(sqlCC, connectionCC);
                            connectionCC.Open();
                            SqlDataReader readerCC = commandCC.ExecuteReader();
                            if (readerCC.Read())
                            {
                                string sqlCC2 = $"select * from Products where productName = N'{TextBox9.Text}' and category= N'{readerCC[0]}'";
                                SqlConnection connectionCC2 = Connect(s_data);
                                SqlCommand commandCC2 = new SqlCommand(sqlCC2, connectionCC2);
                                connectionCC2.Open();
                                SqlDataReader readerCC2 = commandCC2.ExecuteReader();
                                if (readerCC2.Read() == false)
                                {
                                    SqlCommand command6 = new SqlCommand(sql6, connection6);
                                    connection6.Open();
                                    command6.ExecuteNonQuery();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    connection6.Close();
                                    reviewProduct();
                                    cleanbt3();
                                }
                                else
                                {
                                    hintValue.ForeColor = Color.Red;
                                    hintValue.Text = "該種類產品已存在 請重新輸入";
                                }
                                connectionCC.Close();
                                connectionCC2.Close();
                            }
                        }
                        else
                        {
                            hintValue.ForeColor = Color.Red;
                            hintValue.Text = "productName不得為空 請重新輸入";
                        }

                    }


                    else if (DDLUpdateCols.Text == "picture")
                    {
                        if (TextBox9.Text != "")
                        {
                            string pc = @"images\衣服\";
                            string str = System.AppDomain.CurrentDomain.BaseDirectory;
                            bool checkroot = TextBox9.Text.Contains(pc);

                            if (checkroot)
                            {
                                if (File.Exists($@"{str + TextBox9.Text}"))
                                {
                                    SqlCommand command6 = new SqlCommand(sql6, connection6);
                                    connection6.Open();
                                    command6.ExecuteNonQuery();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    connection6.Close();
                                    reviewProduct();
                                    cleanbt3();
                                }
                                else
                                {
                                    hintValue.ForeColor = Color.Red;
                                    hintValue.Text = "picture檔案不存在<br>請確認「衣服」資料夾是否存在該檔案 ";
                                }
                            }
                            else
                            {
                                hintValue.ForeColor = Color.Red;
                                hintValue.Text = @"picture路徑格式錯誤<br>格式:images\衣服\你的檔名.jpg ";

                            }
                        }
                        else
                        {
                            hintValue.ForeColor = Color.Red;
                            hintValue.Text = "picture路徑不為空";
                        }
                    }

                    else
                    {
                        SqlCommand command6 = new SqlCommand(sql6, connection6);
                        connection6.Open();
                        command6.ExecuteNonQuery();
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                        reviewProduct();
                        cleanbt3();
                    }
                }
                else
                {
                    hintColumn.ForeColor = Color.Red;
                    hintColumn.Text = "請選擇項目";
                }
            }
            else
            {
                hintID2.ForeColor = Color.Red;
                hintID2.Text = "請選擇項目";
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["access"] = "Not ok";
            Response.Redirect(Request.Url.ToString());
        }
    }
}