using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Roblox.Configuration;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Infrastructure;

public class ServerFactory : IServerFactory
{
	private sealed class ServerDefinition : IServer, IEquatable<IServer>
	{
		public int Id { get; internal set; }

		public string HostName { get; internal set; }

		public string Name { get; internal set; }

		public short ServerFarmId { get; internal set; }

		public int ServerTypeId { get; internal set; }

		public int DatacenterId { get; internal set; }

		public string PrivateIPAddress { get; internal set; }

		public string PrimaryIPAddress { get; internal set; }

		public DateTime UpdatedUtc { get; internal set; }

		public override bool Equals(object obj)
		{
			if (obj is IServer server)
			{
				return Equals(server);
			}
			return false;
		}

		public bool Equals(IServer other)
		{
			return Id == other.Id;
		}

		public override int GetHashCode()
		{
			return Id;
		}
	}

	private static readonly TimeSpan _ServerGroupCacheDuration = TimeSpan.FromMinutes(20.0);

	private static readonly TimeSpan _IndividualServerLookupCacheDuration = TimeSpan.FromMinutes(60.0);

	private static readonly TimeSpan _AllServerTypesCacheDuration = TimeSpan.FromHours(24.0);

	public IReadOnlyCollection<IServer> GetServersByServerType(ServerType serverType)
	{
		return GetServersByServerTypeId((int)serverType);
	}

	public IReadOnlyCollection<IServer> GetServersByServerTypeAndServerGroup(ServerType serverType, ServerGroup serverGroup)
	{
		return GetServersByServerGroupIdAndServerTypeId((int)serverGroup, (int)serverType);
	}

	public IReadOnlyCollection<IServer> GetServersByServerTypeAndServerGroupWithNoCaching(ServerType serverType, ServerGroup serverGroup)
	{
		return GetServersByServerGroupIdAndServerTypeIdWithNoCaching((int)serverGroup, (int)serverType);
	}

	public IReadOnlyCollection<IServer> GetServersByServerGroupIdAndServerTypeId(int serverGroupId, int serverTypeId)
	{
		return GetServersByServerGroupIdServerTypeIdAndServerStatusId(serverGroupId, serverTypeId, 2);
	}

	public IReadOnlyCollection<IServer> GetServersByServerGroupIdAndServerTypeIdWithNoCaching(int serverGroupId, int serverTypeId)
	{
		return GetServersByServerGroupIdServerTypeIdAndServerStatusIdWithNoCaching(serverGroupId, serverTypeId, 2);
	}

	public IReadOnlyCollection<IServer> GetServersByServerTypeServerGroupAndServerStatus(ServerType serverType, ServerGroup serverGroup, ServerStatus serverStatus)
	{
		return GetServersByServerGroupIdServerTypeIdAndServerStatusId((int)serverGroup, (int)serverType, (int)serverStatus);
	}

	public IReadOnlyCollection<IServer> GetServersByServerTypeServerGroupAndServerStatusWithNoCaching(ServerType serverType, ServerGroup serverGroup, ServerStatus serverStatus)
	{
		return GetServersByServerGroupIdServerTypeIdAndServerStatusIdWithNoCaching((int)serverGroup, (int)serverType, (int)serverStatus);
	}

	public IReadOnlyCollection<IServer> GetServersByServerGroupIdServerTypeIdAndServerStatusId(int serverGroupId, int serverTypeId, int serverStatusId)
	{
		return InfrastructureCache.FetchItem("serverGroupId:" + serverGroupId + "_serverTypeId:" + serverTypeId + "_serverStatusId:" + serverStatusId, _ServerGroupCacheDuration, () => GetServersByServerGroupIdServerTypeIdAndServerStatusIdWithNoCaching(serverGroupId, serverTypeId, serverStatusId));
	}

	public IReadOnlyCollection<IServer> GetServersByServerGroupIdServerTypeIdAndServerStatusIdWithNoCaching(int serverGroupId, int serverTypeId, int serverStatusId)
	{
		SqlParameter[] parameters = new SqlParameter[4]
		{
			new SqlParameter("@ServerGroupID", serverGroupId),
			new SqlParameter("@EnvironmentID", RobloxEnvironment.Id),
			new SqlParameter("@ServerTypeID", serverTypeId),
			new SqlParameter("@ServerStatusID", serverStatusId)
		};
		return RobloxDatabase.RobloxInfrastructure.ExecuteReader("Servers_GetServersByServerGroupIDEnvironmentIDServerTypeIDAndServerStatusID", parameters).Select(BuildServerDefinition).ToList();
	}

	public IReadOnlyCollection<IServer> GetServersBySuperFarmIdAndServerTypeIdWithNoCaching(int superFarmId, int serverTypeId)
	{
		SqlParameter[] parameters = new SqlParameter[3]
		{
			new SqlParameter("@SuperFarmID", superFarmId),
			new SqlParameter("@EnvironmentID", RobloxEnvironment.Id),
			new SqlParameter("@ServerTypeID", serverTypeId)
		};
		return RobloxDatabase.RobloxInfrastructure.ExecuteReader("Servers_GetLiveServersBySuperFarmIDAndEnvironmentIDAndServerTypeID", parameters).Select(BuildServerDefinition).ToList();
	}

	public IReadOnlyCollection<IServer> GetServersBySuperFarmIdAndServerTypeId(int superFarmId, int serverTypeId)
	{
		return InfrastructureCache.FetchItem("serverGroupId:" + superFarmId + "_serverTypeId:" + serverTypeId, _ServerGroupCacheDuration, () => GetServersBySuperFarmIdAndServerTypeIdWithNoCaching(superFarmId, serverTypeId));
	}

	public IReadOnlyCollection<IServer> GetServersByServerTypeId(int serverTypeId)
	{
		return InfrastructureCache.FetchItem("serverTypeId:" + serverTypeId, _ServerGroupCacheDuration, () => GetServersByServerTypeIdWithNoCaching(serverTypeId));
	}

	public IReadOnlyCollection<IServer> GetServersByServerTypeIdWithNoCaching(int serverTypeId)
	{
		SqlParameter[] parameters = new SqlParameter[2]
		{
			new SqlParameter("@EnvironmentID", RobloxEnvironment.Id),
			new SqlParameter("@ServerTypeID", serverTypeId)
		};
		return RobloxDatabase.RobloxInfrastructure.ExecuteReader("Servers_GetLiveServersByEnvironmentIDAndServerTypeID", parameters).Select(BuildServerDefinition).ToList();
	}

	public IServer GetServerById(int serverId)
	{
		return InfrastructureCache.FetchItem("serverId:" + serverId, _IndividualServerLookupCacheDuration, () => GetServerByIdWithNoCaching(serverId));
	}

	public IServer GetServerByIdWithNoCaching(int serverId)
	{
		return RobloxDatabase.RobloxInfrastructure.Get("Servers_GetServerByID", serverId, BuildServerDefinition);
	}

	public IServer GetServerByHostNameWithNoCaching(string hostName)
	{
		return RobloxDatabase.RobloxInfrastructure.Lookup("Servers_GetServerByHostName", BuildServerDefinition, new SqlParameter("@HostName", hostName));
	}

	public IDictionary<int, string> GetAllServerTypes()
	{
		return InfrastructureCache.FetchItem("GetAllServerTypes", _AllServerTypesCacheDuration, GetAllServerTypesWithNoCaching);
	}

	public IDictionary<int, string> GetAllServerTypesWithNoCaching()
	{
		return RobloxDatabase.RobloxInfrastructure.ExecuteReader("ServerTypes_GetAllServerTypes", null).ToDictionary((IDictionary<string, object> m) => (int)m["ID"], (IDictionary<string, object> m) => (string)m["Name"]);
	}

	private static IServer BuildServerDefinition(IDictionary<string, object> row)
	{
		row.TryGetValue("ServerFarmID", out var serverFarmIdObject);
		short serverFarmId = (serverFarmIdObject as short?).GetValueOrDefault();
		return new ServerDefinition
		{
			Id = (int)row["ID"],
			HostName = (string)row["HostName"],
			ServerFarmId = serverFarmId,
			ServerTypeId = (int)row["ServerTypeID"],
			Name = (row["Name"] as string),
			DatacenterId = (row["DataCenterID"] as int?).GetValueOrDefault(),
			PrivateIPAddress = (row["PrivateIPAddress"] as string),
			PrimaryIPAddress = (row["PrimaryIPAddress"] as string),
			UpdatedUtc = DateTimeUtils.ConvertCentralDateTimeToUtc((DateTime)row["Updated"])
		};
	}
}
