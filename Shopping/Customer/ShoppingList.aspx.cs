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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static Models.ApiResultModel<List<OrdersModel>> GetOrders()
        {
            Common.Common common = new Common.Common();
            try
            {
                OrdersService ordersService = new OrdersService();
                List<OrdersModel> orders = ordersService.GetOrders();

                return common.ThrowResult<List<OrdersModel>>(Enum.ApiStatusEnum.OK, string.Empty, orders);
            }
            catch (Exception ex)
            {
                return common.ThrowResult<List<OrdersModel>>(Enum.ApiStatusEnum.InternalServerError, ex.Message, null);
            }
        }
    }
}