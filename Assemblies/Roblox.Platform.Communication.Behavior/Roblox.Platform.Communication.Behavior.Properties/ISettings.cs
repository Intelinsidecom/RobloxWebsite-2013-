using System;

namespace Roblox.Platform.Communication.Behavior.Properties;

internal interface ISettings
{
	int EventStreamLoggingUserPercentage { get; }

	int PiiInfractionLimit { get; }

	TimeSpan PiiInfractionTimespan { get; }

	bool PiiInfractionTrackingEnabled { get; }

	TimeSpan PiiBanTimespan { get; }

	int PiiGlobalBanLimit { get; }

	TimeSpan PiiGlobalBanLimitTimespan { get; }

	bool IsPiiBanEnforced { get; }

	bool IsPiiInfractionTrackingEnabled { get; }
}
