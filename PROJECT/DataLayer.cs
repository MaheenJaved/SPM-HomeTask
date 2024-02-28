using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class DataLayer
    {
        public static void InsertData(String Query, SqlConnection con)
        {
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable selectData(String Query, SqlConnection con)
        {
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static void updateData(String Query, SqlConnection con)
        {
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
        public static void deleteData(String Query, SqlConnection con)
        {
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}
