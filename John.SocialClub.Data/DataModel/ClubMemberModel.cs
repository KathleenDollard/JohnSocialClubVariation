// -----------------------------------------------------------------------
// <copyright file="ClubMemberModel.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.DataModel
{
    using System;
    using DataUtils;
    using John.SocialClub.Data.Enum;

    public class ClubMemberModel : IHasPrimaryKey<int>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Occupation Occupation { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public HealthStatus HealthStatus { get; set; }
        public decimal Salary { get; set; }
        public int NumberOfChildren { get; set; }
    }
}
