using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class NewsletterUnsubscribeFloodChecker : FloodChecker
{
	public NewsletterUnsubscribeFloodChecker(string ipAddress)
		: base($"NewsletterUnsubscribeFloodChecker_IPAdress:{ipAddress}", Settings.Default.NewsletterUnsubscribeFloodCheckLimit, TimeSpan.FromHours(Settings.Default.NewsletterUnsubscribeFloodCheckExpiryHours))
	{
	}
}
