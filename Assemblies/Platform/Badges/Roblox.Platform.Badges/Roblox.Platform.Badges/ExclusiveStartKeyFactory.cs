using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Badges;

internal class ExclusiveStartKeyFactory : IExclusiveStartKeyFactory
{
	private const char _KeyPartsSeparator = '.';

	public string BuildAwardedBadgeExclusiveStartKeyString(IAwardedBadgeIdentifier awardedBadgeIdentifier)
	{
		if (awardedBadgeIdentifier == null)
		{
			throw new PlatformArgumentNullException("awardedBadgeIdentifier");
		}
		return $"{awardedBadgeIdentifier.Id}{'.'}{awardedBadgeIdentifier.AwardDateTime.Ticks}";
	}

	public IAwardedBadgeIdentifier ExtractAwardedBadgeExclusiveStartKeyFromString(string awardedBadgeIdentifierKeyString)
	{
		if (string.IsNullOrWhiteSpace(awardedBadgeIdentifierKeyString))
		{
			throw new PlatformArgumentException(string.Format("{0} must be a non-empty string.", "awardedBadgeIdentifierKeyString"));
		}
		string[] array = awardedBadgeIdentifierKeyString.Split('.');
		if (array.Length != 2)
		{
			throw new PlatformArgumentException(string.Format("{0} is not valid key.", "awardedBadgeIdentifierKeyString"));
		}
		if (!long.TryParse(array[0], out var badgeId))
		{
			throw new PlatformArgumentException(string.Format("{0} is not valid key.", "awardedBadgeIdentifierKeyString"));
		}
		if (!long.TryParse(array[1], out var ticks))
		{
			throw new PlatformArgumentException(string.Format("{0} is not valid key.", "awardedBadgeIdentifierKeyString"));
		}
		return new AwardedBadgeIdentifier(badgeId, new DateTime(ticks, DateTimeKind.Utc));
	}
}
