using Shopping.Models;
using Shopping.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            //Session["loginstatus"] = "Amber";

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
                return common.ThrowResult<List<CustomersModel>>(Enum.ApiStatusEnum.OK, string.Empty, customers);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<List<CustomersModel>>(Enum.ApiStatusEnum.InternalServerError, ex.Message, null);
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
                            MessageBox.Show("密碼修改成功");
                            //正確 執行更新密碼
                        }
                        else
                        {
                            //舊密碼輸入錯誤

                            MessageBox.Show("舊密碼輸入錯誤");
                        }
                    }
                    else
                    {
                        MessageBox.Show("新密碼輸入錯誤");
                    }
                }
                else
                {
                    MessageBox.Show("密碼格式錯誤");
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
                //檢查副檔名 to do

                // File was sent
                HttpPostedFile myFile = FileUpload1.PostedFile;

                // Get size of uploaded file
                int nFileLen = myFile.ContentLength;

                if (FileUpload1.HasFile && nFileLen > 0)
                {
                    string picturePath1 = $"/images/FileUpload/" + DateTime.Now.ToString("yyyy_MM_dd_hhmmss_sss") + ".jpg";
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
                        MessageBox.Show("上傳成功");

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }


                }
                else
                {
                    MessageBox.Show("請選擇圖片檔案");
                }

            }
            else
            {
                // No file
                MessageBox.Show("請選擇圖片檔案");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}