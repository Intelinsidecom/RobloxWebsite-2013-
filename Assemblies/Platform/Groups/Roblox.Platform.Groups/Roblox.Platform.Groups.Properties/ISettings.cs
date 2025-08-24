using System;

namespace Roblox.Platform.Groups.Properties;

public interface ISettings
{
	int JoinGroupFloodCheckerLimit { get; }

	TimeSpan JoinGroupFloodCheckerExpiry { get; }

	bool JoinGroupFloodCheckerEnabled { get; }

	int ClaimOwnershipFloodCheckerLimit { get; }

	TimeSpan ClaimOwnershipFloodCheckerExpiry { get; }

	bool ClaimOwnershipFloodCheckerEnabled { get; }

	TimeSpan OwnershipLeasedLockTimeSpan { get; }
}
