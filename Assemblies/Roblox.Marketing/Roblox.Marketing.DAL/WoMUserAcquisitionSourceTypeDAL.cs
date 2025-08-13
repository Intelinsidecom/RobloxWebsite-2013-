using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing.DAL;

public class WoMUserAcquisitionSourceTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal bool IsActive { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static WoMUserAcquisitionSourceTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		if ((byte)record["ID"] == 0)
		{
			return null;
		}
		return new WoMUserAcquisitionSourceTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			IsActive = (bool)record["IsActive"],
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
		RobloxDatabase.RobloxMarketing.Delete("WoMUserAcquisitionSourceTypes_DeleteWoMUserAcquisitionSourceTypeByID", ID);
	}

	internal static WoMUserAcquisitionSourceTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("WoMUserAcquisitionSourceTypes_GetWoMUserAcquisitionSourceTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<byte>("WoMUserAcquisitionSourceTypes_InsertWoMUserAcquisitionSourceType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("WoMUserAcquisitionSourceTypes_UpdateWoMUserAcquisitionSourceTypeByID", queryParameters);
	}

	internal static ICollection<byte> GetActiveWoMUserAcquisitionSourceTypeIDsPaged(byte startRowIndex, byte maximumRows)
	{
		if (maximumRows == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows),
			new SqlParameter("@IsActive", 1)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<byte>("WoMUserAcquisitionSourceTypes_GetWoMUserAcquisitionSourceTypeIDsByIsActive_Paged", queryParameters);
	}
}
