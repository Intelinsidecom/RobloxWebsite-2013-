using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Infrastructure;

public class SuperFarmMemberFactory
{
	private class SuperFarmMemberDefinition : ISuperFarmMember
	{
		public int Id { get; internal set; }

		public int ServerId { get; internal set; }

		public int SuperFarmId { get; internal set; }
	}

	private static readonly TimeSpan _SuperFarmMemberByServerIdCacheDuration = TimeSpan.FromMinutes(60.0);

	private static readonly TimeSpan _SuperFarmMembersBySuperFarmIdCacheDuration = TimeSpan.FromMinutes(60.0);

	public ISuperFarmMember GetSuperFarmMemberByServerId(int serverId)
	{
		return InfrastructureCache.FetchItem($"GetSuperFarmMemberByServerId:{serverId}", _SuperFarmMemberByServerIdCacheDuration, delegate
		{
			SqlParameter[] sqlParameters = new SqlParameter[1]
			{
				new SqlParameter("@ServerID", serverId)
			};
			IDictionary<string, object> dictionary = RobloxDatabase.RobloxInfrastructure.ExecuteReader("SuperFarmMembers_GetByServerID", sqlParameters).FirstOrDefault();
			return (dictionary != null) ? BuildSuperFarmMemberDefinition(dictionary) : null;
		});
	}

	public IEnumerable<ISuperFarmMember> GetSuperFarmMembersBySuperFarmId(int superFarmId)
	{
		return InfrastructureCache.FetchItem($"GetSuperFarmMembersBySuperFarmId:{superFarmId}", _SuperFarmMembersBySuperFarmIdCacheDuration, delegate
		{
			SqlParameter[] sqlParameters = new SqlParameter[1]
			{
				new SqlParameter("@SuperFarmID", superFarmId)
			};
			return RobloxDatabase.RobloxInfrastructure.ExecuteReader("SuperFarmMembers_GetBySuperFarmID", sqlParameters).Select(BuildSuperFarmMemberDefinition);
		});
	}

	private static ISuperFarmMember BuildSuperFarmMemberDefinition(IDictionary<string, object> row)
	{
		return new SuperFarmMemberDefinition
		{
			Id = (int)row["ID"],
			ServerId = (int)row["ServerID"],
			SuperFarmId = (int)row["SuperFarmID"]
		};
	}
}
