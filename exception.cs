using System;

namespace exception_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Data Source=(local); Intergrated Security = true;";
            string sql = "SELECT COUNT(1) FROM sys.objects";
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                sqlCommand cmd = new SqlCommand(sql, conn);
                object count = cmd.ExecuteScalar();
                Console.WriteLine(count);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
    }
}
