using System;
using System.Collections;
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
        
        public void addtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("picture");
            dt.Columns.Add("productName");
            dt.Columns.Add("picture");
            dt.Columns.Add("category");
            dt.Columns.Add("inventory");
            dt.Columns.Add("price");
            dt.Columns.Add("introduction");
            dt.Columns.Add("initdate");

        }

        public void reviewProduct()
        {
            helpSQL.Text = "";
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"select * from Products order by initdate DESC,ID DESC";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("showpicture");
            dt.Columns.Add("productName");
            dt.Columns.Add("picture");
            dt.Columns.Add("category");
            dt.Columns.Add("inventory");
            dt.Columns.Add("price");
            dt.Columns.Add("introduction");
            dt.Columns.Add("initdate");

            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];
                row["productName"] = read[1];

                row["picture"] = read[2];
                string[] s = read[2].ToString().Split('\\');
                row["category"] = read[3];
                row["showpicture"] = s[s.GetUpperBound(0)];
                row["inventory"] = read[4];
                row["price"] = read[5];
                row["introduction"] = read[7];
                row["initdate"] = read[6];
                dt.Rows.Add(row);
            }
            product.DataSource = dt;

            product.DataBind();
            connection.Close();
        }

        public void searchProduct(string a)
        {
            helpSQL.Text = a;
            SqlConnection connection = new SqlConnection(s_data);
            SqlCommand command = new SqlCommand(a, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("showpicture");
            dt.Columns.Add("productName");
            dt.Columns.Add("picture");
            dt.Columns.Add("category");
            dt.Columns.Add("inventory");
            dt.Columns.Add("price");
            dt.Columns.Add("introduction");
            dt.Columns.Add("initdate");

            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];
                row["productName"] = read[1];
                row["picture"] = read[2];
                string[] s = read[2].ToString().Split('\\');
                row["showpicture"] = s[s.GetUpperBound(0)];
                row["category"] = read[3];
                row["inventory"] = read[4];
                row["price"] = read[5];
                row["introduction"] = read[7];
                row["initdate"] = read[6];
                dt.Rows.Add(row);
            }
            product.DataSource = dt;

            product.DataBind();
            connection.Close();
        }



        public void cleanbt4()
        {
            DataView dv = (DataView)this.SqlDataSourceProductName.Select(new DataSourceSelectArguments());
            DDLSearchProductName.Items.Clear();
            DDLSearchProductName.Items.Add("請選擇");
            DDLSearchProductName.DataSource = dv;
            DDLSearchProductName.DataTextField = "productName";
            DDLSearchProductName.DataBind();
        }

        public void cleansub()
        {
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            
        }

        
        




        public void changecocolor()
        {
           
            hintPS.ForeColor = Color.Black;
            hintp1.ForeColor = Color.Black;
            hintp2.ForeColor = Color.Black;
            hintp3.ForeColor = Color.Black;
            hintp4.ForeColor = Color.Black;
            hintp5.ForeColor = Color.Black;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["access"] != null && Session["access"] == "ok")
            {

            }
            else
            {
                Response.Redirect("manager");
            }
            hintPS.Text = "選擇即將搜尋的產品名稱";
            hintp1.Text = "";
            hintp2.Text = "";
            hintp3.Text = "";
            hintp4.Text = "";
            hintp5.Text = "";
            changecocolor();
            if (!IsPostBack)
            {
                
                reviewProduct();
                cleanbt4();
                cleansub();
            }
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
        

        

        

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["access"] = "Not ok";
            Response.Redirect(Request.Url.ToString());
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (DDLSearchProductName.SelectedItem.Text != "請選擇")
            {
                string SqlS = $"select * from Products where productName = N'{DDLSearchProductName.Text}'order by initdate DESC,ID DESC";
                searchProduct(SqlS);
                cleanbt4();
            }
            else
            {
                hintPS.ForeColor = Color.Red;
                hintPS.Text = "請選擇項目";
            }
        }

        protected void product_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string ID = product.DataKeys[e.RowIndex].Value.ToString();
            SqlConnection connection = new SqlConnection(s_data);
            SqlCommand command = new SqlCommand($"delete from Products where ID = '{ID}'", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            cleanbt4();
            reviewProduct();
        }

        protected void product_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            product.EditIndex = -1;
            if (helpSQL.Text != "")
            {
                searchProduct(helpSQL.Text);
            }
            else
            {
                reviewProduct();
            }
        }

        protected void product_RowEditing(object sender, GridViewEditEventArgs e)
        {
            product.EditIndex = e.NewEditIndex;
            if (helpSQL.Text != "")
            {
                searchProduct(helpSQL.Text);
                
            }
            else
            {
                reviewProduct();
            }
        }

        protected void product_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            string ID = product.DataKeys[e.RowIndex].Values[0].ToString();
            string productName = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            string category = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox5")).Text;
            string inventory = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox7")).Text;
            string price = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox3")).Text;
            string showpicture = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox6")).Text;
            string introduction = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox8")).Text;
            bool priceCheck = Regex.IsMatch(price, @"\d");
            bool inventoryCheck = Regex.IsMatch(inventory, @"\d");
            bool showpictureChinesecheck = Regex.IsMatch(showpicture, @"[\u4e00-\u9fa5]");
            string strroot = System.AppDomain.CurrentDomain.BaseDirectory;
            //確認庫存為數字且大於等於0
            if (productName != "")
            {
                if (category != "")
                {
                    string sqlrepeat = $"select * from Products where (productName= N'{productName}' and category= N'{category}') and ID != '{ID}'";
                    SqlConnection connectionrepeat = new SqlConnection(s_data);
                    SqlCommand commandrepeat = new SqlCommand(sqlrepeat, connectionrepeat);
                    connectionrepeat.Open();
                    SqlDataReader readerrepeat = commandrepeat.ExecuteReader();
                    if (readerrepeat.Read() != true)
                    {
                        connectionrepeat.Close();
                        if (inventoryCheck && int.Parse(inventory) >= 0)
                        {
                            //確認價格為數字且不為0
                            if (priceCheck && int.Parse(price) > 0)
                            {
                                SqlConnection connectionCP = new SqlConnection(s_data);
                                string sqlCP = $"update Products SET price = N'{price}' where productName= N'{productName}'";
                                SqlCommand commandCP = new SqlCommand(sqlCP, connectionCP);
                                connectionCP.Open();
                                commandCP.ExecuteNonQuery();
                                connectionCP.Close();
                                if (showpicture != "")
                                {
                                    if (showpictureChinesecheck != true)
                                    {
                                        string sqlSP = $"select picture from Products where ID='{ID}'";
                                        SqlConnection connectionSP = new SqlConnection(s_data);
                                        SqlCommand commandSP = new SqlCommand(sqlSP, connectionSP);
                                        connectionSP.Open();
                                        SqlDataReader reader = commandSP.ExecuteReader();
                                        //先讀出圖片路徑用來編譯成新路徑
                                        if (reader.Read())
                                        {
                                            List<string> getpicture = new List<string>();
                                            string[] prepare = reader[0].ToString().Split('\\');
                                            foreach (string x in prepare)
                                            {
                                                getpicture.Add(x);
                                            }
                                            getpicture.RemoveAt(getpicture.Count - 1);
                                            string picturecombine = string.Join("\\", getpicture.ToArray());
                                            string picture = picturecombine + "\\" + showpicture;

                                            //查看檔案是否存在
                                            if (File.Exists(strroot + picture))
                                            {
                                                string strUpdate = $"update Products set productName = N'{productName}',picture = N'{picture}', category = N'{category}', inventory = '{inventory}', price = '{price}', introduction = N'{introduction}' where ID='{ID}'";
                                                SqlConnection connection = new SqlConnection(s_data);
                                                connection.Open();
                                                SqlCommand command = new SqlCommand(strUpdate, connection);
                                                command.ExecuteNonQuery();
                                                connection.Close();
                                                cleanbt4();
                                                product.EditIndex = -1;
                                                reviewProduct();
                                            }
                                            else
                                            {
                                                //MessageBox.Show("圖片路徑不存在 請重新確認");
                                                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('圖片路徑不存在 請重新確認');},1000);", true);
                                            }
                                        }
                                        connectionSP.Close();
                                    }
                                    else
                                    {
                                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('圖片檔名不得有中文字');},1000);", true);
                                    }
                                }
                                else
                                {
                                    //MessageBox.Show("圖片檔名不得為空");
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('圖片檔名不得為空');},1000);", true);
                                }
                            }
                            else
                            {
                                //MessageBox.Show("價格需為大於0的數字");
                                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('價格需為大於0的數字');},1000);", true);
                            }
                        }
                        else
                        {
                            connectionrepeat.Close();
                            //MessageBox.Show("庫存需為不小於0的數字");
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('庫存需為不小於0的數字');},1000);", true);
                        }
                    }
                    else
                    {
                        //MessageBox.Show("商品名稱、顏色種類已存在 請重新輸入");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('商品名稱、顏色種類已存在 請重新輸入');},1000);", true);
                    }
                }
                else 
                {
                    //MessageBox.Show("商品顏色不得為空");
                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('商品顏色不得為空');},1000);", true);
                }
            }
            else
            {
                //MessageBox.Show("商品名稱不得為空");
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('商品名稱不得為空');},1000);", true);
            }

        }
        protected void product_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            product.PageIndex = e.NewPageIndex;
            reviewProduct();
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            bool inventoryCheck = Regex.IsMatch(TextBox12.Text, @"\d");
            bool priceCheck = Regex.IsMatch(TextBox13.Text, @"\d");
            DateTime dt = DateTime.Now;

           
            

            if (TextBox10.Text != "")
            {
                if (TextBox11.Text != "")
                {
                    SqlConnection connection = new SqlConnection(s_data);
                    string sql = $"select * from Products where productName = N'{TextBox10.Text}'and category = N'{TextBox11.Text}' ";
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == false)
                    {
                        connection.Close();
                        if (inventoryCheck && int.Parse(TextBox12.Text) >= 0)
                        {
                            if (priceCheck && int.Parse(TextBox13.Text) >0)
                            {
                                HttpPostedFile myFile = FileUpload2.PostedFile;
                                int nFileLen = myFile.ContentLength;
                                if (FileUpload2.HasFile && nFileLen > 0)
                                {
                                    string date = DateTime.Now.ToString("yyyyMMddhhmmss");
                                    string picturePath2 = $@"images\衣服\S_{date}.jpg";
                                    string imgPath = Server.MapPath(picturePath2);
                                    FileUpload2.SaveAs(imgPath);
                                    SqlConnection connection2 = new SqlConnection(s_data);
                                    string sql2 = $"insert into [Products](productName,picture,category,inventory,price,introduction) values(N'{TextBox10.Text}',N'{picturePath2}',N'{TextBox11.Text}','{TextBox12.Text}','{TextBox13.Text}',N'{Request.Form["contactresponse"].ToString()}')";
                                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                                    connection2.Open();
                                    command2.ExecuteNonQuery();
                                    connection2.Close();
                                    cleansub();
                                    cleanbt4();
                                    reviewProduct();
                                }
                                else
                                {
                                    hintp5.ForeColor = Color.Red;
                                    hintp5.Text = "圖片未上傳 請確認";
                                }
                            }
                            else
                            {
                                hintp4.ForeColor = Color.Red;
                                hintp4.Text = "價格需為<br>大於0的數字";
                                //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "sub", "setTimeout( function(){alert('價格需為大於0的數字');},600);", true);
                            }
                        }
                        else
                        {
                            hintp3.ForeColor = Color.Red;
                            hintp3.Text = "庫存需為<br>不小於0的數字";
                            //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "sub", "setTimeout( function(){alert('庫存需為不小於0的數字');},600);", true);
                        }
                    }
                    else
                    {
                        hintp2.ForeColor = Color.Red;
                        hintp2.Text = "商品種類重複 <br> 請重新輸入";
                        hintp1.ForeColor = Color.Red;
                        hintp1.Text = "商品種類重複 <br>請重新輸入";
                        connection.Close();
                        //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "sub", "setTimeout( function(){alert('商品種類重複 <br>請重新輸入');},0);", true);
                    }

                }
                else
                {
                    hintp2.ForeColor = Color.Red;
                    hintp2.Text = "商品種類<br>不得為空";
                    //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "sub", "setTimeout( function(){alert('商品種類不得為空');},0);", true);
                }

            }
            else
            {
                hintp1.ForeColor = Color.Red;
                hintp1.Text = "商品名稱<br>不得為空";
                //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "sub", "setTimeout( function(){alert('商品名稱不得為空');},0);", true);
            }
        }

        protected void all_Click(object sender, EventArgs e)
        {
            reviewProduct();
        }






        

        //protected void product_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowState > 0 && DataControlRowState.Edit > 0)
        //    {
        //        e.Row.FindControl("Label1").Focus();
        //    }
        //}
    }
    
 }
