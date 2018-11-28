// -----------------------------------------------------------------------
// <copyright file="ConnectionAccess.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.DataAccess
{
    using DataUtils;
    using John.SocialClub.Data.Sql;
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public abstract class AccessBase<TModel>
    {
        protected string ConnectionString
            => ConfigurationManager
                    .ConnectionStrings["SocialClubDBConnection"]
                    .ToString();

        protected abstract void FillSearchParams(SqlDataAdapter dataAdapter, ISearchDefinition<TModel> searchDefinition);
        protected abstract void AddCommonParameters(SqlCommand c, TModel m);

        public DataTable GetAll()
          => AccessTools.GetAll(Scripts.SqlGetAll, ConnectionString);

        public DataRow GetById(int id)
            => AccessTools.GetById(Scripts.SqlGetById, ConnectionString, id);

        public DataTable Search(object occupation, object maritalStatus, string operand)
            => AccessTools.Search(string.Format(Scripts.SqlSearch, operand), ConnectionString,
                FillSearchParams);

        public bool Add(TModel clubMember)
            => AccessTools.Add(Scripts.SqlUpdate, ConnectionString,
                clubMember, AddCommonParameters);


        public bool Update(TModel clubMember)
               => AccessTools.Update<TModel, int>(Scripts.SqlUpdate, ConnectionString,
                   clubMember, AddCommonParameters);

        public bool Delete(int id)
            => AccessTools.Delete(Scripts.sqlDelete, ConnectionString, id);
    }
}
