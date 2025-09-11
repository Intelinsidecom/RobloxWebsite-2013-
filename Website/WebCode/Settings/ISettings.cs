namespace Roblox.WebsiteSettings.Properties;

public interface ISettings
{
	bool MatchmakeWithFriends { get; }

	bool XboxCrossPlayUserNameEnabled { get; }

	bool IsRequestUserPartyGameExceptionLoggingEnabled { get; }

	/// <summary>
	/// Indicates if it checks Verified Creator on WWW endpoints
	/// </summary>
	int IsCopyingAllowedOnlyForVerifiedCreatorEnabledRolloutPercentage { get; }

	bool XboxCrossPlayPartyFollowMatchmaking { get; }
}
