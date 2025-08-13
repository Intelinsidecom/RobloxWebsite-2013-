using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class RejectedUser : IRejectedUser
{
	public IUser User { get; set; }

	public UserRejectedReason Reason { get; set; }
}
