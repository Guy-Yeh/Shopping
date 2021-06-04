using Shopping.Models;
using Shopping.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

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

    }
}