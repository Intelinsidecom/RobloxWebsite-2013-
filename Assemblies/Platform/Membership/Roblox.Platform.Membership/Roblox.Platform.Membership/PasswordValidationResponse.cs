namespace Roblox.Platform.Membership;

internal class PasswordValidationResponse : IPasswordValidationResponse
{
	public PasswordValidationResult Result { get; }

	public PasswordValidationResponse(PasswordValidationResult result)
	{
		Result = result;
	}
}
