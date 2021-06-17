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
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Chat where response IS NULL OR response = ''";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            usercontact.DataSource = read;
            usercontact.DataBind();
            connection.Close();
        }

        public void reviewChatDate()
        {
            SqlConnection connection4 = Connect(s_data);
            if (Convert.ToInt32(DDLDayE.Text) < 9)
            {
                string sql4 = $"select * from Chat where initdate between '{DDLYearS.Text + DDLMonthS.Text + DDLDayS.Text}' and '{DDLYearE.Text + DDLMonthE.Text +"0"+(Convert.ToInt32(DDLDayE.Text) + 1)}'";
                SqlCommand command4 = new SqlCommand(sql4, connection4);
                connection4.Open();
                SqlDataReader read = command4.ExecuteReader();
                usercontact.DataSource = read;
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
                    usercontact.DataSource = read;
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
            hintResponse.ForeColor = Color.Black;
            hintID.ForeColor = Color.Black;
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

        public void cleanbt1()
        {
            DDLContactID.Items.Clear();
            DDLContactID.Items.Add("ID");
            DataView dv = (DataView)this.SqlDataSourceChat.Select(new DataSourceSelectArguments());
            DDLContactID.DataSource = dv;
            DDLContactID.DataTextField = "ID";
            DDLContactID.DataBind();
        }

        public void cleanbt3()
        {
            DataView dvy = (DataView)this.SqlDataSourceYears.Select(new DataSourceSelectArguments());
            DataView dvm = (DataView)this.SqlDataSourceMonth.Select(new DataSourceSelectArguments());
            DataView dvd = (DataView)this.SqlDataSourceDay.Select(new DataSourceSelectArguments());

            DDLYearS.Items.Clear();
            DDLYearS.Items.Add("StartYear");
            DDLYearS.DataSource = dvy;
            DDLYearS.DataTextField = "years";
            DDLYearS.DataBind();

            DDLMonthS.Items.Clear();
            DDLMonthS.Items.Add("StartMonth");
            DDLMonthS.DataSource = dvm;
            DDLMonthS.DataTextField = "months";
            DDLMonthS.DataBind();

            DDLDayS.Items.Clear();
            DDLDayS.Items.Add("StartDay");
            DDLDayS.DataSource = dvd;
            DDLDayS.DataTextField = "days";
            DDLDayS.DataBind();

            DDLYearE.Items.Clear();
            DDLYearE.Items.Add("EndYear");
            DDLYearE.DataSource = dvy;
            DDLYearE.DataTextField = "years";
            DDLYearE.DataBind();

            DDLMonthE.Items.Clear();
            DDLMonthE.Items.Add("EndMonth");
            DDLMonthE.DataSource = dvm;
            DDLMonthE.DataTextField = "months";
            DDLMonthE.DataBind();

            DDLDayE.Items.Clear();
            DDLDayE.Items.Add("EndDay");
            DDLDayE.DataSource = dvd;
            DDLDayE.DataTextField = "days";
            DDLDayE.DataBind();
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
            hintResponse.Text = "";
            hintID.Text = "";
            hintSearch.Text = "";
            hintDate.Text = "";
            changecocolor();
            if (!IsPostBack)
            {
                SqlConnection connection = Connect(s_data);
                string sql = $"select * from Chat where response IS NULL OR response = ''";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader read = command.ExecuteReader();
                usercontact.DataSource = read;
                usercontact.DataBind();
                connection.Close();
                cleanbt1();
                cleanbt3();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DDLContactID.SelectedItem.Text != "ID")
            {
                if (Request.Form["contactresponse"] != "")
                {
                    SqlConnection connection2 = Connect(s_data);
                    string sql2 = $"update Chat SET response= N'{Request.Form["contactresponse"].ToString()}',updateInitdate = getdate() where ID='{int.Parse(DDLContactID.Text)}'";
                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt1", "setTimeout( function(){alert('回覆成功');},0);", true);
                    cleanbt1();
                    reviewChat();
                }
                else
                {
                    hintResponse.ForeColor = Color.Red;
                    hintResponse.Text = "response不得為空";
                }
            }
            else
            {
                hintID.ForeColor = Color.Red;
                hintID.Text = "請選擇項目";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Form["searchaccount"] != "")
            {
                SqlConnection connection3 = Connect(s_data);
                string sql3 = $"select * from Chat where account = '{Request.Form["searchaccount"].ToString()}'";
                SqlCommand command3 = new SqlCommand(sql3, connection3);
                connection3.Open();
                SqlDataReader read = command3.ExecuteReader();
                usercontact.DataSource = read;
                usercontact.DataBind();
                connection3.Close();
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt2", "setTimeout( function(){alert('搜尋成功');},0);", true);
                
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
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('篩選成功');},0);", true);
                        cleanbt3();
                    }
                    else if (int.Parse(DDLYearS.Text) == int.Parse(DDLYearE.Text))
                    {
                        if (int.Parse(DDLMonthS.Text) < int.Parse(DDLMonthE.Text))
                        {
                            reviewChatDate();
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('篩選成功');},0);", true);
                            cleanbt3();
                        }
                        else if ((int.Parse(DDLMonthS.Text) == int.Parse(DDLMonthE.Text)))
                        {
                            if (int.Parse(DDLDayS.Text) <= int.Parse(DDLDayE.Text))
                            {
                                reviewChatDate();
                                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt3", "setTimeout( function(){alert('篩選成功');},0);", true);
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
    }
}