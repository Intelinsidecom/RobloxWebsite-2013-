using Roblox.ApiClientBase;
using Roblox.Badges.Client;
using Roblox.DataV2.Core;

namespace Roblox.Platform.Badges;

internal interface IBadgeConverter
{
    Roblox.ApiClientBase.SortOrder ConvertToClientSortOrder(Roblox.DataV2.Core.SortOrder sortOrder);

    Roblox.Platform.Badges.Badge ConvertToPlatformBadge(Roblox.Badges.Client.Badge badge);

    Roblox.Platform.Badges.BadgeAwarder ConvertToPlatformBadgeAwarder(Roblox.Badges.Client.Awarder clientBadgeAwarder);

    Roblox.Badges.Client.Awarder ConvertToClientBadgeAwarder(Roblox.Platform.Badges.IBadgeAwarder platformBadgeAwarder);

    Roblox.Badges.Client.Badge ConvertToClientBadge(Roblox.Platform.Badges.Badge badge);
}
