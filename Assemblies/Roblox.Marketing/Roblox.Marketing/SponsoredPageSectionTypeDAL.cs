using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class SponsoredPageSectionTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static SponsoredPageSectionTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		byte id = (byte)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new SponsoredPageSectionTypeDAL
		{
			ID = id,
			Value = (string)record["Value"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPageSectionTypes_DeleteSponsoredPageSectionTypeByID", ID);
	}

	internal static SponsoredPageSectionTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPageSectionTypes_GetSponsoredPageSectionTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<byte>("SponsoredPageSectionTypes_InsertSponsoredPageSectionType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("SponsoredPageSectionTypes_UpdateSponsoredPageSectionTypeByID", queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<SponsoredPageSectionTypeDAL> GetOrCreate(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxMarketing.GetOrCreate("SponsoredPageSectionTypes_GetOrCreateSponsoredPageSectionType", BuildDAL, queryParameters);
	}

	internal static SponsoredPageSectionTypeDAL GetSponsoredPageSectionTypeByValue(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("SponsoredPageSectionTypes_GetSponsoredPageSectionTypeByValue", BuildDAL, queryParameters);
	}
}
