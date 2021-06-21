using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Drawing;
using System.IO;
using System.Text;

namespace Shopping
{
    public partial class manageraccount : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string searchID;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        public void reviewAccount()
        {
            helpSQL.Text = "";
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"select * from Customers";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("picture");
            dt.Columns.Add("showpicture");
            dt.Columns.Add("account");
            dt.Columns.Add("password");
            dt.Columns.Add("name");
            dt.Columns.Add("phone");
            dt.Columns.Add("email");
            dt.Columns.Add("address");
            dt.Columns.Add("discount");
            dt.Columns.Add("access");
            dt.Columns.Add("initdate");
            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];

                if (read[1].ToString() == "" || read[1] is null)
                {
                    row["picture"] = @"/images/使用者照片/def.jpg";
                }
                else 
                {
                    row["picture"] = read[1];
                }
                row["showpicture"] = read[1].ToString().Replace("/images/使用者照片/", "");
                row["account"] = read[2];
                row["password"] = read[3];
                row["name"] = read[4];
                row["phone"] = read[5];
                row["email"] = read[6];
                row["address"] = read[7];
                row["discount"] = read[8];
                row["access"] = read[9];
                row["initdate"] = read[10];
                dt.Rows.Add(row);
            }
            //useraccount.VirtualItemCount = dt.Rows.Count;
            //useraccount.DataSource = useraccounttable(0,2);
            useraccount.DataSource = dt;
            useraccount.DataBind();
            connection.Close();

        }

        //protected DataTable useraccounttable(int currentpage, int mypagesize)
        //{
        //    SqlConnection connectiondt= new SqlConnection(s_data);
        //    SqlDataReader dr = null;
        //    string sqldt = $"select * from Customers";
        //    sqldt += "OFFSET" + (currentpage * useraccount.PageSize) + "ROWS FETCH NEXT" + (mypagesize) + "ROWS ONLY";
        //    SqlCommand commanddt = new SqlCommand(sqldt, connectiondt);
        //    DataTable DT = new DataTable();
        //    connectiondt.Open();
        //    dr = commanddt.ExecuteReader();
        //    DT.Load(dr);
        //    return DT;
        //}

        public void searchaccount(string a)
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
            dt.Columns.Add("account");
            dt.Columns.Add("password");
            dt.Columns.Add("name");
            dt.Columns.Add("phone");
            dt.Columns.Add("email");
            dt.Columns.Add("address");
            dt.Columns.Add("discount");
            dt.Columns.Add("access");
            dt.Columns.Add("initdate");
            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];

                if (read[1].ToString() == "" || read[1] is null)
                {
                    row["picture"] = @"/images/使用者照片/def.jpg";
                }
                else
                {
                    row["picture"] = read[1];
                }
                row["showpicture"] = read[1].ToString().Replace("/images/使用者照片/","");
                row["account"] = read[2];
                row["password"] = read[3];
                row["name"] = read[4];
                row["phone"] = read[5];
                row["email"] = read[6];
                row["address"] = read[7];
                row["discount"] = read[8];
                row["access"] = read[9];
                row["initdate"] = read[10];
                dt.Rows.Add(row);
            }
            useraccount.DataSource = dt;
            useraccount.DataBind();
            connection.Close();

        }

        public void changecolor()
        {                           
            hintIDS.ForeColor = Color.Black;

        }

        public bool checkaccount(string a)
        {
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"select ID from Customers where account='{a}'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            bool check = read.Read();
            if (read.Read())
            {
                searchID = read[0].ToString();
            }            
            connection.Close();
            return check;
        }
       
        
        public void cleanbt4()
        {
            //DataView dv = (DataView)this.SqlDataSourceAccount.Select(new DataSourceSelectArguments());
            //DDLSearchAccount.Items.Clear();
            //DDLSearchAccount.Items.Add("請選擇");
            //DDLSearchAccount.DataSource = dv;
            //DDLSearchAccount.DataTextField = "account";
            //DDLSearchAccount.DataBind();
            TextBox7.Text = "";
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
            hintIDS.Text = "";
            changecolor();
            
            if (!IsPostBack)
            {
                reviewAccount();                                          
                cleanbt4();
            }
        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    string sql3 = $"delete from Customers where account='{DDLDeleteAccount.Text}'";

        //    if (DDLDeleteAccount.SelectedItem.Text!="請選擇")
        //    {
        //        SqlConnection connection3 = Connect(s_data);
        //        SqlCommand command3 = new SqlCommand(sql3, connection3);
        //        connection3.Open();
        //        command3.ExecuteNonQuery();
        //        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt2", "setTimeout( function(){alert('刪除成功');},0);", true);
        //        connection3.Close();
        //        reviewAccount();
        //        cleanbt2();
        //        cleanbt3();
        //        cleanbt4();
        //    }
        //    else
        //    {
        //        hintID.ForeColor = Color.Red;
        //        hintID.Text = "請選擇項目";
        //    }

        //}

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["access"] = "Not ok";
            Response.Redirect("manager");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string sql3 = $"select * from Customers where account='{TextBox7.Text}'";
            if (TextBox7.Text != "")
            {
                if (checkaccount(TextBox7.Text))
                {
                    searchaccount(sql3);                    
                    cleanbt4();
                }
                else
                {
                    hintIDS.ForeColor = Color.Red;
                    hintIDS.Text = "帳號不存在 請重新輸入";
                }
            }
            else
            {
                hintIDS.ForeColor = Color.Red;
                hintIDS.Text = "帳號不得為空 請重新輸入";
            }
        }

        //gridview刪除客戶資料
        protected void useraccount_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string ID = useraccount.DataKeys[e.RowIndex].Value.ToString();           
            SqlConnection connection = new SqlConnection(s_data);
            SqlCommand command = new SqlCommand($"delete from Customers where ID = '{ID}'", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            reviewAccount();
        }
        protected void useraccount_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            useraccount.EditIndex = -1;
            if (helpSQL.Text != "")
            {
                searchaccount(helpSQL.Text);
            }
            else
            {
                reviewAccount();
            }
        }

        protected void useraccount_RowEditing(object sender, GridViewEditEventArgs e)
        {
            useraccount.EditIndex = e.NewEditIndex;
             
            if (helpSQL.Text != "")
            {
                searchaccount(helpSQL.Text);
            }
            else
            {
                reviewAccount();
            }

        }
        protected void useraccount_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            string ID = useraccount.DataKeys[e.RowIndex].Values[0].ToString();
            string access = ((TextBox)useraccount.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            string sql = $"update customers set access = '{access}'";
            if (access == "Yes" || access == "No")
            {
                SqlConnection connection = new SqlConnection(s_data);
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                useraccount.EditIndex = -1;
                reviewAccount();
            }
            else
            {
                MessageBox.Show("權限僅能輸入Yes或No 請重新輸入");
                //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "update", "setTimeout( function(){alert('權限僅能輸入Yes或No 請重新輸入');},600);", true);
            }

            //string update = $"update Customers SET account= N'{TextBox9.Text}' where account='{TextBox8.Text}'";
            //string sqlSP = $"select picture from Customers where ID='{ID}'";
            //SqlConnection connectionSP = new SqlConnection(s_data);
            //SqlCommand commandSP = new SqlCommand(sqlSP, connectionSP 
            //connectionSP.Open();
            //SqlDataReader reader = commandSP.ExecuteReader();
        }

        protected void useraccount_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            useraccount.PageIndex = e.NewPageIndex;
            reviewAccount();
        }

        protected void all_Click(object sender, EventArgs e)
        {
            Response.Redirect("manageraccount");
        }
        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    string sql3 = $"select * from Customers where account='{DDLSearchAccount.Text}'";

        //    if (DDLSearchAccount.SelectedItem.Text != "請選擇")
        //    {
        //        searchaccount(sql3);
        //        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt4", "setTimeout( function(){alert('篩選成功');},0);", true);                                
        //        cleanbt4();
        //    }
        //    else
        //    {
        //        hintIDS.ForeColor = Color.Red;
        //        hintIDS.Text = "請選擇項目";
        //    }
        //}
    }
}