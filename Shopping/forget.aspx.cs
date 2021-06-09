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

namespace Shopping
{
    public partial class forget : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //forgetA_TextBox.Text = "Enter Email Account";
            if (!IsPostBack)
            {

            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void forgetA_TextBox_TextChanged(object sender, EventArgs e)
        {
            forgetP_TextBox.Text = "";
        }

        protected void forgetP_TextBox_TextChanged(object sender, EventArgs e)
        {
            forgetA_TextBox.Text = "";
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string forgetStatus;
            //忘記帳號
            if (forgetA_TextBox.Text != "" && forgetP_TextBox.Text == "")
            {
                forgetStatus = "FA";
                SendEmail();
            }
            //忘記密碼
            else if (forgetA_TextBox.Text == "" && forgetP_TextBox.Text != "")
            {
                forgetStatus = "FP";
                SendEmail();
            }
            //內容未填寫
            else
            {
                
                errorText.Text = "未輸入內容";
            }
        }
        public void SendEmail()
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
            string emailTo = "feel6942@gmail.com";
            //主旨
            string subject = "Hello";
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
            
            string body = @"<html>
                      <body>
                      <p>Dear Ms. Susan,</p>
                      <p>Thank you for your letter of yesterday inviting me to come for an interview on Friday afternoon, 5th July, at 2:30.
                              I shall be happy to be there as requested and will bring my diploma and other papers with me.</p>
                      <p>Sincerely,<br>-Jack</br></p>
                      </body>
                      </html>
                     ";
            

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
    }
    

}