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
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;

    public abstract class AccessBase<TAccess, TModel, TKey, TSearchDef>
        where TAccess : AccessBase<TAccess, TModel, TKey, TSearchDef>
        where TModel : IHasPrimaryKey<TKey>
        where TKey : struct
        where TSearchDef : ISearchDefinition<TModel>
    {
        private readonly string tableName;

        protected AccessBase(string tableName) 
            => this.tableName = tableName;

        protected string ConnectionString
            => ConfigurationManager
                    .ConnectionStrings["SocialClubDBConnection"]
                    .ToString();

        protected abstract void FillSearchParams(SqlDataAdapter dataAdapter, TSearchDef searchDefinition);
        protected abstract void AddCommonParameters(SqlCommand c, TModel m);
        protected abstract Dictionary<string, Func<TModel, object>> FieldList { get; }

        public DataTable GetAll()
          => AccessTools.GetAll(SelectAllScript, ConnectionString);

        public DataRow GetById(int id)
            => AccessTools.GetById(SelectByIdScript, ConnectionString, id);

        public DataTable Search(TSearchDef searchDef, string operand)
            => AccessTools.Search<TModel, TSearchDef>(string.Format(SearchScript , operand), ConnectionString,
                searchDef, FillSearchParams);

        public bool Add(TModel clubMember)
            => AccessTools.Add(InsertScript, ConnectionString,
                clubMember, AddCommonParameters);


        public bool Update(TModel clubMember)
               => AccessTools.Update<TModel, TKey>(UpdateScript, ConnectionString,
                   clubMember, AddCommonParameters);

        public bool Delete(int id)
            => AccessTools.Delete(DeleteScript, ConnectionString, id);

        protected virtual string SelectAllScript
            => "Select"
                + string.Join(", ", FieldList.Select(prop => prop.Key))
                + " From " + tableName;

        protected virtual string SelectByIdScript
            => SelectAllScript + " Where Id = @Id";

        protected virtual string InsertScript
            => "Insert Into "
            + tableName + "(" + string.Join(", ", FieldList.Select(prop => prop.Key)) + ")"
            + "Values(" + string.Join(", ", FieldList.Select(prop => "@" + prop.Key)) + ")";

        protected virtual string UpdateScript
            => "Update " + tableName + " Set "
            + string.Join(", ", FieldList.Select(prop => $"[{prop.Key}] = @{prop.Key}")) + ")"
            + " Where Id = @Id";

        protected virtual string DeleteScript
            => $"Delete From {tableName} Where (Id = @Id)";

        protected virtual string SearchScript
            => SelectAllScript
            + " Where (" + string.Join(" {0} ",
                 typeof(TSearchDef)
                  .GetProperties()
                  .Select(prop => $"(@{prop.Name} Is NULL OR @{prop.Name} = {prop.Name})")) ;

    }
}
