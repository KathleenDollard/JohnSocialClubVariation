using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUtils
{
    public static class AccessTools
    {
        public static DataTable GetAll(string script, string connectionString)
        {
            var dataTable = new DataTable();
            using (var dataAdapter = new SqlDataAdapter(script, connectionString))
            {
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

    }
}
