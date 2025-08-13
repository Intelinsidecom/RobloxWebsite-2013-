using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class GroupDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroups;

	private static readonly long DefaultEmblemID = 1L;

	private string _Name = string.Empty;

	private string _Description = string.Empty;

	public long ID { get; set; }

	public long? AgentID { get; set; }

	public long? OwnerUserID { get; set; } = 0L;


	public long PreviousOwnerUserID { get; set; }

	public string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value.Substring(0, (value.Length < 50) ? value.Length : 50);
		}
	}

	public string Description
	{
		get
		{
			return _Description;
		}
		set
		{
			_Description = value.Substring(0, (value.Length < 1000) ? value.Length : 1000);
		}
	}

	public long EmblemID { get; set; } = DefaultEmblemID;


	public bool PublicEntryAllowed { get; set; } = true;


	public bool BCOnlyJoin { get; set; }

	public bool IsLocked { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		(new SqlParameter[1])[0] = new SqlParameter("@ID", ID);
		RobloxDatabase.RobloxGroups.Delete("GroupsV2_DeleteGroupV2ByID", ID);
	}

	public void Insert()
	{
		if (!OwnerUserID.HasValue || OwnerUserID == 0)
		{
			throw new ApplicationException("Required value not specified: OwnerUserID");
		}
		if (PreviousOwnerUserID == 0L)
		{
			throw new ApplicationException("Required value not specified: PreviousOwnerUserID");
		}
		if (_Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[11]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@OwnerUserID", (!OwnerUserID.HasValue) ? DBNull.Value : ((object)OwnerUserID.Value)),
			new SqlParameter("@PreviousOwnerUserID", PreviousOwnerUserID),
			new SqlParameter("@Name", _Name),
			new SqlParameter("@Description", _Description),
			new SqlParameter("@EmblemID", EmblemID),
			new SqlParameter("@PublicEntryAllowed", PublicEntryAllowed),
			new SqlParameter("@BCOnlyJoin", BCOnlyJoin),
			new SqlParameter("@IsLocked", IsLocked),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroups.Insert<long>("GroupsV2_InsertGroupV2", queryParameters);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (PreviousOwnerUserID == 0L)
		{
			throw new ApplicationException("Required value not specified: PreviousOwnerUserID");
		}
		if (_Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[12]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@OwnerUserID", (!OwnerUserID.HasValue) ? DBNull.Value : ((object)OwnerUserID.Value)),
			new SqlParameter("@PreviousOwnerUserID", PreviousOwnerUserID),
			new SqlParameter("@Name", _Name),
			new SqlParameter("@Description", _Description),
			new SqlParameter("@EmblemID", EmblemID),
			new SqlParameter("@PublicEntryAllowed", PublicEntryAllowed),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@Created", Created),
			new SqlParameter("@BCOnlyJoin", BCOnlyJoin),
			new SqlParameter("@AgentID", AgentID),
			new SqlParameter("@IsLocked", IsLocked)
		};
		RobloxDatabase.RobloxGroups.Update("GroupsV2_UpdateGroupV2ByID", queryParameters);
	}

	private static GroupDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			OwnerUserID = ((record["OwnerUserID"] == null || record["OwnerUserID"].Equals(DBNull.Value)) ? null : new long?(Convert.ToInt64(record["OwnerUserID"]))),
			PreviousOwnerUserID = Convert.ToInt64(record["PreviousOwnerUserID"]),
			Name = (string)record["Name"],
			Description = (string)record["Description"],
			EmblemID = (long)record["EmblemID"],
			PublicEntryAllowed = (bool)record["PublicEntryAllowed"],
			BCOnlyJoin = (bool)record["BCOnlyJoin"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			AgentID = ((record["AgentID"] == null || record["AgentID"].Equals(DBNull.Value)) ? null : new long?(Convert.ToInt64(record["AgentID"]))),
			IsLocked = (record["IsLocked"] != null && !record["IsLocked"].Equals(DBNull.Value) && (bool)record["IsLocked"])
		};
	}

	public static void Delete(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID");
		}
		(new SqlParameter[1])[0] = new SqlParameter("@ID", id);
		RobloxDatabase.RobloxGroups.Delete("GroupsV2_DeleteGroupV2ByID", id);
	}

	public static GroupDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		(new SqlParameter[1])[0] = new SqlParameter("@ID", id);
		return RobloxDatabase.RobloxGroups.Get("GroupsV2_GetGroupV2ByID", id, BuildDAL);
	}

	public static GroupDAL Get(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxGroups.Lookup("GroupsV2_GetGroupV2ByName", BuildDAL, queryParameters);
	}
}
