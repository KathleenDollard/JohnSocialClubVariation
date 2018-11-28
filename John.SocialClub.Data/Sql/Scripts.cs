// -----------------------------------------------------------------------
// <copyright file="Scripts.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.Sql
{
    public static class Scripts
    {
        public static readonly string sqlGetClubMemberById = "Select" +
            " Id, FirstName, MiddleName, LastName, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember Where Id = @Id";

        public static readonly string SqlGetAllClubMembers = "Select" +
            " Id, FirstName, MiddleName, LastName,  DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember";

        public static readonly string SqlUpdateClubMember = "Insert Into" +
            " ClubMember( FirstName, MiddleName, LastName,  DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren)" +
            " Values(@FirstName, @MiddleName, @LastName,  @DateOfBirth, @Occupation, @MaritalStatus, @HealthStatus, @Salary, @NumberOfChildren)";

        public static readonly string SqlSearchClubMembers = "Select " +
            " Id, FirstName, MiddleName, LastName,  DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember Where (@Occupation Is NULL OR @Occupation = Occupation) {0}" +
            " (@MaritalStatus Is NULL OR @MaritalStatus = MaritalStatus)";

        public static readonly string sqlUpdateClubMember = "Update ClubMember " +
            " Set [FirstName] = @FirstName,[MiddleName] = @MiddleName, [LastName] = @LastName,  [DateOfBirth] = @DateOfBirth, [Occupation] = @Occupation, [MaritalStatus] = @MaritalStatus, " +
            " [HealthStatus] = @HealthStatus, [Salary] = @Salary, [NumberOfChildren] = @NumberOfChildren Where ([Id] = @Id)";

        public static readonly string sqlDeleteClubMember = "Delete From ClubMember Where (Id = @Id)";
    }
}
