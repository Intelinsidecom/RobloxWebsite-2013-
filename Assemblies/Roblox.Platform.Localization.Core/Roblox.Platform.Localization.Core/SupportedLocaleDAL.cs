using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class SupportedLocaleDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxLocalization;

	internal int ID { get; set; }

	internal string Locale { get; set; }

	internal string Name { get; set; }

	internal string NativeName { get; set; }

	internal int LanguageID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static SupportedLocaleDAL BuildDAL(IDictionary<string, object> record)
	{
		return new SupportedLocaleDAL
		{
			ID = (int)record["ID"],
			Locale = (string)record["Locale"],
			Name = (string)record["Name"],
			NativeName = (string)record["NativeName"],
			LanguageID = (int)record["LanguageID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxLocalization.Delete("SupportedLocales_DeleteSupportedLocaleByID", ID);
	}

	internal static SupportedLocaleDAL Get(int id)
	{
		return RobloxDatabase.RobloxLocalization.Get("SupportedLocales_GetSupportedLocaleByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Locale", Locale),
			new SqlParameter("@Name", Name),
			new SqlParameter("@NativeName", NativeName),
			new SqlParameter("@LanguageID", LanguageID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxLocalization.Insert<int>("SupportedLocales_InsertSupportedLocale", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Locale", Locale),
			new SqlParameter("@Name", Name),
			new SqlParameter("@NativeName", NativeName),
			new SqlParameter("@LanguageID", LanguageID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxLocalization.Update("SupportedLocales_UpdateSupportedLocaleByID", queryParameters);
	}

	internal static ICollection<SupportedLocaleDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxLocalization.MultiGet("SupportedLocales_GetSupportedLocalesByIDs", ids, BuildDAL);
	}

	internal static SupportedLocaleDAL GetSupportedLocaleByLocale(string locale)
	{
		if (string.IsNullOrEmpty(locale))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Locale", locale)
		};
		return RobloxDatabase.RobloxLocalization.Lookup("SupportedLocales_GetSupportedLocaleByLocale", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetSupportedLocaleIDsPaged(int startRowIndex, int maximumRows)
	{
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxLocalization.GetIDCollection<int>("SupportedLocales_GetSupportedLocaleIDs_Paged", queryParameters);
	}
}
