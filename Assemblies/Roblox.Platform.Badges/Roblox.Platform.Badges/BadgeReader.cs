using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Badges.Client;
using Roblox.Platform.Badges.Properties;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.Badges;

/// <inheritdoc />
public class BadgeReader : IBadgeReader
{
	private readonly IBadgeConverter _BadgeConverter;

	private readonly IBadgesClient _BadgesClient;

	private readonly ISettings _Settings;

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeReader.AllowedPageSizes" />
	public IReadOnlyCollection<int> AllowedPageSizes { get; internal set; } = (IReadOnlyCollection<int>)(object)new int[4] { 10, 25, 50, 100 };


	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.BadgeReader" />
	/// </summary>
	/// <param name="badgesClient">The <see cref="T:Roblox.Badges.Client.IBadgesClient" /></param>
	/// <param name="settings">The badge <see cref="T:Roblox.Platform.Badges.Properties.ISettings" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badgesClient" />, <paramref name="settings" /></exception>
	public BadgeReader(IBadgesClient badgesClient, ISettings settings)
	{
		_BadgesClient = badgesClient ?? throw new ArgumentNullException("badgesClient");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_BadgeConverter = new BadgeConverter();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeReader.GetBadge(System.Int64)" />
	public Badge GetBadge(long badgeId)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (badgeId <= 0)
		{
			return null;
		}
		GetBadgeByIdResult getBadgeResult = _BadgesClient.GetById(new BadgeIdentifier
		{
			Id = badgeId
		});
		if (((getBadgeResult != null) ? getBadgeResult.Badge : null) == null)
		{
			return null;
		}
		return _BadgeConverter.ConvertToPlatformBadge(getBadgeResult.Badge);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeReader.GetBadges(System.Collections.Generic.ICollection{System.Int64})" />
	/// <exception cref="T:System.ArgumentNullException">
	/// <paramref name="badgeIds" />, 
	/// </exception>
	/// <exception cref="T:System.ArgumentException">
	/// <paramref name="badgeIds" /> Count is bigger than <see cref="P:Roblox.Platform.Badges.Properties.ISettings.BadgeReaderGetBadgesPerCallLimit" />, 
	/// </exception>
	public ICollection<Badge> GetBadges(ICollection<long> badgeIds)
	{
		if (badgeIds == null)
		{
			throw new ArgumentNullException("badgeIds");
		}
		if (!badgeIds.Any())
		{
			return new Badge[0];
		}
		if (badgeIds.Count > _Settings.BadgeReaderGetBadgesPerCallLimit)
		{
			throw new ArgumentException($"Collection size is bigger than limit per call. Current limit: {_Settings.BadgeReaderGetBadgesPerCallLimit}.", "badgeIds");
		}
		GetBadgesByIdsResult getBadgesByIdsResult = _BadgesClient.GetByIds((IReadOnlyCollection<BadgeIdentifier>)(object)((IEnumerable<long>)badgeIds).Select((Func<long, BadgeIdentifier>)((long bid) => new BadgeIdentifier
		{
			Id = bid
		})).ToArray());
		List<Badge> orderedBadges = new List<Badge>();
		foreach (long badgeId in badgeIds)
		{
			Badge badge = getBadgesByIdsResult.Badges.FirstOrDefault((Badge b) => ((BadgeIdentifier)b).Id == badgeId);
			if (badge != null)
			{
				orderedBadges.Add(_BadgeConverter.ConvertToPlatformBadge(badge));
			}
		}
		return orderedBadges;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeReader.GetBadgesByAwarder(Roblox.Platform.Badges.IBadgeAwarder,Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo{System.Int64})" />
	public IPlatformPageResponse<long, Badge> GetBadgesByAwarder(IBadgeAwarder badgeAwarder, IExclusiveStartKeyInfo<long> exclusiveStartInfo)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		if (badgeAwarder == null)
		{
			throw new ArgumentNullException("badgeAwarder");
		}
		if (exclusiveStartInfo == null)
		{
			throw new ArgumentNullException("exclusiveStartInfo");
		}
		if (!AllowedPageSizes.Contains(exclusiveStartInfo.Count))
		{
			throw new ArgumentException(string.Format("{0}.{1} can't be equal to {2}.", "exclusiveStartInfo", "Count", exclusiveStartInfo.Count) + string.Format(" Available options are: {0}", string.Join(", ", AllowedPageSizes)), "exclusiveStartInfo");
		}
		if (badgeAwarder.Type != BadgeAwarderType.Place)
		{
			throw new ArgumentException(string.Format("{0}.{1} is not Place.", "badgeAwarder", "Type"), "badgeAwarder");
		}
		BadgeIdentifier exclusiveBadgeIdentifier = null;
		if (exclusiveStartInfo.TryGetExclusiveStartKey(out var exclusiveStartKey))
		{
			if (exclusiveStartKey < 0)
			{
				throw new ArgumentException("ExclusiveStartKey cannot be negative.", "exclusiveStartInfo");
			}
			exclusiveBadgeIdentifier = new BadgeIdentifier
			{
				Id = exclusiveStartKey
			};
		}
		return new PlatformPageResponse<long, Badge>(_BadgesClient.GetBadgesByAwarder(_BadgeConverter.ConvertToClientBadgeAwarder(badgeAwarder), exclusiveBadgeIdentifier, exclusiveStartInfo.Count + 1, _BadgeConverter.ConvertToClientSortOrder(exclusiveStartInfo.GetDatabaseRequestSortOrder())).Badges.Select(_BadgeConverter.ConvertToPlatformBadge).ToArray(), exclusiveStartInfo, (Badge b) => b.Id);
	}
}
