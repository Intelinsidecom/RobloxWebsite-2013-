using System;

namespace Roblox.Platform.Assets;

/// <summary>
/// A wrapper for asset option class in SCL.
/// </summary>
public interface IAssetOption
{
	long Id { get; }

	long AssetId { get; }

	bool EnableComments { get; set; }

	bool EnableRatings { get; }

	bool IsCopyLocked { get; set; }

	bool IsFriendsOnly { get; }

	bool IsAllowingGear { get; }

	ulong AllowedGearCategories { get; }

	long? DefaultExpirationInTicks { get; }

	bool EnforceGenre { get; }

	bool IsExpireable { get; }

	MembershipType MinMembershipType { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
