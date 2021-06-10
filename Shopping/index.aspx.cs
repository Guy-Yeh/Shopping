﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class index : Page
    {
        string customers_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        /*protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["quantity"]== null)
                Response.Cookies["quantity"].Value = "0";

            if (Request.Cookies["cart"]!=null)
                Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            else
                Label1.Text = " 總金額：" + "0";         
        }*/
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["loginstatus"] = "1";
            //驗證是否登錄
            if (Session["loginstatus"] != null)
            {
                SqlConnection connection1 = new SqlConnection(customers_data);
                string sq11 = $"select account from Customers";
                SqlCommand command1 = new SqlCommand(sq11, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {

                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq12 = $"select sum(productPrice) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command2 = new SqlCommand(sq12, connection2);
                connection2.Open();
                SqlDataReader read2 = command2.ExecuteReader();
                if (read2.HasRows)
                {
                    if (read2.Read())
                    {
                        Label1.Text ="消費金額：" + read2[0].ToString();
                    }
                }
                connection2.Close();
            }
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'領造型線T' and category=N'{DropDownList1.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
                /*HttpCookie usecookie = new HttpCookie("buy");
                if (DropDownList1.SelectedValue == "白")
                {
                    if (Request.Cookies["buy"] != null)
                        usecookie.Values.Add(Request.Cookies["buy"].Values);
                    usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "1");
                    Response.AppendCookie(usecookie);
                    Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
                }
                else if (DropDownList1.SelectedValue == "紅")
                {
                    if (Request.Cookies["buy"] != null)
                        usecookie.Values.Add(Request.Cookies["buy"].Values);
                    usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "2");
                    Response.AppendCookie(usecookie);
                    Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
                }
                else if (DropDownList1.SelectedValue == "綠")
                {
                    if (Request.Cookies["buy"] != null)
                        usecookie.Values.Add(Request.Cookies["buy"].Values);
                    usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "3");
                    Response.AppendCookie(usecookie);
                    Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
                }
                Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label3.Text)).ToString();
                Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
                Response.Redirect("index");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'袖滾配色t' and category=N'{DropDownList2.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
            /*HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList2.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "4");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList2.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "5");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList2.SelectedValue == "綠")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "6");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList2.SelectedValue == "橘")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "7");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label5.Text)).ToString();
            Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
            Response.Redirect("index");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'剪裁T' and category=N'{DropDownList3.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
            /*HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList3.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "8");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList3.SelectedValue == "灰")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "9");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList3.SelectedValue == "杏")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "10");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList3.SelectedValue == "咖啡")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "11");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList3.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "12");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label7.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
            Response.Redirect("index");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {//產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'細肩露肩t' and category=N'{DropDownList4.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
            /*HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList4.SelectedValue == "紅")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "13");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList4.SelectedValue == "綠")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "14");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList4.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "15");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList4.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "16");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label9.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
            Response.Redirect("index");
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'胸抓摺衫' and category=N'{DropDownList5.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
            /*HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList5.SelectedValue == "粉")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "17");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList5.SelectedValue == "灰")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "18");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList5.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "19");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label11.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
            Response.Redirect("index");
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'格紋澎袖衫' and category=N'{DropDownList6.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
            /*HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList6.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "20");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList6.SelectedValue == "紅")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "21");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label13.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
            Response.Redirect("index");
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'中抓摺雪紡衫' and category=N'{DropDownList7.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
            /*HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList7.SelectedValue == "杏")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "25");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList7.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "26");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList7.SelectedValue == "紅")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "27");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label15.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
            Response.Redirect("index");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            //產生一個字串的陣列承接商品資料
            string[] array = new string[3];
            //驗證是否登錄
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            else
            {
                //從資料庫Products中取出商品資料並寫入字串
                SqlConnection connection1 = new SqlConnection(product_data);
                string sql = $"select * from Products where productName =N'滾邊寬袖衫' and category=N'{DropDownList8.SelectedValue}'";
                SqlCommand command1 = new SqlCommand(sql, connection1);
                connection1.Open();
                SqlDataReader read1 = command1.ExecuteReader();
                if (read1.HasRows)
                {
                    if (read1.Read())
                    {
                        //陣列分別存入商品資料的 1.商品名稱 3.商品顏色 5.商品價格
                        array[0] = read1[1].ToString();
                        array[1] = read1[3].ToString();
                        array[2] = read1[5].ToString();
                    }
                }
                connection1.Close();
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq2 = $"insert into [OrderDetail](customerAccount,productName,productColor,productPrice,qty,cart) values(@customerAccount,@productName,@productColor,@productPrice,@qty,@cart)";
                SqlCommand Command2 = new SqlCommand(sq2, connection2);
                connection2.Open();
                Command2.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
                Command2.Parameters["@customerAccount"].Value = Session["loginstatus"].ToString();
                Command2.Parameters.Add("@productName", SqlDbType.NVarChar);
                Command2.Parameters["@productName"].Value = array[0];
                Command2.Parameters.Add("@productColor", SqlDbType.NVarChar);
                Command2.Parameters["@productColor"].Value = array[1];
                Command2.Parameters.Add("@productPrice", SqlDbType.NVarChar);
                Command2.Parameters["@productPrice"].Value = array[2];
                Command2.Parameters.Add("@qty", SqlDbType.Int);
                Command2.Parameters["@qty"].Value = 1;
                Command2.Parameters.Add("@cart", SqlDbType.NVarChar);
                Command2.Parameters["@cart"].Value = "是";
                Command2.ExecuteNonQuery();
                connection2.Close();
            }
            /*HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList8.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "22");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList8.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "23");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList8.SelectedValue == "粉")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "24");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label17.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;*/
            Response.Redirect("index");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] != null)
            {
                SqlConnection connection = new SqlConnection(orderdetail_data);
                string sql = $"delete from OrderDetail where customerAccount=N'{Session["loginstatus"]}'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("index");
                /*HttpCookie cookie = Request.Cookies["buy"];
                if (cookie != null)
                {
                    cookie.Expires = DateTime.Now.AddDays(-2);
                    Response.Cookies.Set(cookie);
                }
                Response.Cookies["cart"].Value = "0";
                Response.Redirect("index");*/
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "領造型線T";
            Response.Redirect("product");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "袖滾配色t";
            Response.Redirect("product");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "剪裁T";
            Response.Redirect("product");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "細肩露肩t";
            Response.Redirect("product");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "胸抓摺衫";
            Response.Redirect("product");
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "格紋澎袖衫";
            Response.Redirect("product");
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "中抓摺雪紡衫";
            Response.Redirect("product");
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "滾邊寬袖衫";
            Response.Redirect("product");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }
    }
}