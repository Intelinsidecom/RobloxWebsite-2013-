namespace Roblox.Platform.TextFilter {
    class UsernameValidationResult : IUsernameValidationResult

{
	public bool IsValid { get; set; }

	public bool IsPotentialPiiViolation { get; set; }
}


}
