using Roblox.Platform.Core;
using Roblox.Platform.Marketing.Core.Entities;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Marketing;

public class Win10AppSignupFactory : IWin10AppSignupFactory
{
	public IWin10AppSignup Create(IUserIdentifier user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (user.Id == 0L)
		{
			throw new PlatformArgumentException("user");
		}
		Roblox.Platform.Marketing.Core.Entities.Win10AppSignup win10AppSignup = new Roblox.Platform.Marketing.Core.Entities.Win10AppSignup();
		win10AppSignup.UserID = user.Id;
		win10AppSignup.Save();
		return new Win10AppSignup(win10AppSignup);
	}
}
