using System;

namespace Roblox.Platform.Assets;

/// <inheritdoc cref="T:Roblox.Platform.Assets.IAssetOption" />
public class AssetOption : IAssetOption
{
	public long Id { get; set; }

	public long AssetId { get; set; }

	public bool EnableComments { get; set; }

	public bool EnableRatings { get; set; }

	public bool IsCopyLocked { get; set; }

	public bool IsFriendsOnly { get; set; }

	public bool IsAllowingGear => AllowedGearCategories != 0;

	public ulong AllowedGearCategories { get; set; }

	public long? DefaultExpirationInTicks { get; set; }

	public bool EnforceGenre { get; set; }

	public bool IsExpireable => DefaultExpirationInTicks.HasValue;

	public MembershipType MinMembershipType { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }
}
