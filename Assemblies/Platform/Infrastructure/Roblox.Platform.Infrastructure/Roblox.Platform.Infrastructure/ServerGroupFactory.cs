using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Infrastructure;

public class ServerGroupFactory
{
	private class ServerGroupDefinition : IServerGroup
	{
		public int Id { get; internal set; }

		public int GroupTypeId { get; internal set; }

		public string Name { get; internal set; }

		public string Description { get; internal set; }
	}

	private static readonly TimeSpan _GroupListCacheDuration = TimeSpan.FromHours(1.0);

	public IEnumerable<IServerGroup> GetAllServerGroups()
	{
		return InfrastructureCache.FetchItem("AllServerGroups", _GroupListCacheDuration, delegate
		{
			List<IServerGroup> list = new List<IServerGroup>();
			DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "ServerGroups_GetAllServerGroups");
			using (DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString))
			{
				using SqlDataReader sqlDataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
				while (sqlDataReader.Read())
				{
					ServerGroupDefinition item = BuildServerGroup(sqlDataReader);
					list.Add(item);
				}
			}
			list.Sort((IServerGroup a, IServerGroup b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));
			return list;
		});
	}

	public IReadOnlyCollection<int> GetServerGroupIdsByServerId(int serverId)
	{
		return InfrastructureCache.FetchItem("GetServerGroupIdsByServerId:" + serverId, _GroupListCacheDuration, delegate
		{
			SqlParameter[] sqlParameters = new SqlParameter[1]
			{
				new SqlParameter("@ServerID", serverId)
			};
			return (from record in RobloxDatabase.RobloxInfrastructure.ExecuteReader("ServerGroupMembers_GetServerGroupIDsByServerID", sqlParameters)
				select (int)record["ServerGroupID"]).ToList();
		});
	}

	private static ServerGroupDefinition BuildServerGroup(IDataRecord reader)
	{
		return new ServerGroupDefinition
		{
			Id = (int)reader["ID"],
			GroupTypeId = (int)reader["GroupTypeID"],
			Description = (reader["Description"] as string),
			Name = (string)reader["Name"]
		};
	}
}
