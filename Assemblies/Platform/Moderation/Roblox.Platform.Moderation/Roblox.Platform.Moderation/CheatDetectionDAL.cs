using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class CheatDetectionDAL
{
	public long UserID;

	public int CheatTypeDetected;

	public int ActionTypePerformed;

	public DateTime Created;

	public DateTime Updated;

	private static readonly string dbConnectionString_CheatDetectionDAL = Settings.Default.dbConnectionString_RobloxModeration;

	public long ID { get; set; }

	public CheatDetectionDAL()
	{
		ID = 0L;
	}

	private static CheatDetectionDAL BuildDAL(SqlDataReader reader)
	{
		CheatDetectionDAL dal = new CheatDetectionDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.CheatTypeDetected = (int)reader["CheatTypeDetected"];
			dal.ActionTypePerformed = (int)reader["ActionTypePerformed"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@CheatTypeDetected", CheatTypeDetected),
			new SqlParameter("@ActionTypePerformed", ActionTypePerformed),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_CheatDetectionDAL, "CheatDetections_InsertCheatDetection", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@CheatTypeDetected", CheatTypeDetected),
			new SqlParameter("@ActionTypePerformed", ActionTypePerformed),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_CheatDetectionDAL, "CheatDetections_UpdateCheatDetectionByID", queryParameters));
	}

	public void Delete()
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_CheatDetectionDAL, "CheatDetections_DeleteCheatDetectionByID", queryParameters));
	}

	public static CheatDetectionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CheatDetectionDAL, "CheatDetections_GetCheatDetectionByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetCheatDetectionIDsByUserID_Paged(long userId, int startRowIndex, int maximumRows)
	{
		if (userId == 0L)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_CheatDetectionDAL, "CheatDetections_GetCheatDetectionIDsByUserID_Paged", queryParameters));
	}
}
