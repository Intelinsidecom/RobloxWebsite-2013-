namespace Roblox.Platform.TextFilter {
    /// <summary>

/// An interface representing the result of validating text submitted for an object name in <see cref="M:Roblox.Platform.TextFilter.ITextFilter.ValidateObjectName(Roblox.Platform.TextFilter.IObjectNameValidationRequest)" />
/// </summary>
public interface IObjectNameValidationResult
{
	/// <summary>
	/// Whether the request object name is valid
	/// </summary>
	bool IsValid { get; }
}


}
