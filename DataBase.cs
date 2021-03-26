using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement
{
    public static class DataBase
    {
        public static string StringConnection = @"Data source=.\SQLEXPRESS; Initial Catalog = HotelManagement; Integrated Security = True";
        public static SqlConnection SqlConnection = new SqlConnection(StringConnection);

        public static object GetQueryValue(string queryText)
        {
            SqlConnection connection = new SqlConnection(StringConnection);
            connection.Open();

            using (SqlCommand sqlCommand = new SqlCommand(queryText, connection))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                object value = sqlDataReader[0];
                sqlDataReader.Close();
                connection.Close();
                return value;
            }
        }
    }
}
