namespace Roblox.Platform.Marketing;

/// <summary>
/// Defines which type of content can be targeted by Takeovers
///
/// This class is backed by a database table:
///     RobloxMarketing.dbo.ContentItemType
///
/// If you add a new value to this enum you must insert a new value into
/// the database table and have the and int value as the ID.
/// </summary>
public enum ContentItemType
{
	/// <summary>
	/// The takeover is targeted at an Asset, the ContentItemTarget is an AssetId.
	/// </summary>
	Asset = 1
}
