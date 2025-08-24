using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class PartnerDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal string Name { get; set; }

	internal bool IsActive { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("Partners_DeletePartnerByID", ID);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("Partners_InsertPartner", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("Partners_UpdatePartnerByID", queryParameters);
	}

	private static PartnerDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new PartnerDAL
		{
			ID = id,
			Name = (string)record["Name"],
			IsActive = (bool)record["IsActive"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal static PartnerDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("Partners_GetPartnerByID", id, BuildDAL);
	}

	internal static ICollection<int> GetPartnerIDs_Paged(int startRowIndex, int maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("Partners_GetPartnerIDs_Paged", queryParameters);
	}

	internal static PartnerDAL GetByName(string name)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("Partners_GetPartnerByName", BuildDAL, queryParameters);
	}
}
