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
            => AccessTools.Add(Scripts.SqlUpdateClubMember, ConnectionString, 
                clubMember,  AddCommonParameters);

        private static void AddCommonParameters(SqlCommand c, ClubMemberModel m)
        {
            c.Parameters.AddWithValue("@FirstName", m.FirstName);
            c.Parameters.AddWithValue("@MiddleName", m.MiddleName);
            c.Parameters.AddWithValue("@LastName", m.LastName);
            c.Parameters.AddWithValue("@DateOfBirth", m.DateOfBirth.ToShortDateString());
            c.Parameters.AddWithValue("@Occupation", (int)m.Occupation);
            c.Parameters.AddWithValue("@MaritalStatus", (int)m.MaritalStatus);
            c.Parameters.AddWithValue("@HealthStatus", (int)m.HealthStatus);
            c.Parameters.AddWithValue("@Salary", m.Salary);
            c.Parameters.AddWithValue("@NumberOfChildren", m.NumberOfChildren);
        }

        public bool UpdateClubMember(ClubMemberModel clubMember)
               => AccessTools.Update(Scripts.SqlUpdateClubMember, ConnectionString, clubMember,
                (c, m) =>
                {
                    AddCommonParameters(c, m);
                    c.Parameters.AddWithValue("@Id", clubMember.Id);
                });

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
