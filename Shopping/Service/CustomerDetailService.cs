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
        public CustomerDetailService(string _loginstatus) {
            auth = _loginstatus;
        }

        public List<CustomersModel> GetCustomers(string account)
        {
            Auth();
            CustomerDetailDao customerDetailDao = new CustomerDetailDao();
            List<CustomersModel> customers = customerDetailDao.GetCustomers(account);
            return customers;
        }


        public bool DelAccount(string account, string access)
        {
            try
            {
                //throw new ArgumentException("驗證錯誤");
                CustomerDetailDao customerDetailDao = new CustomerDetailDao();
                return customerDetailDao.DelAccount(account, access);
            }
            catch (Exception ex)
            {
                throw;
            }
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


        public bool EditAddress(int id, string address)
        {
            try
            {
                //throw new ArgumentException("驗證錯誤");
                CustomerDetailDao customerDetailDao = new CustomerDetailDao();
                return customerDetailDao.EditAddress(id, address);
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

        public bool CheckPassword(string account, string oldPwd)
        {
            try
            {
                CustomerDetailDao customerDetailDao = new CustomerDetailDao();
                return customerDetailDao.CheckPassword(account, oldPwd);
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool EditPassword1(string account, string reNewPwd)
        {
            try
            {
                CustomerDetailDao customerDetailDao = new CustomerDetailDao();
                return customerDetailDao.EditPassword1(account, reNewPwd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}