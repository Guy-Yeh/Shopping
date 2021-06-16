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

        public List<CustomersModel> GetCustomers(string account)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(s_data);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand($"SELECT * FROM [dbo].[Customers] WHERE account = @account;", connection);
            command.Parameters.Add("@account", SqlDbType.NVarChar).Value = account;
            sqlDataAdapter.SelectCommand = command;
      

          
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool EditName(int id, string name)
        {
            try {
                SqlConnection connection = new SqlConnection(s_data);
                SqlCommand command = new SqlCommand(@"UPDATE Customers
                       SET
                          name = @name
                        WHERE ID = @id ", connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public bool EditPhoneNumber(int id, string phone)
        {

            //throw new ArgumentException("驗證錯誤");

            try
            {
                SqlConnection connection = new SqlConnection(s_data);
                SqlCommand command = new SqlCommand(@"UPDATE Customers
                       SET
                          phone = @phone
                        WHERE ID = @id ", connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;

                connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                return true;
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
                SqlConnection connection = new SqlConnection(s_data);
                SqlCommand command = new SqlCommand(@"UPDATE Customers
                       SET
                          address = @address
                        WHERE ID = @id ", connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;

                connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                return true;
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
        //        SqlConnection connection = new SqlConnection(s_data);
        //        SqlCommand command = new SqlCommand(@"UPDATE Customers
        //               SET
        //                  picture = @picture
        //                WHERE ID = @id ", connection);
        //        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        //        command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = picture;

        //        connection.Open();
        //        command.ExecuteNonQuery();
        //        command.Dispose();
        //        connection.Close();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        public bool CheckPassword(string account,string oldPwd)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(s_data);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"SELECT password FROM [dbo].[Customers] WHERE account = @account and password = @oldPwd;", connection);
                command.Parameters.Add("@account", SqlDbType.NVarChar).Value = account;
                command.Parameters.Add("@oldPwd", SqlDbType.NVarChar).Value = oldPwd;
                sqlDataAdapter.SelectCommand = command;

                //與資料庫連接的通道開啟
                connection.Open();

                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                dt = ds.Tables[0];

                //關閉與資料庫連接的通道
                connection.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        
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
                SqlConnection connection = new SqlConnection(s_data);
                SqlCommand command = new SqlCommand(@"UPDATE Customers SET password = @password WHERE account = @account ", connection);
                command.Parameters.Add("@account", SqlDbType.NVarChar).Value = account;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = reNewPwd;

                connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}