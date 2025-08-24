namespace Roblox.TextFilter;

/// <summary>
/// An public implementation of <see cref="T:Roblox.TextFilter.IUsernameValidationRequest" /> to be instantiated by consumers making username validation requests.
/// </summary>
public class UsernameValidationRequest : IUsernameValidationRequest
{
	/// <summary>
	/// <inheritdoc cref="P:Roblox.TextFilter.IUsernameValidationRequest.RequestedName" />
	/// </summary>
	public string RequestedName { get; set; }

	/// <summary>
	/// <inheritdoc cref="P:Roblox.TextFilter.IUsernameValidationRequest.IsUnder13" />
	/// </summary>
	public bool IsUnder13 { get; set; }
}
