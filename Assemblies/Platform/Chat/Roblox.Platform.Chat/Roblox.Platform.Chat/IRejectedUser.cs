using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public interface IRejectedUser
{
	IUser User { get; set; }

	UserRejectedReason Reason { get; set; }
}
