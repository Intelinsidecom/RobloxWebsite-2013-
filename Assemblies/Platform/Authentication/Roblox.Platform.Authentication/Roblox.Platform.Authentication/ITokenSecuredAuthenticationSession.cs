namespace Roblox.Platform.Authentication;

public interface ITokenSecuredAuthenticationSession : IAuthenticationSession
{
	ISessionToken SessionToken { get; }
}
