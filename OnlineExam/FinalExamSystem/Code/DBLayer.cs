using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using OnlineExam.Code;
using System.IO;

namespace OnlineExam
{
    public class DBLayer
    {
        public static DataTable SelectData(string stored,params SqlParameter[] pars)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["online"].ConnectionString);
                SqlCommand command = new SqlCommand(stored, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (pars != null)
                {
                    command.Parameters.AddRange(pars);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
               
                adapter.Fill(dataTable);
                
            }
            catch (Exception ex)
            {

                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), "DBLayer", "DmlOperation");

            }
            finally
            {

            }
            return dataTable;

        }
        public static int DmlOperation(string stored, params SqlParameter[] pars)
        {
            SqlConnection connection = new SqlConnection();
            int rowEffect=-1;
            try
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["online"].ConnectionString;
                SqlCommand command = new SqlCommand(stored, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (pars != null)
                {
                    command.Parameters.AddRange(pars);
                }
                connection.Open();
                rowEffect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(),"DBLayer" , "DmlOperation");

            }
            finally
            {
                connection.Close();
            }

            return rowEffect;
        }
        public static SqlDataReader SelectWithDml(string stored, params SqlParameter[] pars)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataReader dataReader = null;
            try
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["online"].ConnectionString;
                SqlCommand command = new SqlCommand(stored, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(pars);
                connection.Open();
                dataReader = command.ExecuteReader();
                
            }
            catch (Exception ex)
            {

                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), "DBLayer", "DmlOperation");

            }
            finally
            {
                connection.Close();
            }
            return dataReader;
        }



    }
}