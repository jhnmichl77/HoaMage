using System;
using MySql.Data.MySqlClient;

public class DatabaseHelper
{
    private const string ConnectionString = "server=your_server;database=hoa_db;user=your_user;password=your_password;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(ConnectionString);
    }
}
