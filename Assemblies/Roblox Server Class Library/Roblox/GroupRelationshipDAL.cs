using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class GroupRelationshipDAL
{
	public long GroupID;

	public long RelatedGroupID;

	public byte GroupRelationshipTypeID;

	public DateTime Created;

	public DateTime Updated;

	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroups;

	public long ID { get; set; }

	private static GroupRelationshipDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupRelationshipDAL
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
		ID = RobloxDatabase.RobloxGroups.Insert<long>("GroupRelationshipsV2_InsertGroupRelationshipV2", queryParameters);
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
		RobloxDatabase.RobloxGroups.Update("GroupRelationshipsV2_UpdateGroupRelationshipV2ByID", queryParameters);
	}

	public void Delete()
	{
		RobloxDatabase.RobloxGroups.Delete("GroupRelationshipsV2_DeleteGroupRelationshipV2ByID", ID);
	}

	public static GroupRelationshipDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		return RobloxDatabase.RobloxGroups.Get("GroupRelationshipsV2_GetGroupRelationshipV2ByID", id, BuildDAL);
	}

	public static GroupRelationshipDAL Get(long groupId, long relatedGroupId, byte groupRelationshipTypeId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (relatedGroupId == 0L)
		{
			throw new ApplicationException("Required value not specified: RelatedGroupID.");
		}
		if (groupRelationshipTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: GroupRelationshipTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@RelatedGroupID", relatedGroupId),
			new SqlParameter("@GroupRelationshipTypeID", groupRelationshipTypeId)
		};
		return RobloxDatabase.RobloxGroups.Lookup("GroupRelationshipsV2_GetGroupRelationshipV2ByGroupIDAndRelatedGroupIDAndTypeID", BuildDAL, queryParameters);
	}

	public static ICollection<long> GetGroupRelationshipIDsByGroupIDAndTypeIDPaged(long groupId, byte typeId, int startRowIndex, int maximumRows)
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
		return RobloxDatabase.RobloxGroups.GetIDCollection<long>("GroupRelationshipsV2_GetGroupRelationshipV2IDsByGroupIDAndTypeID_Paged", queryParameters);
	}

	public static int GetTotalNumberOfGroupRelationshipsByGroupIDAndTypeID(long groupId, byte typeId)
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
		return RobloxDatabase.RobloxGroups.GetCount<int>("GroupRelationshipsV2_GetTotalNumberOfGroupRelationshipsV2ByGroupIDAndTypeID", queryParameters);
	}
}
