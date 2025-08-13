namespace Roblox.TextFilter;

/// <summary>
/// An interferface representing a request to validate text submitted for an object name in <see cref="M:Roblox.TextFilter.ITextFilter.ValidateObjectName(Roblox.TextFilter.IObjectNameValidationRequest)" />
/// </summary>
public interface IObjectNameValidationRequest
{
	/// <summary>
	/// The name being requested for validation
	/// </summary>
	string RequestedName { get; }
}
