using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class GiftCardAccessFloodChecker : FloodChecker
{
	public GiftCardAccessFloodChecker(long? userId, string ipAddress)
		: base($"GiftCardAccessFloodChecker_UserId:{userId ?? 0}_IPAdress:{ipAddress}", Settings.Default.GiftCardAccessFloodCheckLimit, TimeSpan.FromHours(Settings.Default.GiftCardAccessFloodCheckExpiryHours))
	{
	}
}
