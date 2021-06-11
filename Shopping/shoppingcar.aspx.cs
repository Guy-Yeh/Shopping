﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{

    public partial class shoppingcar : Page
    {
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string orders_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;
        public bool reviewSerial()
        {
            Random rnd = new Random();
            string ser = "";
            for (int i = 0; i < 10; i++)    //編成serial number
            {
                int serialrnd = rnd.Next(0, 10);
                ser += serialrnd.ToString();
            }
            SqlConnection connection1 =new SqlConnection(orders_data);
            string sql1 = $"select * from Orders where serial='{ser}'";  //為了找尋serial是否重複
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            connection1.Open();
            SqlDataReader Read1 = command1.ExecuteReader();
            bool f = Read1.HasRows;
            connection1.Close();
            return f;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("loging");
            }
            SqlConnection connection = new SqlConnection(orderdetail_data);
            string sq1 = $"select sum(productPrice) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand command1 = new SqlCommand(sq1, connection);
            connection.Open();
            SqlDataReader read1 = command1.ExecuteReader();
            if (read1.HasRows)
            {
                if (read1.Read())
                {
                    Label4.Text = read1[0].ToString();
                }
            }
            connection.Close();
            SqlConnection connection2 = new SqlConnection(orderdetail_data);
            string sq12 = $"select sum(productPrice) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand command2 = new SqlCommand(sq12, connection2);
            connection2.Open();
            SqlDataReader read2 = command2.ExecuteReader();
            if (read2.HasRows)
            {
                if (read2.Read())
                {
                    Label1.Text = "消費金額：" + read2[0].ToString();
                }
            }
            connection2.Close();
            /*if (Request.Cookies["quantity"] == null)
                Response.Cookies["quantity"].Value = "0";

            if (Request.Cookies["cart"] != null)
                Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            else
                Label1.Text = " 總金額：" + "0";

            if (Request.Cookies["buy"] != null) {
                int a = 0;
                for (int i = 0; i < Convert.ToInt32(Request.Cookies["quantity"].Value); i++)
                {                   
                    TableRow r1 = new TableRow();
                    SqlConnection connection = new SqlConnection(product_data);
                    string sq1 = $"select * from Products where ID ='{Request.Cookies["buy"][$"{i}"]}' ";
                    System.Data.SqlClient.SqlCommand command1 = new SqlCommand(sq1, connection);
                    connection.Open();
                    SqlDataReader read1 = command1.ExecuteReader();

                    if (read1.HasRows)
                    {
                        if (read1.Read())
                        {
                            
                            TableCell c1 = new TableCell();
                            c1.HorizontalAlign = HorizontalAlign.Center;
                            Image image = new Image();
                            image.Height = 120  ;
                            image.Width = 100 ;
                            image.ImageUrl = $"{ read1[2]}";
                            c1.Controls.Add(image);
                            r1.Cells.Add(c1);
                            TableCell c2 = new TableCell();
                            c2.Controls.Add(new LiteralControl($"{read1[1]}"));
                            r1.Cells.Add(c2);
                            TableCell c3 = new TableCell();
                            c3.HorizontalAlign = HorizontalAlign.Center;
                            c3.Controls.Add(new LiteralControl($"{read1[3]}"));
                            r1.Cells.Add(c3);
                            TableCell c4 = new TableCell();
                            c4.HorizontalAlign = HorizontalAlign.Center;
                            c4.Controls.Add(new LiteralControl($"1"));
                            r1.Cells.Add(c4);
                            TableCell c5 = new TableCell();
                            c5.HorizontalAlign = HorizontalAlign.Center;
                            c5.Controls.Add(new LiteralControl($"{read1[5]}"));
                            r1.Cells.Add(c5);
                            TableCell c6 = new TableCell();
                            c6.HorizontalAlign = HorizontalAlign.Center;
                            CheckBox checkBox = new CheckBox();
                            Button button = new Button();
                            button.ID = $"b{a}";
                            a++;
                            button.Text = "刪除";
                            button.BackColor = System.Drawing.Color.MediumTurquoise;
                            button.ForeColor = System.Drawing.Color.White;
                            button.BorderStyle = BorderStyle.None;
                            button.Command += new CommandEventHandler(this.On_Button);
                            c6.Controls.Add(button);
                            r1.Cells.Add(c6);
                        }
                    }                   
                    Table1.Rows.Add(r1);
                    connection.Close();
                }
                TableRow r2 = new TableRow();
                TableCell c7 = new TableCell();
                c7.Controls.Add(new LiteralControl("總金額："));
                r2.Cells.Add(c7);
                TableCell c8 = new TableCell();
                c8.Controls.Add(new LiteralControl());
                r2.Cells.Add(c8);
                TableCell c9 = new TableCell();
                c9.Controls.Add(new LiteralControl());
                r2.Cells.Add(c9);
                TableCell c10 = new TableCell();
                c10.Controls.Add(new LiteralControl());
                r2.Cells.Add(c10);
                TableCell c11 = new TableCell();
                c11.HorizontalAlign = HorizontalAlign.Center;
                c11.Controls.Add(new LiteralControl(Request.Cookies["cart"].Value));
                r2.Cells.Add(c11);
                TableCell c12 =new TableCell();
                c12.Controls.Add(new LiteralControl());
                r2.Cells.Add(c12);
                Table1.Rows.Add(r2);
            }*/
        }
        /*protected void On_Button(Object sender, CommandEventArgs e)
        {
            
            if (Request.Cookies["buy"] != null)
            {
                for (int i = 0; i < Convert.ToInt32(Request.Cookies["quantity"].Value); i++)
                {
                    Button Button = (Button)Page.FindControl($"b{i}");
                    if (Button.ID == $"b{i}")
                    {
                        Label2.Text = "aaa";
                        HttpCookie usecookie = new HttpCookie("buy");
                        if (Request.Cookies["buy"] != null)
                            usecookie.Values.Add(Request.Cookies["buy"].Values);
                        Request.Cookies["buy"][$"{i}"] = "1";
                        Response.AppendCookie(usecookie);
                        Response.Redirect("shoppingcar");
                    }
                }
            }

        }*/

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] != null)
            {
                SqlConnection connection = new SqlConnection(orderdetail_data);
                string sql = $"delete from OrderDetail where customerAccount=N'{Session["loginstatus"]}'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("shoppingcar");
                /*HttpCookie cookie = Request.Cookies["buy"];
                if (cookie != null)
                {
                    cookie.Expires = DateTime.Now.AddDays(-2);
                    Response.Cookies.Set(cookie);
                }
                Response.Cookies["cart"].Value = "0";
                Response.Redirect("shoppingcar");*/
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment");
        }

        protected void userorder_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label2.Text = (userorder.Rows[e.RowIndex].Cells[1].Text.Trim()).ToString();
            string id = (userorder.Rows[e.RowIndex].Cells[1].Text.Trim()).ToString();
            SqlConnection connection = new SqlConnection(orderdetail_data);
            string sql = $"delete from OrderDetail where ID=N'{id}'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("shoppingcar");
        }

    }
}