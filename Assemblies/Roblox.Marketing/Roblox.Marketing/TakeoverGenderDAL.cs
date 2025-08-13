using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class TakeoverGenderDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int TakeoverID { get; set; }

	internal byte GenderTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static TakeoverGenderDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new TakeoverGenderDAL
		{
			ID = id,
			TakeoverID = (int)record["TakeoverID"],
			GenderTypeID = (byte)record["GenderTypeID"],
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
		RobloxDatabase.RobloxMarketing.Delete("TakeoverGenders_DeleteTakeoverGenderByID", ID);
	}

	internal static TakeoverGenderDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("TakeoverGenders_GetTakeoverGenderByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@TakeoverID", TakeoverID),
			new SqlParameter("@GenderTypeID", GenderTypeID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("TakeoverGenders_InsertTakeoverGender", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@TakeoverID", TakeoverID),
			new SqlParameter("@GenderTypeID", GenderTypeID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("TakeoverGenders_UpdateTakeoverGenderByID", queryParameters);
	}

	internal static TakeoverGenderDAL GetTakeoverGenderByTakeoverID(int takeoverId)
	{
		if (takeoverId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@TakeoverID", takeoverId)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("TakeoverGenders_GetTakeoverGenderByTakeoverID", BuildDAL, queryParameters);
	}

	internal static ICollection<TakeoverGenderDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxMarketing.MultiGet("TakeoverGenders_GetTakeoverGendersByIDs", ids, BuildDAL);
	}
}
