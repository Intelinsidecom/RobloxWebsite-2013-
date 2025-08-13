using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Properties;

namespace Roblox.Web.Code;

public class DeviceHandleFloodCheckerFactory
{
	public DeviceHandleUserActionFloodChecker GetFloodChecker(ulong btId, UserActionType actionType)
	{
		return actionType switch
		{
			UserActionType.AddFriend => new DeviceHandleUserActionFloodChecker(btId, actionType.ToString(), Settings.Default.DeviceHandleAddFriendFloodCheckLimit, Settings.Default.DeviceHandleAddFriendFloodCheckExpiry, Settings.Default.DeviceHandleAddFriendFloodCheckEnabled), 
			UserActionType.SendMessage => new DeviceHandleUserActionFloodChecker(btId, actionType.ToString(), Settings.Default.DeviceHandleSendMessageFloodCheckLimit, Settings.Default.DeviceHandleSendMessageFloodCheckExpiry, Settings.Default.DeviceHandleSendMessageFloodCheckEnabled), 
			UserActionType.PostComment => new DeviceHandleUserActionFloodChecker(btId, actionType.ToString(), Settings.Default.DeviceHandlePostCommentFloodCheckLimit, Settings.Default.DeviceHandlePostCommentFloodCheckExpiry, Settings.Default.DeviceHandlePostCommentFloodCheckEnabled), 
			UserActionType.GroupJoin => new DeviceHandleUserActionFloodChecker(btId, actionType.ToString(), Settings.Default.DeviceHandleGroupJoinFloodCheckLimit, Settings.Default.DeviceHandleGroupJoinFloodCheckExpiry, Settings.Default.DeviceHandleGroupJoinFloodCheckEnabled), 
			UserActionType.Follow => new DeviceHandleUserActionFloodChecker(btId, actionType.ToString(), Settings.Default.DeviceHandleFollowFloodCheckLimit, Settings.Default.DeviceHandleFollowFloodCheckExpiry, Settings.Default.DeviceHandleFollowFloodCheckEnabled), 
			_ => new DeviceHandleUserActionFloodChecker(btId), 
		};
	}
}
