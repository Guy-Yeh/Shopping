using Shopping.Dao;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Service
{
    public class OrdersService : BaseService
    {
        public List<OrdersModel> GetOrders()
        {
            OrdersDao ordersDao = new OrdersDao();
            List<OrdersModel> orders = ordersDao.GetOrders();
            return orders;
        }

        
    }
}