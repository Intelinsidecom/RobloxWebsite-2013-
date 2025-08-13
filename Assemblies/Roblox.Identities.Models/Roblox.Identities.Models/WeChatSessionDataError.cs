namespace Roblox.Identities.Models;

/// <summary>
/// Errors that can occur when executing WeChat Identity operations
/// </summary>
public enum WeChatSessionDataError
{
	/// <summary>
	/// Unknown error occurred
	/// </summary>
	UnknownError = 0,
	/// <summary>
	/// The request was called with an empty request object
	/// </summary>
	EmptyRequest = 1,
	/// <summary>
	/// Identity data already exists
	/// </summary>
	ExistingIdentityData = 2,
	/// <summary>
	/// The request was called with bad WeChat Open Id
	/// </summary>
	InvalidWeChatOpenId = 100,
	/// <summary>
	/// Account Id is required
	/// </summary>
	RequiredAccountId = 200,
	/// <summary>
	/// Platform is required
	/// </summary>
	RequiredPlatform = 201,
	/// <summary>
	/// Refresh token is required
	/// </summary>
	RequiredRefreshToken = 202,
	/// <summary>
	/// Access token is required
	/// </summary>
	RequiredAccessToken = 203,
	/// <summary>
	/// Open identifier is required
	/// </summary>
	RequiredOpenId = 204,
	/// <summary>
	/// The identity data was not found
	/// </summary>
	NotFoundIdentityData = 300,
	/// <summary>
	/// The session data was not found
	/// </summary>
	NotFoundSessionData = 301
}
