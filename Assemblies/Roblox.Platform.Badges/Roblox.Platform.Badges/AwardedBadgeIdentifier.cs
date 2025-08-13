using System;

namespace Roblox.Platform.Badges;

/// <summary>
/// Implementation of IAwardedBadgeIdentifier
/// </summary>
public class AwardedBadgeIdentifier : IAwardedBadgeIdentifier, IBadgeIdentifier
{
	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeIdentifier.Id" />
	public long Id { get; }

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IAwardedBadgeIdentifier.AwardDateTime" />
	public DateTime AwardDateTime { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Badges.AwardedBadgeIdentifier" /> class.
	/// </summary>
	/// <param name="id">The Badge Id.</param>
	/// <param name="awardDateTime">The Badge award date time.</param>
	public AwardedBadgeIdentifier(long id, DateTime awardDateTime)
	{
		Id = id;
		AwardDateTime = awardDateTime;
	}
}
