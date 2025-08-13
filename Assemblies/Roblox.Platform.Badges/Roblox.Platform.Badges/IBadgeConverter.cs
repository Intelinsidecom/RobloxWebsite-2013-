using Roblox.ApiClientBase;
using Roblox.Badges.Client;
using Roblox.DataV2.Core;

namespace Roblox.Platform.Badges;

internal interface IBadgeConverter
{
	Roblox.ApiClientBase.SortOrder ConvertToClientSortOrder(Roblox.DataV2.Core.SortOrder sortOrder);

	Badge ConvertToPlatformBadge(Badge badge);

	BadgeAwarder ConvertToPlatformBadgeAwarder(Awarder clientBadgeAwarder);

	Awarder ConvertToClientBadgeAwarder(IBadgeAwarder platformBadgeAwarder);

	Badge ConvertToClientBadge(Badge badge);
}
