﻿using Microsoft.Data.SqlClient;

namespace Library.DataAccess.Concrete.ADONET
{
    public class VTYS
    {
        private static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static bool SqlExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static SqlDataReader SqlExecuteReader(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            cmd.Connection = conn;
            return cmd.ExecuteReader();
        }
    }
}
