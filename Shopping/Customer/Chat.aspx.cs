using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping.Customer
{
    public partial class Chat : System.Web.UI.Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ChatConnectionString"].ConnectionString;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }
        public static string loginstatus = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            

        //Session["loginstatus"] = "Amber";

            try
            {
                if (Session["loginstatus"] != null)
                {
                    loginstatus = Session["loginstatus"].ToString();
                }
                else
                {
                    loginstatus = "";
                }
            }
            catch (Exception ex)
            {
                loginstatus = "";
            }
            if (!IsPostBack)
            {
                reviewChat();
            }
        }

        public void reviewChat() {
            SqlConnection connection = Connect(s_data);

            string sql = $"select * from Chat where account = @account ORDER BY  initdate desc" ;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            command.Parameters.Add("@account", SqlDbType.NVarChar).Value = loginstatus;
            sqlDataAdapter.SelectCommand = command;
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            //chatGridView.DataSource = read;

            //使用DataTable來儲存資料
            DataTable dt = new DataTable();
            dt.Load(read);
            chatGridView.DataSource = dt.AsDataView();
            chatGridView.DataBind();

            command.Cancel();
            connection.Dispose();
            connection.Close();


        }

        protected void chatGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            chatGridView.PageIndex = e.NewPageIndex;
            //chatGridView.DataBind(); ; //取資料   
            reviewChat();
        }

        protected void chatGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Text = (e.Row.RowIndex + 1).ToString();
            }
        }

        protected void keyin_Click(object sender, EventArgs e)
        {
            string costomerTalk = Request.Form["costomerTextBox"].ToString();
            if (string.IsNullOrEmpty(costomerTalk.Trim()))
            {
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "test", "setTimeout( function(){alert('請輸入文字');},0);", true);
                //MessageBox.Show("請輸入文字");
            }
            else {
                SqlConnection connection = Connect(s_data);
                string sql = $"insert into Chat (account,message) values (@account,@message) ";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                command.Parameters.Add("@account", SqlDbType.NVarChar).Value = loginstatus;
                command.Parameters.Add("@message", SqlDbType.NVarChar).Value = costomerTalk;
                sqlDataAdapter.SelectCommand = command;
                connection.Open();

                //command.ExecuteNonQuery();
                SqlDataReader read = command.ExecuteReader();
                //chatGridView.DataSource = read;
                DataTable dt = new DataTable();
                dt.Load(read);
                chatGridView.DataSource = dt.AsDataView();
                chatGridView.DataBind();


                command.Cancel();
                connection.Dispose();





                connection.Close();
                //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "test", "setTimeout( function(){alert('回覆成功');},0);", true);
                //MessageBox.Show("回覆成功");
                reviewChat();
            }
        }
    }
}