using System;

namespace Roblox.FloodCheckers;

public class ElevatedActionFloodChecker : FloodChecker
{
	public ElevatedActionFloodChecker(string elevatedActionName, string targetType, string targetIdentifier, bool enabled, int limit, TimeSpan expiry)
		: base($"Action:{elevatedActionName}_{targetType}:{targetIdentifier}", limit, expiry, enabled, "Roblox.Web.ElevatedActions")
	{
	}
}
