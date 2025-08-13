namespace Roblox.Platform.Badges;

/// <summary>
/// Badge creation failure reason types
/// </summary>
public enum BadgeCreationFailureReason
{
	/// <summary>
	/// User cannot create badge for specified universe
	/// </summary>
	UnauthorizedBadgeCreation,
	/// <summary>
	/// User doesn't have permission to manage specified BadgeIcon
	/// </summary>
	UnauthorizedBadgeIconUsage,
	/// <summary>
	/// User cannot purchase a badge
	/// </summary>
	PurchaseFailed,
	/// <summary>
	/// Badge name and/or description were fully moderated
	/// </summary>
	TextFullyModerated,
	/// <summary>
	/// Error on badge instance creation
	/// </summary>
	BadgeInstanceCreationFailed,
	/// <summary>
	/// Unknown error during badge name and description moderation
	/// </summary>
	TextModerationFailed
}
