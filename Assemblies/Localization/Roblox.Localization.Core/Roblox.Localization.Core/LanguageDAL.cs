using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class LanguageDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxLocalization;

	internal int ID { get; set; }

	internal string Name { get; set; }

	internal string NativeName { get; set; }

	internal string LanguageCode { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static LanguageDAL BuildDAL(IDictionary<string, object> record)
	{
		return new LanguageDAL
		{
			ID = (int)record["ID"],
			Name = (string)record["Name"],
			NativeName = (string)record["NativeName"],
			LanguageCode = (string)record["LanguageCode"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxLocalization.Delete("Languages_DeleteLanguageByID", ID);
	}

	internal static LanguageDAL Get(int id)
	{
		return RobloxDatabase.RobloxLocalization.Get("Languages_GetLanguageByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@NativeName", NativeName),
			new SqlParameter("@LanguageCode", LanguageCode),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxLocalization.Insert<int>("Languages_InsertLanguage", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@NativeName", NativeName),
			new SqlParameter("@LanguageCode", LanguageCode),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxLocalization.Update("Languages_UpdateLanguageByID", queryParameters);
	}

	internal static ICollection<LanguageDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxLocalization.MultiGet("Languages_GetLanguagesByIDs", ids, BuildDAL);
	}

	internal static LanguageDAL GetLanguageByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxLocalization.Lookup("Languages_GetLanguageByName", BuildDAL, queryParameters);
	}

	internal static LanguageDAL GetLanguageByLanguageCode(string languageCode)
	{
		if (string.IsNullOrEmpty(languageCode))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@LanguageCode", languageCode)
		};
		return RobloxDatabase.RobloxLocalization.Lookup("Languages_GetLanguageByLanguageCode", BuildDAL, queryParameters);
	}
}
