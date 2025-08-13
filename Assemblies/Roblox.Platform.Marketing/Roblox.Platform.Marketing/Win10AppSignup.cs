using System;
using Roblox.Platform.Marketing.Core.Entities;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Marketing;

internal class Win10AppSignup : IWin10AppSignup
{
	public IUserIdentifier User { get; internal set; }

	public DateTime Created { get; internal set; }

	internal Win10AppSignup(Roblox.Platform.Marketing.Core.Entities.Win10AppSignup entity)
	{
		User = UserIdentifierFactory.GetUserIdentifier(entity.UserID);
		Created = entity.Created;
	}
}
