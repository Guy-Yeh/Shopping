using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace Shopping
{
    public partial class forget : System.Web.UI.Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string body;
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            errorText.Text = "";
            //forgetA_TextBox.Text = "Enter Email Account";
            if (!IsPostBack)
            {
                
            }
            if (Session["loginstatus"] != null)
            {
                Response.Redirect("index");
            }
        }

        

       

        protected void registerButton_Click(object sender, EventArgs e)
        {
            if ((forgetP_TextBox.Text == null || forgetP_TextBox.Text == ""))
            {
                errorText.Text = "*輸入資訊不得為空";
                return;
            }
            SqlConnection connection = new SqlConnection(s_data);
            string emailCheck = $"select * from Customers where email ='" + forgetP_TextBox.Text + "'";
           
            SqlCommand Command_email = new SqlCommand(emailCheck, connection);


            connection.Open();
            SqlDataReader Reader_email = Command_email.ExecuteReader();
            if (Reader_email.HasRows)
            {
                while (Reader_email.Read())
                {
                    string sqlpasswd = Reader_email["password"].ToString();
                    string sqlName = Reader_email["name"].ToString();
                    body = @"<html><body><p>親愛的 " + sqlName
                            + " 您好,</p><p>感謝你使用丹丹服飾的自動回信系統，如非本人請無視本系統信件謝謝。</p><p>您的帳號的密碼為「" + sqlpasswd
                            + "」</p><p>祝您有愉快的購物體驗,<br>-丹丹服飾</br></p></body></html>";
                    try
                    {
                        errorText.Text = "*請稍等...";
                        SendEmail(body, forgetP_TextBox.Text);
                        errorText.Text = "*寄送成功";
                    }
                    catch
                    {
                        errorText.Text = "*寄送失敗";
                    }

                }
            }
            else
            {
                errorText.Text = "*查無此email";
            }

            connection.Close();


            
             
            
        }
        //寄送email信件
        public void SendEmail(string body, string emailTo)
        {
            //設定smtp主機
            string smtpAddress = "smtp.gmail.com";

            //設定Port
            int portNumber = 587;

            bool enableSSL = true;
            //填入寄送方email和密碼
            string emailFrom = "vs.for.test2021@gmail.com";
            string password = "aaabbbccc7788";


            //收信方email
            //string emailTo = "feel6942@gmail.com";
            //主旨
            string subject = "丹丹服飾系統訊息";
            //內容副超連結
            /*
            string body = @"<html>
                      <body>
                      <p>Dear Ms. Susan,</p>
                      <p>Thank you for your letter of yesterday inviting me to come for an interview on Friday afternoon, 5th July, at 2:30.
                              I shall be happy to be there as requested and will bring my diploma and other papers with me.</p>
                      <p>Sincerely,<br>-Jack</br><a href='http://tw.yahoo.com' target='_blank'>Yahoo!奇摩</a></p>
                      </body>
                      </html>
                     ";
            */
            //內容無副超連結
            
            /*
            string body = @"<html>
                      <body>
                      <p>Dear Ms. Susan,</p>
                      <p>Thank you for your letter of yesterday inviting me to come for an interview on Friday afternoon, 5th July, at 2:30.
                              I shall be happy to be there as requested and will bring my diploma and other papers with me.</p>
                      <p>Sincerely,<br>-Jack</br></p>
                      </body>
                      </html>
                     ";
            */

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                // 若你的內容是HTML格式，則為True
                mail.IsBodyHtml = true;


                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }

        protected void loginLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("login");
        }

        protected void registerLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("register");
        }
    }
    

}