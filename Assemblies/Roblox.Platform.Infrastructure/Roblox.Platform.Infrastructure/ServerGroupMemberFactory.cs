using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Infrastructure;

public class ServerGroupMemberFactory : IServerGroupMemberFactory
{
	private sealed class ServerGroupMember : IServerGroupMember, IEquatable<IServerGroupMember>
	{
		public int Id { get; internal set; }

		public int ServerId { get; internal set; }

		public ServerGroup ServerGroup { get; internal set; }

		public DateTime CreatedUtc { get; internal set; }

		public override int GetHashCode()
		{
			return Id;
		}

		public override bool Equals(object obj)
		{
			if (obj is IServerGroupMember serverGroupMember)
			{
				return Equals(serverGroupMember);
			}
			return false;
		}

		public bool Equals(IServerGroupMember other)
		{
			return Id == other?.Id;
		}
	}

	private const string _GameServerMemberCacheKeyPrefix = "GameServerMembersBy";

	private static readonly TimeSpan _ServerGroupMemberCacheDuration = TimeSpan.FromMinutes(20.0);

	public IReadOnlyCollection<IServerGroupMember> GetServerGroupMembersByServerId(int serverId)
	{
		return GetServerGroupMembersWithCaching(() => GetServerGroupMembersByServerIdWithNoCaching(serverId), serverId);
	}

	public IReadOnlyCollection<IServerGroupMember> GetServerGroupMembersByServerIdWithNoCaching(int serverId)
	{
		SqlParameter[] parameters = new SqlParameter[1]
		{
			new SqlParameter("@ServerID", serverId)
		};
		return RobloxDatabase.RobloxInfrastructure.ExecuteReader("ServerGroupMembers_GetByServerID", parameters).Select(BuildServerGroupMember).ToList();
	}

	public IServerGroupMember GetServerGroupMemberByServerIdAndServerGroup(int serverId, ServerGroup serverGroup)
	{
		return GetServerGroupMemberByServerIdAndServerGroupId(serverId, (int)serverGroup);
	}

	public IServerGroupMember GetServerGroupMemberByServerIdAndServerGroupWithNoCaching(int serverId, ServerGroup serverGroup)
	{
		return GetServerGroupMemberByServerIdAndServerGroupIdWithNoCaching(serverId, (int)serverGroup);
	}

	public IServerGroupMember GetServerGroupMemberByServerIdAndServerGroupId(int serverId, int serverGroupId)
	{
		return GetServerGroupMembersWithCaching(() => GetServerGroupMemberByServerIdAndServerGroupIdWithNoCaching(serverId, serverGroupId), serverId, serverGroupId);
	}

	public IServerGroupMember GetServerGroupMemberByServerIdAndServerGroupIdWithNoCaching(int serverId, int serverGroupId)
	{
		SqlParameter[] parameters = new SqlParameter[2]
		{
			new SqlParameter("@ServerID", serverId),
			new SqlParameter("@ServerGroupID", serverGroupId)
		};
		return RobloxDatabase.RobloxInfrastructure.ExecuteReader("ServerGroupMembers_GetServerGroupMemberByServerAndServerGroup", parameters).Select(BuildServerGroupMember).FirstOrDefault();
	}

	private static T GetServerGroupMembersWithCaching<T>(Func<T> getter, int serverId, int? serverGroupId = null)
	{
		return InfrastructureCache.FetchItem(GetInfrastructureCacheKey(), _ServerGroupMemberCacheDuration, getter);
		string GetInfrastructureCacheKey()
		{
			if (!serverGroupId.HasValue)
			{
				return string.Format("{0}{1}:{2}", "GameServerMembersBy", "serverId", serverId);
			}
			return string.Format("{0}{1}:{2}_{3}:{4}", "GameServerMembersBy", "serverId", serverId, "serverGroupId", serverGroupId);
		}
	}

	private static IServerGroupMember BuildServerGroupMember(IDictionary<string, object> row)
	{
		return new ServerGroupMember
		{
			Id = (int)row["ID"],
			ServerId = (int)row["ServerID"],
			ServerGroup = (ServerGroup)row["ServerGroupID"],
			CreatedUtc = DateTimeUtils.ConvertCentralDateTimeToUtc((DateTime)row["Created"])
		};
	}
}
