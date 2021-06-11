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

        public bool EditName(int id, string name)
        {
            try
            {
                //throw new ArgumentException("驗證錯誤");
                CustomerDetailDao customerDetailDao = new CustomerDetailDao();
                return customerDetailDao.EditName(id, name);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool EditPhoneNumber(int id, string phone)
        {
            try
            {
                //throw new ArgumentException("驗證錯誤");
                CustomerDetailDao customerDetailDao = new CustomerDetailDao();
                return customerDetailDao.EditPhoneNumber(id, phone);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //public bool EditPicture(int id, string picture)
        //{
        //    try
        //    {

        //        CustomerDetailDao customerDetailDao = new CustomerDetailDao();
        //        return customerDetailDao.EditPicture(id, picture);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

    }
}