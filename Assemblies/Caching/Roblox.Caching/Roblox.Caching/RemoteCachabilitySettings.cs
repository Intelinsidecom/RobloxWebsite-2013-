using System;
using Roblox.Configuration;

namespace Roblox.Caching;

public class RemoteCachabilitySettings : IRemoteCachabilitySettings
{
	public string MemcachedGroupName { get; private set; }

	public RemoteCachabilitySettings(ISingleSetting<string> memcachedClusterGroupSetting)
	{
		if (memcachedClusterGroupSetting == null)
		{
			throw new ArgumentNullException("memcachedClusterGroupSetting");
		}
		memcachedClusterGroupSetting.MonitorChanges((ISingleSetting<string> s) => s.Value, delegate(string v)
		{
			if (!(MemcachedGroupName == v))
			{
				MemcachedGroupName = v;
			}
		});
		MemcachedGroupName = memcachedClusterGroupSetting.Value;
	}
}
