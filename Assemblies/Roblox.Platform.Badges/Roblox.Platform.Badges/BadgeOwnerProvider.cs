using System;
using Roblox.Data;
using Roblox.Platform.Assets;

namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeOwnerProvider" />
public class BadgeOwnerProvider : IBadgeOwnerProvider
{
	private readonly IPlaceFactory _PlaceFactory;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Badges.BadgeOwnerProvider" />.
	/// </summary>
	/// <param name="placeFactory">An <see cref="T:Roblox.Platform.Assets.IPlaceFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="placeFactory" /></exception>
	public BadgeOwnerProvider(IPlaceFactory placeFactory)
	{
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Badges.IBadgeOwnerProvider.GetBadgeOwner(Roblox.Platform.Badges.Badge)" />
	public BadgeOwner GetBadgeOwner(Badge badge)
	{
		if (badge == null)
		{
			throw new ArgumentNullException("badge");
		}
		if (badge.Awarder.Type != BadgeAwarderType.Place)
		{
			throw new ArgumentException(string.Format("Only {0} awarder type is implemented.", "Place"), "badge");
		}
		IPlace place = _PlaceFactory.Get(badge.Awarder.Id);
		if (place == null)
		{
			throw new DataIntegrityException(string.Format("{0} is not attached to a valid place!", "badge"));
		}
		switch (place.CreatorType)
		{
		case Roblox.Platform.Assets.CreatorType.User:
		{
			BadgeOwner result = default(BadgeOwner);
			result.Id = place.CreatorTargetId;
			result.Type = BadgeOwnerType.User;
			return result;
		}
		case Roblox.Platform.Assets.CreatorType.Group:
		{
			BadgeOwner result = default(BadgeOwner);
			result.Id = place.CreatorTargetId;
			result.Type = BadgeOwnerType.Group;
			return result;
		}
		default:
			throw new NotImplementedException(string.Format("{0} has unsupported owner type.", "badge"));
		}
	}
}
