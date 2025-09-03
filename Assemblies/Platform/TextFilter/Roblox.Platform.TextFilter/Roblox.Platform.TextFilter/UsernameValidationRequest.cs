namespace Roblox.Platform.TextFilter {
    /// <summary>

/// An public implementation of <see cref="T:Roblox.Platform.TextFilter.IUsernameValidationRequest" /> to be instantiated by consumers making username validation requests.
/// </summary>
public class UsernameValidationRequest : IUsernameValidationRequest
{
	/// <summary>
	/// <inheritdoc cref="P:Roblox.Platform.TextFilter.IUsernameValidationRequest.RequestedName" />
	/// </summary>
	public string RequestedName { get; set; }

	/// <summary>
	/// <inheritdoc cref="P:Roblox.Platform.TextFilter.IUsernameValidationRequest.IsUnder13" />
	/// </summary>
	public bool IsUnder13 { get; set; }
}


}
