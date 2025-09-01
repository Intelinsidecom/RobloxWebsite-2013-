using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Localization.Core {
    [ExcludeFromCodeCoverage]
    internal class LanguageDefaultSupportedLocaleDAL
    {
        private const RobloxDatabase _Database = RobloxDatabase.RobloxLocalization;

        internal int ID { get; set; }

        internal int LanguageID { get; set; }

        internal int SupportedLocaleID { get; set; }

        internal DateTime Created { get; set; }

        internal DateTime Updated { get; set; }

        private static LanguageDefaultSupportedLocaleDAL BuildDAL(IDictionary<string, object> record)
        {
            return new LanguageDefaultSupportedLocaleDAL
            {
                ID = (int)record["ID"],
                LanguageID = (int)record["LanguageID"],
                SupportedLocaleID = (int)record["SupportedLocaleID"],
                Created = (DateTime)record["Created"],
                Updated = (DateTime)record["Updated"]
            };
        }

        internal void Delete()
        {
            RobloxDatabase.RobloxLocalization.Delete("LanguageDefaultSupportedLocales_DeleteLanguageDefaultSupportedLocaleByID", ID);
        }

        internal static LanguageDefaultSupportedLocaleDAL Get(int id)
        {
            return RobloxDatabase.RobloxLocalization.Get("LanguageDefaultSupportedLocales_GetLanguageDefaultSupportedLocaleByID", id, BuildDAL);
        }

        internal void Insert()
        {
            Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[5]
            {
                new Microsoft.Data.SqlClient.SqlParameter("@ID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                },
                new Microsoft.Data.SqlClient.SqlParameter("@LanguageID", LanguageID),
                new Microsoft.Data.SqlClient.SqlParameter("@SupportedLocaleID", SupportedLocaleID),
                new Microsoft.Data.SqlClient.SqlParameter("@Created", Created),
                new Microsoft.Data.SqlClient.SqlParameter("@Updated", Updated)
            };
            ID = RobloxDatabase.RobloxLocalization.Insert<int>("LanguageDefaultSupportedLocales_InsertLanguageDefaultSupportedLocale", queryParameters);
        }

        internal void Update()
        {
            Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[5]
            {
                new Microsoft.Data.SqlClient.SqlParameter("@ID", ID),
                new Microsoft.Data.SqlClient.SqlParameter("@LanguageID", LanguageID),
                new Microsoft.Data.SqlClient.SqlParameter("@SupportedLocaleID", SupportedLocaleID),
                new Microsoft.Data.SqlClient.SqlParameter("@Created", Created),
                new Microsoft.Data.SqlClient.SqlParameter("@Updated", Updated)
            };
            RobloxDatabase.RobloxLocalization.Update("LanguageDefaultSupportedLocales_UpdateLanguageDefaultSupportedLocaleByID", queryParameters);
        }

        internal static ICollection<LanguageDefaultSupportedLocaleDAL> MultiGet(ICollection<int> ids)
        {
            return RobloxDatabase.RobloxLocalization.MultiGet("LanguageDefaultSupportedLocales_GetLanguageDefaultSupportedLocalesByIDs", ids, BuildDAL);
        }

        internal static LanguageDefaultSupportedLocaleDAL GetLanguageDefaultSupportedLocaleByLanguageID(int languageId)
        {
            if (languageId == 0)
            {
                return null;
            }
            Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[1]
            {
                new Microsoft.Data.SqlClient.SqlParameter("@LanguageID", languageId)
            };
            return RobloxDatabase.RobloxLocalization.Lookup("LanguageDefaultSupportedLocales_GetLanguageDefaultSupportedLocaleByLanguageID", BuildDAL, queryParameters);
        }
    }
}
