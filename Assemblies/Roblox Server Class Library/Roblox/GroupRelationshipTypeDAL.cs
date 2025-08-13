using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupRelationshipTypeDAL
{
	public string Value;

	public bool IsReciprocal;

	public DateTime Created;

	public DateTime Updated;

	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroups;

	public byte ID { get; set; }

	private static GroupRelationshipTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupRelationshipTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			IsReciprocal = (bool)record["IsReciprocal"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@IsReciprocal", IsReciprocal),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroups.Insert<byte>("GroupRelationshipTypes_InsertGroupRelationshipType", queryParameters);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@IsReciprocal", IsReciprocal),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroups.Update("GroupRelationshipTypes_UpdateGroupRelationshipTypeByID", queryParameters);
	}

	public void Delete()
	{
		RobloxDatabase.RobloxGroups.Delete("GroupRelationshipTypes_DeleteGroupRelationshipTypeByID", ID);
	}

	public static GroupRelationshipTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		(new SqlParameter[1])[0] = new SqlParameter("@ID", id);
		return RobloxDatabase.RobloxGroups.Get("GroupRelationshipTypes_GetGroupRelationshipTypeByID", id, BuildDAL);
	}

	public static GroupRelationshipTypeDAL Get(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxGroups.Lookup("GroupRelationshipTypes_GetGroupRelationshipTypeByValue", BuildDAL, queryParameters);
	}
}
