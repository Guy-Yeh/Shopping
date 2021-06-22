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
    public class indexDao : BaseDao
    {
        string product_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;

        public List<indexModel> indexproduct()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(product_data);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(@"SELECT 
              picture,productName,price,category
              FROM Products ", connection);
            sqlDataAdapter.SelectCommand = command;
            //與資料庫連接的通道開啟
            connection.Open();
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dt = ds.Tables[0];
            //關閉與資料庫連接的通道
            connection.Close();
            var indexModel = dt.ToList<indexModel>();
            List<indexModel> orders = indexModel.ToList<indexModel>();
            return orders;
        }        
    }
}