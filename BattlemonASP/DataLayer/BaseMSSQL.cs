using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.DataLayer
{
    public class BaseMSSQL
    {
        private static readonly string connectionString = @"Data Source=mssql.fhict.local;Initial Catalog=dbi390337;Persist Security Info=True;User ID=dbi390337;Password=willemII";


        static public DataSet ExecuteSql(string sql, List<KeyValuePair<string, string>> parameters)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = conn.CreateCommand();

                foreach (KeyValuePair<string, string> kvp in parameters)
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@" + kvp.Key;
                    param.Value = kvp.Value;
                    cmd.Parameters.Add(param);
                }

                cmd.CommandText = sql;
                da.SelectCommand = cmd;

                conn.Open();
                da.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("The following error occured: " + ex.GetType().Name + ".");
                return null;
            }

            return ds;
        }
    }
}
