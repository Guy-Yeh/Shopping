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
    public partial class managershowpicture : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ShowPictureConnectionString"].ConnectionString;
        string s_data2 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;

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

        public void reviewShowPicture()
        {
            helpSQL.Text = "";
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"select * from ShowPicture order by ID DESC";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("picture");
            dt.Columns.Add("showpicture");
            dt.Columns.Add("productName");
            dt.Columns.Add("show");


            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];
                row["picture"] = read[1];
                string[] s = read[1].ToString().Split('\\');
                row["showpicture"] = s[s.GetUpperBound(0)];
                row["productName"] = read[2];
                row["show"] = read[3];
                dt.Rows.Add(row);
            }
            product.DataSource = dt;

            product.DataBind();
            connection.Close();
        }

        //顯示123的值
        //public void set123()
        //{
        //    string sql1 = $"select productName from ShowPicture where show ='1' ";
        //    string sql2 = $"select productName from ShowPicture where show ='2' ";
        //    string sql3 = $"select productName from ShowPicture where show ='3' ";
        //    SqlConnection connection = new SqlConnection(s_data);
        //    SqlCommand command = new SqlCommand(sql1, connection);
        //    connection.Open();
        //    SqlDataReader read = command.ExecuteReader();
        //    if (read.Read())
        //    {
        //        show1.Text = read[0].ToString();
        //    }
        //    else
        //    {
        //        show1.Text = "尚未設定";
        //    }
        //    connection.Close();

        //    command = new SqlCommand(sql2, connection);
        //    connection.Open();
        //    read = command.ExecuteReader();
        //    if (read.Read())
        //    {
        //        show2.Text = read[0].ToString();
        //    }
        //    else
        //    {
        //        show2.Text = "尚未設定";
        //    }
        //    connection.Close();
        //    command = new SqlCommand(sql3, connection);
        //    connection.Open();
        //    read = command.ExecuteReader();
        //    if (read.Read())
        //    {
        //        show3.Text = read[0].ToString();
        //    }
        //    else
        //    {
        //        show3.Text = "尚未設定";
        //    }
        //    connection.Close();

        //}

        public void searchShowPicture(string a)
        {
            helpSQL.Text = a;
            SqlConnection connection = new SqlConnection(s_data);
            SqlCommand command = new SqlCommand(a, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("picture");
            dt.Columns.Add("showpicture");
            dt.Columns.Add("productName");
            dt.Columns.Add("show");

            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];
                row["picture"] = read[1];
                string[] s = read[1].ToString().Split('\\');
                row["showpicture"] = s[s.GetUpperBound(0)];
                row["productName"] = read[2];
                row["show"] = read[3];
                dt.Rows.Add(row);
            }
            product.DataSource = dt;
            product.DataBind();
            connection.Close();
        }

        public bool checkShowPicture(string a)
        {
            SqlConnection connection = new SqlConnection(s_data);
            SqlCommand command = new SqlCommand(a, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            bool csp = read.Read();
            connection.Close();
            return csp;
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
            DataView dv = (DataView)this.SqlDataSource1.Select(new DataSourceSelectArguments());
            DDLShow.Items.Clear();
            DDLShow.Items.Add("請選擇");
            DDLShow.DataSource = dv;
            DDLShow.DataTextField = "show";
            DDLShow.DataBind();
        }

        public void changecocolor()
        {

            hintPS.ForeColor = Color.Black;
            hintp1.ForeColor = Color.Black;
            hintp2.ForeColor = Color.Black;
            hintp3.ForeColor = Color.Black;
            //hintset.ForeColor = Color.Black;
            //hintt1.ForeColor = Color.Black;
            //hintt2.ForeColor = Color.Black;
            //hintt3.ForeColor = Color.Black;
        }

        //public void cleanset()
        //{
        //    DataView dv = (DataView)this.SqlDataSourceProductName.Select(new DataSourceSelectArguments());
        //    DDLtt1.Items.Clear();
        //    DDLtt1.Items.Add("請選擇");
        //    DDLtt1.DataSource = dv;
        //    DDLtt1.DataTextField = "productName";
        //    DDLtt1.DataBind();
        //    DDLtt2.Items.Clear();
        //    DDLtt2.Items.Add("請選擇");
        //    DDLtt2.DataSource = dv;
        //    DDLtt2.DataTextField = "productName";
        //    DDLtt2.DataBind();
        //    DDLtt3.Items.Clear();
        //    DDLtt3.Items.Add("請選擇");
        //    DDLtt3.DataSource = dv;
        //    DDLtt3.DataTextField = "productName";
        //    DDLtt3.DataBind();

        //    TextBox5.Text = "";
        //    TextBox7.Text = "";
        //    /TextBox8.Text = "";
        //}
        public void cleanhint()
        {
            hintp1.Text = "";
            hintp2.Text = "";
            hintp3.Text = "";
            //hintset.Text = "";
            //hintt1.Text = "";
            //hintt2.Text = "";
            //hintt3.Text = "";
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
            cleanhint();
            hintPS.Text = "選擇即將搜尋的產品名稱";
            changecocolor();
            if (!IsPostBack)
            {
                reviewShowPicture();
                cleanbt4();
                cleansub();
                //set123();
                //cleanset();
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
                string SqlS = $"select * from ShowPicture where productName = N'{DDLSearchProductName.Text}'";
                searchShowPicture(SqlS);
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
            SqlCommand command = new SqlCommand($"delete from ShowPicture where ID = '{ID}'", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            //set123();
            cleanbt4();
            //cleanset();
            reviewShowPicture();
        }

        protected void product_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            product.EditIndex = -1;
            if (helpSQL.Text != "")
            {
                searchShowPicture(helpSQL.Text);
            }
            else
            {
                reviewShowPicture();
            }
        }

        protected void product_RowEditing(object sender, GridViewEditEventArgs e)
        {
            product.EditIndex = e.NewEditIndex;
            if (helpSQL.Text != "")
            {                
                searchShowPicture(helpSQL.Text);
            }
            else
            {                
                reviewShowPicture();
            }
        }

        protected void product_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            string ID = product.DataKeys[e.RowIndex].Values[0].ToString();
            string productName = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            string showpicture = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox6")).Text;
            string show = ((TextBox)product.Rows[e.RowIndex].FindControl("TextBox3")).Text;
            bool showpictureChinesecheck = Regex.IsMatch(showpicture, @"[\u4e00-\u9fa5]");
            string strroot = System.AppDomain.CurrentDomain.BaseDirectory;
            


            if (productName != "")
            {
                string sqlPC = $"select distinct * from Products where productName= N'{productName}'";
                SqlConnection connectionPC = new SqlConnection(s_data2);
                SqlCommand commandPC = new SqlCommand(sqlPC, connectionPC);
                connectionPC.Open();
                SqlDataReader readerPC = commandPC.ExecuteReader();
                if (readerPC.Read() == true)
                {
                    connectionPC.Close();
                    string sql = $"select * from ShowPicture where productName = N'{productName}' and ID !='{ID}'";
                    if (checkShowPicture(sql) != true)
                    {
                        if (show != "")
                        {
                            if (show != "No")
                            {
                                //確認要不要卡
                                //string sql2 = $"select * from ShowPicture where show ='{show}'and ID !='{ID}'";
                                //if (checkShowPicture(sql2) != true)
                                //{
                                if (show == "1" || show == "2" || show == "3" || show == "4" || show == "5" || show == "6" || show == "7" || show == "8")
                                {
                                    if (showpicture != "")
                                    {
                                        if (showpictureChinesecheck != true)
                                        {
                                            string sqlSP = $"select picture,show from ShowPicture where ID='{ID}'";
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
                                                    //先把原本的顯示設定替換
                                                    string sqlchange = $"update ShowPicture set show ='{reader[1]}' where show ='{show}'";
                                                    SqlConnection connectionchange = new SqlConnection(s_data);
                                                    SqlCommand commandchange = new SqlCommand(sqlchange, connectionchange);
                                                    connectionchange.Open();
                                                    commandchange.ExecuteNonQuery();
                                                    connectionchange.Close();
                                                    connectionSP.Close();
                                                    string strUpdate = $"update ShowPicture set productName = N'{productName}',picture = N'{picture}', show = '{show}' where ID='{ID}'";
                                                    SqlConnection connection = new SqlConnection(s_data);
                                                    connection.Open();
                                                    SqlCommand command = new SqlCommand(strUpdate, connection);
                                                    command.ExecuteNonQuery();
                                                    connection.Close();
                                                    product.EditIndex = -1;
                                                    //set123();
                                                    cleanbt4();
                                                    //cleanset();
                                                    reviewShowPicture();

                                                }
                                                else
                                                {
                                                    connectionSP.Close();
                                                    //MessageBox.Show("圖片路徑不存在 請重新確認");
                                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('圖片路徑不存在 請重新確認');},1000);", true);
                                                }
                                            }
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
                                    //MessageBox.Show("顯示設定只能設為1,2,3,No 請更改");
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('顯示設定修改只能為1~8的數字 請更改');},1000);", true);
                                }

                            }
                            //else
                            //{
                            //    if (showpicture != "")
                            //    {
                            //        if (showpictureChinesecheck != true)
                            //        {
                            //            string sqlSP = $"select picture from ShowPicture where ID='{ID}'";
                            //            SqlConnection connectionSP = new SqlConnection(s_data);
                            //            SqlCommand commandSP = new SqlCommand(sqlSP, connectionSP);
                            //            connectionSP.Open();
                            //            SqlDataReader reader = commandSP.ExecuteReader();
                            //            //先讀出圖片路徑用來編譯成新路徑
                            //            if (reader.Read())
                            //            {
                            //                List<string> getpicture = new List<string>();
                            //                string[] prepare = reader[0].ToString().Split('\\');
                            //                foreach (string x in prepare)
                            //                {
                            //                    getpicture.Add(x);
                            //                }
                            //                getpicture.RemoveAt(getpicture.Count - 1);
                            //                string picturecombine = string.Join("\\", getpicture.ToArray());
                            //                string picture = picturecombine + "\\" + showpicture;

                            //                //查看檔案是否存在
                            //                if (File.Exists(strroot + picture))
                            //                {
                            //                    string strUpdate = $"update ShowPicture set productName = N'{productName}',picture = N'{picture}', show = '{show}' where ID='{ID}'";
                            //                    SqlConnection connection = new SqlConnection(s_data);
                            //                    connection.Open();
                            //                    SqlCommand command = new SqlCommand(strUpdate, connection);
                            //                    command.ExecuteNonQuery();
                            //                    connection.Close();
                            //                    product.EditIndex = -1;
                            //                    set123();
                            //                    cleanbt4();
                            //                    cleanset();
                            //                    reviewShowPicture();
                            //                }
                            //                else
                            //                {
                            //                    //MessageBox.Show("圖片路徑不存在 請重新確認");
                            //                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('圖片路徑不存在 請重新確認');},1000);", true);
                            //                }
                            //            }
                            //            connectionSP.Close();
                            //        }
                            //        else
                            //        {
                            //            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('圖片檔名不得有中文字');},1000);", true);
                            //        }
                            //    }
                            //    else
                            //    {
                            //        //MessageBox.Show("圖片檔名不得為空");
                            //        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('圖片檔名不得為空');},1000);", true);
                            //    }
                            //}
                        }
                        else
                        {
                            //MessageBox.Show("顯示設定不得為空");
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('顯示設定不得為空');},1000);", true);
                        }
                    }
                    else
                    {
                        //MessageBox.Show("商品名稱重複 請重新輸入");
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('商品名稱重複 請重新輸入');},1000);", true);
                    }
                }
                else
                {
                    connectionPC.Close();
                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('該商品名稱不存在於商品資料庫 請重新確認');},1000);", true);
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
            reviewShowPicture();
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            if (TextBox10.Text != "")
            {
                string sqlPC = $"select distinct * from Products where productName = N'{TextBox10.Text}'";
                SqlConnection connectionPC = new SqlConnection(s_data2);
                SqlCommand commandPC = new SqlCommand(sqlPC, connectionPC);
                connectionPC.Open();
                SqlDataReader readerPC = commandPC.ExecuteReader();
                if (readerPC.Read() == true)
                {
                    connectionPC.Close();
                    string sql = $"select * from ShowPicture where productName = N'{TextBox10.Text}'";
                    if (checkShowPicture(sql) != true)
                    {
                        if (DDLShow.SelectedItem.Text != "請選擇")
                        {
                            if (DDLShow.SelectedItem.Text != "No")
                            {
                                //確定要不要卡
                                //string sql2 = $"select * from ShowPicture where show ='{DDLShow.Text}'";
                                //if (checkShowPicture(sql2) != true)
                                //{
                                //    HttpPostedFile myFile = FileUpload2.PostedFile;
                                //    int nFileLen = myFile.ContentLength;
                                //    if (FileUpload2.HasFile && nFileLen > 0)
                                //    {
                                //        string picturePath2 = $@"images\衣服\{TextBox10.Text}.jpg";
                                //        string imgPath = Server.MapPath(picturePath2);
                                //        FileUpload2.SaveAs(imgPath);
                                //        SqlConnection connection3 = new SqlConnection(s_data);
                                //        string sql3 = $"insert into [ShowPicture](productName,picture,show) values (N'{TextBox10.Text}',N'{picturePath2}','{DDLShow.Text}')";
                                //        SqlCommand command3 = new SqlCommand(sql3, connection3);
                                //        connection3.Open();
                                //        command3.ExecuteNonQuery();
                                //        connection3.Close();
                                //        cleansub();
                                //        set123();
                                //        reviewShowPicture();
                                //    }
                                //    else
                                //    {
                                //        hintp2.ForeColor = Color.Red;
                                //        hintp2.Text = "請上傳圖片";
                                //    }

                                //}
                                ////不卡版
                                string sqlchange = $"update ShowPicture set show ='No' where show ='{DDLShow.Text}'";
                                SqlConnection connectionchange = new SqlConnection(s_data);
                                SqlCommand commandchange = new SqlCommand(sqlchange, connectionchange);
                                connectionchange.Open();
                                commandchange.ExecuteNonQuery();
                                connectionchange.Close();

                                HttpPostedFile myFile = FileUpload2.PostedFile;
                                int nFileLen = myFile.ContentLength;
                                if (FileUpload2.HasFile && nFileLen > 0)
                                {
                                    string picturePath2 = $@"images\衣服\{TextBox10.Text}.jpg";
                                    string imgPath = Server.MapPath(picturePath2);
                                    FileUpload2.SaveAs(imgPath);
                                    SqlConnection connection3 = new SqlConnection(s_data);
                                    string sql3 = $"insert into [ShowPicture](productName,picture,show) values (N'{TextBox10.Text}',N'{picturePath2}','{DDLShow.Text}')";
                                    SqlCommand command3 = new SqlCommand(sql3, connection3);
                                    connection3.Open();
                                    command3.ExecuteNonQuery();
                                    connection3.Close();
                                    cleansub();
                                    //set123();
                                    //cleanset();
                                    cleanbt4();
                                    reviewShowPicture();
                                }
                                else
                                {
                                    hintp2.ForeColor = Color.Red;
                                    hintp2.Text = "請上傳圖片";
                                }
                                //hintp3.ForeColor = Color.Red;
                                //hintp3.Text = "該設定目前已存在 <br>請更改設定為No或取代已存在設定";
                            }
                            else
                            {
                                HttpPostedFile myFile = FileUpload2.PostedFile;
                                int nFileLen = myFile.ContentLength;
                                if (FileUpload2.HasFile && nFileLen > 0)
                                {
                                    string date = DateTime.Now.ToString("yyyyMMddhhmmss");
                                    string picturePath2 = $@"images\衣服\S_{date}.jpg";
                                    string imgPath = Server.MapPath(picturePath2);
                                    FileUpload2.SaveAs(imgPath);
                                    SqlConnection connection3 = new SqlConnection(s_data);
                                    string sql3 = $"insert into [ShowPicture](productName,picture,show) values (N'{TextBox10.Text}',N'{picturePath2}','{DDLShow.Text}')";
                                    SqlCommand command3 = new SqlCommand(sql3, connection3);
                                    connection3.Open();
                                    command3.ExecuteNonQuery();
                                    connection3.Close();
                                    cleansub();
                                    //set123();
                                    cleanbt4();
                                    //cleanset();
                                    reviewShowPicture();
                                }
                                else
                                {
                                    hintp2.ForeColor = Color.Red;
                                    hintp2.Text = "請上傳圖片";
                                }

                            }
                        }
                        else
                        {
                            hintp3.ForeColor = Color.Red;
                            hintp3.Text = "請輸入顯示設定";
                        }
                    }
                    else
                    {
                        hintp1.ForeColor = Color.Red;
                        hintp1.Text = "商品名稱重複 請重新輸入";
                    }
                }
                else
                {
                    hintp1.ForeColor = Color.Red;
                    hintp1.Text = "該商品名稱不存在於商品資料庫內 <br>請重新確認";
                    
                }
            }
            else
            {
                hintp1.ForeColor = Color.Red;
                hintp1.Text = "商品名稱不得為空";                
            }

        }

        protected void all_Click(object sender, EventArgs e)
        {
            reviewShowPicture();
        }

        protected void Button123_Click(object sender, EventArgs e)
        {
            string sql = $"select * from ShowPicture where show = '1' or show = '2' or show = '3' order by show ASC";
            searchShowPicture(sql);
        }

        //設定123名
        //protected void set_Click(object sender, EventArgs e)
        //{
        //    if (TextBox5.Text != "" && TextBox7.Text != "" && TextBox8.Text != "")
        //    {
        //        if (TextBox5.Text != TextBox7.Text && TextBox5.Text != TextBox8.Text && TextBox7.Text != TextBox8.Text)
        //        {
        //            string check1 = $"select * from ShowPicture where productName= N'{TextBox5.Text}'";
        //            string check2 = $"select * from ShowPicture where productName= N'{TextBox7.Text}'";
        //            string check3 = $"select * from ShowPicture where productName= N'{TextBox8.Text}'";
        //            if (checkShowPicture(check1))
        //            {
        //                if (checkShowPicture(check2))
        //                {
        //                    if (checkShowPicture(check3))
        //                    {
        //                        string sqlNo = $"update ShowPicture set show='No'  where show != 'No'";
        //                        SqlConnection connectionNo = new SqlConnection(s_data);
        //                        SqlCommand commandNo = new SqlCommand(sqlNo, connectionNo);
        //                        connectionNo.Open();
        //                        commandNo.ExecuteNonQuery();
        //                        connectionNo.Close();

        //                        string sql123 = $"update ShowPicture set show='1'  where productName = N'{TextBox5.Text}'";
        //                        SqlConnection connection123 = new SqlConnection(s_data);
        //                        SqlCommand command123 = new SqlCommand(sql123, connection123);
        //                        connection123.Open();
        //                        command123.ExecuteNonQuery();
        //                        connection123.Close();

        //                        sql123 = $"update ShowPicture set show='2'  where productName = N'{TextBox7.Text}'";
        //                        command123 = new SqlCommand(sql123, connection123);
        //                        connection123.Open();
        //                        command123.ExecuteNonQuery();
        //                        connection123.Close();

        //                        sql123 = $"update ShowPicture set show='3'  where productName = N'{TextBox8.Text}'";
        //                        command123 = new SqlCommand(sql123, connection123);
        //                        connection123.Open();
        //                        command123.ExecuteNonQuery();
        //                        connection123.Close();
                               
        //                        set123();
        //                        cleanset();
        //                        reviewShowPicture();
        //                    }
        //                    else
        //                    {
        //                        hintt3.ForeColor = Color.Red;
        //                        hintt3.Text = "商品名稱不存在";
        //                    }
        //                }
        //                else
        //                {
        //                    hintt2.ForeColor = Color.Red;
        //                    hintt2.Text = "商品名稱不存在";
        //                }
        //            }
        //            else
        //            {
        //                hintt1.ForeColor = Color.Red;
        //                hintt1.Text = "商品名稱不存在";
        //            }
        //        }
        //        else
        //        {
        //            hintset.ForeColor = Color.Red;
        //            hintset.Text = "更改主頁圖片 商品名稱不得重複";
        //        }

        //    }
        //    else
        //    {
        //        hintset.ForeColor = Color.Red;
        //        hintset.Text = "更改主頁圖片 商品名稱不得為空";
        //    }

        //}

        //protected void set_Click(object sender, EventArgs e)
        //{
        //    if (DDLtt1.SelectedItem.Text != "請選擇" && DDLtt2.SelectedItem.Text != "請選擇" && DDLtt3.SelectedItem.Text != "請選擇")
        //    {
        //        if (DDLtt1.Text != DDLtt2.Text && DDLtt1.Text != DDLtt3.Text && DDLtt2.Text != DDLtt3.Text)
        //        {
        //            exchange(DDLtt1.Text, show1.Text,"1");
        //            exchange(DDLtt2.Text, show2.Text,"2");
        //            exchange(DDLtt3.Text, show3.Text,"3");
                    

        //            //string sqlNo = $"update ShowPicture set show='No'  where show != 'No'";
        //            //SqlConnection connectionNo = new SqlConnection(s_data);
        //            //SqlCommand commandNo = new SqlCommand(sqlNo, connectionNo);
        //            //connectionNo.Open();
        //            //commandNo.ExecuteNonQuery();
        //            //connectionNo.Close();

        //            //string sql123 = $"update ShowPicture set show='1'  where productName = N'{DDLtt1.Text}'";
        //            //SqlConnection connection123 = new SqlConnection(s_data);
        //            //SqlCommand command123 = new SqlCommand(sql123, connection123);
        //            //connection123.Open();
        //            //command123.ExecuteNonQuery();
        //            //connection123.Close();

        //            //sql123 = $"update ShowPicture set show='2'  where productName = N'{DDLtt2.Text}'";
        //            //command123 = new SqlCommand(sql123, connection123);
        //            //connection123.Open();
        //            //command123.ExecuteNonQuery();
        //            //connection123.Close();

        //            //sql123 = $"update ShowPicture set show='3'  where productName = N'{DDLtt3.Text}'";
        //            //command123 = new SqlCommand(sql123, connection123);
        //            //connection123.Open();
        //            //command123.ExecuteNonQuery();
        //            //connection123.Close();

        //            set123();
        //            cleanset();
        //            reviewShowPicture();
        //        }
        //        else
        //        {
        //            hintset.ForeColor = Color.Red;
        //            hintset.Text = "更改主頁圖片 商品名稱不得重複";
        //        }

        //    }
        //    else
        //    {
        //        hintset.ForeColor = Color.Red;
        //        hintset.Text = "更改主頁圖片 商品名稱皆須選擇";
        //    }

        //}

        //protected void product_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    //if(e.Row.RowState> 0 && DataControlRowState.Edit>0)
        //    //{
        //    //    e.Row.FindControl("Label1").Focus();
        //    //} 
        //}

        //替換123名

    //    public void exchange(string change,string name, string number)
    //    {
    //        string sql123change = $"select show from ShowPicture where productName = N'{change}'";
    //        SqlConnection connection123change = new SqlConnection(s_data);
    //        SqlCommand command123change = new SqlCommand(sql123change, connection123change);
    //        connection123change.Open();
    //        SqlDataReader reader123 = command123change.ExecuteReader();
    //        while (reader123.Read())
    //        {
    //            string sql123o = $"update ShowPicture set show='{reader123[0]}'  where productName = N'{name}'";
    //            SqlConnection connection123o = new SqlConnection(s_data);
    //            SqlCommand command123o = new SqlCommand(sql123o, connection123o);
    //            connection123o.Open();
    //            command123o.ExecuteNonQuery();
    //            connection123o.Close();

    //            string sql123 = $"update ShowPicture set show='{number}'  where productName = N'{change}'";
    //            SqlConnection connection123 = new SqlConnection(s_data);
    //            SqlCommand command123 = new SqlCommand(sql123, connection123);
    //            connection123.Open();
    //            command123.ExecuteNonQuery();
    //            connection123.Close();
    //        }
    //        connection123change.Close();
    //    }

    }


}
