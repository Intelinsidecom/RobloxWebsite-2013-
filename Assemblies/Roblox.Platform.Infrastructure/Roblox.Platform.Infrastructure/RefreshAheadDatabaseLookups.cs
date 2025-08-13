using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Newtonsoft.Json;
using Roblox.Caching;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;
using Roblox.Networking;
using Roblox.Platform.Infrastructure.Properties;

namespace Roblox.Platform.Infrastructure;

internal static class RefreshAheadDatabaseLookups
{
	private static readonly TimeSpan _GetLiveIPAddressesWithServerAndVendorInfoExpiration = TimeSpan.FromMinutes(1.0);

	private static readonly LazyWithRetry<RefreshAhead<Dictionary<int, string>>> _VendorIDToNameMapRefreshAhead = new LazyWithRetry<RefreshAhead<Dictionary<int, string>>>(GetVendorIDToNameMapRefreshAhead);

	private static readonly LazyWithRetry<RefreshAhead<Dictionary<string, Server>>> _IPAddressToServerMapRefreshAhead = new LazyWithRetry<RefreshAhead<Dictionary<string, Server>>>(GetIPAddressToServerMapRefreshAhead);

	private static readonly LazyWithRetry<RefreshAhead<HashSet<int>>> _ServerIDsInAllowedGroupsRefreshAhead = new LazyWithRetry<RefreshAhead<HashSet<int>>>(GetServerIDsInAllowedGroupsRefreshAhead);

	private static readonly LazyWithRetry<RefreshAhead<HashSet<string>>> _DosArrestNetworksIpAddressesRefreshAhead = new LazyWithRetry<RefreshAhead<HashSet<string>>>(GetDosArrestNetworksIpAddressesRefreshAhead);

	private static readonly LazyWithRetry<RefreshAhead<HashSet<string>>> _SnatIpAddressesRefreshAhead = new LazyWithRetry<RefreshAhead<HashSet<string>>>(GetSnatIpAddressesRefreshAhead);

	public static Dictionary<int, string> VendorIDToNameMap => _VendorIDToNameMapRefreshAhead.Value.Value;

	public static Dictionary<string, Server> IPAddressToServerMap => _IPAddressToServerMapRefreshAhead.Value.Value;

	public static HashSet<int> ServerIDsInAllowedGroups => _ServerIDsInAllowedGroupsRefreshAhead.Value.Value;

	public static HashSet<string> DosArrestNetworksIpAddresses => _DosArrestNetworksIpAddressesRefreshAhead.Value.Value;

	public static HashSet<string> SnatIpAddresses => _SnatIpAddressesRefreshAhead.Value.Value;

	private static RefreshAhead<Dictionary<int, string>> GetVendorIDToNameMapRefreshAhead()
	{
		return RefreshAhead<Dictionary<int, string>>.ConstructAndPopulate(Settings.Default.VendorIDToNameMapRefreshInterval, () => GetAllVendorIDsAndNames());
	}

	private static RefreshAhead<Dictionary<string, Server>> GetIPAddressToServerMapRefreshAhead()
	{
		return RefreshAhead<Dictionary<string, Server>>.ConstructAndPopulate(Settings.Default.PrimaryIPAddressToServerMapRefreshInterval, (Func<Dictionary<string, Server>>)delegate
		{
			Dictionary<string, Server> dictionary = new Dictionary<string, Server>();
			foreach (Server current in GetLiveServerIDsAndServerTypeAndServerStatusAndVendorIDAndPrimaryIP())
			{
				dictionary[current.IPAddress] = current;
			}
			return dictionary;
		});
	}

	private static RefreshAhead<HashSet<int>> GetServerIDsInAllowedGroupsRefreshAhead()
	{
		return RefreshAhead<HashSet<int>>.ConstructAndPopulate(Settings.Default.ServerIDsInAllowedGroupsRefreshInterval, (Func<HashSet<int>>)delegate
		{
			int[] array = Settings.Default.AllowedServerGroupIDs.Split(',').Select(int.Parse).ToArray();
			HashSet<int> allServerIds = new HashSet<int>();
			int[] array2 = array;
			for (int j = 0; j < array2.Length; j++)
			{
				GetAllServersIDsForGroupID(array2[j]).ForEach(delegate(int i)
				{
					allServerIds.Add(i);
				});
			}
			return allServerIds;
		});
	}

	private static RefreshAhead<HashSet<string>> GetDosArrestNetworksIpAddressesRefreshAhead()
	{
		return RefreshAhead<HashSet<string>>.ConstructAndPopulate(Settings.Default.DosArrestNetworksRefreshInterval, (Func<HashSet<string>>)delegate
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string dosArrestNetworkPrefix in GetDosArrestNetworkPrefixes())
			{
				foreach (string current in IpPrefixParser.ComputeIpAddressesFromPrefix(dosArrestNetworkPrefix))
				{
					hashSet.Add(current);
				}
			}
			return hashSet;
		});
	}

	private static RefreshAhead<HashSet<string>> GetSnatIpAddressesRefreshAhead()
	{
		return RefreshAhead<HashSet<string>>.ConstructAndPopulate(Settings.Default.SnatIpAddressesRefreshInterval, (Func<HashSet<string>>)delegate
		{
			HashSet<string> hashSet = new HashSet<string>();
			if (Settings.Default.ReadSnatIpAddressesFromDatabase)
			{
				foreach (string networkSnatPrefix in GetNetworkSnatPrefixes())
				{
					foreach (string current in IpPrefixParser.ComputeIpAddressesFromPrefix(networkSnatPrefix))
					{
						hashSet.Add(current);
					}
				}
			}
			return hashSet;
		});
	}

	private static Dictionary<int, string> GetAllVendorIDsAndNames()
	{
		DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "Vendors_GetAllVendorIDsAndNames");
		Dictionary<int, string> map = new Dictionary<int, string>();
		using DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString);
		using SqlDataReader dataReader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
		while (dataReader.Read())
		{
			int id = (int)dataReader["ID"];
			string name = (string)dataReader["Name"];
			map[id] = name;
		}
		return map;
	}

	private static List<int> GetAllServersIDsForGroupID(int serverGroupID)
	{
		List<int> list = new List<int>();
		DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "ServerGroupMembers_GetAllServersIDsForGroupID");
		using DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString);
		dbHelper.SQLParameters.Add(new SqlParameter("@ServerGroupID", serverGroupID));
		using SqlDataReader reader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
		while (reader.Read())
		{
			int id = (int)reader["ServerID"];
			list.Add(id);
		}
		return list;
	}

	private static IEnumerable<Server> GetLiveServerIDsAndServerTypeAndServerStatusAndVendorIDAndPrimaryIP()
	{
		string[] serversStrings = InfrastructureCache.GetStringArrayFromRedis("Servers:GetLiveIPAddressesWithServerAndVendorInfo");
		if (serversStrings == null)
		{
			List<Server> list = new List<Server>();
			DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "Servers_GetLiveIPAddressesWithServerAndVendorInfo");
			using (DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString))
			{
				using SqlDataReader reader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
				while (reader.Read())
				{
					if (reader["ServerStatusID"] is int serverStatusId && reader["ServerTypeID"] is int serverTypeId)
					{
						Server server = new Server
						{
							ID = (int)reader["ID"],
							ServerStatusID = serverStatusId,
							ServerTypeID = serverTypeId,
							VendorID = (int)reader["VendorID"],
							IPAddress = (string)reader["IPAddress"]
						};
						list.Add(server);
					}
				}
			}
			serversStrings = list.Select(JsonConvert.SerializeObject).ToArray();
			InfrastructureCache.WriteStringArrayToRedis("Servers:GetLiveIPAddressesWithServerAndVendorInfo", serversStrings, _GetLiveIPAddressesWithServerAndVendorInfoExpiration);
			return list;
		}
		return serversStrings.Select(JsonConvert.DeserializeObject<Server>);
	}

	private static List<string> GetDosArrestNetworkPrefixes()
	{
		List<string> result = new List<string>();
		int dosArrestDataSenterId;
		using (DbHelper dbHelper2 = new DbHelper(new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "DataCenters_GetDataCenterByName").ConnectionString))
		{
			dbHelper2.SQLParameters.Add(new SqlParameter("@Name", "DosArrest-Global"));
			using SqlDataReader sqlDataReader = dbHelper2.ExecuteSQLReader("DataCenters_GetDataCenterByName", CommandType.StoredProcedure);
			if (!sqlDataReader.Read())
			{
				return new List<string>();
			}
			dosArrestDataSenterId = (int)sqlDataReader["ID"];
		}
		DbInfo dbInfo2 = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "Networks_GetEnabledByDataCenterID");
		using DbHelper dbHelper = new DbHelper(dbInfo2.ConnectionString);
		dbHelper.SQLParameters.Add(new SqlParameter("@DataCenterID", dosArrestDataSenterId));
		using SqlDataReader reader = dbHelper.ExecuteSQLReader(dbInfo2.StoredProcedure, CommandType.StoredProcedure);
		while (reader.Read())
		{
			result.Add((string)reader["NetworkPrefix"]);
		}
		return result;
	}

	private static List<string> GetNetworkSnatPrefixes()
	{
		List<string> list = new List<string>();
		DbInfo dbInfo = new DbInfo(RobloxDatabase.RobloxInfrastructure.GetConnectionString(), "Networks_GetSNATRanges");
		using DbHelper dbHelper = new DbHelper(dbInfo.ConnectionString);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader(dbInfo.StoredProcedure, CommandType.StoredProcedure);
		while (reader.Read())
		{
			list.Add((string)reader["NetworkPrefix"]);
		}
		return list;
	}
}
