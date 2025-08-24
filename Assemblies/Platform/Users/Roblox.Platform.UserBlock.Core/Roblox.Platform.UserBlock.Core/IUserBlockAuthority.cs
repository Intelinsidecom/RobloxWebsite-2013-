using System.Collections.Generic;
using Roblox.Permissions.Client;
using Roblox.Platform.Membership;

namespace Roblox.Platform.UserBlock.Core;

public interface IUserBlockAuthority
{
	string PermissionGroupKey { get; }

	PageResult<long, long> GetBlockedUsersPaged(IUser blocker, int page);

	IEnumerable<long> GetAllBlockedUsers(IUser blocker);

	bool IsBlocked(IUser blocker, long blockeeId);

	bool CheckReciprocalBlock(IUser viewer, IUser viewee, out string msg);

	bool CheckReciprocalBlock(IUser viewer, IUser viewee);

	void SetBlockStatusInCache(IUser blocker, long blockeeId, bool isBlocked);
}
