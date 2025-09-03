namespace Roblox.Platform.TextFilter {
    /// <summary>

/// An interferface representing a request to validate text submitted for an object name in <see cref="M:Roblox.Platform.TextFilter.ITextFilter.ValidateObjectName(Roblox.Platform.TextFilter.IObjectNameValidationRequest)" />
/// </summary>
public interface IObjectNameValidationRequest
{
	/// <summary>
	/// The name being requested for validation
	/// </summary>
	string RequestedName { get; }
}


}
