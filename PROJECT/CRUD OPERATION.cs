using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    abstract class CRUD_OPERATION
    {
        public abstract void InsertOperation(String Query, SqlConnection con);
        public abstract void updateOperation(String Query, SqlConnection con);
        public abstract void deleteOperation(String Query, SqlConnection con);
        public abstract DataTable selectOperation(String Query, SqlConnection con);

    }
}
