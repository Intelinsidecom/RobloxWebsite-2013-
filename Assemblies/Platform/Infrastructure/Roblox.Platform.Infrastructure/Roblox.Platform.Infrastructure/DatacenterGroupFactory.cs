using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Infrastructure;

public class DatacenterGroupFactory
{
	private class DatacenterGroupDefinition : IDatacenterGroup
	{
		public int Id { get; internal set; }

		public string Name { get; internal set; }

		public string Description { get; internal set; }
	}

	private static readonly TimeSpan _GroupListCacheDuration = TimeSpan.FromHours(1.0);

	public IEnumerable<IDatacenterGroup> GetAllDatacenterGroups()
	{
		return InfrastructureCache.FetchItem("AllDatacenterGroups", _GroupListCacheDuration, () => RobloxDatabase.RobloxInfrastructure.ExecuteReader("DataCenterGroups_GetAllDataCenterGroups", null).Select(BuildDatacenterGroup).ToArray());
	}

	private static DatacenterGroupDefinition BuildDatacenterGroup(IDictionary<string, object> reader)
	{
		return new DatacenterGroupDefinition
		{
			Id = (int)reader["ID"],
			Description = (reader["Description"] as string),
			Name = (string)reader["Name"]
		};
	}
}
