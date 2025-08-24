using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Infrastructure;

public static class Extensions
{
	public static IEnumerable<short> GetDistinctFarmIds(this IEnumerable<IServer> servers)
	{
		return servers.Select((IServer s) => s.ServerFarmId).Distinct();
	}

	public static IEnumerable<short> GetWebFarmIds(this ServerFactory serverFactory)
	{
		return serverFactory.GetServersByServerType(ServerType.WebServer).GetDistinctFarmIds();
	}
}
