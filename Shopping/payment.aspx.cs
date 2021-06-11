using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class payment : Page
    {
        //連線字串
        string customers_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string orders_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;
        //全域變數訂單號碼
        string ser;
        //訂單號碼生成方法
        public bool reviewSerial()
        {
            Random rnd = new Random();
            ser = "";
            for (int i = 0; i < 10; i++)    //編成serial number
            {
                int serialrnd = rnd.Next(0, 10);
                ser += serialrnd.ToString();
            }
            SqlConnection connection1 = new SqlConnection(orders_data);
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
            //產生變數確認購物車內是否有內容
            bool cart;
            //連線至orderdetail
            SqlConnection connection1 = new SqlConnection(orderdetail_data);
            string sql1 = $"select productName,productColor,productPrice,qty from OrderDetail where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            connection1.Open();
            SqlDataReader read1 = command1.ExecuteReader();
            //透過讀取資料庫確定購物車內是否有值
            if (read1.HasRows)
                cart = true;
            else
                cart = false;
            //將productName,productColor,productPrice,qty顯示於gridview
            GridView1.DataSource = read1;
            GridView1.DataBind();
            connection1.Close();
            //將購買總金額顯示於label4
            string sql2 = $"select sum(productPrice*qty) from OrderDetail where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand command2 = new SqlCommand(sql2, connection1);
            connection1.Open();
            SqlDataReader read2 = command2.ExecuteReader();
            if (read2.Read())
            {
                Label4.Text = read2[0].ToString();
            }
            connection1.Close();
            //購物車有內容
            if (cart == true)
            {
                //連線至customers
                SqlConnection connection2 = new SqlConnection(customers_data);
                //將客戶名稱，地址，電話分別顯示於TextBox1,2,3
                string sql3 = $"select * from Customers where account=N'{Session["loginstatus"]}'";
                SqlCommand command3 = new SqlCommand(sql3, connection2);
                connection2.Open();
                SqlDataReader read3 = command3.ExecuteReader();
                if (read3.HasRows)
                {
                    if (read3.Read())
                    {
                        TextBox1.Text = read3[4].ToString();
                        TextBox2.Text = read3["address"].ToString();
                        TextBox3.Text = read3[5].ToString();
                    }
                }
                connection2.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            while (reviewSerial())
            {
                reviewSerial();
            }
            SqlConnection connection1 = new SqlConnection(orders_data);
            string sql1 = $"insert into [Orders](serial,customerAccount,name,phone,address,totalPrice,status) values(@serial,@customerAccount,@name,@phone,@address,@totalPrice,@status)";
            SqlCommand Command1 = new SqlCommand(sql1, connection1);
            connection1.Open();
            Command1.Parameters.Add("@serial", SqlDbType.NVarChar);
            Command1.Parameters["@serial"].Value = ser;
            Command1.Parameters.Add("@customerAccount", SqlDbType.NVarChar);
            Command1.Parameters["@customerAccount"].Value = Session["loginstatus"];
            Command1.Parameters.Add("@name", SqlDbType.NVarChar);
            Command1.Parameters["@name"].Value = TextBox1.Text;
            Command1.Parameters.Add("@phone", SqlDbType.NVarChar);
            Command1.Parameters["@phone"].Value = TextBox3.Text;
            Command1.Parameters.Add("@address", SqlDbType.NVarChar);
            Command1.Parameters["@address"].Value = TextBox2.Text;
            Command1.Parameters.Add("@totalPrice", SqlDbType.NVarChar);
            Command1.Parameters["@totalPrice"].Value = Label4.Text;
            Command1.Parameters.Add("@status", SqlDbType.NVarChar);
            Command1.Parameters["@status"].Value = "賣家處理中";
            Command1.ExecuteNonQuery();
            connection1.Close();
           
            SqlConnection connection2 = new SqlConnection(orderdetail_data);
            string sql2 = $"update OrderDetail set serial = '{ser}', cart=N'否' where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand Command2 = new SqlCommand(sql2, connection2);
            connection2.Open();
            Command2.ExecuteNonQuery();
            connection2.Close();
            Response.Redirect("payment");
        }
    }
}