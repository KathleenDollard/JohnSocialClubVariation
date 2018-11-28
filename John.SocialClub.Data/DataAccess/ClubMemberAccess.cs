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
    using DataUtils;

    public class ClubMemberAccess : ConnectionAccess, IClubMemberAccess
    {
        public DataTable GetAllClubMembers() 
            => AccessTools.GetAll(Scripts.SqlGetAllClubMembers, ConnectionString);

        public DataRow GetClubMemberById(int id) 
            => AccessTools.GetById(Scripts.sqlGetClubMemberById, ConnectionString, id);

        public DataTable SearchClubMembers(object occupation, object maritalStatus, string operand) 
            => AccessTools.Search(string.Format(Scripts.SqlSearchClubMembers, operand), ConnectionString,
                da =>
                {
                    da.SelectCommand.Parameters.AddWithValue("@Occupation", occupation ?? DBNull.Value);
                    da.SelectCommand.Parameters.AddWithValue("@MaritalStatus", maritalStatus ?? DBNull.Value);
                });

        public bool AddClubMember(ClubMemberModel clubMember)
        {
            using (var sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = new SqlConnection(ConnectionString);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = Scripts.SqlInsertClubMember;

                sqlCommand.Parameters.AddWithValue("@FirstName", clubMember.FirstName);
                sqlCommand.Parameters.AddWithValue("@MiddleName", clubMember.MiddleName);
                sqlCommand.Parameters.AddWithValue("@LastName", clubMember.LastName);
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", clubMember.DateOfBirth.ToShortDateString());
                sqlCommand.Parameters.AddWithValue("@Occupation", (int)clubMember.Occupation);
                sqlCommand.Parameters.AddWithValue("@MaritalStatus", (int)clubMember.MaritalStatus);
                sqlCommand.Parameters.AddWithValue("@HealthStatus", (int)clubMember.HealthStatus);
                sqlCommand.Parameters.AddWithValue("@Salary", clubMember.Salary);
                sqlCommand.Parameters.AddWithValue("@NumberOfChildren", clubMember.NumberOfChildren);

                sqlCommand.Connection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public bool UpdateClubMember(ClubMemberModel clubMember)
        {
            using (var dbCommand = new SqlCommand())
            {
                dbCommand.Connection = new SqlConnection(ConnectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = Scripts.sqlUpdateClubMember;

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

                dbCommand.Connection.Open();
                int rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public bool DeleteClubMember(int id)
        {
            using (var dbCommand = new SqlCommand())
            {
                dbCommand.Connection = new SqlConnection(ConnectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = Scripts.sqlDeleteClubMember;

                dbCommand.Parameters.AddWithValue("@Id", id);

                dbCommand.Connection.Open();
                int rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}
