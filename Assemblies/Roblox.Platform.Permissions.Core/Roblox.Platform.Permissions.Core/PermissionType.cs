namespace Roblox.Platform.Permissions.Core;

public enum PermissionType
{
	EmailIsVerified,
	AccountAgeOverOneDay,
	UserIsAuthenticated,
	NoOne,
	IsInGroupRoleSet,
	IsInGroup,
	IsFriend,
	IsBestFriend,
	IsInList,
	IsAssetCreator,
	IsFollower,
	IsFollowedBy,
	AllUsers,
	IsInClan,
	IsXboxUser,
	IsCoppaAdultAndNotGdprChild,
	IsInGdprJurisdiction,
	IsCoppaAdult,
	IsUserUnder13,
	IsUserUnderChinaPolicy,
	IsTargetUserUnderChinaPolicy,
	PermissionTypeNotFoundError
}
