using System;

namespace Roblox.AuthenticationV2.Properties;

internal interface ISettings
{
	string AuthenticationV2CookieName { get; }

	TimeSpan AuthenticationV2CookieTimeToLive { get; }

	string RobloxUserClaimType { get; }

	bool IsAuthenticationV2ForSoothsayersEnabled { get; }

	bool IsAuthenticationV2ForEveryoneEnabled { get; }

	int AuthenticationV2RolloutPerMyriad { get; }
}
