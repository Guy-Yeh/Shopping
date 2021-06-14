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
    public class OrdersDao : BaseDao
    {
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;

        public List<OrdersModel> GetOrders()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(s_data);
            //SqlCommand command = new SqlCommand($"select * from Customers", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select * from Orders", connection);


            //與資料庫連接的通道開啟
            connection.Open();

            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dt = ds.Tables[0];

            //關閉與資料庫連接的通道
            connection.Close();

            var ordersModel = dt.ToList<OrdersModel>();
            List<OrdersModel> orders = ordersModel.ToList<OrdersModel>();

            return orders;
        }
    }
}