using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Infrastructure;

public class GameServerCpuPowerFetcher
{
	private readonly RefreshAhead<IDictionary<string, int>> _GamesRelayIpAddressToCpuPowerMap;

	public GameServerCpuPowerFetcher()
	{
		_GamesRelayIpAddressToCpuPowerMap = RefreshAhead<IDictionary<string, int>>.ConstructAndPopulate(TimeSpan.FromSeconds(60.0), () => GetServerIpAddressToCpuPowerMap(58, RobloxEnvironment.Id));
	}

	public int GetGameServerCpuPower(string ipAddress)
	{
		_GamesRelayIpAddressToCpuPowerMap.Value.TryGetValue(ipAddress, out var cpuPower);
		return cpuPower;
	}

	private IDictionary<string, int> GetServerIpAddressToCpuPowerMap(int serverGroupId, int environmentId)
	{
		SqlParameter[] parameters = new SqlParameter[2]
		{
			new SqlParameter("@ServerGroupID", serverGroupId),
			new SqlParameter("@EnvironmentID", environmentId)
		};
		Dictionary<string, int> serverCpuPowerByIP = new Dictionary<string, int>();
		foreach (IDictionary<string, object> item in RobloxDatabase.RobloxInfrastructure.ExecuteReader("Servers_GetRccServerIpAddressDataCenterIDTotalCPUPowerByServerGroupIDAndEnvironmentID", parameters))
		{
			string ipAddress = (string)item["IpAddress"];
			int? totalCpuPower = (int?)item["TotalCPUPower"];
			if (totalCpuPower.HasValue)
			{
				serverCpuPowerByIP.Add(ipAddress, totalCpuPower.Value);
			}
		}
		return serverCpuPowerByIP;
	}
}
