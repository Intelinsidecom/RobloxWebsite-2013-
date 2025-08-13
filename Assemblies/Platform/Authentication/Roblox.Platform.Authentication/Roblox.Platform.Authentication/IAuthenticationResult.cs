namespace Roblox.Platform.Authentication;

public interface IAuthenticationResult
{
	bool IsValid { get; }

	int? AccountId { get; }

	ISessionToken SessionToken { get; }
}
