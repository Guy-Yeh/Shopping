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

        //public bool DelOrders(string status, string serial)
        //{
        //    //SqlConnection connection = new SqlConnection(s_data);
        //    //connection.Open();

        //    //SqlTransaction transaction;
        //    //transaction = connection.BeginTransaction("");
        //    //SqlCommand command = connection.CreateCommand();
        //    //command.Transaction = transaction;
        //    try
        //    {
        //        //command.CommandText = "delete from [OrderDetail] where serial = @serial";
        //        //command.Parameters.Add("@serial", SqlDbType.NVarChar).Value = serial;
        //        //command.ExecuteNonQuery();

        //        //command.CommandText = "delete from [Orders] where serial = @serial1";
        //        //command.Parameters.Add("@serial1", SqlDbType.NVarChar).Value = serial;
        //        //command.ExecuteNonQuery();
        //        //transaction.Commit();

        //        SqlConnection connection = new SqlConnection(s_data);
        //        SqlCommand command = new SqlCommand(@"UPDATE Orders
        //               SET
        //                  status = @status
        //                WHERE serial = @serial ", connection);
        //        command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
        //        command.Parameters.Add("@serial", SqlDbType.NVarChar).Value = serial;


        //        connection.Open();
        //        command.ExecuteNonQuery();
        //        command.Dispose();






        //        //關閉與資料庫連接的通道
        //        connection.Close();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //       // transaction.Rollback();
        //        throw;
        //    }


        //}
        public bool DelOrders(string status, string serial)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(s_data);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(@"select * from [dbo].[OrderDetail]
                    where serial = @serialc;", connection);
                command.Parameters.Add("@serialc", SqlDbType.NVarChar).Value = serial;
                sqlDataAdapter.SelectCommand = command;

                //與資料庫連接的通道開啟
                connection.Open();

                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                dt = ds.Tables[0];

                //關閉與資料庫連接的通道
                connection.Close();
            }
            catch (Exception)
            {
                // transaction.Rollback();
                throw;
            }

            // 組裝語法
            string str = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str += @"UPDATE [dbo].[Products]
                    SET inventory = (inventory + " + dt.Rows[i]["qty"].ToString() + @")
                    WHERE productName = N'" + dt.Rows[i]["productName"].ToString() + @"' and category = N'" + dt.Rows[i]["productColor"].ToString() + @"'; ";
            }

            str += @"UPDATE [dbo].[Orders]
                SET [status] = N'取消訂單'
                WHERE serial = @serialc_2";

            //執行更新
            try
            {
                SqlConnection connection = new SqlConnection(s_data);
                SqlCommand command = new SqlCommand(str, connection);
                command.Parameters.Add("@serialc_2", SqlDbType.NVarChar).Value = serial;

                connection.Open();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("");
                command.Transaction = transaction;


                command.ExecuteNonQuery();
                
                transaction.Commit();


                command.Dispose();

                //關閉與資料庫連接的通道
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                //ㄨㄜtransaction.Rollback();
                throw;
            }


        }
    }
}