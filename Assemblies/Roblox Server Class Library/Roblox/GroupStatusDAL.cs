using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupStatusDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupPosts;

	internal long ID { get; set; }

	internal long GroupID { get; set; }

	internal long PosterID { get; set; }

	internal string Message { get; set; }

	internal DateTime Updated { get; set; }

	internal DateTime Created { get; set; }

	internal void Delete()
	{
		RobloxDatabase.RobloxGroupPosts.Delete("StatusesV2_DeleteStatusV2ByID", ID);
	}

	internal void Insert()
	{
		if (PosterID == 0L)
		{
			throw new ApplicationException("Required value not specified: PosterID");
		}
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@PosterID", PosterID),
			new SqlParameter("@Message", string.IsNullOrEmpty(Message) ? ((IConvertible)DBNull.Value) : ((IConvertible)Message)),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxGroupPosts.Insert<long>("StatusesV2_InsertStatusV2", queryParameters);
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (PosterID == 0L)
		{
			throw new ApplicationException("Required value not specified: PosterID");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@PosterID", PosterID),
			new SqlParameter("@Message", string.IsNullOrEmpty(Message) ? ((IConvertible)DBNull.Value) : ((IConvertible)Message)),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxGroupPosts.Update("StatusesV2_UpdateStatusV2ByID", queryParameters);
	}

	private static GroupStatusDAL BuildDAL(IDictionary<string, object> record)
	{
		if (Convert.ToInt64(record["ID"]) == 0L)
		{
			return null;
		}
		return new GroupStatusDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			GroupID = Convert.ToInt64(record["GroupID"]),
			PosterID = Convert.ToInt64(record["PosterID"]),
			Message = ((record["Message"] == null || record["Message"].Equals(DBNull.Value)) ? string.Empty : ((string)record["Message"])),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal static GroupStatusDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		return RobloxDatabase.RobloxGroupPosts.Get("StatusesV2_GetStatusV2ByID", id, BuildDAL);
	}

	internal static GroupStatusDAL GetByGroupID(long groupId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@GroupID", groupId)
		};
		return RobloxDatabase.RobloxGroupPosts.Lookup("StatusesV2_GetStatusV2ByGroupID", BuildDAL, queryParameters);
	}
}
