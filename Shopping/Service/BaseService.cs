using Shopping.Dao;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Service
{
    public class BaseService
    {
        //public bool GetCustomer(string account,string access)
        //{
        //    try
        //    {
        //        BaseDao baseDao = new BaseDao();

        //        return baseDao.GetCustomer(account, access);


        //    }
        //    catch {
        //        throw new ArgumentException("請先登入");
        //    }



        //}
        public string auth = "";

        public BaseService()
        {

        }

        public void Auth()
        {
            try
            {

                //BaseDao baseDao = new BaseDao();
                //List<CustomersModel> customer = BaseDao.GetCustomer(loginstatus);
                if (string.IsNullOrEmpty(auth))
                {
                    throw new ArgumentException("驗證錯誤");
                }
                else
                {

                }
            }
            catch
            {
                throw new ArgumentException("驗證錯誤");
            }
        }
    }
}