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
    public partial class ShoppingList : System.Web.UI.Page
    {
        public static string loginstatus = "";
        protected void Page_Load(object sender, EventArgs e)
        {
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

        [WebMethod]
        public static Models.ApiResultModel<List<ShoppingListModel>> GetOrders()
        {
            Common.Common common = new Common.Common();
            try
            {
                OrdersService ordersService = new OrdersService();
                List<ShoppingListModel> orders = ordersService.GetOrders(loginstatus);

                return common.ThrowResult<List<ShoppingListModel>>(Enum.ApiStatusEnum.OK, string.Empty, orders);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<List<ShoppingListModel>>(Enum.ApiStatusEnum.InternalServerError, ex.Message, null);
            }
        }

        [WebMethod]
        public static Models.ApiResultModel<bool> DelOrders(string status,string serial)
        {
            Common.Common common = new Common.Common();
            try
            {
                OrdersService ordersService = new OrdersService();
                bool orders = ordersService.DelOrders(status,serial);

                return common.ThrowResult<bool>(Enum.ApiStatusEnum.OK, string.Empty, orders);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<bool>(Enum.ApiStatusEnum.InternalServerError, ex.Message, false);
            }
        }
    }
}