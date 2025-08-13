using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public class GroupJoinRequestFactory : IGroupJoinRequestFactory
{
	public virtual IEnumerable<GroupJoinRequest> GetGroupJoinRequestsByUser(IUser user)
	{
		user.VerifyIsNotNull();
		return GroupJoinRequest.GetGroupJoinRequestsByUserID(user.Id);
	}

	public IPlatformPageResponse<long, GroupJoinRequest> GetGroupJoinRequestsByGroup(IGroup group, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		if (exclusiveStartKeyInfo.Count < 0)
		{
			throw new ArgumentOutOfRangeException("exclusiveStartKeyInfo", "ExclusiveStartKeyInfo Count is out of range");
		}
		return new PlatformPageResponse<long, GroupJoinRequest>(GroupJoinRequest.GetGroupJoinRequestsByGroupIDEnumerative(group.Id, exclusiveStartKeyInfo.GetNullableExclusiveStartKey(), exclusiveStartKeyInfo.Count + 1).ToArray(), exclusiveStartKeyInfo, (GroupJoinRequest r) => r.ID);
	}

	public virtual GroupJoinRequest GetGroupJoinRequest(IGroup group, IUser user)
	{
		if (user == null)
		{
			return null;
		}
		group.VerifyIsNotNull();
		return GroupJoinRequest.Get(group.Id, user.Id);
	}
}
