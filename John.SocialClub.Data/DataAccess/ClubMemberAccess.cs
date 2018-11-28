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
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    public class ClubMemberAccess : AccessBase<ClubMemberModel, int, ClubMemberModel.SearchDefinition >
    {
        public ClubMemberAccess() : base(nameof(ClubMemberAccess))
        { }

        private Dictionary<string, Func<ClubMemberModel, object>> properties
            = new Dictionary<string, Func<ClubMemberModel, object>>()
            {
                ["FirstName"] = m => m.FirstName,
                ["MiddleName"] = m => m.MiddleName,
                ["LastName"] = m => m.LastName,
                ["DateOfBirth"] = m => m.DateOfBirth.ToShortDateString(),
                ["Occupation"] = m => (int)m.Occupation,
                ["MaritalStatus"] = m => (int)m.MaritalStatus,
                ["HealthStatus"] = m => (int)m.HealthStatus,
                ["Salary"] = m => m.Salary,
                ["NumberOfChildren"] = m => m.NumberOfChildren
            };

        protected override Dictionary<string, Func<ClubMemberModel, object>> FieldList
            => properties;

        protected override void AddCommonParameters(SqlCommand command, ClubMemberModel model)
        {
            foreach (var propPair in properties)
            {
                command.Parameters.AddWithValue("@" + propPair.Key, propPair.Value(model));
            }
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
