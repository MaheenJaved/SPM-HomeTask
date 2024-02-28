using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PROJECT
{
    class BusinessLayer : CRUD_OPERATION
    {
        public override void InsertOperation(string Query, SqlConnection con)
        {
            DataLayer.InsertData(Query, con);
        }

        public override void updateOperation(string Query, SqlConnection con)
        {
            DataLayer.updateData(Query, con);
        }

        public override void deleteOperation(string Query, SqlConnection con)
        {
            DataLayer.deleteData(Query, con);
        }

        public override DataTable selectOperation(string Query, SqlConnection con)
        {
            return DataLayer.selectData(Query, con);
        }
    }
}
