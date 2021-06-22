using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Shopping
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string s_data2 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string s_data3 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {




        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string[] Datakeys = new string[3] { "ID", "serial", "customerAccount" };
            //GridView1.DataKeyNames = Datakeys;
            ////string ID = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //string name = GridView1.DataKeys[e.RowIndex][1].ToString();
            //SqlConnection connection = new SqlConnection(s_data);
            //SqlCommand command = new SqlCommand($"delete from OrderDetail where customerAccount = '{name}'", connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();
            //Response.Redirect(Request.Url.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = TextBox2.Text;
        }


        protected void Button2_Click(object sender, EventArgs e)
        {

            string mailman = "";
            string account2 = "";
            string serial = "9296492469";
            string serialTime;
            int i = 1;
            var mailContent = "";
            var mailContent2 = "";
            var mailHead = ""; 
            var mailHead2 = "";
            int sum = 0;

            
           
            string sqlTime = $"select initdate,name,phone,address,customerAccount  from Orders where serial='{serial}'";
            SqlConnection connTime = new SqlConnection(s_data3);
            SqlCommand commandTime = new SqlCommand(sqlTime, connTime);
            connTime.Open();
            SqlDataReader reader = commandTime.ExecuteReader();
            if (reader.Read())
            {
                account2 = reader[4].ToString();
                serialTime = reader[0].ToString();

                //寫出三個標題
                mailHead = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td>{account2}您好,</tr></td><tr><td>&nbsp;</tr></td><tr><td>已收到您的訂單{serial}。</tr></td><tr><td>單單服飾已經正在確認您的訂單。</tr></td></tbody></table>";
                mailHead2 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td style='font-weight:bold'>訂單明細</tr></td><tr><td>&nbsp;</tr></td><tr><td  width='220'>訂單編號:</td><td width='220'>{serial}</td></tr><tr><td width='220'>訂單日期:<td width='220'>{serialTime}</td></tr></tbody></table>";
                mailContent2 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tr><td style='font-weight:bold'>出貨資訊</tr></td><tr><td>&nbsp;</tr></td><tr><td width='220'>收件人:</td><td width='220'>{reader[1]} </td></tr><tr><td width='150'>聯絡電話:</td><td width='220'>{reader[2]}</td></tr><tr><td width='150'>寄送地址:</td><td width='220'>{reader[3]}</td></tr></tbody></table>";
            }
            connTime.Close();

            string sqlMail = $"select email from  Customers where account='{account2}'";
            SqlConnection connMail = new SqlConnection(s_data2);
            SqlCommand commandMail = new SqlCommand(sqlMail, connMail);
            connMail.Open();
            SqlDataReader readerMail = commandMail.ExecuteReader();
            if (readerMail.Read())
            {
                mailman = readerMail[0].ToString();
            }
            connMail.Close();


            //mail基本設定(寄件人、mail主題等)
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("vs.for.test2021@gmail.com", " guy1234");
            mail.To.Add($"{mailman}");
            mail.Subject = "丹丹服飾訂單訊息";

            string sqlContent = $"select productName,productColor,productPrice, qty, productPicture from OrderDetail where serial='{serial}'";
            SqlConnection connContent = new SqlConnection(s_data);
            SqlCommand commandContent = new SqlCommand(sqlContent, connContent);
            connContent.Open();
            SqlDataReader readerContent = commandContent.ExecuteReader();
            mailContent = mailHead + mailHead2;
            while (readerContent.Read())
            {
                string[] prepare = readerContent[4].ToString().Split('\\');
                string filenojpg = prepare[prepare.Length-1].Replace(".jpg", "");
                mailContent += $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tr><td>" +$"<img alt=\'\' hspace=0 src=\'cid:{filenojpg}\' align=baseline border=0 width='100' height = '120'>"+$"</td></tr><tr><td>{i}.{readerContent[0]}({readerContent[1]})</tr></td><tr><td>&nbsp;</tr></td><tr><td width='220'>數量:</td><td width='220'>{readerContent[3]} </td></tr><tr><td width='150'>價格:</td><td width='220'>NT${readerContent[2]}</td></tr></tbody></table>";
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mailContent, null, "text/html");
                LinkedResource imageResource = new LinkedResource(@"C:\Users\yekno\Desktop\Shopping\Shopping\"+ $"{readerContent[4]}", "image/jpeg");
                i++;
                imageResource.ContentId = filenojpg;
                imageResource.TransferEncoding = TransferEncoding.Base64;
                htmlView.LinkedResources.Add(imageResource);
                mail.AlternateViews.Add(htmlView);
                sum += Convert.ToInt32(readerContent[2]) * Convert.ToInt32(readerContent[3]);
            }
            connContent.Close();

            var mailcontent3 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td style='font-weight:bold'>付款資訊</tr></td><tr><td>&nbsp;</tr></td><tr><td  width='220'>付款狀態:</td><td width='220'>已付款</td></tr><tr><td width='220'>付款金額:<td width='220'>NT${sum}</td></tr></tbody></table>";
            var mailcontent4 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td>&nbsp;</tr></td><tr><td style='font-weight:bold'>接下來</td></tr><tr><td>&nbsp;</td></tr><tr><td>請等待丹丹服飾出貨您的商品，感謝您的支持！</td></tr><tr><td>單單服飾團隊敬上</td>";
            
            mailContent += mailContent2 + mailcontent3 + mailcontent4 +"<td>"+ $"<img alt=\'\' hspace=0 src=\'cid:CAT4\' align=baseline border=0 width='100' height = '60'>" + $"</td></tr></tbody></table>";
            AlternateView htmlView2 = AlternateView.CreateAlternateViewFromString(mailContent, null, "text/html");
            LinkedResource imageResource2 = new LinkedResource(@"C:\Users\yekno\Desktop\Shopping\Shopping\" + @"images\CAT4.png", "image/jpeg");
            imageResource2.ContentId = "CAT4";
            imageResource2.TransferEncoding = TransferEncoding.Base64;
            htmlView2.LinkedResources.Add(imageResource2);
            mail.AlternateViews.Add(htmlView2);

            SendMail(mail);
        }

        
        private string getImgPath(string strImgName)
        {
            //設定(絕對)圖片路徑
            string strImgPath = @"C:\Users\yekno\Desktop\Shopping\Shopping\images\使用者照片\" + strImgName;
            return strImgPath;
        }

        private static void SendMail(System.Net.Mail.MailMessage mail)
        {
            //設定smtp主機
            string smtpAddress = "smtp.gmail.com";

            //設定Port
            int portNumber = 587;
            bool enableSSL = true;

            //填入寄送方email和密碼
            string emailFrom = "vs.for.test2021@gmail.com";
            string password = "aaabbbccc7788";

            // send the message using SMTP client
            SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);

            // _mailServer is the MailServer IP or Name
            // mail Server IP or NAME 
            smtp.Credentials = new NetworkCredential(emailFrom, password);
            smtp.EnableSsl = enableSSL;
            smtp.Send(mail);

        } //  End SendMail

        public static void EmbeddedImagesLinked(string mailman, string allmail)
        {
            // create the mail message
            MailMessage mail = new MailMessage();

            // set the addresses
            mail.From = new MailAddress("vs.for.test2021@gmail.com", " guy1234");
            mail.To.Add($"{mailman}");
           

            // set the content
            mail.Subject = "丹丹服飾訂單訊息";


            string htmlBody = allmail;
            htmlBody += "<img alt=\"\" hspace=0 src=\"cid:agay123\" align=baseline border=0 width='100' height = '120'>";
            htmlBody += $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td style='font-weight:bold'>付款資訊</tr></td><tr><td>&nbsp;</tr></td><tr><td  width='220'>付款狀態:</td><td width='220'>已付款</td></tr><tr><td width='220'>付款金額:<td width='220'>NT$</td></tr></tbody></table>";
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");

            
            LinkedResource imageResource = new LinkedResource(
                  @"C:\Users\yekno\Desktop\Shopping\Shopping\images\使用者照片\agay123.jpg", "image/jpeg");
            imageResource.ContentId = "agay123";
            imageResource.TransferEncoding = TransferEncoding.Base64;

            // adding the imaged linked to htmlView...
            htmlView.LinkedResources.Add(imageResource);

            // add the views
           
            mail.AlternateViews.Add(htmlView);

            // send mail
            SendMail(mail);

        } // End EmbeddedImagesLinked



        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    string mailman = "";
        //    string account2 = "";
        //    string serial = "9296492469";
        //    string serialTime;
        //    int i = 1;
        //    var mailContent = "";
        //    var mailContent2 = "";
        //    var mailHead = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td>{account2}您好,</tr></td><tr><td>&nbsp;</tr></td><tr><td>已收到您的訂單{serial}。</tr></td><tr><td>我們已通知賣家確認訂單後出貨。感謝您的支持！</tr></td></tbody></table>";
        //    var mailHead2 = "";
        //    int sum = 0;

        //    string sqlTime = $"select initdate,name,phone,address,customerAccount  from Orders where serial='{serial}'";
        //    SqlConnection connTime = new SqlConnection(s_data3);
        //    SqlCommand commandTime = new SqlCommand(sqlTime, connTime);
        //    connTime.Open();
        //    SqlDataReader reader = commandTime.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        account2 = reader[4].ToString();
        //        serialTime = reader[0].ToString();
        //        mailHead2 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td style='font-weight:bold'>訂單明細</tr></td><tr><td>&nbsp;</tr></td><tr><td  width='220'>訂單編號:</td><td width='220'>{serial}</td></tr><tr><td width='220'>訂單日期:<td width='220'>{serialTime}</td></tr></tbody></table>";
        //        mailContent2 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tr><td style='font-weight:bold'>出貨資訊</tr></td><tr><td>&nbsp;</tr></td><tr><td width='220'>收件人:</td><td width='220'>{reader[1]} </td></tr><tr><td width='150'>聯絡電話:</td><td width='220'>{reader[2]}</td></tr><tr><td width='150'>寄送地址:</td><td width='220'>{reader[3]}</td></tr></tbody></table>";
        //    }
        //    connTime.Close();

        //    string sqlMail = $"select email from  Customers where account='{account2}'";
        //    SqlConnection connMail = new SqlConnection(s_data2);
        //    SqlCommand commandMail = new SqlCommand(sqlMail, connMail);
        //    connMail.Open();
        //    SqlDataReader readerMail = commandMail.ExecuteReader();
        //    if (readerMail.Read())
        //    {
        //        mailman = readerMail[0].ToString();
        //    }
        //    connMail.Close();


        //    string sqlContent = $"select productName,productColor,productPrice, qty, productPicture from OrderDetail where serial='{serial}'";
        //    SqlConnection connContent = new SqlConnection(s_data);
        //    SqlCommand commandContent = new SqlCommand(sqlContent, connContent);
        //    connContent.Open();
        //    SqlDataReader readerContent = commandContent.ExecuteReader();
        //    while (readerContent.Read())
        //    {
        //        mailContent += $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tr><td>< mg alt = \'\' src =\'cid:agay123\' width='100' height='120'></td></tr><tr><td>{i}.{readerContent[0]}({readerContent[1]})</tr></td><tr><td>&nbsp;</tr></td><tr><td width='220'>數量:</td><td width='220'>{readerContent[3]} </td></tr><tr><td width='150'>價格:</td><td width='220'>NT${readerContent[2]}</td></tr></tbody></table>";
        //        i++;
        //        sum += Convert.ToInt32(readerContent[2]) * Convert.ToInt32(readerContent[3]);
        //    }
        //    connContent.Close();

        //    var mailcontent3 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td style='font-weight:bold'>付款資訊</tr></td><tr><td>&nbsp;</tr></td><tr><td  width='220'>付款狀態:</td><td width='220'>已付款</td></tr><tr><td width='220'>付款金額:<td width='220'>NT${sum}</td></tr></tbody></table>";

        //    var allmail = mailHead + mailHead2 + mailContent + mailContent2 + mailcontent3;

        //    SendEmail(allmail, mailman);
        //}


        //public void SendEmail(string body, string emailTo)
        //{
        //    //設定smtp主機
        //    string smtpAddress = "smtp.gmail.com";

        //    //設定Port
        //    int portNumber = 587;

        //    bool enableSSL = true;
        //    //填入寄送方email和密碼
        //    string emailFrom = "vs.for.test2021@gmail.com";
        //    string password = "aaabbbccc7788";


        //    //收信方email
        //    //string emailTo = "feel6942@gmail.com";
        //    //主旨
        //    string subject = "丹丹服飾系統訊息";
        //    //內容副超連結
        //    /*
        //    string body = @"<html>
        //              <body>
        //              <p>Dear Ms. Susan,</p>
        //              <p>Thank you for your letter of yesterday inviting me to come for an interview on Friday afternoon, 5th July, at 2:30.
        //                      I shall be happy to be there as requested and will bring my diploma and other papers with me.</p>
        //              <p>Sincerely,<br>-Jack</br><a href='http://tw.yahoo.com' target='_blank'>Yahoo!奇摩</a></p>
        //              </body>
        //              </html>
        //             ";
        //    */
        //    //內容無副超連結

        //    /*
        //    string body = @"<html>
        //              <body>
        //              <p>Dear Ms. Susan,</p>
        //              <p>Thank you for your letter of yesterday inviting me to come for an interview on Friday afternoon, 5th July, at 2:30.
        //                      I shall be happy to be there as requested and will bring my diploma and other papers with me.</p>
        //              <p>Sincerely,<br>-Jack</br></p>
        //              </body>
        //              </html>
        //             ";
        //    */
        //    using (MailMessage mail = new MailMessage())
        //    {
        //        mail.From = new MailAddress(emailFrom);
        //        mail.To.Add(emailTo);
        //        mail.Subject = subject;
        //        mail.Body = body;
        //        // 若你的內容是HTML格式，則為True
        //        mail.IsBodyHtml = true;


        //        using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
        //        {
        //            smtp.Credentials = new NetworkCredential(emailFrom, password);
        //            smtp.EnableSsl = enableSSL;
        //            smtp.Send(mail);
        //        }
        //    }
        //}
    }
}