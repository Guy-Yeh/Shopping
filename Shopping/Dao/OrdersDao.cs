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

        public List<ShoppingListModel> GetOrders(string account)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(s_data);
            //SqlCommand command = new SqlCommand($"select * from Customers", connection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT 
            //  a.serial, a.customerAccount, a.name, a.phone, a.address, a.totalPrice, a.status, a.initdate,
            //  b.productPicture, b.productName, b.productColor, productPrice, b.qty
            //  FROM [Orders] as a
            //  JOIN [OrderDetail] as b
            //  on a.serial = b.serial 
            //  order by a.initdate desc;", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(@"SELECT 
              a.serial, a.customerAccount, a.name, a.phone, a.address, a.totalPrice, a.status, a.initdate,
              b.productPicture, b.productName, b.productColor, productPrice, b.qty
              FROM [Orders] as a
              JOIN [OrderDetail] as b
              on a.serial = b.serial 
              where a.customerAccount = @account
              order by a.initdate desc;", connection);
            command.Parameters.Add("@account", SqlDbType.NVarChar).Value = account;
            sqlDataAdapter.SelectCommand = command;



            //與資料庫連接的通道開啟
            connection.Open();

            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dt = ds.Tables[0];

            //關閉與資料庫連接的通道
            connection.Close();

            var ordersModel = dt.ToList<ShoppingListModel>();
            List<ShoppingListModel> orders = ordersModel.ToList<ShoppingListModel>();

            return orders;
        }

        //public bool DelOrders(string serial)
        //{
        //    SqlConnection connection = new SqlConnection(s_data);
        //    connection.Open();

        //    SqlTransaction transaction;
        //    transaction = connection.BeginTransaction("Transaction");
        //    SqlCommand command = connection.CreateCommand();
        //    command.Transaction = transaction;
        //    try
        //    {
        //        command.CommandText = "delete from [Orders] where serial = @serial";
        //        command.Parameters.Add("@serial", SqlDbType.NVarChar).Value = serial;
        //        command.ExecuteNonQuery();

        //        command.CommandText = "delete from [OrderDetail] where serial = @serial";
        //        command.Parameters.Add("@serial", SqlDbType.NVarChar).Value = serial;
        //        command.ExecuteNonQuery();



        //        transaction.Commit();

        //        //關閉與資料庫連接的通道
        //        connection.Close();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        transaction.Rollback();
        //        throw;
        //    }


        //}

        public bool DelOrders(string serial)
        {
            SqlConnection connection = new SqlConnection(s_data);
            connection.Open();

            SqlTransaction transaction;
            transaction = connection.BeginTransaction("");
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            try
            {
                command.CommandText = "delete from [OrderDetail] where serial = @serial";
                command.Parameters.Add("@serial", SqlDbType.NVarChar).Value = serial;
                command.ExecuteNonQuery();

                command.CommandText = "delete from [Orders] where serial = @serial1";
                command.Parameters.Add("@serial1", SqlDbType.NVarChar).Value = serial;
                command.ExecuteNonQuery();

                


                transaction.Commit();

                //關閉與資料庫連接的通道
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }


        }
    }
}