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

        public static DataRow GetById<TKey>(string script, string connectionString, TKey id)
            where TKey : struct
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

        public static DataTable Search<TModel, TSearchDef>(string script, string connectionString, 
            TSearchDef searchDef, Action<SqlDataAdapter, TSearchDef> fillParams)
            where TSearchDef : ISearchDefinition<TModel>
        {
            var dataTable = new DataTable();
            using (var dataAdapter = new SqlDataAdapter(script, connectionString))
            {
                fillParams(dataAdapter, searchDef);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static bool Add<TModel>(string script, string connectionString, 
            TModel model, Action<SqlCommand, TModel> fillParams)
        {
            using (var sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = new SqlConnection(connectionString);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = script;

                fillParams(sqlCommand, model);

                sqlCommand.Connection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public static bool Update<T, TKey>(string script, string connectionString, 
                T model, Action<SqlCommand, T> fillParams)
            where TKey : struct
            where T : IHasPrimaryKey<TKey>
        {
            using (var sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = new SqlConnection(connectionString);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = script;

                fillParams(sqlCommand, model);
                sqlCommand.Parameters.AddWithValue("@Id", model.Id);

                sqlCommand.Connection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public static bool Delete(string script, string connectionString, int id)
        {
            using (var sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = new SqlConnection(connectionString);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = script;

                sqlCommand.Parameters.AddWithValue("@Id", id);

                sqlCommand.Connection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}
