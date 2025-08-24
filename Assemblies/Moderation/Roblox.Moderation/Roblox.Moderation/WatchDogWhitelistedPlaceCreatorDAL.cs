using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Moderation.Properties;

namespace Roblox.Platform.Moderation;

public class WatchDogWhitelistedPlaceCreatorDAL
{
	internal long ID { get; set; }

	internal long CreatorID { get; set; }

	internal DateTime Created { get; set; }

	private static string _DbConnectionString => Settings.Default.ModerationNewConnectionString;

	private static WatchDogWhitelistedPlaceCreatorDAL BuildDAL(SqlDataReader reader)
	{
		WatchDogWhitelistedPlaceCreatorDAL dal = new WatchDogWhitelistedPlaceCreatorDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.CreatorID = (long)reader["CreatorID"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "WatchDogWhitelistedPlaceCreatorsV2_DeleteWatchDogWhitelistedPlaceCreatorV2ByID", queryParameters));
	}

	internal static WatchDogWhitelistedPlaceCreatorDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "WatchDogWhitelistedPlaceCreatorsV2_GetWatchDogWhitelistedPlaceCreatorV2ByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatorID", CreatorID),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "WatchDogWhitelistedPlaceCreatorsV2_InsertWatchDogWhitelistedPlaceCreatorV2", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@CreatorID", CreatorID),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "WatchDogWhitelistedPlaceCreatorsV2_UpdateWatchDogWhitelistedPlaceCreatorV2ByID", queryParameters));
	}

	internal static WatchDogWhitelistedPlaceCreatorDAL GetWatchDogWhitelistedPlaceCreatorByCreatorID(long creatorID)
	{
		if (creatorID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@CreatorID", creatorID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "WatchDogWhitelistedPlaceCreatorsV2_GetWatchDogWhitelistedPlaceCreatorV2ByCreatorID", queryParameters), BuildDAL);
	}
}
