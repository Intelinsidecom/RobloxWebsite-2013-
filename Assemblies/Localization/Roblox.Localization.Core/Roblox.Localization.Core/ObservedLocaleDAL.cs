using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Localization.Core {
    [ExcludeFromCodeCoverage]
    internal class ObservedLocaleDAL
    {
        private const RobloxDatabase _Database = RobloxDatabase.RobloxLocalization;

        internal int ID { get; set; }

        internal string Locale { get; set; }

        internal int? LanguageID { get; set; }

        internal int? SupportedLocaleID { get; set; }

        internal DateTime Created { get; set; }

        internal DateTime Updated { get; set; }

        private static ObservedLocaleDAL BuildDAL(IDictionary<string, object> record)
        {
            return new ObservedLocaleDAL
            {
                ID = (int)record["ID"],
                Locale = (string)record["Locale"],
                LanguageID = (int?)record["LanguageID"],
                SupportedLocaleID = (int?)record["SupportedLocaleID"],
                Created = (DateTime)record["Created"],
                Updated = (DateTime)record["Updated"]
            };
        }

        internal void Delete()
        {
            RobloxDatabase.RobloxLocalization.Delete("ObservedLocales_DeleteObservedLocaleByID", ID);
        }

        internal static ObservedLocaleDAL Get(int id)
        {
            return RobloxDatabase.RobloxLocalization.Get("ObservedLocales_GetObservedLocaleByID", id, BuildDAL);
        }

        internal void Insert()
        {
            Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[6]
            {
                new Microsoft.Data.SqlClient.SqlParameter("@ID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                },
                new Microsoft.Data.SqlClient.SqlParameter("@Locale", Locale),
                new Microsoft.Data.SqlClient.SqlParameter("@LanguageID", LanguageID.HasValue ? ((object)LanguageID) : DBNull.Value),
                new Microsoft.Data.SqlClient.SqlParameter("@SupportedLocaleID", SupportedLocaleID.HasValue ? ((object)SupportedLocaleID) : DBNull.Value),
                new Microsoft.Data.SqlClient.SqlParameter("@Created", Created),
                new Microsoft.Data.SqlClient.SqlParameter("@Updated", Updated)
            };
            ID = RobloxDatabase.RobloxLocalization.Insert<int>("ObservedLocales_InsertObservedLocale", queryParameters);
        }

        internal void Update()
        {
            Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[6]
            {
                new Microsoft.Data.SqlClient.SqlParameter("@ID", ID),
                new Microsoft.Data.SqlClient.SqlParameter("@Locale", Locale),
                new Microsoft.Data.SqlClient.SqlParameter("@LanguageID", LanguageID.HasValue ? ((object)LanguageID) : DBNull.Value),
                new Microsoft.Data.SqlClient.SqlParameter("@SupportedLocaleID", SupportedLocaleID.HasValue ? ((object)SupportedLocaleID) : DBNull.Value),
                new Microsoft.Data.SqlClient.SqlParameter("@Created", Created),
                new Microsoft.Data.SqlClient.SqlParameter("@Updated", Updated)
            };
            RobloxDatabase.RobloxLocalization.Update("ObservedLocales_UpdateObservedLocaleByID", queryParameters);
        }

        internal static ICollection<ObservedLocaleDAL> MultiGet(ICollection<int> ids)
        {
            return RobloxDatabase.RobloxLocalization.MultiGet("ObservedLocales_GetObservedLocalesByIDs", ids, BuildDAL);
        }

        internal static ObservedLocaleDAL GetObservedLocaleByLocale(string locale)
        {
            if (string.IsNullOrEmpty(locale))
            {
                return null;
            }
            Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[1]
            {
                new Microsoft.Data.SqlClient.SqlParameter("@Locale", locale)
            };
            return RobloxDatabase.RobloxLocalization.Lookup("ObservedLocales_GetObservedLocaleByLocale", BuildDAL, queryParameters);
        }
    }
}
