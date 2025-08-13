using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class PageTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("PageTypes_DeletePageTypeByID", ID);
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
		ID = RobloxDatabase.RobloxMarketing.Insert<byte>("PageTypes_InsertPageType", queryParameters);
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
		RobloxDatabase.RobloxMarketing.Update("PageTypes_UpdatePageTypeByID", queryParameters);
	}

	private static PageTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		byte id = (byte)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new PageTypeDAL
		{
			ID = id,
			Value = (string)record["Value"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal static PageTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("PageTypes_GetPageTypeByID", id, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<PageTypeDAL> GetOrCreate(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new ApplicationException("Required value not specified: value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxMarketing.GetOrCreate("PageTypes_GetOrCreatePageType", BuildDAL, queryParameters);
	}

	internal static ICollection<byte> GetPageTypeIDsPaged(byte startRowIndex, byte maximumRows)
	{
		if (maximumRows == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<byte>("PageTypes_GetPageTypeIDs_Paged", queryParameters);
	}
}
