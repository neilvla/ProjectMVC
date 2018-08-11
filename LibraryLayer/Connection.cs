using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLayer
{
    public class Connection
    {
        static string connectionString = "server=localhost;port=3306;database=agroappbd;uid=root;password=admin123;SslMode=none;";

        public static MySqlConnection getConnection()
        {
            MySqlConnection cn = new MySqlConnection(connectionString);
            cn.Open();

            return cn;
        }
    }
}
