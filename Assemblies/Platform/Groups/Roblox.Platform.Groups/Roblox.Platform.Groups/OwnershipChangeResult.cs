namespace Roblox.Platform.Groups;

public enum OwnershipChangeResult
{
	Success,
	InvalidGroup,
	Unauthorized,
	NewOwnerDoesNotExist,
	NewOwnerNeedsPremiumMembership,
	NewOwnerNotInGroup,
	OperationUnavailable
}
