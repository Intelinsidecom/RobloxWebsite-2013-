using System;
using Roblox.Configuration;

namespace Roblox.Caching;

public class MigrationCacheabilitySettings : IMigrationCacheabilitySettings
{
	public string MigrationMemcachedGroupName { get; internal set; }

	public MigrationStateChange MigrationStateChange { get; internal set; }

	public MigrationCacheabilitySettings(ISingleSetting<string> migrationMemcachedGroupName, ISingleSetting<MigrationStateChange> migrationStateChange)
	{
		if (migrationMemcachedGroupName == null)
		{
			throw new ArgumentNullException("migrationMemcachedGroupName");
		}
		if (migrationStateChange == null)
		{
			throw new ArgumentNullException("migrationStateChange");
		}
		migrationMemcachedGroupName.ReadValueAndMonitorChanges((ISingleSetting<string> s) => s.Value, delegate(string v)
		{
			if (!(MigrationMemcachedGroupName == v))
			{
				MigrationMemcachedGroupName = v;
			}
		});
		migrationStateChange.ReadValueAndMonitorChanges((ISingleSetting<MigrationStateChange> s) => s.Value, delegate(MigrationStateChange v)
		{
			if (!(MigrationStateChange == v))
			{
				if (MigrationStateChange == null)
				{
					MigrationStateChange = v;
				}
				else if (MigrationStateChange.SourceState == v.SourceState && MigrationStateChange.DestinationState == v.DestinationState)
				{
					MigrationStateChange.RolloutPerThousand = v.RolloutPerThousand;
				}
				else
				{
					MigrationStateChange = v;
				}
			}
		});
	}
}
