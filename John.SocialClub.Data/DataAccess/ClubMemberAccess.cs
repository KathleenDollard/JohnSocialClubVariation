// -----------------------------------------------------------------------
// <copyright file="ClubMemberAccess.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.DataAccess
{
    using John.SocialClub.Data.DataModel;
    using John.SocialClub.Data.Sql;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Data access class for ClubMember table
    /// </summary>
    public class ClubMemberAccess : ConnectionAccess, IClubMemberAccess
    {
        /// <summary>
        /// Method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAllClubMembers()
        {
            var dataTable = new DataTable();

            using (var dataAdapter = new SqlDataAdapter(Scripts.SqlGetAllClubMembers, ConnectionString))
            {

                // Fill the datatable from adapter
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Method to get club member by Id
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>Data row</returns>
        public DataRow GetClubMemberById(int id)
        {
            var dataTable = new DataTable();
            DataRow dataRow;

            using (var dataAdapter = new SqlDataAdapter(Scripts.sqlGetClubMemberById, ConnectionString))
            {
                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Id", id);

                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                // Get the datarow from the table
                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }

        /// <summary>
        /// Method to search club members by multiple parameters
        /// </summary>
        /// <param name="occupation">occupation value</param>
        /// <param name="maritalStatus">marital status</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        public DataTable SearchClubMembers(object occupation, object maritalStatus, string operand)
        {
            var dataTable = new DataTable();

            using (var sqlDataAdapter = new SqlDataAdapter())
            {
                // Create the command and set its properties
                sqlDataAdapter.SelectCommand = new SqlCommand
                {
                    Connection = new SqlConnection(ConnectionString),
                    CommandType = CommandType.Text,

                    // Assign the SQL to the command object
                    CommandText = string.Format(Scripts.SqlSearchClubMembers, operand)
                };

                // Add the input parameters to the parameter collection
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Occupation", occupation == null ? DBNull.Value : occupation);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaritalStatus", maritalStatus == null ? DBNull.Value : maritalStatus);

                // Fill the table from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Method to add new member
        /// </summary>
        /// <param name="clubMember">club member model</param>
        /// <returns>true or false</returns>
        public bool AddClubMember(ClubMemberModel clubMember)
        {
            using (var sqlCommand = new SqlCommand())
            {
                // Set the command object properties
                sqlCommand.Connection = new SqlConnection(ConnectionString);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = Scripts.SqlInsertClubMember;

                // Add the input parameters to the parameter collection
                sqlCommand.Parameters.AddWithValue("@FirstName", clubMember.FirstName);
                sqlCommand.Parameters.AddWithValue("@MiddleName", clubMember.MiddleName);
                sqlCommand.Parameters.AddWithValue("@LastName", clubMember.LastName);
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", clubMember.DateOfBirth.ToShortDateString());
                sqlCommand.Parameters.AddWithValue("@Occupation", (int)clubMember.Occupation);
                sqlCommand.Parameters.AddWithValue("@MaritalStatus", (int)clubMember.MaritalStatus);
                sqlCommand.Parameters.AddWithValue("@HealthStatus", (int)clubMember.HealthStatus);
                sqlCommand.Parameters.AddWithValue("@Salary", clubMember.Salary);
                sqlCommand.Parameters.AddWithValue("@NumberOfChildren", clubMember.NumberOfChildren);

                // Open the connection, execute the query and close the connection
                sqlCommand.Connection.Open();
                var rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        /// <summary>
        /// Method to update club member
        /// </summary>
        /// <param name="clubMember">club member</param>
        /// <returns>true / false</returns>
        public bool UpdateClubMember(ClubMemberModel clubMember)
        {
            using (var dbCommand = new SqlCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new SqlConnection(ConnectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = Scripts.sqlUpdateClubMember;

                // Add the input parameters to the parameter collection
                dbCommand.Parameters.AddWithValue("@FirstName", clubMember.FirstName);
                dbCommand.Parameters.AddWithValue("@MiddleName", clubMember.MiddleName);
                dbCommand.Parameters.AddWithValue("@LastName", clubMember.LastName);
                dbCommand.Parameters.AddWithValue("@DateOfBirth", clubMember.DateOfBirth.ToShortDateString());
                dbCommand.Parameters.AddWithValue("@Occupation", (int)clubMember.Occupation);
                dbCommand.Parameters.AddWithValue("@MaritalStatus", (int)clubMember.MaritalStatus);
                dbCommand.Parameters.AddWithValue("@HealthStatus", (int)clubMember.HealthStatus);
                dbCommand.Parameters.AddWithValue("@Salary", clubMember.Salary);
                dbCommand.Parameters.AddWithValue("@NumberOfChildren", clubMember.NumberOfChildren);
                dbCommand.Parameters.AddWithValue("@Id", clubMember.Id);

                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        /// <summary>
        /// Method to delete a club member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        public bool DeleteClubMember(int id)
        {
            using (var dbCommand = new SqlCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new SqlConnection(ConnectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = Scripts.sqlDeleteClubMember;

                // Add the input parameter to the parameter collection
                dbCommand.Parameters.AddWithValue("@Id", id);

                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}
