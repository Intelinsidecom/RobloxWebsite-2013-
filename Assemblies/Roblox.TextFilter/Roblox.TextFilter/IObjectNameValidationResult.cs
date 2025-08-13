namespace Roblox.TextFilter;

/// <summary>
/// An interface representing the result of validating text submitted for an object name in <see cref="M:Roblox.TextFilter.ITextFilter.ValidateObjectName(Roblox.TextFilter.IObjectNameValidationRequest)" />
/// </summary>
public interface IObjectNameValidationResult
{
	/// <summary>
	/// Whether the request object name is valid
	/// </summary>
	bool IsValid { get; }
}
