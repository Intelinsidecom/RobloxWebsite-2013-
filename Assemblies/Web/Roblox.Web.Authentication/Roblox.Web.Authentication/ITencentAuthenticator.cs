using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

public interface ITencentAuthenticator
{
	ILoginResult Authenticate(IUser user);
}
