using System;
using Roblox.EventLog;
using Roblox.Platform.Badges.Properties;
using Roblox.Platform.Counters;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeCounter" />
public class BadgeCounter : IBadgeCounter
{
	private readonly IDurableCounterFactory _DurableCounterFactory;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.BadgeCounter" />.
	/// </summary>
	/// <param name="durableCounterFactory">An <see cref="T:Roblox.Platform.Counters.IDurableCounterFactory" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="settings">The <see cref="T:Roblox.Platform.Badges.Properties.ISettings" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="durableCounterFactory" />, <paramref name="logger" />, <paramref name="settings" /></exception>
	public BadgeCounter(IDurableCounterFactory durableCounterFactory, ILogger logger, ISettings settings)
	{
		_DurableCounterFactory = durableCounterFactory ?? throw new ArgumentNullException("durableCounterFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeCounter.IncrementBadgeAwardCounter(Roblox.Platform.Badges.IBadgeIdentifier)" />
	public void IncrementBadgeAwardCounter(IBadgeIdentifier badgeIdentifier)
	{
		if (badgeIdentifier == null)
		{
			throw new ArgumentNullException("badgeIdentifier");
		}
		GetAllTimeCounter(badgeIdentifier).IncrementInBackground();
		GetTimeBucketedCounter(badgeIdentifier).IncrementInBackground(DateTime.Now);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeCounter.GetBadgeAwardCount(Roblox.Platform.Badges.IBadgeIdentifier,Roblox.Platform.Counters.Frequency)" />
	public long GetBadgeAwardCount(IBadgeIdentifier badgeIdentifier, Frequency frequency)
	{
		try
		{
			if (frequency == Frequency.AllTime)
			{
				return (long)GetAllTimeCounter(badgeIdentifier).GetCount();
			}
			return (long)GetTimeBucketedCounter(badgeIdentifier).GetCount(frequency);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return 0L;
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeCounter.GetBadgeWinRatePercentage(Roblox.Platform.Badges.IBadgeIdentifier,System.Int64)" />
	public double GetBadgeWinRatePercentage(IBadgeIdentifier badge, long pastDayRootPlaceVisits)
	{
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		if (pastDayRootPlaceVisits <= 0)
		{
			return 0.0;
		}
		double rawRarity = Math.Round((double)GetBadgeAwardCount(badge, Frequency.PastDay) * _Settings.BadgeRarityUniquenessCorrectionFactor / (double)pastDayRootPlaceVisits, 3);
		return Math.Min(1.0, rawRarity);
	}

	internal ICounter GetAllTimeCounter(IBadgeIdentifier badgeIdentifier)
	{
		return _DurableCounterFactory.GetCounter("Badge", "Award", badgeIdentifier.Id);
	}

	internal ITimeBucketedCounter GetTimeBucketedCounter(IBadgeIdentifier badgeIdentifier)
	{
		return _DurableCounterFactory.GetTimeBucketedCounter(CounterType.Hourly, "Badge", "Award", badgeIdentifier.Id);
	}
}
