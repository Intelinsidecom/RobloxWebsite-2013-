using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Agents.Entities;

[Serializable]
internal class AgentDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxUsers;

	public long ID { get; set; }

	public byte AgentTypeID { get; set; }

	public long AgentTargetID { get; set; }

	public DateTime Created { get; set; } = DateTime.MinValue;


	public DateTime? Updated { get; set; }

	private static AgentDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AgentDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			AgentTypeID = (byte)record["AssociatedEntityTypeID"],
			AgentTargetID = ((record["AssociatedEntityID"] != null) ? Convert.ToInt64(record["AssociatedEntityID"]) : 0),
			Created = (DateTime)record["Created"],
			Updated = (DateTime?)record["Updated"]
		};
	}

	public static AgentDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		return RobloxDatabase.RobloxUsers.Get("UsersV2_GetUserV2ByID", id, BuildDAL);
	}

	public static AgentDAL GetByAgentTypeIdAndAgentTargetId(byte agentTypeId, long agentTargetId)
	{
		if (agentTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: AgentTypeID.");
		}
		if (agentTargetId == 0L)
		{
			throw new ApplicationException("Required value not specified: AgentTargetID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@AssociatedEntityTypeID", agentTypeId),
			new SqlParameter("@AssociatedEntityID", agentTargetId)
		};
		return RobloxDatabase.RobloxUsers.Lookup("UsersV2_GetUserV2ByAssociatedEntityIDAndAssociatedEntityTypeID", BuildDAL, queryParameters);
	}
}
