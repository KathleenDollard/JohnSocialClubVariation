// -----------------------------------------------------------------------
// <copyright file="ClubMemberAccess.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.DataAccess
{
    using DataUtils;
    using John.SocialClub.Data.DataModel;
    using John.SocialClub.Data.Sql;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class ClubMemberAccess : AccessBase<ClubMemberModel>
    {
        protected override void AddCommonParameters(SqlCommand c, ClubMemberModel m)
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

        protected override void FillSearchParams(SqlDataAdapter dataAdapter)
        {
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Occupation", occupation ?? DBNull.Value);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@MaritalStatus", maritalStatus ?? DBNull.Value);

        }
    }
}
