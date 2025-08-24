namespace Roblox.TextFilter;

internal class ObjectNameValidationResult : IObjectNameValidationResult
{
	public bool IsValid { get; }

	public ObjectNameValidationResult(bool isValid)
	{
		IsValid = isValid;
	}
}
