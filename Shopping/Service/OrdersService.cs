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
        public List<ShoppingListModel> GetOrders(string account)
        {
            OrdersDao ordersDao = new OrdersDao();
            List<ShoppingListModel> orders = ordersDao.GetOrders(account);
            return orders;
        }

        public bool DelOrders(string status,string serial)
        {
            OrdersDao ordersDao = new OrdersDao();
            bool orders = ordersDao.DelOrders(status,serial);
            return true;
        }


    }
}