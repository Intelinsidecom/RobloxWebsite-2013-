using System;

namespace Roblox.Platform.Captcha.Properties;

internal interface ISettings
{
	object this[string propertyName] { get; set; }

	bool CaptchaFirstFollowRequestEnabledForAll { get; }

	bool CaptchaFirstFriendRequestEnabledForAll { get; }

	bool CaptchaFirstGroupJoinEnabledForAll { get; }

	bool CaptchaFirstPostCommentEnabledForAll { get; }

	bool CaptchaFirstPostCommentEnabledForSoothsayers { get; }

	int FollowCaptchaMinUserAgeInDays { get; }

	int FriendRequestCaptchaMinUserAgeInDays { get; }

	int GroupJoinCaptchaMinUserAgeInDays { get; }

	bool IsAccountAgeBypassCaptchaEnabled { get; }

	bool IsCaptchaFirstMessageEnabledForAll { get; }

	bool IsTimeInGameBypassCaptchaEnabled { get; }

	int MessageCaptchaMinUserAgeInDays { get; }

	TimeSpan SuccessExpirationTime { get; }

	bool TimeInGameBypassOnlyIncludeRecentMonths { get; }

	int TimeInGameMonthsRangeFromCurrentInclusive { get; }

	int TimeInGameSecondsBypassCaptchaThreshold { get; }

	bool IsCaptchaV2RequiredForAllRequests { get; }
}
