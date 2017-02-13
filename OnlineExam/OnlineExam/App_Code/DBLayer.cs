using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for DBLayer
/// </summary>
public class DBLayer
{
    
         public static DataTable SelectData(string stored, params SqlParameter[] pars)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["online"].ConnectionString);
        SqlCommand command = new SqlCommand(stored, connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddRange(pars);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        return dataTable;

    }
    public static int DmlOperation(string stored, params SqlParameter[] pars)
    {
        SqlConnection connection = new SqlConnection();
        int rowEffect;
        try
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["online"].ConnectionString;
            SqlCommand command = new SqlCommand(stored, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(pars);
            connection.Open();
            rowEffect = command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {

            throw;
        }
        finally
        {
            connection.Close();
        }

        return rowEffect;
    }
    public static DataTable seldata(string query)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["online"].ConnectionString);
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        return dt;
    }



}
   