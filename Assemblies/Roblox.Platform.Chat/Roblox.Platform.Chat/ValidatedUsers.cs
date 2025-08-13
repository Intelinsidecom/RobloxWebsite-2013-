using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class ValidatedUsers
{
	public IReadOnlyCollection<IUser> AcceptedUsers { get; set; }

	public IReadOnlyCollection<IRejectedUser> RejectedUsers { get; set; }
}
