using System.Collections.Generic;

namespace Roblox.Games.Client;

public class UpdatePolicyGroupMembersPostData
{
	public IReadOnlyCollection<PolicyGroupMember> PolicyGroupMembers { get; set; }
}
