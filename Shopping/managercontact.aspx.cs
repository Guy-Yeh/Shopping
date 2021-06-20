using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping
{
    public partial class managercontact : Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ChatConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }

        public void reviewChat()
        {
            helpSQL.Text = "";
            helpSQL2.Text = "";
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Chat where response IS NULL OR response = ''";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("account");
            dt.Columns.Add("message");
            dt.Columns.Add("response");
            dt.Columns.Add("initdate");
            dt.Columns.Add("updateInitdate");
            while(read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];
                row["account"] = read[1];
                row["message"] = read[2];
                row["response"] = read[3];
                row["initdate"] = read[4];
                row["updateInitdate"] = read[5];
                dt.Rows.Add(row);

            }
            usercontact.DataSource = dt;
            usercontact.DataBind();
            connection.Close();
        }

        public void searchChat(string a)
        {
            helpSQL.Text = a;
            helpSQL2.Text = "";
            SqlConnection connection3 = Connect(s_data);
            SqlCommand command3 = new SqlCommand(a, connection3);
            connection3.Open();
            SqlDataReader read = command3.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("account");
            dt.Columns.Add("message");
            dt.Columns.Add("response");
            dt.Columns.Add("initdate");
            dt.Columns.Add("updateInitdate");
            while (read.Read())
            {
                DataRow row = dt.NewRow();
                row["ID"] = read[0];
                row["account"] = read[1];
                row["message"] = read[2];
                row["response"] = read[3];
                row["initdate"] = read[4];
                row["updateInitdate"] = read[5];
                dt.Rows.Add(row);

            }
            usercontact.DataSource = dt;
            usercontact.DataBind();
            connection3.Close();

        }

        public void reviewChatDate()
        {
            helpSQL.Text = "";
            helpSQL2.Text = "date";
            SqlConnection connection4 = Connect(s_data);
            if (Convert.ToInt32(DDLDayE.Text) < 9)
            {
                string sql4 = $"select * from Chat where initdate between '{DDLYearS.Text + DDLMonthS.Text + DDLDayS.Text}' and '{DDLYearE.Text + DDLMonthE.Text +"0"+(Convert.ToInt32(DDLDayE.Text) + 1)}'";
                SqlCommand command4 = new SqlCommand(sql4, connection4);
                connection4.Open();
                SqlDataReader read = command4.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("account");
                dt.Columns.Add("message");
                dt.Columns.Add("response");
                dt.Columns.Add("initdate");
                dt.Columns.Add("updateinitdate");
                while (read.Read())
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = read[0];
                    row["account"] = read[1];
                    row["message"] = read[2];
                    row["response"] = read[3];
                    row["initdate"] = read[4];
                    row["updateinitdate"] = read[5];
                    dt.Rows.Add(row);
                }
                usercontact.DataSource = dt;
                usercontact.DataBind();
                connection4.Close();
            }
            else
            {
                if (ValidateDateTime((DDLYearS.Text + DDLMonthS.Text + (Convert.ToInt32(DDLDayE.Text) + 1)), "yyyyMMdd") == true)
                {
                    string sql4 = $"select * from Chat where initdate between '{DDLYearS.Text + DDLMonthS.Text + DDLDayS.Text}' and '{DDLYearE.Text + DDLMonthE.Text + (Convert.ToInt32(DDLDayE.Text) + 1)}'";
                    SqlCommand command4 = new SqlCommand(sql4, connection4);
                    connection4.Open();
                    SqlDataReader read = command4.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("account");
                    dt.Columns.Add("message");
                    dt.Columns.Add("response");
                    dt.Columns.Add("initdate");
                    dt.Columns.Add("updateinitdate");
                    while (read.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = read[0];
                        row["account"] = read[1];
                        row["message"] = read[2];                       
                        row["response"] = read[3];
                        row["initdate"] = read[4];
                        row["updateinitdate"] = read[5];                        
                        dt.Rows.Add(row);
                    }                    
                    usercontact.DataSource = dt;
                    usercontact.DataBind();
                    connection4.Close();
                }
                else
                {
                    if(ValidateDateTime(DDLYearE.Text + (Convert.ToInt32(DDLMonthE.Text) + 1) + "01","yyyyMMdd") == true)
                    {
                        string sql4 = $"select * from Chat where initdate between '{DDLYearS.Text + DDLMonthS.Text + DDLDayS.Text}' and '{DDLYearE.Text + (Convert.ToInt32(DDLMonthE.Text) + 1) + "01"}'";
                        SqlCommand command4 = new SqlCommand(sql4, connection4);
                        connection4.Open();
                        SqlDataReader read = command4.ExecuteReader();
                        usercontact.DataSource = read;
                        usercontact.DataBind();
                        connection4.Close();
                    }
                    else
                    {
                        string sql4 = $"select * from Chat where initdate between '{DDLYearS.Text + DDLMonthS.Text + DDLDayS.Text}' and '{(Convert.ToInt32(DDLYearE.Text)+1) + "01" + "01"}'";
                        SqlCommand command4 = new SqlCommand(sql4, connection4);
                        connection4.Open();
                        SqlDataReader read = command4.ExecuteReader();
                        usercontact.DataSource = read;
                        usercontact.DataBind();
                        connection4.Close();
                    }
                }
            } 
        }

        public void changecocolor()
        {
           
            hintSearch.ForeColor = Color.Black;
            hintDate.ForeColor = Color.Black;
        }

        protected void empty()
        {
            DataTable dt = new DataTable();
            this.usercontact.DataSource = dt;
            this.usercontact.DataBind();
        }

        public static bool ValidateDateTime(string datetime, string format)
        {
            if (datetime == null || datetime.Length == 0)
            {
                return false;
            }
            try
            {
                System.Globalization.DateTimeFormatInfo dtfi = new System.Globalization.DateTimeFormatInfo();
                dtfi.FullDateTimePattern = format;
                DateTime dt = DateTime.ParseExact(datetime, "F", dtfi);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        

        public void cleanbt3()
        {
            DataView dvy = (DataView)this.SqlDataSourceYears.Select(new DataSourceSelectArguments());
            DataView dvm = (DataView)this.SqlDataSourceMonth.Select(new DataSourceSelectArguments());
            DataView dvd = (DataView)this.SqlDataSourceDay.Select(new DataSourceSelectArguments());
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            string[] list = today.Split('/');
            
            string todayY = list[0];
            string todayM = list[1];
            string todayD = list[2];

            DDLYearS.Items.Clear();
            DDLYearS.Items.Add("年");
            DDLYearS.DataSource = dvy;
            DDLYearS.DataTextField = "years";
            DDLYearS.DataBind();

            DDLMonthS.Items.Clear();
            DDLMonthS.Items.Add("月");
            DDLMonthS.DataSource = dvm;
            DDLMonthS.DataTextField = "months";
            DDLMonthS.DataBind();

            DDLDayS.Items.Clear();
            DDLDayS.Items.Add("日");
            DDLDayS.DataSource = dvd;
            DDLDayS.DataTextField = "days";
            DDLDayS.DataBind();

            DDLYearE.Items.Clear();
            DDLYearE.Items.Add(todayY);
            DDLYearE.DataSource = dvy;
            DDLYearE.DataTextField = "years";
            DDLYearE.DataBind();

            DDLMonthE.Items.Clear();
            DDLMonthE.Items.Add(todayM);
            DDLMonthE.DataSource = dvm;
            DDLMonthE.DataTextField = "months";
            DDLMonthE.DataBind();

            DDLDayE.Items.Clear();
            DDLDayE.Items.Add(todayD);
            DDLDayE.DataSource = dvd;
            DDLDayE.DataTextField = "days";
            DDLDayE.DataBind();
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
            
            hintSearch.Text = "";
            hintDate.Text = "";
            changecocolor();
            if (!IsPostBack)
            {
                reviewChat();
               
                cleanbt3();
            }
        }


        

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Form["searchaccount"] != "")
            {
                string sql3 = $"select * from Chat where account = '{Request.Form["searchaccount"]}'";
                searchChat(sql3);
            }
            else
            {
                hintSearch.ForeColor = Color.Red;
                hintSearch.Text = "account不得為空";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (DDLYearS.SelectedItem.Text != "StartYear" && DDLMonthS.SelectedItem.Text != "StartMonth" && DDLDayS.SelectedItem.Text != "StartDay" && DDLYearE.SelectedItem.Text != "EndYear" && DDLMonthE.SelectedItem.Text != "EndMonth" && DDLDayE.SelectedItem.Text != "EndDay")
            {
                if (ValidateDateTime((DDLYearS.Text + DDLMonthS.Text + DDLDayS.Text), "yyyyMMdd") == true && ValidateDateTime((DDLYearE.Text + DDLMonthE.Text + DDLDayE.Text), "yyyyMMdd") == true)
                {
                    if (int.Parse(DDLYearS.Text) < int.Parse(DDLYearE.Text))
                    {
                        reviewChatDate();                        
                        cleanbt3();
                    }
                    else if (int.Parse(DDLYearS.Text) == int.Parse(DDLYearE.Text))
                    {
                        if (int.Parse(DDLMonthS.Text) < int.Parse(DDLMonthE.Text))
                        {
                            reviewChatDate();                            
                            cleanbt3();
                        }
                        else if ((int.Parse(DDLMonthS.Text) == int.Parse(DDLMonthE.Text)))
                        {
                            if (int.Parse(DDLDayS.Text) <= int.Parse(DDLDayE.Text))
                            {
                                reviewChatDate();                               
                                cleanbt3();
                            }
                            else
                            {
                                hintDate.ForeColor = Color.Red;
                                hintDate.Text = "起始日不得超過終止日";
                                empty();
                            }

                        }
                        else
                        {
                            hintDate.ForeColor = Color.Red;
                            hintDate.Text = "起始日不得超過終止日";
                            empty();
                        }
                    }
                    else
                    {
                        hintDate.ForeColor = Color.Red;
                        hintDate.Text = "起始日不得超過終止日";
                        empty();
                    }
                }
                else
                {
                    hintDate.ForeColor = Color.Red;
                    hintDate.Text = "選擇日期不存在";
                    empty();
                }
            }
            else
            {
                hintDate.ForeColor = Color.Red;
                hintDate.Text = "所有項目皆須選擇";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["access"] = "Not ok";
            Response.Redirect(Request.Url.ToString());
        }

        protected void all_Click(object sender, EventArgs e)
        {
            Response.Redirect("managercontact");
        }

        protected void usercontact_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string ID = usercontact.DataKeys[e.RowIndex].Values[0].ToString();
            string response = ((TextBox)usercontact.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            string strUpdate = $"update Chat set response = N'{response}', updateInitdate= getdate()  where ID='{ID}'";
            SqlConnection connection = new SqlConnection(s_data);
            connection.Open();
            SqlCommand command = new SqlCommand(strUpdate, connection);
            command.ExecuteNonQuery();
            connection.Close();
            usercontact.EditIndex = -1;
            reviewChat();
        }

        protected void usercontact_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            usercontact.EditIndex = -1;
            if (helpSQL.Text != "")
            {
                searchChat(helpSQL.Text);
            }
            else if (helpSQL2.Text != "")
            {
                reviewChatDate();
            }
            else
            {
                reviewChat();
            }
        }

        protected void usercontact_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            usercontact.PageIndex = e.NewPageIndex;
            reviewChat();
        }

        protected void usercontact_RowEditing(object sender, GridViewEditEventArgs e)
        {
            usercontact.EditIndex = e.NewEditIndex;

            if (helpSQL.Text != "")
            {
                searchChat(helpSQL.Text);
            }
            else if (helpSQL2.Text != "")
            {
                reviewChatDate();
            }
            else
            {
                reviewChat();
            }
        }
    }
}