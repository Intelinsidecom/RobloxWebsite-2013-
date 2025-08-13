using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupFeatureTypeDAL
{
	public string Name;

	public DateTime Created;

	public DateTime Updated;

	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroups;

	public byte ID { get; set; }

	private static GroupFeatureTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupFeatureTypeDAL
		{
			ID = (byte)record["ID"],
			Name = (string)record["Name"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroups.Insert<byte>("GroupFeatureTypes_InsertGroupFeatureType", queryParameters);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroups.Update("GroupFeatureTypes_UpdateGroupFeatureTypeByID", queryParameters);
	}

	public void Delete()
	{
		RobloxDatabase.RobloxGroups.Delete("GroupFeatureTypes_DeleteGroupFeatureTypeByID", ID);
	}

	public static GroupFeatureTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxGroups.Get("GroupFeatureTypes_GetGroupFeatureTypeByID", id, BuildDAL);
	}

	public static GroupFeatureTypeDAL Get(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxGroups.Lookup("GroupFeatureTypes_GetGroupFeatureTypeByName", BuildDAL, queryParameters);
	}
}
