// -----------------------------------------------------------------------
// <copyright file="ConnectionAccess.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.DataAccess
{
    using System.Configuration;

    public abstract class ConnectionAccess
    {
        protected string ConnectionString
            => ConfigurationManager
                    .ConnectionStrings["SocialClubDBConnection"]
                    .ToString();
    }
}
