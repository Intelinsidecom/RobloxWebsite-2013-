namespace Roblox.TextFilter;

/// <summary>
/// An interface representing a request to validate text submitted for a username against the <see cref="T:Roblox.TextFilter.IUsernameFilter" />
/// </summary>
public interface IUsernameValidationRequest
{
	/// <summary>
	/// The name being requested for validation
	/// </summary>
	string RequestedName { get; set; }

	/// <summary>
	/// Whether the request is for a user under age of 13
	/// </summary>
	bool IsUnder13 { get; set; }
}
