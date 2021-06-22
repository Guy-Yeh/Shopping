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
    public partial class managershoppingcar : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string s_data2 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;

        public void reviewOrder()
        {
            SqlConnection connectionorigin = new SqlConnection(s_data);
            string sqlorigin = $"select * from OrderDetail where cart= N'是'";
            SqlCommand command = new SqlCommand(sqlorigin, connectionorigin);
            connectionorigin.Open();
            SqlDataReader readorigin = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("customerAccount");
            dt.Columns.Add("productPicture");
            dt.Columns.Add("productName");
            dt.Columns.Add("productColor");
            dt.Columns.Add("productPrice");
            dt.Columns.Add("qty");
            
            while (readorigin.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = readorigin[0];
                row["customerAccount"] = readorigin[2];
                row["productPicture"] = readorigin[3];
                row["productName"] = readorigin[4];
                row["productColor"] = readorigin[5];
                row["productPrice"] = readorigin[6];
                row["qty"] = readorigin[7];
                dt.Rows.Add(row);

            }
            usershoppingcar.DataSource = dt;
            usershoppingcar.DataBind();
            connectionorigin.Close();
            
        }

        public void searchOrder(string name, string check)
        {
            SqlConnection connectionorigin = new SqlConnection(s_data);
            string sqlorigin = $"select * FROM OrderDetail where {name}=N'{check}' And cart= N'是' ";
            SqlCommand command = new SqlCommand(sqlorigin, connectionorigin);
            connectionorigin.Open();
            SqlDataReader searchorigin = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("customerAccount");
            dt.Columns.Add("productPicture");
            dt.Columns.Add("productName");
            dt.Columns.Add("productColor");
            dt.Columns.Add("productPrice");
            dt.Columns.Add("qty");
            while (searchorigin.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = searchorigin[0];
                row["customerAccount"] = searchorigin[2];
                row["productPicture"] = searchorigin[3];
                row["productName"] = searchorigin[4];
                row["productColor"] = searchorigin[5];
                row["productPrice"] = searchorigin[6];
                row["qty"] = searchorigin[7];
                dt.Rows.Add(row);

            }
            usershoppingcar.DataSource = dt;
            usershoppingcar.DataBind();
            connectionorigin.Close();
        }

        public void cleanbtsca()
        {
            TextBox2.Text = "";
            //DataView dv = (DataView)this.SqlDataSourceCustomerAccount.Select(new DataSourceSelectArguments());
            //DDLSearchCustomerAccount.Items.Clear();
            //DDLSearchCustomerAccount.Items.Add("請選擇");
            //DDLSearchCustomerAccount.DataSource = dv;
            //DDLSearchCustomerAccount.DataTextField = "account";
            //DDLSearchCustomerAccount.DataBind();
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

        public void cleanbtspc()
        {
            DataView dv = (DataView)this.SqlDataSourceProductColor.Select(new DataSourceSelectArguments());
            DDLSearchproductColor.Items.Clear();
            DDLSearchproductColor.Items.Add("請選擇");
            DDLSearchproductColor.DataSource = dv;
            DDLSearchproductColor.DataTextField = "category";
            DDLSearchproductColor.DataBind();
        }

        

        

        

        public void changecolor()
        {
            hintCustomerAccount.ForeColor = Color.Black;
            hintProductName.ForeColor = Color.Black;
            hintproductColor.ForeColor = Color.Black;
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

            hintCustomerAccount.Text = "";
            hintProductName.Text = "";
            hintproductColor.Text = "";
            
            changecolor();
            if (!IsPostBack)
            {
                reviewOrder();
                cleanbtsca();
                cleanbtspn();
                cleanbtspc();
            }
        }


        protected void customerAccountsearch_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != "")
            {
                string sql = $"select * from Customers where account = '{TextBox2.Text}'";
                SqlConnection connection = new SqlConnection(s_data2);
                SqlCommand command = new SqlCommand(sql,connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    searchOrder("customerAccount", TextBox2.Text);
                    cleanbtsca();
                }
                else
                {
                    hintCustomerAccount.ForeColor = Color.Red;
                    hintCustomerAccount.Text = "帳號不存在";
                }
            }
            else
            {
                hintCustomerAccount.ForeColor = Color.Red;
                hintCustomerAccount.Text = "帳號不得為空"; 
            }
            //if (DDLSearchCustomerAccount.SelectedItem.Text != "請選擇")
            //{
            //    searchOrder("customerAccount", DDLSearchCustomerAccount.Text);
            //    cleanbtsca();
            //}
            //else
            //{
            //    hintCustomerAccount.ForeColor = Color.Red;
            //    hintCustomerAccount.Text = "請選擇項目";
            //}

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

        protected void colorsearch_Click(object sender, EventArgs e)
        {
            if (DDLSearchproductColor.SelectedItem.Text != "請選擇")
            {
                searchOrder("productColor", DDLSearchproductColor.Text);
                cleanbtspc();
            }
            else
            {
                hintproductColor.ForeColor = Color.Red;
                hintproductColor.Text = "請選擇項目";
            }
        }

        

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["access"] = "Not ok";
            Response.Redirect(Request.Url.ToString());
        }

        protected void all_Click(object sender, EventArgs e)
        {
            Response.Redirect("managershoppingcar");
        }
    }
}