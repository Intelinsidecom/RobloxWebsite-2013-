namespace Roblox.Identities.Models;

/// <summary>
/// Errors that can occur with QQ session Data
/// </summary>
public enum QQSessionDataError
{
	/// <summary>
	/// Unknown error occurred
	/// </summary>
	UnknownError,
	/// <summary>
	/// The request was called with an empty request object
	/// </summary>
	EmptyRequest,
	/// <summary>
	/// An Open ID is needed
	/// </summary>
	RequiredOpenId,
	/// <summary>
	/// The identity data could not be found
	/// </summary>
	NotFoundIdentityData,
	/// <summary>
	/// The session data could not be found
	/// </summary>
	NotFoundSessionData,
	/// <summary>
	/// The QQ account could not be found in the external ID table
	/// </summary>
	NotFoundExternalIdentity,
	/// <summary>
	/// An Account ID is needed
	/// </summary>
	RequiredAccountId,
	/// <summary>
	/// A platform type is needed
	/// </summary>
	RequiredPlatformType,
	/// <summary>
	/// An access token is required
	/// </summary>
	RequiredAccessToken
}
