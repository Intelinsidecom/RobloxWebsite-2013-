namespace Roblox.Platform.Badges;

/// <summary>
///
/// </summary>
public interface IExclusiveStartKeyFactory
{
	/// <summary>
	/// Builds the awarded badge exclusive start key string.
	/// </summary>
	/// <param name="awardedBadgeIdentifier">The awarded badge identifier.</param>
	/// <returns></returns>
	string BuildAwardedBadgeExclusiveStartKeyString(IAwardedBadgeIdentifier awardedBadgeIdentifier);

	/// <summary>
	/// Extracts the awarded badge exclusive start key from string.
	/// </summary>
	/// <param name="awardedBadgeIdentifierKeyString">The awarded badge identifier key string.</param>
	/// <returns></returns>
	IAwardedBadgeIdentifier ExtractAwardedBadgeExclusiveStartKeyFromString(string awardedBadgeIdentifierKeyString);
}
