using System.ComponentModel;
using Roblox.ApiClientBase;
using Roblox.DataV2.Core;

namespace Roblox.Platform.Badges;

internal class BadgeConverter : IBadgeConverter
{
    public Roblox.ApiClientBase.SortOrder ConvertToClientSortOrder(Roblox.DataV2.Core.SortOrder sortOrder)
    {
        if (sortOrder != Roblox.DataV2.Core.SortOrder.Asc)
        {
            return Roblox.ApiClientBase.SortOrder.Desc;
        }
        return Roblox.ApiClientBase.SortOrder.Asc;
    }

    public Roblox.Badges.Client.Badge ConvertToClientBadge(Badge badge)
    {
        //IL_0003: Unknown result type (might be due to invalid IL or missing references)
        //IL_0008: Unknown result type (might be due to invalid IL or missing references)
        //IL_0014: Unknown result type (might be due to invalid IL or missing references)
        //IL_0020: Unknown result type (might be due to invalid IL or missing references)
        //IL_002c: Unknown result type (might be due to invalid IL or missing references)
        //IL_0038: Unknown result type (might be due to invalid IL or missing references)
        //IL_0044: Unknown result type (might be due to invalid IL or missing references)
        //IL_0050: Unknown result type (might be due to invalid IL or missing references)
        //IL_005c: Unknown result type (might be due to invalid IL or missing references)
        //IL_006f: Expected O, but got Unknown
        if (badge != null)
        {
            return new Roblox.Badges.Client.Badge
            {
                Id = badge.Id,
                Created = badge.Created,
                Updated = badge.Updated,
                Description = badge.Description,
                Name = badge.Name,
                IsActive = badge.IsEnabled,
                ImageId = badge.ImageId,
                Awarder = ConvertToClientBadgeAwarder(badge.Awarder)
            };
        }
        return null;
    }

    public Badge ConvertToPlatformBadge(Roblox.Badges.Client.Badge badge)
    {
        if (badge != null)
        {
            return new Badge
            {
                Id = ((Roblox.Badges.Client.BadgeIdentifier)badge).Id,
                Created = badge.Created.ToLocalTime(),
                Updated = badge.Updated.ToLocalTime(),
                Description = badge.Description,
                Name = badge.Name,
                IsEnabled = badge.IsActive,
                ImageId = badge.ImageId,
                Awarder = ConvertToPlatformBadgeAwarder(badge.Awarder)
            };
        }
        return null;
    }

    public BadgeAwarder ConvertToPlatformBadgeAwarder(Roblox.Badges.Client.Awarder clientBadgeAwarder)
    {
        //IL_0018: Unknown result type (might be due to invalid IL or missing references)
        //IL_001d: Unknown result type (might be due to invalid IL or missing references)
        //IL_001e: Unknown result type (might be due to invalid IL or missing references)
        //IL_0020: Invalid comparison between Unknown and I4
        //IL_0040: Unknown result type (might be due to invalid IL or missing references)
        //IL_0046: Unknown result type (might be due to invalid IL or missing references)
        //IL_005a: Expected I4, but got Unknown
        if (clientBadgeAwarder == null)
        {
            return null;
        }
        BadgeAwarder platformBadgeAwarder = new BadgeAwarder
        {
            Id = clientBadgeAwarder.TargetId
        };
        Roblox.Badges.Client.AwarderType type = clientBadgeAwarder.Type;
        if ((int)type == 1)
        {
            platformBadgeAwarder.Type = BadgeAwarderType.Place;
            return platformBadgeAwarder;
        }
        throw new InvalidEnumArgumentException(string.Format("{0}.{1}", "clientBadgeAwarder", "Type"), (int)clientBadgeAwarder.Type, ((object)clientBadgeAwarder.Type).GetType());
    }

    public Roblox.Badges.Client.Awarder ConvertToClientBadgeAwarder(IBadgeAwarder platformBadgeAwarder)
    {
        //IL_0005: Unknown result type (might be due to invalid IL or missing references)
        //IL_000a: Unknown result type (might be due to invalid IL or missing references)
        //IL_0017: Expected O, but got Unknown
        if (platformBadgeAwarder == null)
        {
            return null;
        }
        Roblox.Badges.Client.Awarder clientBadgeAwarder = new Roblox.Badges.Client.Awarder
        {
            TargetId = platformBadgeAwarder.Id
        };
        BadgeAwarderType type = platformBadgeAwarder.Type;
        if (type == BadgeAwarderType.Place)
        {
            clientBadgeAwarder.Type = (Roblox.Badges.Client.AwarderType)1;
            return clientBadgeAwarder;
        }
        throw new InvalidEnumArgumentException(string.Format("{0}.{1}", "platformBadgeAwarder", "Type"), (int)platformBadgeAwarder.Type, platformBadgeAwarder.Type.GetType());
    }
}
