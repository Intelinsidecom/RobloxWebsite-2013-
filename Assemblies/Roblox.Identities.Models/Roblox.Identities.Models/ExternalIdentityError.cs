namespace Roblox.Identities.Models;

/// <summary>
/// Errors that can occur when executing External Identity operations
/// </summary>
public enum ExternalIdentityError
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
	/// The request was called with an invalid external ID
	/// </summary>
	InvalidExternalId,
	/// <summary>
	/// The external ID of that type is already linked to an account ID 
	/// </summary>
	ExternalIdAlreadyLinked,
	/// <summary>
	/// The account ID is already linked to an external ID of that type
	/// </summary>
	AccountIdAlreadyLinked
}
