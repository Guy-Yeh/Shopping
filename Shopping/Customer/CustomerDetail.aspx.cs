using Shopping.Models;
using Shopping.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping.Customer
{
    public partial class CustomerDetail : System.Web.UI.Page
    {
        public static string loginstatus = "";
        public System.Web.UI.WebControls.Image ImageDocument;

        protected void Page_Load(object sender, EventArgs e)
        {
            //測試 假裝有登入
           // Session["loginstatus"] = "Amber";

            try
            {
                if (Session["loginstatus"] != null)
                {
                    loginstatus = Session["loginstatus"].ToString();
                }
            }
            catch (Exception ex)
            {
                loginstatus = "";
                throw;
            }
            finally
            {
           
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {

        }


        [WebMethod]
        public static Models.ApiResultModel<List<CustomersModel>> GetCustomers()
        {
            Common.Common common = new Common.Common();
            try
            {
                CustomerDetailService customerDetailService = new CustomerDetailService();
                List<CustomersModel> customers = customerDetailService.GetCustomers(loginstatus);

                //for (int i = 0; i < customers.Count; i++)
                //{
                //    if (string.IsNullOrEmpty(customers[i].picture))
                //    {
                //        //預設圖片
                //        customers[i].picture = "/images/si2.jpg";
                //    }
                //}

                return common.ThrowResult<List<CustomersModel>>(Enum.ApiStatusEnum.OK, string.Empty, customers);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<List<CustomersModel>>(Enum.ApiStatusEnum.InternalServerError, ex.Message, null);
            }
        }

        [WebMethod]
        public static Models.ApiResultModel<bool> DelAccount(string account, string access)
        {
            Common.Common common = new Common.Common();
            try
            {
                CustomerDetailService customerDetailService = new CustomerDetailService();
                bool r = customerDetailService.DelAccount(account, access);

                return common.ThrowResult<bool>(Enum.ApiStatusEnum.OK, string.Empty, r);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError, ex.Message, false);
            }
        }


        [WebMethod]
        public static Models.ApiResultModel<bool> EditName(int id, string name)
        {
            Common.Common common = new Common.Common();
            try
            {
                CustomerDetailService customerDetailService = new CustomerDetailService();
                bool r =customerDetailService.EditName(id, name);

                return common.ThrowResult<bool>(Enum.ApiStatusEnum.OK, string.Empty, r);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError, ex.Message, false);
            }
        }

        [WebMethod]
        public static Models.ApiResultModel<bool> EditPhoneNumber(int id, string phone)
        {
            Common.Common common = new Common.Common();
            try
            {
                CustomerDetailService customerDetailService = new CustomerDetailService();
                bool r = customerDetailService.EditPhoneNumber(id, phone);

                return common.ThrowResult<bool>(Enum.ApiStatusEnum.OK, string.Empty, r);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError, ex.Message, false);
            }
        }


        [WebMethod]
        public static Models.ApiResultModel<bool> EditAddress(int id, string address)
        {
            Common.Common common = new Common.Common();
            try
            {
                CustomerDetailService customerDetailService = new CustomerDetailService();
                bool r = customerDetailService.EditAddress(id, address);

                return common.ThrowResult<bool>(Enum.ApiStatusEnum.OK, string.Empty, r);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError, ex.Message, false);
            }
        }


        [WebMethod]
        public static Models.ApiResultModel<bool> EditPassword(string account, string oldPwd, string newPwd, string reNewPwd)
        {
            Common.Common common = new Common.Common();
            try
            {
                bool oldPwdRule = Regex.IsMatch(oldPwd, @"[\w-]{7,20}");
                bool newPwdRule = Regex.IsMatch(oldPwd, @"[\w-]{7,20}");
                bool reNewPwdRule = Regex.IsMatch(oldPwd, @"[\w-]{7,20}");
                if (oldPwdRule && newPwdRule && reNewPwdRule)
                {

                    //格式正確
                    if (newPwdRule == reNewPwdRule)
                    {
                        CustomerDetailService customerDetailService = new CustomerDetailService();
                        bool r = customerDetailService.CheckPassword(loginstatus, oldPwd);
                        if (r ==true)
                        {
                            CustomerDetailService customerDetailService2 = new CustomerDetailService();
                            bool r1 = customerDetailService2.EditPassword1(loginstatus, reNewPwd);
                            //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "bt1", "setTimeout( function(){alert('輸入成功');},0);", true);
                            //MessageBox.Show("密碼修改成功");
                            //正確 執行更新密碼
                        }
                        else
                        {
                            //舊密碼輸入錯誤

                            //MessageBox.Show("舊密碼輸入錯誤");
                            return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError, "舊密碼輸入錯誤", true);
                        }
                    }
                    else
                    {
                        //essageBox.Show("新密碼輸入錯誤");
                        return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError, "新密碼輸入錯誤", true);
                    }
                }
                else
                {
                    return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError , "密碼格式錯誤", true);
                    //MessageBox.Show("密碼格式錯誤");
                }
                return common.ThrowResult<bool>(Enum.ApiStatusEnum.OK, string.Empty, true);

            }
            catch (Exception ex)
            {
                return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError, ex.Message, false);
            }
        }

        //protected void Button1_FileUpload(object sender, EventArgs e)
        //{

        //    if (FileUpload1.PostedFile != null)
        //    {
        //        // File was sent
        //        HttpPostedFile myFile = FileUpload1.PostedFile;


        //        // Get size of uploaded file
        //        int nFileLen = myFile.ContentLength;
        //        string imgPath = Server.MapPath("/images/FileUpload/" + DateTime.Now.ToString("yyyy_MM_dd_hhmmss_sss") + ".jpg");
        //        FileUpload1.SaveAs(imgPath);
        //        if (FileUpload1.HasFile)
        //        {

        //            MessageBox.Show("上傳成功");
        //        }

        //    }
        //    else
        //    {
        //        // No file
        //        MessageBox.Show("請選擇圖片檔案");
        //    }
        //}


        protected void Button1_FileUpload(object sender, EventArgs e)
        {

            if (FileUpload1.PostedFile != null)
            {
                string fileExtension = Path.GetExtension(FileUpload1.FileName).ToLower();
                //檢查副檔名 to do
                bool r = CheckPhotoFormat(fileExtension);
                if (r == true)
                {
                    // File was sent
                    HttpPostedFile myFile = FileUpload1.PostedFile;

                    // Get size of uploaded file
                    int nFileLen = myFile.ContentLength;

                    if (FileUpload1.HasFile && nFileLen > 0)
                    {
                        //string picturePath1 = $"/images/FileUpload/" + DateTime.Now.ToString("yyyy_MM_dd_hhmmss_sss") + ".jpg";
                        string picturePath1 = $"/images/UserPicture/" +"_"+ loginstatus + DateTime.Now.ToString("yyyy_MM_dd_hhmmss_sss") + ".jpg";
                        string imgPath = Server.MapPath("~" + picturePath1);
                        FileUpload1.SaveAs(imgPath);
                        //accountImg.ImageUrl = picturePath1;


                        //                    string imgPath = Server.MapPath("~/images/FileUpload/" + DateTime.Now.ToString("yyyy_MM_dd_hhmmss_sss") + ".jpg");
                        //                    FileUpload1.SaveAs(imgPath);
                        //                    accountImg.ImageUrl = imgPath;


                        try
                        {
                            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["CustomersConnectionString"].ConnectionString;
                            SqlConnection connection = new SqlConnection(s_data);
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                            SqlCommand command = new SqlCommand(@"UPDATE Customers
                       SET
                          picture = @picture
                        WHERE account = @account ", connection);
                            command.Parameters.Add("@account", SqlDbType.NVarChar).Value = loginstatus;
                            command.Parameters.Add("@picture", SqlDbType.NVarChar).Value = picturePath1;

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            accountImg.ImageUrl = picturePath1;
                            //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "TEST1", "setTimeout( function(){alert('上傳成功');},200);", true);
                            //MessageBox.Show("上傳成功");

                        }
                        catch (Exception ex)
                        {
                            throw;
                        }


                    }
                    else
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "TEST1", "setTimeout( function(){alert('請選擇圖片檔案');},200);", true);
                        //MessageBox.Show("請選擇圖片檔案");
                    }

                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "TEST1", "setTimeout( function(){alert('請選擇圖片檔案');},200);", true);
                    // No file
                    //MessageBox.Show("請選擇圖片檔案");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        private Boolean CheckPhotoFormat(String fileName)
        {
            //Boolean flag = false;
            String fileExtension = Path.GetExtension(fileName).ToLower();
            String[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };

            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (allowedExtensions[i] == fileExtension)
                {
                    return true;

                    
                }
            }

            return false;
        }


        protected void Button_passTestNumberEntrt(object sender, EventArgs e)
        {
            

            string newMailInput = Request.Form["newMailInput"];
            this.newMailInput2.Text = newMailInput.ToLower();
            bool emailRule = Regex.IsMatch(this.newMailInput2.Text, @"^[a-z0-9_\.-]+\@[\da-z\.-]+\.[a-z\.]{2,6}$");

            if (!string.IsNullOrEmpty(newMailInput))
            {
                if (emailRule == false)
                {
                    //MessageBox.Show("Mail格式錯誤，\n請輸入正確mail''");
                    this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btn", @"setTimeout( function(){alert('Mail格式錯誤，\n請輸入正確mail');},1000);", true);

                }
                else
                {
                    try
                    {
                        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ChatConnectionString"].ConnectionString;
                        SqlConnection connection = new SqlConnection(s_data);
                        string emailCheck = $"select * from Customers where email ='" + this.newMailInput2.Text + "'";
                        SqlCommand Command_email = new SqlCommand(emailCheck, connection);
                        connection.Open();
                        SqlDataReader Reader_email = Command_email.ExecuteReader();
                        if (Reader_email.HasRows)
                        {

                            connection.Close();
                            //MessageBox.Show("該Mail已註冊，\n請輸入其他Mail'");
                            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btn", @"setTimeout( function(){alert('該Mail已註冊，\n請輸入其他Mail');},1000);", true);
                            newMailInput = "";
                            return;
                        }
                        else
                        {
                            connection.Close();


                            Random random = new Random();
                            string keyi = random.Next(100000, 999999).ToString();
                            Session[newMailInput] = keyi.ToString();
                            SendEmail(keyi.ToString(), this.newMailInput2.Text);
                        }

                    }

                    catch (Exception)
                    {

                        throw;

                    }
                }
            }
            else {
                //MessageBox.Show("Mail欄位不得為空，\n請重新輸入您的Mail");
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btn", @"setTimeout( function(){alert('Mail欄位不得為空，\n請重新輸入您的Mail');},1000);", true);
            }




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
            body = @"<html><body><p> 親愛的顧客您好 
                       </p><p>感謝你使用丹丹服飾的自動回信系統，如非本人請無視本系統信件謝謝。</p>
                              <p>您的驗證碼:" + body + "</p></body></html></p><p>祝您有愉快的購物體驗,<br>-丹丹服飾</br></p></body></html>";

            //@"<html><body><p>親愛的 "+ sqlName 
            //                + " 您好,</p><p>感謝你使用丹丹服飾的自動回信系統，如非本人請無視本系統信件謝謝。</p><p>您的帳號為「"+ sqlAcc
            //                + "」</p><p>祝您有愉快的購物體驗,<br>-丹丹服飾</br></p></body></html>";

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
            //MessageBox.Show("驗證碼已寄送至您的Mail");
            this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btn", "setTimeout( function(){alert('驗證碼已寄送至您的Mail');},1000);", true);
        }


        protected void Button_mailEntrt(object sender, EventArgs e)
        {
            string newMailInput = Request.Form["newMailInput"];
            string testNumberMailInput = Request.Form["testNumberMailInput"];

            if (Session[newMailInput] != null && Session[newMailInput].ToString() != "" && Session[newMailInput].ToString() == testNumberMailInput)
            {
                try {
                    // 驗證成功
                    //MessageBox.Show("Mail已修改");
                    //this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btn", "setTimeout( function(){alert('Mail已修改');},200);", true);



                //更新MAIL
                string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ChatConnectionString"].ConnectionString;
                SqlConnection connection = Connect(s_data);

                string sql = $"UPDATE Customers SET email = @email WHERE account = @account ";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = newMailInput;
                command.Parameters.Add("@account", SqlDbType.NVarChar).Value = loginstatus;
                sqlDataAdapter.SelectCommand = command;
                connection.Open();
                //command.ExecuteNonQuery();
                SqlDataReader read = command.ExecuteReader();


                connection.Close();

                    //MessageBox.Show("回覆成功");
                }
                catch(Exception x) {
                    throw;
                }

                this.newMailInput2.Text = "";
                Session.Remove(newMailInput);
            }
            else
            {
                //MessageBox.Show("驗證碼錯誤");
                this.Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "btm", "setTimeout( function(){alert('驗證碼錯誤');},1000);", true);

                // to do 
            }

        }
        public SqlConnection Connect(string x)
        {
            SqlConnection connect = new SqlConnection(x);
            return connect;
        }



    }
}