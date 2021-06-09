using Shopping.Common;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Shopping.Dao
{
    public class CustomerDetailDao : BaseDao
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;

        public List<CustomersModel> GetCustomers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(s_data);
            //SqlCommand command = new SqlCommand($"select * from Customers", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select * from Customers", connection);


            //與資料庫連接的通道開啟
            connection.Open();

            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dt = ds.Tables[0];

            //關閉與資料庫連接的通道
            connection.Close();

            var customersModel = dt.ToList<CustomersModel>();
            List<CustomersModel> customers = customersModel.ToList<CustomersModel>();

            return customers;
        }
    }
}