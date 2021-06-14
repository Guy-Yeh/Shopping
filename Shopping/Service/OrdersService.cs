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
        public List<ShoppingListModel> GetOrders()
        {
            OrdersDao ordersDao = new OrdersDao();
            List<ShoppingListModel> orders = ordersDao.GetOrders();
            return orders;
        }

        public bool DelOrders(string serial)
        {
            OrdersDao ordersDao = new OrdersDao();
            bool orders = ordersDao.DelOrders(serial);
            return true;
        }


    }
}