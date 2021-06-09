using Shopping.Dao;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Service
{
    public class CustomerDetailService : BaseService
    {

        public List<CustomersModel> GetCustomers()
        {
            CustomerDetailDao customerDetailDao = new CustomerDetailDao();
            List<CustomersModel> customers = customerDetailDao.GetCustomers();
            return customers;
        }

        public string EditAccount()
        {
            try
            {
                throw new ArgumentException("驗證錯誤");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}