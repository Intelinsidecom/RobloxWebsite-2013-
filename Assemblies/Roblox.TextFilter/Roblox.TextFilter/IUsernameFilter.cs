namespace Roblox.TextFilter;

/// <summary>
/// An interface representing a text filter for usernames.
///
/// This does NOT cover any other business logic for username validation, such as:
/// - whether the name is already taken
/// - whether the name is too long
/// </summary>
internal interface IUsernameFilter
{
	/// <summary>
	/// Evaluates a username against the 13-or-over username filter
	/// </summary>
	IUsernameValidationResult Evaluate13OUsername(string username);

	/// <summary>
	/// Evaluates a username against the under-13 username filter
	/// </summary>
	IUsernameValidationResult EvaluateU13Username(string username);
}
