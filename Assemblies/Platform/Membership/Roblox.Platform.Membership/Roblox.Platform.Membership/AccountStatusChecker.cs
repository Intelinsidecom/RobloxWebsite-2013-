namespace Roblox.Platform.Membership;

public class AccountStatusChecker : IAccountStatusChecker
{
	public bool IsOk(IUser user)
	{
		return user.AccountStatus == AccountStatus.Ok;
	}

	public bool IsForgotten(IUser user)
	{
		return user.AccountStatus == AccountStatus.Forgotten;
	}
}
