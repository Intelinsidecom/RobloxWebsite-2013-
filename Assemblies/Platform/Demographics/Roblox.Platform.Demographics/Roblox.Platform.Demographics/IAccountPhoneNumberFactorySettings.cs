using System;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Settings for the AccountPhoneNumberFactory.
/// In particular, several flood checker settings.
/// </summary>
public interface IAccountPhoneNumberFactorySettings
{
	bool IsAccountPhoneNumberTableAuditingEnabled { get; }

	bool ArePhoneNumberEphemeralCountersEnabled { get; }

	int UserFloodCheckerLimit { get; }

	TimeSpan UserFloodCheckerWindowPeriod { get; }

	bool UserFloodCheckerEnabled { get; }

	bool UserFloodCheckerRecordFloodedEvents { get; }

	int IpFloodCheckerLimit { get; }

	TimeSpan IpFloodCheckerWindowPeriod { get; }

	bool IpFloodCheckerEnabled { get; }

	bool IpFloodCheckerRecordFloodedEvents { get; }
}
