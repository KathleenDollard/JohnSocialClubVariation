// -----------------------------------------------------------------------
// <copyright file="ClubMemberService.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.BusinessService
{
    using John.SocialClub.Data.DataAccess;
    using John.SocialClub.Data.DataModel;
    using John.SocialClub.Data.Enum;
    using System;
    using System.Data;

    public class ClubMemberService : IClubMemberService
    {
        private ClubMemberAccess memberAccess;

        public ClubMemberService()
            => memberAccess = new ClubMemberAccess();

        public DataRow GetClubMemberById(int id)
            => memberAccess.GetById(id);

        public DataTable GetAllClubMembers()
            => memberAccess.GetAll();

        public DataTable SearchClubMembers(object occupation, object maritalStatus, string operand)
            => memberAccess.Search(new ClubMemberModel.SearchDefinition()
            {
                Occupation = occupation is Occupation 
                            ? (Occupation)occupation
                            : throw new InvalidOperationException(),
                MaritalStatus = maritalStatus is MaritalStatus
                            ? (MaritalStatus)maritalStatus
                            : throw new InvalidOperationException()
            },  operand);

        /// <summary>
        /// Service method to create new member
        /// </summary>
        /// <param name="clubMember">club member model</param>
        /// <returns>true or false</returns>
        public bool RegisterClubMember(ClubMemberModel clubMember)
            => memberAccess.Add(clubMember);

        public bool UpdateClubMember(ClubMemberModel clubMember)
            => memberAccess.Update(clubMember);

        public bool DeleteClubMember(int id)
            => memberAccess.Delete(id);
    }
}
