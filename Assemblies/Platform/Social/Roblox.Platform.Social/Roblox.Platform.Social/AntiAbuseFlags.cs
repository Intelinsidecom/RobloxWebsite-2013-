namespace Roblox.Platform.Social;

/// <summary>
/// A struct containing booleans related to anti-abuse checking and CAPTCHA.
/// </summary>
public struct AntiAbuseFlags
{
	/// <summary>
	/// Is user currently in a game.
	/// </summary>
	public bool IsUserInGame;

	/// <summary>
	/// Is the recipient user in the same game as the sending user.
	/// </summary>
	public bool IsRecipientInSameGameAsUser;

	/// <summary>
	/// Is the user in an app.
	/// </summary>
	public bool IsUserInApp;

	/// <summary>
	/// Has the user filled a captcha or is the user otherwise exempt (e.g. due to time in game).
	/// </summary>
	public bool HasUserFilledOrIsUserExemptFromCaptcha;

	public AntiAbuseFlags(bool isUserInGame, bool isRecipientInSameGameAsUser, bool isUserInApp, bool hasUserFilledOrIsUserExemptFromCaptcha)
	{
		IsUserInGame = isUserInGame;
		IsRecipientInSameGameAsUser = isRecipientInSameGameAsUser;
		IsUserInApp = isUserInApp;
		HasUserFilledOrIsUserExemptFromCaptcha = hasUserFilledOrIsUserExemptFromCaptcha;
	}

	internal FriendshipOperationErrorType? CheckIfSendFriendRequestIsAllowed()
	{
		if (IsUserInGame)
		{
			if (!IsRecipientInSameGameAsUser)
			{
				return FriendshipOperationErrorType.UsersAreNotInSameGame;
			}
		}
		else if (!IsUserInApp && !HasUserFilledOrIsUserExemptFromCaptcha)
		{
			return FriendshipOperationErrorType.UserHasNotPassedCaptcha;
		}
		return null;
	}
}
