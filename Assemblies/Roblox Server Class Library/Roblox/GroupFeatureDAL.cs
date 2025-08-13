using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupFeatureDAL
{
	public long GroupID;

	public byte GroupFeatureTypeID;

	public DateTime Created;

	public DateTime Updated;

	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroups;

	public long ID { get; set; }

	private static GroupFeatureDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupFeatureDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			GroupID = Convert.ToInt64(record["GroupID"]),
			GroupFeatureTypeID = (byte)record["GroupFeatureTypeID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@GroupFeatureTypeID", GroupFeatureTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroups.Insert<long>("GroupFeaturesV2_InsertGroupFeatureV2", queryParameters);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@GroupFeatureTypeID", GroupFeatureTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroups.Update("GroupFeaturesV2_UpdateGroupFeatureV2ByID", queryParameters);
	}

	public void Delete()
	{
		RobloxDatabase.RobloxGroups.Delete("GroupFeaturesV2_DeleteGroupFeatureV2ByID", ID);
	}

	public static GroupFeatureDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		return RobloxDatabase.RobloxGroups.Get("GroupFeaturesV2_GetGroupFeatureV2ByID", id, BuildDAL);
	}

	public static GroupFeatureDAL Get(long groupId, byte groupFeatureTypeId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (groupFeatureTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: GroupFeatureTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@GroupFeatureTypeID", groupFeatureTypeId)
		};
		return RobloxDatabase.RobloxGroups.Lookup("GroupFeaturesV2_GetGroupFeatureV2ByGroupIDAndGroupFeatureTypeID", BuildDAL, queryParameters);
	}

	public static ICollection<long> GetGroupFeatureIDsByGroupID_Paged(long groupId, int startRowIndex, int maximumRows)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxGroups.GetIDCollection<long>("GroupFeaturesV2_GetGroupFeatureV2IDsByGroupID_Paged", queryParameters);
	}
}
