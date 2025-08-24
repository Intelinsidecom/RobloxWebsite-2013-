namespace Roblox.Identities.Models;

/// <summary>
/// Errors that can occur in Identity Data Operations
/// </summary>
public enum IdentityDataError
{
	/// <summary>
	/// An Unknown Error occured
	/// </summary>
	UnknownError,
	/// <summary>
	/// The request was empty
	/// </summary>
	EmptyRequest,
	/// <summary>
	/// The external identity could not be found
	/// </summary>
	NotFoundExternalIdentity,
	/// <summary>
	/// The identity data could not be found
	/// </summary>
	NotFoundIdentityData
}
