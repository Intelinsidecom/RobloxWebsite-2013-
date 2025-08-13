namespace Roblox.Platform.Social;

public enum FriendshipOperationErrorType
{
	AlreadyExists = 2,
	InvalidParameters = 3,
	SelfFriendingAttempt = 6,
	SelfFollowingAttempt = 7,
	NotRecipient = 8,
	FloodLimitExceeded = 9,
	DoesNotExist = 10,
	CurrentUserFriendsLimitExceeded = 12,
	OtherUserFriendsLimitExceeded = 13,
	InvalidUser = 14,
	BannedUser = 15,
	BlockedUser = 16,
	UsersAreNotInSameGame = 17,
	UserHasNotPassedCaptcha = 18,
	PermissionsCheckUnsuccessful = 19,
	PolicyCheckUnsuccessful = 20
}
