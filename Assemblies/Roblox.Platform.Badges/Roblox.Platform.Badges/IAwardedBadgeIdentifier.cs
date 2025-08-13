using System;

namespace Roblox.Platform.Badges;

/// <summary>
/// Awarded Badge Identifier
/// </summary>
public interface IAwardedBadgeIdentifier : IBadgeIdentifier
{
	/// <summary>
	/// Gets or sets the award date time.
	/// </summary>
	DateTime AwardDateTime { get; }
}
