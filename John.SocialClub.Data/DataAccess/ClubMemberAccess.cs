// -----------------------------------------------------------------------
// <copyright file="ClubMemberAccess.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.DataAccess
{
    using DataUtils;
    using John.SocialClub.Data.DataModel;
    using System;
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

        protected override void FillSearchParams(SqlDataAdapter dataAdapter,
            ISearchDefinition<ClubMemberModel> searchDef)
        {
            if (!(searchDef is ClubMemberModel.SearchDefinition clubMemberSearchDef ))
            {
                throw new InvalidOperationException("Internal error: Invalid search definitio");
            }
            if (clubMemberSearchDef.Occupation.HasValue)
            {
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Occupation", clubMemberSearchDef.Occupation);
            }
            if (clubMemberSearchDef.MaritalStatus.HasValue)
            {
                dataAdapter.SelectCommand.Parameters.AddWithValue("@MaritalStatus", clubMemberSearchDef.MaritalStatus);
            }

        }
    }
}
