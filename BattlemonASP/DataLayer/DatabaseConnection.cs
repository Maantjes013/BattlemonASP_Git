using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BattlemonASP.DataLayer
{
    class DatabaseConnection
    {
        private static readonly string connectionString = @"Data Source=mssql.fhict.local;Initial Catalog=dbi410764;User ID=dbi410764;Password=Foppedaan1;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            return conn;
        }

        public static void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }
    }
}
