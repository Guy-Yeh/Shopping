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
        public static string ajaxTest0()
        {
            CustomerDetailService customerDetailService = new CustomerDetailService();
            customerDetailService.ajaxTest0();

            return "Hi,Welcome to China!";
        }
    }
}