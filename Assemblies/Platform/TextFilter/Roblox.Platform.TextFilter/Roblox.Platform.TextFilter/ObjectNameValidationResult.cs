namespace Roblox.Platform.TextFilter {
    class ObjectNameValidationResult : IObjectNameValidationResult

{
	public bool IsValid { get; }

	public ObjectNameValidationResult(bool isValid)
	{
		IsValid = isValid;
	}
}


}
