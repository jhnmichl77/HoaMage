using System;
using System.Data;
using System.Data.OleDb;

public static class DatabaseHelper
{
    public static readonly string myConn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\johnm\OneDrive\Documents\HoaMageDB.accdb;";

    public static DataSet ExecuteQuery(string query)
    {
        using (OleDbConnection connection = new OleDbConnection(myConn))
        {
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }
    }
    public static int ExecuteNonQuery(string query)
    {
        using (OleDbConnection connection = new OleDbConnection(myConn))
        {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                return command.ExecuteNonQuery();
            }
        }
    }
    public static bool TestConnection()
    {
        try
        {
            using (OleDbConnection connection = new OleDbConnection(myConn))
            {
                connection.Open();
                return true; 
            }
        }
        catch (Exception)
        {
            return false; 
        }
    }
}
