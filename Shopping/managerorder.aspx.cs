using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping
{
    public partial class managerorder : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;
        string s_data2 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string s_data3 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        string s_data4 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string s_data5 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ShoppingConnectionString"].ConnectionString;



        

        public void reviewOrder()
        {
            helpSQLO11.Text = "";
            helpSQLO12.Text = "";
            helpSQLO21.Text = "";
            helpSQLO22.Text = "";
            SqlConnection connectionorigin = new SqlConnection(s_data5);
            string sqlorigin = $"select a.ID, a.serial, a.productName, a.productColor, a.productPicture, a.productPrice, a.qty , a.customerAccount, b.name, b.phone, b.address, b.status, b.initdate, b.updateInitdate FROM OrderDetail AS a INNER JOIN Orders AS b ON a.serial = b.serial";
            SqlCommand command = new SqlCommand(sqlorigin, connectionorigin);
            connectionorigin.Open();
            SqlDataReader readorigin = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("serial");
            dt.Columns.Add("productName");
            dt.Columns.Add("productColor");
            dt.Columns.Add("productPicture");
            dt.Columns.Add("productPrice");
            dt.Columns.Add("qty");
            dt.Columns.Add("customerAccount");
            dt.Columns.Add("name");
            dt.Columns.Add("phone");
            dt.Columns.Add("address");
            dt.Columns.Add("status");
            dt.Columns.Add("initdate");
            dt.Columns.Add("updateInitdate");
            while (readorigin.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = readorigin[0];
                row["serial"] = readorigin[1];
                row["productName"] = readorigin[2];
                row["productColor"] = readorigin[3];
                row["productPicture"] = readorigin[4];
                row["productPrice"] = readorigin[5];
                row["qty"] = readorigin[6];
                row["customerAccount"] = readorigin[7];
                row["name"] = readorigin[8];
                row["phone"] = readorigin[9];
                row["address"] = readorigin[10];
                row["status"] = readorigin[11];
                row["initdate"] = readorigin[12];
                row["updateInitdate"] = readorigin[13];
                dt.Rows.Add(row);
            }
            userorder.DataSource = dt;
            userorder.DataBind();
            connectionorigin.Close();
            
        }


        public void searchOrder(string name, string check)
        {
            helpSQLO11.Text = name;
            helpSQLO12.Text = check;
            helpSQLO21.Text = "";
            helpSQLO22.Text = "";
            SqlConnection connectionorigin = new SqlConnection(s_data5);
            string sqlorigin = $"select a.ID, a.serial, a.productName, a.productColor, a.productPicture, a.productPrice," +
                $" a.qty , a.customerAccount, b.name, b.phone, b.address, b.status, b.initdate, b.updateInitdate " +
                $"FROM OrderDetail AS a INNER JOIN Orders AS b ON a.serial = b.serial where a.{name}=N'{check}'";
            SqlCommand command = new SqlCommand(sqlorigin, connectionorigin);
            connectionorigin.Open();
            SqlDataReader readorigin = command.ExecuteReader();            
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("serial");
            dt.Columns.Add("productName");
            dt.Columns.Add("productColor");
            dt.Columns.Add("productPicture");
            dt.Columns.Add("productPrice");
            dt.Columns.Add("qty");
            dt.Columns.Add("customerAccount");
            dt.Columns.Add("name");
            dt.Columns.Add("phone");
            dt.Columns.Add("address");
            dt.Columns.Add("status");
            dt.Columns.Add("initdate");
            dt.Columns.Add("updateInitdate");
            while (readorigin.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = readorigin[0];
                row["serial"] = readorigin[1];
                row["productName"] = readorigin[2];
                row["productColor"] = readorigin[3];
                row["productPicture"] = readorigin[4];
                row["productPrice"] = readorigin[5];
                row["qty"] = readorigin[6];
                row["customerAccount"] = readorigin[7];
                row["name"] = readorigin[8];
                row["phone"] = readorigin[9];
                row["address"] = readorigin[10];
                row["status"] = readorigin[11];
                row["initdate"] = readorigin[12];
                row["updateInitdate"] = readorigin[13];
                dt.Rows.Add(row);
            }
            userorder.DataSource = dt;
            userorder.DataBind();
            connectionorigin.Close();            
        }

        public bool findOrder(string name, string check)
        {
            helpSQLO11.Text = name;
            helpSQLO12.Text = check;
            helpSQLO21.Text = "";
            helpSQLO22.Text = "";
            SqlConnection connectionorigin = new SqlConnection(s_data5);
            string sqlorigin = $"select a.ID, a.serial, a.productName, a.productColor, a.productPicture, a.productPrice," +
                $" a.qty , a.customerAccount, b.name, b.phone, b.address, b.status, b.initdate, b.updateInitdate " +
                $"FROM OrderDetail AS a INNER JOIN Orders AS b ON a.serial = b.serial where a.{name}=N'{check}'";
            SqlCommand command = new SqlCommand(sqlorigin, connectionorigin);
            connectionorigin.Open();
            SqlDataReader readorigin = command.ExecuteReader();
            bool find = readorigin.Read();
            connectionorigin.Close();
            return find;
        }


        public void searchOrder2(string name, string check)
        {
            helpSQLO11.Text = "";
            helpSQLO12.Text = "";
            helpSQLO21.Text = name;
            helpSQLO22.Text = check;
            SqlConnection connectionorigin = new SqlConnection(s_data5);
            string sqlorigin = $"select a.ID, a.serial, a.productName, a.productColor, a.productPicture, a.productPrice," +
                $" a.qty , a.customerAccount, b.name, b.phone, b.address, b.status, b.initdate, b.updateInitdate " +
                $"FROM OrderDetail AS a INNER JOIN Orders AS b ON a.serial = b.serial where b.{name}=N'{check}'";
            SqlCommand command = new SqlCommand(sqlorigin, connectionorigin);
            connectionorigin.Open();
            SqlDataReader readorigin = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("serial");
            dt.Columns.Add("productName");
            dt.Columns.Add("productColor");
            dt.Columns.Add("productPicture");
            dt.Columns.Add("productPrice");
            dt.Columns.Add("qty");
            dt.Columns.Add("customerAccount");
            dt.Columns.Add("name");
            dt.Columns.Add("phone");
            dt.Columns.Add("address");
            dt.Columns.Add("status");
            dt.Columns.Add("initdate");
            dt.Columns.Add("updateInitdate");

            while (readorigin.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = readorigin[0];
                row["serial"] = readorigin[1];
                row["productName"] = readorigin[2];
                row["productColor"] = readorigin[3];
                row["productPicture"] = readorigin[4];
                row["productPrice"] = readorigin[5];
                row["qty"] = readorigin[6];
                row["customerAccount"] = readorigin[7];
                row["name"] = readorigin[8];
                row["phone"] = readorigin[9];
                row["address"] = readorigin[10];
                row["status"] = readorigin[11];
                row["initdate"] = readorigin[12];
                row["updateInitdate"] = readorigin[13];
                dt.Rows.Add(row);
            }
            userorder.DataSource = dt;
            userorder.DataBind();
            connectionorigin.Close();
        }


        public bool findOrder2(string name, string check)
        {
            helpSQLO11.Text = "";
            helpSQLO12.Text = "";
            helpSQLO21.Text = name;
            helpSQLO22.Text = check;
            SqlConnection connectionorigin = new SqlConnection(s_data5);
            string sqlorigin = $"select a.ID, a.serial, a.productName, a.productColor, a.productPicture, a.productPrice," +
                $" a.qty , a.customerAccount, b.name, b.phone, b.address, b.status, b.initdate, b.updateInitdate " +
                $"FROM OrderDetail AS a INNER JOIN Orders AS b ON a.serial = b.serial where b.{name}=N'{check}'";
            SqlCommand command = new SqlCommand(sqlorigin, connectionorigin);
            connectionorigin.Open();
            SqlDataReader readorigin = command.ExecuteReader();
            bool find = readorigin.Read();            
            connectionorigin.Close();
            return find;
        }

        //public bool reviewSerial()
        //{
        //    Random rnd = new Random();
        //    TextBox1.Text = "";
        //    for (int i = 0; i < 10; i++)    //編成serial number
        //    {
        //        int serialrnd = rnd.Next(0, 10);
        //        TextBox1.Text += serialrnd;
        //    }
        //    SqlConnection connection2s = Connect(s_data);
        //    string sql2s = $"select * from Orders where serial='{TextBox1.Text}'";  //為了找尋serial是否重複
        //    SqlCommand command2s = new SqlCommand(sql2s, connection2s);
        //    connection2s.Open();
        //    SqlDataReader Reader2s = command2s.ExecuteReader();
        //    bool f = Reader2s.HasRows;
        //    connection2s.Close();
        //    return f;
        //}

        //public string sourcefind(string x)
        //{
        //    string source = $"select {x} from OrderDetail where ID ='{DDLUpdateOrderDetailID.Text}'";
        //    SqlConnection consource = new SqlConnection(s_data4);
        //    SqlCommand concommand = new SqlCommand(source, consource);
        //    consource.Open();
        //    SqlDataReader dataReader = concommand.ExecuteReader();

        //    if (dataReader.Read())
        //    {
        //        string y = dataReader[0].ToString();
        //        consource.Close();
        //        return y;
        //    }
        //    else
        //    {
        //        consource.Close();
        //        string z = "";
        //        return z;
        //    }

        //}

        //public string ordersfind(string a, string b)
        //{
        //    string orders = $"select {a} from Orders where {b} = N'{sourcefind(b)}'";
        //    SqlConnection conorders = new SqlConnection(s_data);
        //    SqlCommand comorders = new SqlCommand(orders, conorders);
        //    conorders.Open();
        //    SqlDataReader dataReader = comorders.ExecuteReader();

        //    if (dataReader.Read())
        //    {
        //        string y = dataReader[0].ToString();
        //        conorders.Close();
        //        return y;
        //    }
        //    else
        //    {
        //        conorders.Close();
        //        string z = "";
        //        return z;
        //    }

        //}



        //public void DDLreconnect()
        //{
        //    DDLDeleteOrderID.Items.Clear();
        //    DDLDeleteOrderID.Items.Add("請選擇");
        //    DDLUpdateOrderID.Items.Clear();
        //    DDLUpdateOrderID.Items.Add("請選擇");
        //    DataView dv = (DataView)this.SqlDataSourceOrderID.Select(new DataSourceSelectArguments());
        //    DDLDeleteOrderID.DataSource = dv;
        //    DDLDeleteOrderID.DataTextField = "ID";
        //    DDLDeleteOrderID.DataBind();
        //    DDLUpdateOrderID.DataSource = dv;
        //    DDLUpdateOrderID.DataTextField = "ID";
        //    DDLUpdateOrderID.DataBind();
        //}
        public string allcheck(string kind, string productName, string productColor)
        {
            string I = "";
            string sqlSQ = $"select {kind} from Products where productName = N'{productName}' And category = N'{productColor}' ";
            SqlConnection connectionSQ = new SqlConnection(s_data3);
            SqlCommand commandSQ = new SqlCommand(sqlSQ, connectionSQ);
            connectionSQ.Open();
            SqlDataReader readerSQ = commandSQ.ExecuteReader();
            if (readerSQ.Read())
            {
                I = readerSQ[0].ToString();

            }
            connectionSQ.Close();
            return I;
        }

        public bool productexistcheck(string productName, string productColor)
        {
            string sqlSQ = $"select * from Products where productName = N'{productName}' And category = N'{productColor}' ";
            SqlConnection connectionSQ = new SqlConnection(s_data3);
            SqlCommand commandSQ = new SqlCommand(sqlSQ, connectionSQ);
            connectionSQ.Open();
            SqlDataReader readerSQ = commandSQ.ExecuteReader();
            bool existcheck = readerSQ.Read();
            connectionSQ.Close();
            return existcheck;
        }



        public void cleanbtss()
        {            
            TextBox6.Text = "";
        }
        
        
        
        public void cleanbtspn()
        {
            DataView dv = (DataView)this.SqlDataSourceProductName.Select(new DataSourceSelectArguments());
            DDLSearchProductName.Items.Clear();
            DDLSearchProductName.Items.Add("請選擇");
            DDLSearchProductName.DataSource = dv;
            DDLSearchProductName.DataTextField = "productName";
            DDLSearchProductName.DataBind();
        }

        public void cleanbtsn()
        {
            TextBox8.Text = "";
        }

        public void cleanbts()
        {
            DataView dv = (DataView)this.SqlDataSourceOrdersStatus.Select(new DataSourceSelectArguments());
            DDLSearchStatus.Items.Clear();
            DDLSearchStatus.Items.Add("請選擇");
            DDLSearchStatus.DataSource = dv;
            DDLSearchStatus.DataTextField = "status";
            DDLSearchStatus.DataBind();
        }

        

        

        public void changecolor()
        {
            hintSerial.ForeColor = Color.Black;
            hintCustomerAccount.ForeColor = Color.Black;
            hintProductName.ForeColor = Color.Black;
            hintName.ForeColor = Color.Black;
            hintStatus.ForeColor = Color.Black;
            
        }

        

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["access"] != null && Session["access"] == "ok")
            //{

            //}
            //else
            //{
            //    Response.Redirect("manager");
            //}
            hintSerial.Text = "";
            hintCustomerAccount.Text = "";
            hintProductName.Text = "";
            hintName.Text = "";
            hintStatus.Text = "";
            changecolor();
            if (!IsPostBack)
            {
                reviewOrder();
                cleanbtss();                
                cleanbtspn();
                cleanbtsn();
                cleanbts();                
            }
        }



       

        
        protected void serialSearch_Click(object sender, EventArgs e)
        {
            bool serialcheck = Regex.IsMatch(TextBox2.Text, @"\d{10}");
            if (TextBox2.Text!= "")
            {
                if (serialcheck)
                {
                    if (findOrder("serial", TextBox2.Text))
                    {
                        searchOrder("serial", TextBox2.Text);
                        cleanbtss();
                    }
                    else
                    {
                        hintSerial.ForeColor = Color.Red;
                        hintSerial.Text = "訂單編號不存在";
                    }
                    
                }
                else
                {
                    hintSerial.ForeColor = Color.Red;
                    hintSerial.Text = "訂單編號為10碼數字 請確認";
                }
            }
            else
            {
                hintSerial.ForeColor = Color.Red;
                hintSerial.Text = "請輸入訂單編號";
            }
        }

        protected void customerAccountsearch_Click(object sender, EventArgs e)
        {
            bool accountCheck = Regex.IsMatch(TextBox6.Text, @"[\w-]{6,15}");
            if (TextBox6.Text != "")
            {
                if (accountCheck)
                {
                    SqlConnection connection = new SqlConnection(s_data2);
                    string sql = $"select * from Customers where account = '{TextBox6.Text}'";
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        connection.Close();
                        if (findOrder("customerAccount", TextBox6.Text))
                        {
                            searchOrder("customerAccount", TextBox6.Text);
                            cleanbtss();
                        }
                        else
                        {
                            hintCustomerAccount.ForeColor = Color.Red;
                            hintCustomerAccount.Text = "未查詢到該帳號訂單";
                        }
                    }
                    else
                    {
                        connection.Close();
                        hintCustomerAccount.ForeColor = Color.Red;
                        hintCustomerAccount.Text = "帳號不存在 請重新確認";
                    }
                }
                else
                {
                    hintCustomerAccount.ForeColor = Color.Red;
                    hintCustomerAccount.Text = "帳號需包含6-15個英文字母加數字";
                }
            }
            else
            {
                hintCustomerAccount.ForeColor = Color.Red;
                hintCustomerAccount.Text = "請輸入帳號";
            }            

        }

        protected void productNamesearch_Click(object sender, EventArgs e)
        {
            if (DDLSearchProductName.SelectedItem.Text != "請選擇")
            {
                searchOrder("productName", DDLSearchProductName.Text);
                cleanbtspn();               
            }
            else
            {
                hintProductName.ForeColor = Color.Red;
                hintProductName.Text = "請選擇項目";
            }
        }

        protected void namesearch_Click(object sender, EventArgs e)
        {
            if (TextBox8.Text != "")
            {
                if (findOrder2("name",TextBox8.Text))
                {
                    searchOrder2("name", TextBox8.Text);
                    cleanbtsn();
                }
                else 
                {
                    hintName.ForeColor = Color.Red;
                    hintName.Text = "未查詢到該收件人訂單";
                }
            }
            else
            {
                hintName.ForeColor = Color.Red;
                hintName.Text = "請輸入收件人";
            }
        }

        protected void statussearch_Click(object sender, EventArgs e)
        {
            if (DDLSearchStatus.SelectedItem.Text != "請選擇")
            {
                searchOrder2("status", DDLSearchStatus.Text);
                cleanbts();               
            }
            else
            {
                hintStatus.ForeColor = Color.Red;
                hintStatus.Text = "請選擇項目";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["access"] = "Not ok";
            Response.Redirect(Request.Url.ToString());
        }



        protected void userorder_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            userorder.EditIndex = -1;
            if (helpSQLO11.Text != "")
            {
                searchOrder(helpSQLO11.Text, helpSQLO12.Text);
            }
            else if (helpSQLO21.Text != "")
            {
                searchOrder2(helpSQLO21.Text, helpSQLO22.Text);
            }
            else
            {
                reviewOrder();
            }
        }

        protected void userorder_RowEditing(object sender, GridViewEditEventArgs e)
        {
            userorder.EditIndex = e.NewEditIndex;
            if (helpSQLO11.Text != "")
            {
                searchOrder(helpSQLO11.Text, helpSQLO12.Text);
            }
            else if (helpSQLO21.Text != "")
            {
                searchOrder2(helpSQLO21.Text, helpSQLO22.Text);
            }
            else
            {
                reviewOrder();
            }
        }

        protected void userorder_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string ID = userorder.DataKeys[e.RowIndex].Values[0].ToString();
            string serial = ((Label)userorder.Rows[e.RowIndex].FindControl("Label2")).Text;
            string productName = ((TextBox)userorder.Rows[e.RowIndex].FindControl("TextBox3")).Text;
            string productColor = ((TextBox)userorder.Rows[e.RowIndex].FindControl("TextBox4")).Text;
            string qty = ((TextBox)userorder.Rows[e.RowIndex].FindControl("TextBox7")).Text;
            string name = ((TextBox)userorder.Rows[e.RowIndex].FindControl("TextBox9")).Text;
            string phone = ((TextBox)userorder.Rows[e.RowIndex].FindControl("TextBox10")).Text;
            string address = ((TextBox)userorder.Rows[e.RowIndex].FindControl("TextBox11")).Text;
            string status = ((TextBox)userorder.Rows[e.RowIndex].FindControl("TextBox12")).Text;
            bool qtyCheck = Regex.IsMatch(qty, @"\d");            
            bool phoneCheck = Regex.IsMatch(phone, @"^09[\d]{8}$");





            //用來比對是否只有更改訂單狀態
            string sqlCOD = $"select productName, productColor, qty from OrderDetail  where ID = '{ID}'";
            SqlConnection connectionCOD = new SqlConnection(s_data4); //比對OrderDetail
            SqlCommand commandCOD = new SqlCommand(sqlCOD, connectionCOD);
            connectionCOD.Open();
            SqlDataReader readerCOD = commandCOD.ExecuteReader();

            string sqlOOD = $"select name, phone, address from Orders where serial = '{serial}'";
            SqlConnection connectionOOD = new SqlConnection(s_data); //比對Order
            SqlCommand commandOOD = new SqlCommand(sqlOOD, connectionOOD);
            connectionOOD.Open();
            SqlDataReader readerOOD = commandOOD.ExecuteReader();

            if (readerCOD.Read())
            {
                if (readerOOD.Read())
                {
                    string productNamec = readerCOD[0].ToString();
                    string productColorc = readerCOD[1].ToString();
                    string qtyc = readerCOD[2].ToString();
                    string namec = readerOOD[0].ToString();
                    string phonec = readerOOD[1].ToString();
                    string addressc = readerOOD[2].ToString();
                    connectionOOD.Close();
                    connectionCOD.Close();

                    if (status == "賣方處理中")
                    {
                        if (address != "")
                        {
                            if (phoneCheck)
                            {
                                if (name != "")
                                {
                                    if (qtyCheck && int.Parse(qty) >= 0)
                                    {
                                        if (productName == productNamec && productColorc == productColor)
                                        {
                                            //查詢庫存量
                                            if (Convert.ToInt32(allcheck("inventory", productName, productColor)) >= (int.Parse(qty) - int.Parse(qtyc)))
                                            {
                                                //更新庫存數量
                                                string sqlUQ = $"update Products set inventory = '{(Convert.ToInt32(allcheck("inventory", productName, productColor)) - (int.Parse(qty) - int.Parse(qtyc))).ToString()}' where productName = N'{productName}' And category = N'{productColor}' ";
                                                SqlConnection connectionUQ = new SqlConnection(s_data3);
                                                SqlCommand commandUQ = new SqlCommand(sqlUQ, connectionUQ);
                                                connectionUQ.Open();
                                                commandUQ.ExecuteNonQuery();
                                                connectionUQ.Close();

                                                string sqlUOD = $"update OrderDetail set productName = N'{productName}', productColor = N'{productColor}', qty = N'{qty}' where ID = '{ID}'";
                                                SqlConnection connectionUOD = new SqlConnection(s_data4); //更新OrderDetail
                                                SqlCommand commandUOD = new SqlCommand(sqlUOD, connectionUOD);
                                                connectionUOD.Open();
                                                commandUOD.ExecuteNonQuery();
                                                connectionUOD.Close();

                                                //更新總價
                                                string sqlsum = $"select sum(productPrice*qty) from OrderDetail where serial='{serial}'";
                                                SqlConnection connectionsum = new SqlConnection(s_data4);
                                                SqlCommand commandsum = new SqlCommand(sqlsum, connectionsum);
                                                connectionsum.Open();
                                                SqlDataReader Reader4 = commandsum.ExecuteReader();
                                                if (Reader4.Read())
                                                {
                                                    string sqlUO = $"update Orders set name = N'{name}',phone = '{phone}', address = N'{address}',totalprice = '{Reader4[0]}', status = N'{status}', updateInitdate= getdate()  where serial ='{serial}'";
                                                    SqlConnection connectionUO = new SqlConnection(s_data); //更新Order            
                                                    SqlCommand commandUO = new SqlCommand(sqlUO, connectionUO);
                                                    connectionUO.Open();
                                                    commandUO.ExecuteNonQuery();
                                                    connectionUO.Close();
                                                    userorder.EditIndex = -1;
                                                }
                                                connectionsum.Close();
                                                reviewOrder();
                                            }
                                            else
                                            {
                                                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('商品庫存不足 請下修數量');},700);", true);
                                            }

                                        }
                                        else
                                        {
                                            if (productexistcheck(productName, productColor))
                                            {
                                                if (Convert.ToInt32(allcheck("inventory", productName, productColor)) >= (int.Parse(qty)))
                                                {
                                                    //減少新訂單庫存
                                                    string sqlUQ1 = $"update Products set inventory = '{(Convert.ToInt32(allcheck("inventory", productName, productColor)) - (int.Parse(qty))).ToString()}' where productName = N'{productName}' And category = N'{productColor}' ";
                                                    SqlConnection connectionUQ1 = new SqlConnection(s_data3);
                                                    SqlCommand commandUQ1 = new SqlCommand(sqlUQ1, connectionUQ1);
                                                    connectionUQ1.Open();
                                                    commandUQ1.ExecuteNonQuery();
                                                    connectionUQ1.Close();

                                                    //加回舊訂單庫存
                                                    string sqlUQ2 = $"update Products set inventory = '{(Convert.ToInt32(allcheck("inventory", productNamec, productColorc)) + (int.Parse(qtyc))).ToString()}' where productName = N'{productNamec}' And category = N'{productColorc}' ";
                                                    SqlConnection connectionUQ2 = new SqlConnection(s_data3);
                                                    SqlCommand commandUQ2 = new SqlCommand(sqlUQ2, connectionUQ2);
                                                    connectionUQ2.Open();
                                                    commandUQ2.ExecuteNonQuery();
                                                    connectionUQ2.Close();

                                                    string sqlUOD = $"update OrderDetail set productName = N'{productName}', productColor = N'{productColor}', productPrice = N'{allcheck("price", productName, productColor)}', productPicture = N'{allcheck("picture", productName, productColor)}', qty = N'{qty}' where ID = '{ID}'";
                                                    SqlConnection connectionUOD = new SqlConnection(s_data4); //更新OrderDetail
                                                    SqlCommand commandUOD = new SqlCommand(sqlUOD, connectionUOD);
                                                    connectionUOD.Open();
                                                    commandUOD.ExecuteNonQuery();
                                                    connectionUOD.Close();

                                                    string sqlsum = $"select sum(productPrice*qty) from OrderDetail where serial='{serial}'";
                                                    SqlConnection connectionsum = new SqlConnection(s_data4);
                                                    SqlCommand commandsum = new SqlCommand(sqlsum, connectionsum);
                                                    connectionsum.Open();
                                                    SqlDataReader Reader4 = commandsum.ExecuteReader();
                                                    if (Reader4.Read())
                                                    {
                                                        string sqlUO = $"update Orders set name = N'{name}',phone = '{phone}', address = N'{address}',totalprice = '{Reader4[0]}', status = N'{status}', updateInitdate= getdate()  where serial ='{serial}'";
                                                        SqlConnection connectionUO = new SqlConnection(s_data); //更新Order            
                                                        SqlCommand commandUO = new SqlCommand(sqlUO, connectionUO);
                                                        connectionUO.Open();
                                                        commandUO.ExecuteNonQuery();
                                                        connectionUO.Close();
                                                        userorder.EditIndex = -1;
                                                    }
                                                    connectionsum.Close();

                                                    reviewOrder();
                                                }
                                                else
                                                {
                                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('商品庫存不足 請下修數量或更改商品組合');},700);", true);
                                                }
                                            }
                                            else
                                            {
                                                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('商品不存在 請重新輸入商品組合');},700);", true);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('數量需為不小於0的數字');},700);", true);
                                    }
                                }
                                else
                                {
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('收件人不得為空');},700);", true);
                                }
                            }
                            else
                            {
                                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('電話格式有誤 為09加8個數字');},700);", true);
                            }
                        }
                        else
                        {
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('地址欄位不得為空');},700);", true);
                        }
                    }
                    else
                    {
                        if (productName == productNamec && productColor == productColorc && qty == qtyc && name == namec && phone == phonec && address == addressc)
                        {
                            string sqlOS = $"update Orders set status = N'{status}', updateInitdate= getdate() where serial ='{serial}'";
                            SqlConnection connectionOS = new SqlConnection(s_data); //更新Order            
                            SqlCommand commandOS = new SqlCommand(sqlOS, connectionOS);
                            connectionOS.Open();
                            commandOS.ExecuteNonQuery();
                            connectionOS.Close();
                            userorder.EditIndex = -1;
                            reviewOrder();
                        }
                        else
                        {
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert(@'該訂單狀態為配送中、已完成或已取消   無法修改訂單內容、僅能修改訂單狀態');},700);", true);
                        }
                    }
                }
            }

        }

        protected void userorder_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            userorder.PageIndex = e.NewPageIndex;
            reviewOrder();
        }

        protected void all_Click(object sender, EventArgs e)
        {
            Response.Redirect("managerorder");
        }
    }
}