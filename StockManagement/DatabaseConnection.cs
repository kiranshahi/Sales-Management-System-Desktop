using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System;

namespace SalesManagement
{
   public static class DatabaseConnection
    {
        public static AppSettingsReader aps = new AppSettingsReader();
        public static string connectionStr = aps.GetValue("dbConnection", typeof(string)).ToString();
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionStr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }

        public static DataTable GetTable(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection con = GetConnection())
            {

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdType;

                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;

                }
            }
        }

        public static int InsertData(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection con = GetConnection())
            {

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = cmdType;

                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    try
                    {
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
            }
        }

    }
}