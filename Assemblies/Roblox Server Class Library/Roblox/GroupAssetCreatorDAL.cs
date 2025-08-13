using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupAssetCreatorDAL
{
	public long AssetID;

	public long GroupID;

	public long UserID;

	public DateTime Created;

	public DateTime Updated;

	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroups;

	public long ID { get; set; }

	private static GroupAssetCreatorDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupAssetCreatorDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			AssetID = (long)record["AssetID"],
			GroupID = Convert.ToInt64(record["GroupID"]),
			UserID = Convert.ToInt64(record["UserID"]),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroups.Insert<long>("GroupAssetCreatorsV2_InsertGroupAssetCreatorV2", queryParameters);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroups.Update("GroupAssetCreatorsV2_UpdateGroupAssetCreatorV2ByID", queryParameters);
	}

	public void Delete()
	{
		RobloxDatabase.RobloxGroups.Delete("GroupAssetCreatorsV2_DeleteGroupAssetCreatorV2ByID", ID);
	}

	public static GroupAssetCreatorDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		return RobloxDatabase.RobloxGroups.Get("GroupAssetCreatorsV2_GetGroupAssetCreatorV2ByID", id, BuildDAL);
	}

	public static GroupAssetCreatorDAL GetByAssetID(long assetId)
	{
		if (assetId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AssetID", assetId)
		};
		return RobloxDatabase.RobloxGroups.Lookup("GroupAssetCreatorsV2_GetGroupAssetCreatorV2ByAssetID", BuildDAL, queryParameters);
	}
}
