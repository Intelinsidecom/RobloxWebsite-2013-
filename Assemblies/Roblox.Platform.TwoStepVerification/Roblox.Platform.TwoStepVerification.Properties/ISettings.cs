using System;

namespace Roblox.Platform.TwoStepVerification.Properties;

internal interface ISettings
{
	int TwoStepVerificationSetFloodCheckLimit { get; }

	TimeSpan TwoStepVerificationSetFloodCheckExpiry { get; }
}
