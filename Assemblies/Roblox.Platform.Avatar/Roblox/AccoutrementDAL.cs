using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
internal class AccoutrementDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccoutrements;

	internal long ID { get; set; }

	internal long UserID { get; set; }

	internal long UserAssetID { get; set; }

	internal DateTime Created { get; set; } = DateTime.MinValue;


	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxAccoutrements.Delete("Accoutrements_DeleteAccoutrementByID", ID);
	}

	public void Insert()
	{
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (UserAssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserAssetID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@UserAssetID", UserAssetID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccoutrements.Insert<long>("Accoutrements_InsertAccoutrement", queryParameters);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (UserAssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserAssetID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@UserAssetID", UserAssetID),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAccoutrements.Update("Accoutrements_UpdateAccoutrementByID", queryParameters);
	}

	public static AccoutrementDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		return RobloxDatabase.RobloxAccoutrements.Get("Accoutrements_GetAccoutrementByID", id, BuildDAL);
	}

	public static ICollection<AccoutrementDAL> MultiGet(ICollection<long> ids)
	{
		if (ids == null || ids.Count == 0)
		{
			return new List<AccoutrementDAL>();
		}
		return RobloxDatabase.RobloxAccoutrements.MultiGet("Accoutrements_GetAccoutrementsByIDs", ids, BuildDAL);
	}

	public static AccoutrementDAL GetByUserAssetID(long userAssetId)
	{
		if (userAssetId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserAssetID", userAssetId)
		};
		return RobloxDatabase.RobloxAccoutrements.Lookup("Accoutrements_GetAccoutrementByUserAssetID", BuildDAL, queryParameters);
	}

	public static ICollection<long> GetUserAccoutrementIDs(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxAccoutrements.GetIDCollection<long>("Accoutrements_GetAccoutrementIDsByUserID", queryParameters);
	}

	private static AccoutrementDAL BuildDAL(IDictionary<string, object> record)
	{
		AccoutrementDAL dal = new AccoutrementDAL();
		dal.ID = (long)record["ID"];
		dal.UserID = Convert.ToInt64(record["UserID"]);
		dal.UserAssetID = (long)record["UserAssetID"];
		dal.Created = (DateTime)record["Created"];
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}
}
