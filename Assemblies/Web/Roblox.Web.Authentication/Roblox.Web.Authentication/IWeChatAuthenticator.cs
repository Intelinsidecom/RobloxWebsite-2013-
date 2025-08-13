using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

public interface IWeChatAuthenticator
{
	ILoginResult Authenticate(IUser user);
}
