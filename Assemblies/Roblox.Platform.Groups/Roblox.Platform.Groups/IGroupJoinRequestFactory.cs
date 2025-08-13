using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public interface IGroupJoinRequestFactory
{
	IEnumerable<GroupJoinRequest> GetGroupJoinRequestsByUser(IUser user);

	IPlatformPageResponse<long, GroupJoinRequest> GetGroupJoinRequestsByGroup(IGroup group, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	GroupJoinRequest GetGroupJoinRequest(IGroup group, IUser user);
}
