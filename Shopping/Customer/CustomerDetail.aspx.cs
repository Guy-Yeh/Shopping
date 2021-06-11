using Shopping.Models;
using Shopping.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Shopping.Customer
{
    public partial class CustomerDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                List<CustomersModel> customers = customerDetailService.GetCustomers();

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
        public static bool EditPassword()
        {
            return true;
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
                    string imgPath = Server.MapPath("/images/FileUpload/" + DateTime.Now.ToString("yyyy_MM_dd_hhmmss_sss") + ".jpg");
                    FileUpload1.SaveAs(imgPath);
                    MessageBox.Show("上傳成功");
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