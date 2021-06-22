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
    public partial class WebForm3 : System.Web.UI.Page
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;
        string s_data2 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
        string s_data3 = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrderDetailConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {




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

 
            //從訂單篩出下單日 姓名 電話 地址 帳號
            string sqlTime = $"select initdate,name,phone,address,customerAccount  from Orders where serial='{serial}'";
            SqlConnection connTime = new SqlConnection(s_data3);
            SqlCommand commandTime = new SqlCommand(sqlTime, connTime);
            connTime.Open();
            SqlDataReader reader = commandTime.ExecuteReader();
            if (reader.Read())
            {
                account2 = reader[4].ToString();
                serialTime = reader[0].ToString();
                mailHead = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td>{account2}您好,</tr></td><tr><td>&nbsp;</tr></td><tr><td>已收到您的訂單{serial}。</tr></td><tr><td>單單服飾已經正在確認您的訂單。</tr></td></tbody></table>";
                mailHead2 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td style='font-weight:bold'>訂單明細</tr></td><tr><td>&nbsp;</tr></td><tr><td  width='220'>訂單編號:</td><td width='220'>{serial}</td></tr><tr><td width='220'>訂單日期:<td width='220'>{serialTime}</td></tr></tbody></table>";
                mailContent2 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tr><td style='font-weight:bold'>出貨資訊</tr></td><tr><td>&nbsp;</tr></td><tr><td width='220'>收件人:</td><td width='220'>{reader[1]} </td></tr><tr><td width='150'>聯絡電話:</td><td width='220'>{reader[2]}</td></tr><tr><td width='150'>寄送地址:</td><td width='220'>{reader[3]}</td></tr></tbody></table>";
            }
            connTime.Close();



            //從客戶資訊撈出你要寄的EMAIL
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

            //設定mail的訊息以及寄件人等資訊
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("vs.for.test2021@gmail.com", " guy1234");
            mail.To.Add($"{mailman}");

            mail.Subject = "丹丹服飾訂單訊息";

            //從訂單細節撈出資料
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

            //付款資訊的總額和一些寒暄的話
            var mailcontent3 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td style='font-weight:bold'>付款資訊</tr></td><tr><td>&nbsp;</tr></td><tr><td  width='220'>付款狀態:</td><td width='220'>已付款</td></tr><tr><td width='220'>付款金額:<td width='220'>NT${sum}</td></tr></tbody></table>";
            var mailcontent4 = $@"<table border=0 style='border-bottom:1px #008080 solid;'width='500'><tbody><tr><td>&nbsp;</tr></td><tr><td style='font-weight:bold'>接下來</td></tr><tr><td>&nbsp;</td></tr><tr><td>請等待丹丹服飾出貨您的商品，感謝您的支持！</td></tr><tr><td>單單服飾團隊敬上</td>";
            
            //加入丹丹服飾的logo
            mailContent += mailContent2 + mailcontent3 + mailcontent4 +"<td>"+ $"<img alt=\'\' hspace=0 src=\'cid:CAT4\' align=baseline border=0 width='130' height = '50'>" + $"</td></tr></tbody></table>";
            AlternateView htmlView2 = AlternateView.CreateAlternateViewFromString(mailContent, null, "text/html");
            LinkedResource imageResource2 = new LinkedResource(@"C:\Users\yekno\Desktop\Shopping\Shopping\" + @"images\CAT4.png", "image/jpeg");
            imageResource2.ContentId = "CAT4";
            imageResource2.TransferEncoding = TransferEncoding.Base64;
            htmlView2.LinkedResources.Add(imageResource2);
            mail.AlternateViews.Add(htmlView2);

            SendMail(mail);
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

        } 

        
    }
}