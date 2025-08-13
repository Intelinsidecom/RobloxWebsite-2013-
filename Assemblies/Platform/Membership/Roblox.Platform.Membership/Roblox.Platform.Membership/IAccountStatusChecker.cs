namespace Roblox.Platform.Membership;

public interface IAccountStatusChecker
{
	bool IsOk(IUser user);

	bool IsForgotten(IUser user);
}
