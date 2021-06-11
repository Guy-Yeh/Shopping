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
            string source = $"select {x} from OrderDetail where ID ='{DDLUpdateOrderID.Text}'";
            SqlConnection consource = new SqlConnection(s_data4);
            SqlCommand concommand = new SqlCommand(source, consource);
            consource.Open();
            SqlDataReader dataReader = concommand.ExecuteReader();
            
            if (dataReader.Read())
            {
                string y = dataReader[0].ToString();
                return y;
            }
            else
            {
                string z = "";
                return z;
            }

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
            
            bool numberCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool priceCheck = Regex.IsMatch(TextBox9.Text, @"\d");
            bool serialCheck = Regex.IsMatch(TextBox9.Text, @"\d{10}");
            string sql6 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}' where ID='{DDLUpdateOrderID.Text}'";
            string sql6c = $"update Orders SET {DDLUpdateOrderCols.Text}=N'{TextBox9.Text}' where ID='{DDLUpdateOrderID.Text}'";
            SqlConnection connection6 = Connect(s_data);
            string sql7 = $"select * from Orders where {DDLUpdateOrderCols.Text}='{TextBox9.Text}'";
            string number;
            string number2;

            if (DDLUpdateOrderID.SelectedItem.Text != "請選擇")
            {
                if (DDLUpdateOrderCols.SelectedItem.Text != "請選擇")
                {

                    if (DDLUpdateOrderCols.Text == "serial")
                    {
                        SqlConnection connection7 = Connect(s_data);
                        SqlCommand command7 = new SqlCommand(sql7, connection7);
                        connection7.Open();
                        SqlDataReader Reader2 = command7.ExecuteReader();
                        if (Reader2.HasRows)
                        {
                            hintAll.ForeColor = Color.Red;
                            hintAll.Text = "Serial重複 請重新輸入";
                        }
                        else
                        {
                            if (serialCheck == true)
                            {
                                string serial = sourcefind(DDLUpdateOrderCols.Text);
                                SqlConnection connection6s = new SqlConnection(s_data4);
                                string sql6s = $"update OrderDetail SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}' where serial='{serial}'";
                                SqlCommand command6s = new SqlCommand(sql6s, connection6s);
                                connection6s.Open();
                                command6s.ExecuteNonQuery();
                                connection6s.Close();

                                string sql6s2 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}' where serial='{serial}'";
                                SqlCommand command6s2 = new SqlCommand(sql6s2, connection6);
                                connection6.Open();
                                command6s2.ExecuteNonQuery();
                                MessageBox.Show("更新成功");
                                connection6.Close();
                                Response.Redirect(Request.Url.ToString());
                            }
                            else
                            {
                                hintAll.ForeColor = Color.Red;
                                hintAll.Text = "Serial為10碼數字 請重新輸入";
                            }
                        }
                        connection7.Close();
                    }

                    else if (DDLUpdateOrderCols.Text == "productName" || DDLUpdateOrderCols.Text == "productColor")
                    {


                    }

                    else if (DDLUpdateOrderCols.Text == "qty" || DDLUpdateOrderCols.Text == "price")
                    {
                        if (numberCheck == true)
                        {
                            if (DDLUpdateOrderCols.Text == "qty")
                            {

                                string sql8 = $"select price from Orders where ID='{DDLUpdateOrderID.Text}'";
                                SqlConnection connection8 = new SqlConnection(s_data);
                                SqlCommand command8 = new SqlCommand(sql8, connection8);
                                connection8.Open();
                                SqlDataReader Reader3 = command8.ExecuteReader();
                                //string number = Reader3[0].ToString();
                                //string number2 = Convert.ToString(int.Parse(number) * int.Parse(TextBox9.Text));
                                if (Reader3.Read())
                                {
                                    number = Reader3[0].ToString();
                                    number2 = Convert.ToString(int.Parse(number) * int.Parse(TextBox9.Text));
                                    string sql9 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}',totalprice='{number2}' where ID='{DDLUpdateOrderID.Text}'";
                                    SqlConnection connection9 = new SqlConnection(s_data);
                                    SqlCommand command9 = new SqlCommand(sql9, connection9);
                                    connection9.Open();
                                    command9.ExecuteNonQuery();
                                    MessageBox.Show("更新成功");
                                    connection8.Close();
                                    connection9.Close();
                                    reviewOrder();
                                }

                            }
                            else
                            {

                                string sql8 = $"select qty from Orders where ID='{DDLUpdateOrderID.Text}'";
                                SqlConnection connection8 = new SqlConnection(s_data);
                                SqlCommand command8 = new SqlCommand(sql8, connection8);
                                connection8.Open();
                                SqlDataReader Reader3 = command8.ExecuteReader();
                                if (Reader3.Read())
                                {
                                    number = Reader3[0].ToString();
                                    number2 = Convert.ToString(int.Parse(number) * int.Parse(TextBox9.Text));
                                    string sql9 = $"update Orders SET {DDLUpdateOrderCols.Text}='{TextBox9.Text}',totalprice='{number2}' where ID='{DDLUpdateOrderID.Text}'";
                                    SqlConnection connection9 = new SqlConnection(s_data);
                                    SqlCommand command9 = new SqlCommand(sql9, connection9);
                                    connection9.Open();
                                    command9.ExecuteNonQuery();
                                    MessageBox.Show("更新成功");
                                    connection8.Close();
                                    connection9.Close();
                                    reviewOrder();
                                }
                            }


                        }
                        else
                        {
                            hintAll.Text = "qty/price需為數字 請重新輸入";
                        }
                    }
                    else if (DDLUpdateOrderCols.Text == "customerID")
                    {
                        SqlConnection connection10 = new SqlConnection(s_data2);
                        string sql10 = $"select * from Customers where ID ='{TextBox9.Text}'";
                        SqlCommand command10 = new SqlCommand(sql10, connection10);
                        connection10.Open();
                        SqlDataReader Reader4 = command10.ExecuteReader();
                        if (Reader4.HasRows)
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            MessageBox.Show("更新成功");
                            connection6.Close();
                            reviewOrder();
                        }
                        else
                        {
                            hintAll.Text = "customerID不存在 請重新輸入";
                        }
                        connection10.Close();

                    }
                    else if (DDLUpdateOrderCols.Text == "productName")
                    {
                        SqlConnection connection11 = new SqlConnection(s_data3);
                        string sql11 = $"select * from Products where productName ='{TextBox9.Text}'";
                        SqlCommand command11 = new SqlCommand(sql11, connection11);
                        connection11.Open();
                        SqlDataReader Reader5 = command11.ExecuteReader();
                        if (Reader5.HasRows)
                        {
                            SqlCommand command6 = new SqlCommand(sql6, connection6);
                            connection6.Open();
                            command6.ExecuteNonQuery();
                            MessageBox.Show("更新成功");
                            connection6.Close();
                            reviewOrder();
                        }
                        else
                        {
                            hintAll.Text = "productName不存在 請重新輸入";
                        }
                        connection11.Close();
                    }
                    else
                    {
                        SqlCommand command6 = new SqlCommand(sql6, connection6);
                        connection6.Open();
                        command6.ExecuteNonQuery();
                        MessageBox.Show("更新成功");
                        connection6.Close();
                        reviewOrder();
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