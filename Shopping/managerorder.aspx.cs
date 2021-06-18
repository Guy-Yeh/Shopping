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

        

        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }

        public void reviewOrder()
        {
            SqlConnection connectionorigin = Connect(s_data5);
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
            SqlConnection connectionorigin = Connect(s_data5);
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

        public void searchOrder2(string name, string check)
        {
            SqlConnection connectionorigin = Connect(s_data5);
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

        public string sourcefind(string x)
        {
            string source = $"select {x} from OrderDetail where ID ='{DDLUpdateOrderDetailID.Text}'";
            SqlConnection consource = new SqlConnection(s_data4);
            SqlCommand concommand = new SqlCommand(source, consource);
            consource.Open();
            SqlDataReader dataReader = concommand.ExecuteReader();

            if (dataReader.Read())
            {
                string y = dataReader[0].ToString();
                consource.Close();
                return y;
            }
            else
            {
                consource.Close();
                string z = "";
                return z;
            }
            
        }

        public string ordersfind(string a , string b)
        {
            string orders = $"select {a} from Orders where {b} = N'{sourcefind(b)}'";
            SqlConnection conorders = new SqlConnection(s_data);
            SqlCommand comorders = new SqlCommand(orders, conorders);
            conorders.Open();
            SqlDataReader dataReader = comorders.ExecuteReader();

            if (dataReader.Read())
            {
                string y = dataReader[0].ToString();
                conorders.Close();
                return y;
            }
            else
            {
                conorders.Close();
                string z = "";
                return z;
            }

        }

        public void updateorders()
        {
            SqlConnection connection5 = new SqlConnection(s_data);
            string sql5 = $"update Orders SET {DDLUpdateOrderCols.Text}= N'{TextBox9.Text}',updateInitdate= getdate() where serial='{sourcefind("serial")}'";
            SqlCommand command5 = new SqlCommand(sql5, connection5);
            connection5.Open();
            command5.ExecuteNonQuery();
        }

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

        public void cleanbtss()
        {
            DataView dv = (DataView)this.SqlDataSourceOrderSerial.Select(new DataSourceSelectArguments());
            DDLSS.Items.Clear();
            DDLSS.Items.Add("請選擇");
            DDLSS.DataSource = dv;
            DDLSS.DataTextField = "serial";
            DDLSS.DataBind();
        }

        public void cleanbtsca()
        {
            DataView dv = (DataView)this.SqlDataSourceCustomerAccount.Select(new DataSourceSelectArguments());
            DDLSearchCustomerAccount.Items.Clear();
            DDLSearchCustomerAccount.Items.Add("請選擇");
            DDLSearchCustomerAccount.DataSource = dv;
            DDLSearchCustomerAccount.DataTextField = "account";
            DDLSearchCustomerAccount.DataBind();
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
            DataView dv = (DataView)this.SqlDataSourceSearchName.Select(new DataSourceSelectArguments());
            DDLSearchName.Items.Clear();
            DDLSearchName.Items.Add("請選擇");
            DDLSearchName.DataSource = dv;
            DDLSearchName.DataTextField = "name";
            DDLSearchName.DataBind();
        }

        public void cleanbts()
        {
            DataView dv = (DataView)this.SqlDataSourceOrdersStatus.Select(new DataSourceSelectArguments());
            DDLSearchStatus.Items.Clear();
            DDLSearchStatus.Items.Add("請選擇");
            DDLSearchStatus.DataSource = dv;
            DDLSearchStatus.DataTextField = "Cols";
            DDLSearchStatus.DataBind();
        }

        public void cleanbt2()
        {
            DataView dv = (DataView)this.SqlDataSourceOrderSerial.Select(new DataSourceSelectArguments());
            DDLDeleteOrderID.Items.Clear();
            DDLDeleteOrderID.Items.Add("請選擇");
            DDLDeleteOrderID.DataSource = dv;
            DDLDeleteOrderID.DataTextField = "serial";
            DDLDeleteOrderID.DataBind();
            
        }

        public void cleanbt3()
        {
            DataView dv = (DataView)this.SqlDataSourceOrderDetailSearch.Select(new DataSourceSelectArguments());
            DDLUpdateOrderDetailID.Items.Clear();
            DDLUpdateOrderDetailID.Items.Add("請選擇");
            DDLUpdateOrderDetailID.DataSource = dv;
            DDLUpdateOrderDetailID.DataTextField = "ID";
            DDLUpdateOrderDetailID.DataBind();
            DataView dv2 = (DataView)this.SqlDataSourceOrderCols.Select(new DataSourceSelectArguments());
            DDLUpdateOrderCols.Items.Clear();
            DDLUpdateOrderCols.Items.Add("請選擇");
            DDLUpdateOrderCols.DataSource = dv2;
            DDLUpdateOrderCols.DataTextField = "Cols";
            DDLUpdateOrderCols.DataBind();
            TextBox9.Text = "";
        }

        public void changecolor()
        {
            hintSerial.ForeColor = Color.Black;
            hintCustomerAccount.ForeColor = Color.Black;
            hintProductName.ForeColor = Color.Black;
            hintName.ForeColor = Color.Black;
            hintStatus.ForeColor = Color.Black;
            hintID.ForeColor = Color.Black;
            hintID2.ForeColor = Color.Black;
            hintColumn.ForeColor = Color.Black;
            hintAll.ForeColor = Color.Black;
        }

        public void transferInventorybyPN()
        { 
        
        
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
            hintID.Text = "選擇即將刪除的orderSerial";
            hintID2.Text = "選擇即將更新的orderDetailID";
            hintColumn.Text = "選擇即將更新的欄位";
            hintAll.Text = "";
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
                cleanbtsca();
                cleanbtspn();
                cleanbtsn();
                cleanbts();
                cleanbt2();
                cleanbt3();
            }
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {       
            if (DDLDeleteOrderID.SelectedItem.Text != "請選擇")
            {
                string sqlIC = $"select productName, productColor, qty from OrderDetail where serial='{DDLDeleteOrderID.Text}'";
                SqlConnection connectionIC = Connect(s_data4);
                SqlCommand commandIC = new SqlCommand(sqlIC, connectionIC);
                connectionIC.Open();
                SqlDataReader readerIC = commandIC.ExecuteReader();
                while (readerIC.Read())
                {
                    
                    string sqlSP = $"select inventory from Products where productName = N'{readerIC[0]}' And category = N'{readerIC[1]}' ";
                    SqlConnection connectionSP = Connect(s_data3);
                    SqlCommand commandSP = new SqlCommand(sqlSP, connectionSP);
                    connectionSP.Open();
                    SqlDataReader readerSP = commandSP.ExecuteReader();
                    if (readerSP.Read())
                    {
                        string sqlUP = $"update Products set inventory = '{(Convert.ToInt32(readerSP[0]) + Convert.ToInt32(readerIC[2])).ToString()}' where productName = N'{readerIC[0]}' And category = N'{readerIC[1]}' ";
                        SqlConnection connectionUP = Connect(s_data3);
                        SqlCommand commandUP = new SqlCommand(sqlUP, connectionUP);
                        connectionUP.Open();
                        commandUP.ExecuteNonQuery();
                        connectionUP.Close();
                    }
                    connectionSP.Close();
                }
                connectionIC.Close();

                string sql3D = $"delete from OrderDetail where serial='{DDLDeleteOrderID.Text}'";
                SqlConnection connection3D = Connect(s_data4);
                SqlCommand command3D = new SqlCommand(sql3D, connection3D);
                connection3D.Open();
                command3D.ExecuteNonQuery();
                connection3D.Close();

                string sql3 = $"delete from Orders where serial='{DDLDeleteOrderID.Text}'";
                SqlConnection connection3 = Connect(s_data);
                SqlCommand command3 = new SqlCommand(sql3, connection3);
                connection3.Open();
                command3.ExecuteNonQuery();
                connection3.Close();
                reviewOrder();
                cleanbt2();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt2", "setTimeout( function(){alert('刪除成功');},0);", true);
            }
            else
            {
                hintID.ForeColor = Color.Red;
                hintID.Text = "請選擇項目";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            bool numberCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool serialCheck = Regex.IsMatch(TextBox9.Text, @"\d{10}");
            bool phoneCheck = Regex.IsMatch(TextBox9.Text, @"^09[\d]{8}");
            string serialName;
            string serialColor;
            string serialQty;
            string serialPrice;
            if (DDLUpdateOrderDetailID.SelectedItem.Text != "請選擇")
            {


                if (DDLUpdateOrderCols.SelectedItem.Text != "請選擇")
                {

                    if (DDLUpdateOrderCols.Text == "status")
                    {
                        if (TextBox9.Text == "賣方處理中" || TextBox9.Text == "配送中" || TextBox9.Text == "已完成")
                        {
                            updateorders();
                            reviewOrder();
                            cleanbt3();
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                        }
                        else
                        {
                            hintAll.ForeColor = Color.Red;
                            hintAll.Text = "status僅有賣方處理中 配送中 已完成 請擇一填入";
                        }
                    }

                    else
                    {
                        string serialStatus = ordersfind("status", "serial");
                        if (serialStatus == "賣方處理中")
                        {
                            if (DDLUpdateOrderCols.Text == "serial")
                            {
                                string sql0 = $"select * from Orders where {DDLUpdateOrderCols.Text}='{TextBox9.Text}'";
                                SqlConnection connection0 = Connect(s_data);
                                SqlCommand command0 = new SqlCommand(sql0, connection0);
                                connection0.Open();
                                SqlDataReader Reader0 = command0.ExecuteReader();
                                if (Reader0.HasRows)
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "Serial重複 請重新輸入";
                                }
                                else
                                {
                                    if (serialCheck)
                                    {
                                        string serial = sourcefind(DDLUpdateOrderCols.Text);
                                        SqlConnection connection1 = new SqlConnection(s_data4);
                                        string sql1 = $"update OrderDetail SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}' where serial='{serial}'";
                                        SqlCommand command1 = new SqlCommand(sql1, connection1);
                                        connection1.Open();
                                        command1.ExecuteNonQuery();
                                        connection1.Close();

                                        string sql2 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}', updateInitdate= getdate() where serial='{serial}'";
                                        SqlConnection connection2 = new SqlConnection(s_data);
                                        SqlCommand command2 = new SqlCommand(sql2, connection2);
                                        connection2.Open();
                                        command2.ExecuteNonQuery();
                                        connection2.Close();
                                        reviewOrder();
                                        cleanbt3();
                                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    }
                                    else
                                    {
                                        hintAll.ForeColor = Color.Red;
                                        hintAll.Text = "Serial為10碼數字 請重新輸入";
                                    }
                                }
                                connection0.Close();
                            }

                            else if (DDLUpdateOrderCols.Text == "productName")
                            {


                                serialName = sourcefind("productName");
                                serialColor = sourcefind("productColor");
                                serialQty = sourcefind("qty");
                                serialPrice = sourcefind("productPrice");

                                SqlConnection connection3 = new SqlConnection(s_data3);
                                string sql3 = $"select * from Products where {DDLUpdateOrderCols.Text}= N'{TextBox9.Text}' And category = N'{serialColor}' ";
                                SqlCommand command3 = new SqlCommand(sql3, connection3);
                                connection3.Open();
                                SqlDataReader Reader3 = command3.ExecuteReader();

                                if (Reader3.Read())
                                {

                                    if (Convert.ToInt32(Reader3[4]) >= Convert.ToInt32(serialQty))
                                    {
                                        string sqlSP = $"select inventory from Products where productName = N'{serialName}' And category = N'{serialColor}' ";
                                        SqlConnection connectionSP = Connect(s_data3);
                                        SqlCommand commandSP = new SqlCommand(sqlSP, connectionSP);
                                        connectionSP.Open();
                                        SqlDataReader readerSP = commandSP.ExecuteReader();
                                        if (readerSP.Read())
                                        {
                                            string sqlUP = $"update Products set inventory = '{(Convert.ToInt32(readerSP[0]) + Convert.ToInt32(serialQty)).ToString()}' where productName = N'{serialName}' And category = N'{serialColor}' ";
                                            SqlConnection connectionUP = Connect(s_data3);
                                            SqlCommand commandUP = new SqlCommand(sqlUP, connectionUP);
                                            connectionUP.Open();
                                            commandUP.ExecuteNonQuery();
                                            connectionUP.Close();
                                        }
                                        connectionSP.Close();

                                        //更新庫存數
                                        string sqlUP2 = $"update Products set inventory = '{(Convert.ToInt32(Reader3[4]) - Convert.ToInt32(serialQty)).ToString()}' where productName = N'{TextBox9.Text}' And category = N'{serialColor}' ";
                                        SqlConnection connectionUP2 = Connect(s_data3);
                                        SqlCommand commandUP2 = new SqlCommand(sqlUP2, connectionUP2);
                                        connectionUP2.Open();
                                        commandUP2.ExecuteNonQuery();
                                        connectionUP2.Close();

                                        SqlConnection connection3s = new SqlConnection(s_data4);    //更新產品名稱
                                        string sql3s = $"update OrderDetail SET {DDLUpdateOrderCols.Text}= N'{TextBox9.Text}',productPrice = '{Reader3[5]}',productPicture= N'{Reader3[2]}' where ID='{DDLUpdateOrderDetailID.Text}'";
                                        SqlCommand command3s = new SqlCommand(sql3s, connection3s);
                                        connection3s.Open();
                                        command3s.ExecuteNonQuery();
                                        connection3s.Close();

                                        SqlConnection connection5 = new SqlConnection(s_data);  //更新管理者更新時間
                                        string sql5 = $"update Orders SET updateInitdate= getdate() where serial='{sourcefind("serial")}'";
                                        SqlCommand command5 = new SqlCommand(sql5, connection5);
                                        connection5.Open();
                                        command5.ExecuteNonQuery();
                                        connection5.Close();
                                        string sql6 = $"select sum(productPrice*qty) from OrderDetail where serial='{sourcefind("serial")}'"; //獲得totalprice的數字
                                        SqlConnection connection6 = new SqlConnection(s_data4);
                                        SqlCommand command6 = new SqlCommand(sql6, connection6);
                                        connection6.Open();
                                        SqlDataReader Reader4 = command6.ExecuteReader();
                                        if (Reader4.Read())
                                        {
                                            SqlConnection connection7 = new SqlConnection(s_data);
                                            string sql7 = $"update Orders SET totalprice= '{Reader4[0]}',updateInitdate= getdate() where serial='{sourcefind("serial")}'";
                                            SqlCommand command7 = new SqlCommand(sql7, connection7);
                                            connection7.Open();
                                            command7.ExecuteNonQuery();
                                            connection7.Close();
                                        }
                                        connection6.Close();
                                        reviewOrder();
                                        cleanbt3();
                                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);

                                    }
                                    else
                                    {
                                        hintAll.ForeColor = Color.Red;
                                        hintAll.Text = "商品名稱庫存不足 請重新輸入";
                                    }

                                }



                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "商品名稱不存在 請重新輸入";
                                }

                            }
                            else if (DDLUpdateOrderCols.Text == "productColor")
                            {
                                serialName = sourcefind("productName");
                                serialColor = sourcefind("productColor");
                                serialPrice = sourcefind("productPrice");
                                serialQty = sourcefind("qty");
                                SqlConnection connection3 = new SqlConnection(s_data3);
                                string sql3 = $"select * from Products where category= N'{TextBox9.Text}' And productName = N'{serialName}' ";
                                SqlCommand command3 = new SqlCommand(sql3, connection3);
                                connection3.Open();
                                SqlDataReader Reader3 = command3.ExecuteReader();

                                if (Reader3.Read())
                                {
                                    if (Convert.ToInt32(Reader3[4]) >= Convert.ToInt32(serialQty))
                                    {
                                        string sqlSC = $"select inventory from Products where productName = N'{serialName}' And category = N'{serialColor}' ";
                                        SqlConnection connectionSC = Connect(s_data3);
                                        SqlCommand commandSC = new SqlCommand(sqlSC, connectionSC);
                                        connectionSC.Open();
                                        SqlDataReader readerSC = commandSC.ExecuteReader();
                                        if (readerSC.Read())
                                        {
                                            //更新取消的顏色產品庫存數量
                                            string sqlUC = $"update Products set inventory = '{(Convert.ToInt32(readerSC[0]) + Convert.ToInt32(serialQty)).ToString()}' where productName = N'{serialName}' And category = N'{serialColor}' ";
                                            SqlConnection connectionUC = Connect(s_data3);
                                            SqlCommand commandUC = new SqlCommand(sqlUC, connectionUC);
                                            connectionUC.Open();
                                            commandUC.ExecuteNonQuery();
                                            connectionUC.Close();
                                        }
                                        connectionSC.Close();

                                        string sqlUC2 = $"update Products set inventory = '{(Convert.ToInt32(Reader3[4]) - Convert.ToInt32(serialQty)).ToString()}' where productName = N'{serialName}' And category = N'{TextBox9.Text}' ";
                                        SqlConnection connectionUC2 = Connect(s_data3);
                                        SqlCommand commandUC2 = new SqlCommand(sqlUC2, connectionUC2);
                                        connectionUC2.Open();
                                        commandUC2.ExecuteNonQuery();
                                        connectionUC2.Close();

                                        SqlConnection connection5 = new SqlConnection(s_data);  //更新使用者更新時間
                                        string sql5 = $"update Orders SET updateInitdate= getdate() where serial='{sourcefind("serial")}'";
                                        SqlCommand command5 = new SqlCommand(sql5, connection5);
                                        connection5.Open();
                                        command5.ExecuteNonQuery();

                                        SqlConnection connection4 = new SqlConnection(s_data4);
                                        string sql4 = $"update OrderDetail SET {DDLUpdateOrderCols.Text}= N'{TextBox9.Text}', productPicture = N'{Reader3[2].ToString()}' where ID='{DDLUpdateOrderDetailID.Text}'";
                                        SqlCommand command4 = new SqlCommand(sql4, connection4);
                                        connection4.Open();
                                        command4.ExecuteNonQuery();
                                        connection4.Close();
                                        reviewOrder();
                                        cleanbt3();
                                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                    }
                                    else
                                    {
                                        hintAll.ForeColor = Color.Red;
                                        hintAll.Text = "商品顏色庫存不足 請重新輸入";
                                    }
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "商品顏色不存在 請重新輸入";
                                }

                            }

                            else if (DDLUpdateOrderCols.Text == "phone")
                            {
                                if (phoneCheck)
                                {
                                    updateorders();
                                    reviewOrder();
                                    cleanbt3();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                }

                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "phone格式錯誤 請重新輸入";
                                }
                            }

                            else if (DDLUpdateOrderCols.Text == "qty")
                            {
                                if (numberCheck && int.Parse(TextBox9.Text) >= 0)
                                {
                                    serialQty = sourcefind("qty");
                                    serialName = sourcefind("productName");
                                    serialColor = sourcefind("productColor");
                                    string sqlSQ = $"select inventory from Products where productName = N'{serialName}' And category = N'{serialColor}' ";
                                    SqlConnection connectionSQ = Connect(s_data3);
                                    SqlCommand commandSQ = new SqlCommand(sqlSQ, connectionSQ);
                                    connectionSQ.Open();
                                    SqlDataReader readerSQ = commandSQ.ExecuteReader();
                                    if (readerSQ.Read())
                                    {
                                        if (Convert.ToInt32(readerSQ[0]) >= (int.Parse(TextBox9.Text) - int.Parse(serialQty)))
                                        {
                                            //更新庫存數量
                                            string sqlUQ = $"update Products set inventory = '{(Convert.ToInt32(readerSQ[0]) - (int.Parse(TextBox9.Text) - int.Parse(serialQty))).ToString()}' where productName = N'{serialName}' And category = N'{serialColor}' ";
                                            SqlConnection connectionUQ = Connect(s_data3);
                                            SqlCommand commandUQ = new SqlCommand(sqlUQ, connectionUQ);
                                            connectionUQ.Open();
                                            commandUQ.ExecuteNonQuery();
                                            connectionUQ.Close();

                                            SqlConnection connection5 = new SqlConnection(s_data4); //更OrderDetail數量
                                            string sql5 = $"update OrderDetail SET {DDLUpdateOrderCols.Text}= '{TextBox9.Text}' where ID='{DDLUpdateOrderDetailID.Text}'";
                                            SqlCommand command5 = new SqlCommand(sql5, connection5);
                                            connection5.Open();
                                            command5.ExecuteNonQuery();
                                            connection5.Close();

                                            string sql6 = $"select sum(productPrice*qty) from OrderDetail where serial='{sourcefind("serial")}'";
                                            SqlConnection connection6 = new SqlConnection(s_data4);
                                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                                            connection6.Open();
                                            SqlDataReader Reader4 = command6.ExecuteReader();
                                            if (Reader4.Read())
                                            {
                                                SqlConnection connection7 = new SqlConnection(s_data);
                                                string sql7 = $"update Orders SET totalprice= '{Reader4[0]}',updateInitdate= getdate() where serial='{sourcefind("serial")}'";
                                                SqlCommand command7 = new SqlCommand(sql7, connection7);
                                                connection7.Open();
                                                command7.ExecuteNonQuery();
                                                connection7.Close();
                                            }
                                            connection6.Close();
                                            connectionSQ.Close();
                                            reviewOrder();
                                            cleanbt3();
                                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                        }
                                        else
                                        {
                                            hintAll.ForeColor = Color.Red;
                                            hintAll.Text = "商品數量庫存不足 請重新輸入";

                                        }
                                    }
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "qty需為數字且須大於0 請重新輸入";
                                }
                            }
                            else
                            {
                                if (TextBox9.Text != "")
                                {
                                    updateorders();
                                    reviewOrder();
                                    cleanbt3();
                                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('更新成功');},0);", true);
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "name/address不得為空 請重新輸入";
                                }
                            }                          
                        }
                        else
                        {
                            hintAll.ForeColor = Color.Red;
                            hintAll.Text = "訂單已出貨無法修改 請重新輸入";
                        }
                    }
                }
                else
                {
                    hintID2.ForeColor = Color.Red;
                    hintID2.Text = "請選擇項目";
                }
            }
            else
            {
                hintID2.ForeColor = Color.Red;
                hintID2.Text = "請選擇項目";
            }

        }
        protected void serialSearch_Click(object sender, EventArgs e)
        {
            if(DDLSS.SelectedItem.Text!="請選擇")
            {
                searchOrder("serial", DDLSS.Text);
                cleanbtss();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btss", "setTimeout( function(){alert('篩選成功');},0);", true);
            }
            else
            {
                hintSerial.ForeColor = Color.Red;
                hintSerial.Text = "請選擇項目";
            }
        }

        protected void customerAccountsearch_Click(object sender, EventArgs e)
        {
            if (DDLSearchCustomerAccount.SelectedItem.Text != "請選擇")
            {
                searchOrder("customerAccount", DDLSearchCustomerAccount.Text);
                cleanbtsca();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btca", "setTimeout( function(){alert('篩選成功');},0);", true);
            }
            else
            {
                hintCustomerAccount.ForeColor = Color.Red;
                hintCustomerAccount.Text = "請選擇項目";
            }

        }

        protected void productNamesearch_Click(object sender, EventArgs e)
        {
            if (DDLSearchProductName.SelectedItem.Text != "請選擇")
            {
                searchOrder("productName", DDLSearchProductName.Text);
                cleanbtspn();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btpn", "setTimeout( function(){alert('篩選成功');},0);", true);
            }
            else
            {
                hintProductName.ForeColor = Color.Red;
                hintProductName.Text = "請選擇項目";
            }
        }

        protected void namesearch_Click(object sender, EventArgs e)
        {
            if (DDLSearchName.SelectedItem.Text != "請選擇")
            {
                searchOrder2("name", DDLSearchName.Text);
                cleanbtsn();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btn", "setTimeout( function(){alert('篩選成功');},0);", true);
            }
            else
            {
                hintName.ForeColor = Color.Red;
                hintName.Text = "請選擇項目";
            }
        }

        protected void statussearch_Click(object sender, EventArgs e)
        {
            if (DDLSearchStatus.SelectedItem.Text != "請選擇")
            {
                searchOrder2("status", DDLSearchStatus.Text);
                cleanbts();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bts", "setTimeout( function(){alert('篩選成功');},0);", true);
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
    }
}