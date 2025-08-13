namespace Roblox.Platform.Groups;

public enum JoinGroupFailureReason
{
	AlreadyMember,
	UserInMaxGroups,
	JoinRequestAlreadyPending,
	NonexistentGroup,
	NeedsPremiumMembership,
	Floodchecked,
	GroupClosed
}
