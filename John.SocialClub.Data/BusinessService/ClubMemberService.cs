// -----------------------------------------------------------------------
// <copyright file="ClubMemberService.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.BusinessService
{
    using System.Data;
    using John.SocialClub.Data.DataAccess;
    using John.SocialClub.Data.DataModel;

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
            => memberAccess.Search(occupation, maritalStatus, operand);

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
