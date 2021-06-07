using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            reviewChat();
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
        protected void Page_Load(object sender, EventArgs e)
        {
            hintResponse.Text = "";
            hintID.Text = "";
            hintSearch.Text = "";
            hintDate.Text = "";
            SqlConnection connection = Connect(s_data);
            string sql = $"select * from Chat where response IS NULL OR response = ''";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            usercontact.DataSource = read;
            usercontact.DataBind();
            connection.Close();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DDLContactID.SelectedItem.Text != "ID")
            {
                if (Request.Form["contactresponse"] != "")
                {
                    SqlConnection connection2 = Connect(s_data);
                    string sql2 = $"update Chat SET response='{Request.Form["contactresponse"].ToString()}' where ID='{int.Parse(DDLContactID.Text)}'";
                    SqlCommand command2 = new SqlCommand(sql2, connection2);
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("回覆成功");
                    reviewChat();
                }
                else
                {
                    hintResponse.Text = "response不得為空";
                }
            }
            else
            {
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
                MessageBox.Show("搜尋成功");
            }
            else
            {
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
                        MessageBox.Show("篩選成功");
                    }
                    else if (int.Parse(DDLYearS.Text) == int.Parse(DDLYearE.Text))
                    {
                        if (int.Parse(DDLMonthS.Text) < int.Parse(DDLMonthE.Text))
                        {
                            reviewChatDate();
                            MessageBox.Show("篩選成功");
                        }
                        else if ((int.Parse(DDLMonthS.Text) == int.Parse(DDLMonthE.Text)))
                        {
                            if (int.Parse(DDLDayS.Text) <= int.Parse(DDLDayE.Text))
                            {
                                reviewChatDate();
                                MessageBox.Show("篩選成功");
                            }
                            else
                            {
                                hintDate.Text = "起始日不得超過終止日";
                                reviewChatDate();
                            }

                        }
                        else
                        {
                            hintDate.Text = "起始日不得超過終止日";
                            reviewChatDate();
                        }
                    }
                    else
                    {
                        hintDate.Text = "起始日不得超過終止日";
                        reviewChatDate();
                    }
                }
                else
                {
                    hintDate.Text = "選擇日期不存在";
                }
            }
            else
            {
                hintDate.Text = "所有項目皆須選擇";
            }
        }
    }
}