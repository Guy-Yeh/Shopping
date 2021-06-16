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


        public void reviewOrder()
        {
            SqlConnection connectionorigin = new SqlConnection(s_data);
            string sqlorigin = $"select * from OrderDetail where cart=N'是'";
            SqlCommand command = new SqlCommand(sqlorigin, connectionorigin);
            connectionorigin.Open();
            SqlDataReader readorigin = command.ExecuteReader();
            DataTable dt = new DataTable();
           
            usershoppingcar.DataSource = readorigin;
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
            
            usershoppingcar.DataSource = searchorigin;
            usershoppingcar.DataBind();
            connectionorigin.Close();
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

        protected void colorsearch_Click(object sender, EventArgs e)
        {
            if (DDLSearchproductColor.SelectedItem.Text != "請選擇")
            {
                searchOrder("productColor", DDLSearchproductColor.Text);
                cleanbtspc();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btn", "setTimeout( function(){alert('篩選成功');},0);", true);
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
    }
}