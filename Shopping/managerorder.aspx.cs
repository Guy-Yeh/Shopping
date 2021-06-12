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
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Orders";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            userorder.DataSource = read;
            userorder.DataBind();
            connection.Close();
        }

        public bool reviewSerial()
        {
            Random rnd = new Random();
            TextBox1.Text = "";
            for (int i = 0; i < 10; i++)    //編成serial number
            {
                int serialrnd = rnd.Next(0, 10);
                TextBox1.Text += serialrnd;
            }
            SqlConnection connection2s = Connect(s_data);
            string sql2s = $"select * from Orders where serial='{TextBox1.Text}'";  //為了找尋serial是否重複
            SqlCommand command2s = new SqlCommand(sql2s, connection2s);
            connection2s.Open();
            SqlDataReader Reader2s = command2s.ExecuteReader();
            bool f = Reader2s.HasRows;
            connection2s.Close();
            return f;
        }

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
            string sql5 = $"update Orders SET {DDLUpdateOrderCols.Text}= N'{TextBox9.Text}' where serial='{sourcefind("serial")}'";
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



        protected void Page_Load(object sender, EventArgs e)
        {
            hintCustomerID.Text = "";
            hintProductID.Text = "";
            hintStatus.Text = "";
            hintQty.Text = "";
            hintID.Text = "選擇即將刪除的orderID";
            hintID2.Text = "選擇即將更新的orderID";
            hintColumn.Text = "選擇即將更新的欄位";
            hintAll.Text = "輸入更新的值";
            
            if (!IsPostBack)
            {
                reviewOrder();
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            while (reviewSerial())
            {
                reviewSerial();
            }

            SqlConnection connectionp = Connect(s_data3);
            string sqlp = $"select price from Products where ID='{DDLAddProductID.Text}'";  //為了找尋serial是否重複
            SqlCommand commandp = new SqlCommand(sqlp, connectionp);
            connectionp.Open();
            SqlDataReader Readerp = commandp.ExecuteReader();

            

            

            bool qtyCheck = Regex.IsMatch(TextBox4.Text, @"\d");
            

            
            if (DDLAddCustomerID.SelectedItem.Text != "請選擇")
            {
                if (DDLAddProductID.SelectedItem.Text != "請選擇")
                {
                    if (qtyCheck == true)
                    {

                        if (DDLAddstatus.SelectedItem.Text != "請選擇")
                        {
                            if (Readerp.Read())
                            {
                                TextBox5.Text = Readerp[0].ToString();
                                TextBox11.Text = (int.Parse(TextBox4.Text) * int.Parse(TextBox5.Text)).ToString();
                                string sql2 = $"insert into [Orders](serial,customerID,productID,qty,price,totalprice,status) values('{TextBox1.Text}','{DDLAddCustomerID.Text}','{DDLAddProductID.Text}','{TextBox4.Text}','{TextBox5.Text}','{TextBox11.Text}',N'{DDLAddstatus.Text}')";
                                SqlConnection connection2 = Connect(s_data);
                                SqlCommand command2 = new SqlCommand(sql2, connection2);
                                connection2.Open();
                                command2.ExecuteNonQuery();
                                MessageBox.Show("輸入成功");
                                connection2.Close();
                                connectionp.Close();
                                reviewOrder();
                               
                            }
                        }
                        else
                        {
                            hintStatus.Text = "請選擇項目";
                        }

                    }

                    else
                    {
                        hintQty.Text = "qty需為數字 請重新輸入";
                    }
                }
                else
                {
                    hintProductID.Text = "請選擇項目";
                }
            }
            else
            {
                hintCustomerID.Text="請選擇項目";
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DDLDeleteOrderID.SelectedItem.Text != "請選擇")
            {
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
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt2", "setTimeout( function(){alert('刪除成功');},0);", true);
                
                Response.Redirect(Request.Url.ToString());
                
            }
            else
            {
                hintID.ForeColor = Color.Red;
                hintID.Text = "請選擇項目";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string serialStatus = ordersfind("status","serial");
            bool numberCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool priceCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool serialCheck = Regex.IsMatch(TextBox9.Text, @"\d{10}");
            bool phoneCheck = Regex.IsMatch(TextBox9.Text, @"^09[\d]{8}");
            string sql20 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}' where ID='{DDLUpdateOrderDetailID.Text}'";
            string sql6c = $"update Orders SET {DDLUpdateOrderCols.Text}=N'{TextBox9.Text}' where ID='{DDLUpdateOrderDetailID.Text}'";

            SqlConnection connection20 = new SqlConnection(s_data);
            string number;
            string number2;

            if (DDLUpdateOrderDetailID.SelectedItem.Text != "請選擇")
            {
                if (serialStatus == "賣家處理中")
                {
                    if (DDLUpdateOrderCols.SelectedItem.Text != "請選擇")
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
                                if (serialCheck == true)
                                {
                                    string serial = sourcefind(DDLUpdateOrderCols.Text);
                                    SqlConnection connection1 = new SqlConnection(s_data4);
                                    string sql1 = $"update OrderDetail SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}' where serial='{serial}'";
                                    SqlCommand command1 = new SqlCommand(sql1, connection1);
                                    connection1.Open();
                                    command1.ExecuteNonQuery();
                                    connection1.Close();

                                    string sql2 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}' where serial='{serial}'";
                                    SqlConnection connection2 = new SqlConnection(s_data);
                                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                                    connection2.Open();
                                    command2.ExecuteNonQuery();
                                    MessageBox.Show("更新成功");
                                    connection2.Close();
                                    Response.Redirect(Request.Url.ToString());
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
                            string serialColor = sourcefind("productColor");
                            string serialPrice = sourcefind("productPrice");


                            SqlConnection connection3 = new SqlConnection(s_data3);
                            string sql3 = $"select * from Products where {DDLUpdateOrderCols.Text}= N'{TextBox9.Text}' And category = N'{serialColor}' ";
                            SqlCommand command3 = new SqlCommand(sql3, connection3);
                            connection3.Open();
                            SqlDataReader Reader3 = command3.ExecuteReader();

                            if (Reader3.Read())
                            {

                                if (Convert.ToInt32(Reader3[5]) <= Convert.ToInt32(serialPrice))
                                {
                                    SqlConnection connection4 = new SqlConnection(s_data4);
                                    string sql4 = $"update OrderDetail SET {DDLUpdateOrderCols.Text}= N'{TextBox9.Text}', productPicture = N'{Reader3[2].ToString()}' where ID='{DDLUpdateOrderDetailID.Text}'";
                                    SqlCommand command4 = new SqlCommand(sql4, connection4);
                                    connection4.Open();
                                    command4.ExecuteNonQuery();
                                    connection4.Close();
                                    MessageBox.Show("更新成功");
                                   
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "商品價格需小於原本商品 請重新輸入";
                                }
                            }
                            else
                            {
                                hintAll.ForeColor = Color.Red;
                                hintAll.Text = "商品不存在 請重新輸入";
                            }

                        }
                        else if (DDLUpdateOrderCols.Text == "productColor")
                        {
                            string serialName = sourcefind("productName");
                            string serialPrice2 = sourcefind("productPrice");

                            SqlConnection connection3 = new SqlConnection(s_data3);
                            string sql3 = $"select * from Products where category= N'{TextBox9.Text}' And productName = N'{serialName}' ";
                            SqlCommand command3 = new SqlCommand(sql3, connection3);
                            connection3.Open();
                            SqlDataReader Reader3 = command3.ExecuteReader();

                            if (Reader3.Read())
                            {

                                if (Convert.ToInt32(Reader3[5]) <= Convert.ToInt32(serialPrice2))
                                {
                                    SqlConnection connection4 = new SqlConnection(s_data4);
                                    string sql4 = $"update OrderDetail SET {DDLUpdateOrderCols.Text}= N'{TextBox9.Text}', productPicture = N'{Reader3[2].ToString()}' where ID='{DDLUpdateOrderDetailID.Text}'";
                                    SqlCommand command4 = new SqlCommand(sql4, connection4);
                                    connection4.Open();
                                    command4.ExecuteNonQuery();
                                    connection4.Close();
                                    MessageBox.Show("更新成功");
                                }
                                else
                                {
                                    hintAll.ForeColor = Color.Red;
                                    hintAll.Text = "商品價格需小於原本商品 請重新輸入";
                                }
                            }
                            else
                            {
                                hintAll.ForeColor = Color.Red;
                                hintAll.Text = "商品不存在 請重新輸入";
                            }

                        }

                        else if (DDLUpdateOrderCols.Text == "phone")
                        {
                            if (phoneCheck)
                            {
                                updateorders();
                                MessageBox.Show("更新成功");
                            }

                            else
                            {
                                hintAll.ForeColor = Color.Red;
                                hintAll.Text = "phone格式錯誤 請重新輸入";
                            }
                        }

                        
                        else if (DDLUpdateOrderCols.Text == "status")
                        {
                            if (TextBox9.Text == "賣方處理中" || TextBox9.Text == "配送中" || TextBox9.Text == "已完成")
                            {
                                updateorders();
                                MessageBox.Show("更新成功");
                            }
                            else
                            {
                                hintAll.ForeColor = Color.Red;
                                hintAll.Text = "status僅有賣方處理中 配送中 已完成 請擇一填入";
                            }

                        }

                        else if (DDLUpdateOrderCols.Text == "qty")
                        {
                            if (numberCheck && int.Parse(TextBox9.Text)>=0)
                            {
                                SqlConnection connection5 = new SqlConnection(s_data4);
                                string sql5 = $"update OrderDetail SET {DDLUpdateOrderCols.Text}= '{TextBox9.Text}' where ID='{DDLUpdateOrderDetailID.Text}'";
                                SqlCommand command5 = new SqlCommand(sql5, connection5);
                                connection5.Open();
                                command5.ExecuteNonQuery();
                               

                                int totalprice = int.Parse(sourcefind("productprice")) * int.Parse((TextBox9.Text));
                                string sql6 = $"select sum(productPrice*qty) from OrderDetail where serial='{sourcefind("serial")}'";
                                SqlConnection connection6 = new SqlConnection(s_data4);
                                SqlCommand command6 = new SqlCommand(sql6, connection6);
                                connection6.Open();
                                SqlDataReader Reader4 = command6.ExecuteReader();
                                if (Reader4.Read())
                                {
                                    SqlConnection connection7 = new SqlConnection(s_data);
                                    string sql7 = $"update Orders SET totalprice= '{Reader4[0]}' where serial='{sourcefind("serial")}'";
                                    SqlCommand command7 = new SqlCommand(sql7, connection7);
                                    connection7.Open();
                                    command7.ExecuteNonQuery();
                                    connection7.Close();
                                }
                                connection6.Close();
                                
                                MessageBox.Show("更新成功");

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
                                MessageBox.Show("更新成功");
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
                        hintColumn.ForeColor = Color.Red;
                        hintColumn.Text = "請選擇項目";
                    }
                }
                else
                {
                    hintAll.ForeColor = Color.Red;
                    hintAll.Text = "訂單已出貨無法修改 請重新輸入";
                }
            }
            else
            {
                hintID2.ForeColor = Color.Red;
                hintID2.Text = "請選擇項目";
            }
            
        }
    }
}