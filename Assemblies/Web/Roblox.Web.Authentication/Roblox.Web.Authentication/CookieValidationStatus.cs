namespace Roblox.Web.Authentication;

internal enum CookieValidationStatus
{
	CookieRetrievalFailed = 0,
	CookieVersionMismatch = 1,
	SessionTokenNotFound = 2,
	SessionTokenExpired = 3,
	IpAddressMismatch = 5,
	InvalidUser = 6,
	InvalidSessionForUser = 8,
	InvalidSessionToken = 9,
	Success = 10,
	SessionTokenNotFoundOnExtend = 11,
	WeChatSessionNotFound = 100,
	TencentSessionNotFound = 101
}
