namespace Roblox.Platform.Authentication;

internal class AuthenticationResult : IAuthenticationResult
{
	public bool IsValid { get; }

	public int? AccountId { get; }

	public ISessionToken SessionToken { get; }

	internal AuthenticationResult(bool isValid, int? accountId, ISessionToken sessionToken)
	{
		SessionToken = sessionToken;
		AccountId = accountId;
		IsValid = isValid;
	}
}
