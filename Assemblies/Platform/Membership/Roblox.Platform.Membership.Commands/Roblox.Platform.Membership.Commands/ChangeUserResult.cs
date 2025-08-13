using Roblox.Platform.Core;

namespace Roblox.Platform.Membership.Commands;

internal class ChangeUserResult<T> : Result<T>, IChangeUserResult<T>, IResult<T> where T : struct
{
	public IUser User { get; }

	public ChangeUserResult(IUser user, T response)
		: base(response)
	{
		User = user;
	}
}
