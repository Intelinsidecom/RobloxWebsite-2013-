using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupRelationshipRequestDAL
{
	public long GroupID;

	public long RelatedGroupID;

	public byte GroupRelationshipTypeID;

	public DateTime Created;

	public DateTime Updated;

	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroups;

	public long ID { get; set; }

	private static GroupRelationshipRequestDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupRelationshipRequestDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			GroupID = Convert.ToInt64(record["GroupID"]),
			RelatedGroupID = Convert.ToInt64(record["RelatedGroupID"]),
			GroupRelationshipTypeID = (byte)record["GroupRelationshipTypeID"],
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
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@RelatedGroupID", RelatedGroupID),
			new SqlParameter("@GroupRelationshipTypeID", GroupRelationshipTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroups.Insert<long>("GroupRelationshipRequestsV2_InsertGroupRelationshipRequestV2", queryParameters);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@RelatedGroupID", RelatedGroupID),
			new SqlParameter("@GroupRelationshipTypeID", GroupRelationshipTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroups.Update("GroupRelationshipRequestsV2_UpdateGroupRelationshipRequestV2ByID", queryParameters);
	}

	public void Delete()
	{
		RobloxDatabase.RobloxGroups.Delete("GroupRelationshipRequestsV2_DeleteGroupRelationshipRequestV2ByID", ID);
	}

	public static GroupRelationshipRequestDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		return RobloxDatabase.RobloxGroups.Get("GroupRelationshipRequestsV2_GetGroupRelationshipRequestV2ByID", id, BuildDAL);
	}

	public static ICollection<long> GetGroupRelationshipRequestIDsByGroupIDRelatedGroupIDAndGroupRelationshipTypeID(long groupId, long relatedGroupId, byte groupRelationshipTypeId, int count, long? exclusiveStartId)
	{
		if (groupId == 0L)
		{
			throw new ArgumentException("Parameter 'groupId' cannot be null, empty or the default value.");
		}
		if (relatedGroupId == 0L)
		{
			throw new ArgumentException("Parameter 'relatedGroupId' cannot be null, empty or the default value.");
		}
		if (groupRelationshipTypeId == 0)
		{
			throw new ArgumentException("Parameter 'groupRelationshipTypeId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@RelatedGroupID", relatedGroupId),
			new SqlParameter("@GroupRelationshipTypeID", groupRelationshipTypeId),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartID", exclusiveStartId ?? 0)
		};
		return RobloxDatabase.RobloxGroups.GetIDCollection<long>("GroupRelationshipRequestsV2_GetGroupRelationshipRequestsV2IDsByGroupIDRelatedGroupIDAndGroupRelationshipTypeID", queryParameters);
	}

	public static int GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndRelatedGroupIDAndTypeID(long groupId, long relatedGroupId, byte typeId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (relatedGroupId == 0L)
		{
			throw new ApplicationException("Required value not specified: RelatedGroupId.");
		}
		if (typeId == 0)
		{
			throw new ApplicationException("Required value not specified: GroupRelationshipTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@RelatedGroupID", relatedGroupId),
			new SqlParameter("@GroupRelationshipTypeID", typeId)
		};
		return RobloxDatabase.RobloxGroups.GetCount<int>("GroupRelationshipRequestsV2_GetTotalNumberOfGroupRelationshipRequestsV2ByGroupIDAndRelatedGroupIDAndTypeID", queryParameters);
	}

	public static ICollection<long> GetGroupRelationshipRequestIDsByGroupIDAndTypeIDPaged(long groupId, byte typeId, int startRowIndex, int maximumRows)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (typeId == 0)
		{
			throw new ApplicationException("Required value not specified: GroupRelationshipTypeID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@GroupRelationshipTypeID", typeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxGroups.GetIDCollection<long>("GroupRelationshipRequestsV2_GetGroupRelationshipRequestV2IDsByGroupIDAndTypeID_Paged", queryParameters);
	}

	public static int GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndTypeID(long groupId, byte typeId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (typeId == 0)
		{
			throw new ApplicationException("Required value not specified: GroupRelationshipTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@GroupRelationshipTypeID", typeId)
		};
		return RobloxDatabase.RobloxGroups.GetCount<int>("GroupRelationshipRequestsV2_GetTotalNumberOfGroupRelationshipRequestsV2ByGroupIDAndTypeID", queryParameters);
	}
}
