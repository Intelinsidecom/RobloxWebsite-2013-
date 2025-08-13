namespace Roblox.TextFilter;

/// <summary>
/// A public implementation of <see cref="T:Roblox.TextFilter.IObjectNameValidationRequest" /> to be instantiated by consumers making username validation requests.
/// </summary>
public class ObjectNameValidationRequest : IObjectNameValidationRequest
{
	/// <summary>
	/// <inheritdoc cref="P:Roblox.TextFilter.IUsernameValidationRequest.RequestedName" />
	/// </summary>
	public string RequestedName { get; }

	/// <summary>
	/// Default constructor
	/// </summary>
	/// <param name="requestedName"></param>
	public ObjectNameValidationRequest(string requestedName)
	{
		RequestedName = requestedName;
	}
}
