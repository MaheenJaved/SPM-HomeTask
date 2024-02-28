using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class SQL
    {
        public static SqlConnection Sqlconnection()
        {
            return new SqlConnection(@"Data Source=MAHEEN-JAVED;Initial Catalog=Hospital;Integrated Security=True");
        }
        public static void Insert(string Query, SqlConnection con)
        {
            BusinessLayer sql = new BusinessLayer();
            sql.InsertOperation(Query, con);
        }
        public static void Update(string Query, SqlConnection con)
        {
            BusinessLayer sql = new BusinessLayer();
            sql.updateOperation(Query, con);
        }
        public static void Delete(string Query, SqlConnection con)
        {
            BusinessLayer sql = new BusinessLayer();
            sql.deleteOperation(Query, con);
        }
        public static DataTable select(string Query, SqlConnection con)
        {
            BusinessLayer sql = new BusinessLayer();
            return sql.selectOperation(Query, con);
        }
    }
}
