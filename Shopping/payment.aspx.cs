using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping
{
    public partial class payment : Page
    {
        //連線字串
        string customers_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string orderdetail_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string orders_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;
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
            if (Session["loginstatus"] != null)
            {
                Button4.Text = "會員資料";
                Button3.Text = "登出";
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
                //連線至orderdetail
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sq12 = $"select sum(productPrice*qty) from OrderDetail where customerAccount='{Session["loginstatus"]}' and cart=N'是'";
                //如果購物車內有商品將商品總金額顯示於Label1
                SqlCommand command2 = new SqlCommand(sq12, connection2);
                connection2.Open();
                SqlDataReader read2 = command2.ExecuteReader();
                if (read2.HasRows)
                {
                    if (read2.Read())
                    {
                        Label6.Text = "消費金額：" + read2[0].ToString();
                    }
                }
                connection2.Close();
            }
            //產生變數確認購物車內是否有內容
            bool cart;
            //連線至orderdetail
            SqlConnection connection3 = new SqlConnection(orderdetail_data);
            string sql3 = $"select productName,productColor,productPrice,qty from OrderDetail where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand command3 = new SqlCommand(sql3, connection3);
            connection3.Open();
            SqlDataReader read3 = command3.ExecuteReader();
            //透過讀取資料庫確定購物車內是否有值
            if (read3.HasRows)
                cart = true;
            else
                cart = false;
            //將productName,productColor,productPrice,qty顯示於gridview
            GridView1.DataSource = read3;
            GridView1.DataBind();
            connection3.Close();
            //將購買總金額顯示於label4
            string sql4 = $"select sum(productPrice*qty) from OrderDetail where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
            SqlCommand command4 = new SqlCommand(sql4, connection3);
            connection3.Open();
            SqlDataReader read4 = command4.ExecuteReader();
            if (read4.Read())
            {
                Label4.Text = read4[0].ToString();
            }
            connection3.Close();
            //購物車有內容
            if (cart == true)
            {
                if (!IsPostBack)
                {
                    //連線至customers
                    SqlConnection connection4 = new SqlConnection(customers_data);
                    //將客戶名稱，地址，電話分別顯示於TextBox1,2,3
                    string sql5 = $"select * from Customers where account=N'{Session["loginstatus"]}'";
                    SqlCommand command5 = new SqlCommand(sql5, connection4);
                    connection4.Open();
                    SqlDataReader read5 = command5.ExecuteReader();
                    if (read5.Read())
                    {
                        TextBox1.Text = read5[4].ToString();
                        TextBox2.Text = read5["address"].ToString();
                        TextBox3.Text = read5[5].ToString();
                    }
                    connection4.Close();
                }
            }
            else
            {
                Response.Redirect("index");
            }
        }
        //確認送出訂單
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
                Label7.Text = "姓名為必填欄位";
            else if (TextBox2.Text == "")
                Label7.Text = "住址為必填欄位";
            else if (TextBox3.Text == "")
                Label7.Text = "電話為必填欄位";
            else
            {
                //產生一個訂單編號
                while (reviewSerial())
                {
                    reviewSerial();
                }
                //將serial,customerAccount,name,phone,address,totalPrice,status等資料輸入進Orders
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
                Command1.Parameters["@status"].Value = "賣方處理中";
                Command1.ExecuteNonQuery();
                connection1.Close();

                //將orderdetail內serial和cart更正
                SqlConnection connection2 = new SqlConnection(orderdetail_data);
                string sql2 = $"update OrderDetail set serial = '{ser}', cart=N'否' where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand Command2 = new SqlCommand(sql2, connection2);
                connection2.Open();
                Command2.ExecuteNonQuery();
                connection2.Close();

                //連線至orderdetail找出訂單內容
                SqlConnection connection3 = new SqlConnection(orderdetail_data);
                string sql3 = $"select productName,productColor,qty from OrderDetail where serial = '{ser}'";
                SqlCommand command3 = new SqlCommand(sql3, connection3);
                connection3.Open();
                SqlDataReader read3 = command3.ExecuteReader();
                //找到product內庫存數量並更正
                while (read3.Read())
                {
                    SqlConnection connection5 = new SqlConnection(product_data);
                    string sql5 = $"select inventory from Products where productName=N'{read3[0]}' and category=N'{read3[1]}'";
                    SqlCommand command5 = new SqlCommand(sql5, connection5);
                    connection5.Open();
                    SqlDataReader read5 = command5.ExecuteReader();
                    if (read5.Read())
                    {
                        SqlConnection connection4 = new SqlConnection(product_data);
                        string sql4 = $"update Products set inventory = '{Convert.ToInt32(read5[0]) - Convert.ToInt32(read3[2])}' where productName=N'{read3[0]}' and category=N'{read3[1]}'";
                        SqlCommand Command4 = new SqlCommand(sql4, connection4);
                        connection4.Open();
                        Command4.ExecuteNonQuery();
                        connection4.Close();
                    }
                }
                connection3.Close();
                Response.Redirect("payment");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //判定登錄
            if (Session["loginstatus"] != null)
            {
                //連線至orderdetail
                SqlConnection connection = new SqlConnection(orderdetail_data);
                //如果購物車內有商品則刪除該帳號的購物車商品
                string sql = $"delete from OrderDetail where customerAccount=N'{Session["loginstatus"]}' and cart=N'是'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("index");
            }
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("login");
            }
            else
            {
                Response.Redirect(@"Customer/CustomerDetail");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["loginstatus"] == null)
            {
                Response.Redirect("register");
            }
            else
            {
                Session.Remove("loginstatus");
                Response.Redirect("index");
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"購物須知
–  退換貨政策  –
丹丹服飾提供七日鑑賞期體驗。請注意鑑賞期並非試用期，請保持商品狀態維持全新，並保留完整包裝，

1.退換貨：如果您收到的商品，商品有瑕疵或與原先訂購商品不符，或有其他退貨 / 換貨需求，請在 7 天內聯絡客服確認。
（若無法於期限內提出退換貨要求，恕無法提供退換貨服務請見諒）

2.退換貨注意事項：退換貨的商品必須回復原狀，即需保留完整外包裝袋、包裝盒。 

3.下列情形可能影響您的退換貨權限：
 *在您收到商品當下，務必仔細確認商品完整及符合訂購內容。
 *其他逾越檢查之必要或可歸責於您之事由，致商品有毀損、滅失或變更者。

4.若您已取得紙本發票，請於退換貨時一併附上。

5.請您以送貨廠商使用之包裝紙箱將退換貨商品包裝妥當，若原紙箱已遺失，請另使用其他紙箱包覆於商品原廠包裝之外。
（切勿直接於原廠包裝上黏貼紙張或書寫文字，若原廠包裝損毀將無法退貨。）

6.當您申請退換貨後，請主動向貨運人員索取單據，並保留至退換貨完成，以利日後查詢。

感謝您的合作，如有任何疑問歡迎直接與客服人員聯繫。

客服信箱：vs.for.test2021@gmail.com");
        }
    }
}