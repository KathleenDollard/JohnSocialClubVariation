using System;
using System.Data;
using System.Data.SqlClient;

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

        public static DataRow GetById<T>(string script, string connectionString, T id)
            where T : struct
        {
            var dataTable = new DataTable();
            using (var dataAdapter = new SqlDataAdapter(script, connectionString))
            {
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Id", id);
                dataAdapter.Fill(dataTable);
                DataRow dataRow = dataTable.Rows.Count > 0
                    ? dataTable.Rows[0]
                    : null;
                return dataRow;
            }
        }

        public static DataTable Search(string script, string connectionString, Action<SqlDataAdapter> fillParams)
        {
            var dataTable = new DataTable();
            using (var dataAdapter = new SqlDataAdapter(script, connectionString))
            {
                fillParams(dataAdapter);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
