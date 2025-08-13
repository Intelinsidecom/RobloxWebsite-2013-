using System;
using System.Threading.Tasks;
using System.Web;
using Roblox.Platform.Membership;
using Roblox.Platform.Social.Events;

namespace Roblox.Platform.Social;

public class FriendshipEventListener
{
	public static void Register(IFriendshipFactory friendshipFactory, IUserFactory userFactory, IMessageEventPublisher messageEventPublisher, Action<Exception> exceptionHandler)
	{
		friendshipFactory.OnFriendRequestAccepted += delegate(long friendRequestId, long accepterUserId, long? senderUserId)
		{
			OnFriendRequestAccepted(friendRequestId, accepterUserId, senderUserId, friendshipFactory, userFactory, messageEventPublisher, exceptionHandler);
		};
	}

	private static void OnFriendRequestAccepted(long friendRequestId, long accepterUserId, long? senderUserId, IFriendshipFactory friendshipFactory, IUserFactory userFactory, IMessageEventPublisher messageEventPublisher, Action<Exception> exceptionHandler)
	{
		Task.Factory.StartNew(delegate
		{
			try
			{
				SystemMessageSender systemMessageSender = new SystemMessageSender(messageEventPublisher);
				IUser user = userFactory.GetUser(accepterUserId);
				IFriendRequest friendRequest = friendshipFactory.GetFriendRequest(friendRequestId, senderUserId, accepterUserId);
				IUser user2 = userFactory.GetUser(friendRequest.SenderId);
				if (user != null && user2 != null)
				{
					systemMessageSender.Send("Friend Request: Accepted", $"<a href='/User.aspx?ID={user.Id}'>{HttpUtility.HtmlEncode(user.Name)}</a> has accepted your friend request.", user2);
				}
			}
			catch (Exception obj)
			{
				exceptionHandler(obj);
			}
		});
	}
}
