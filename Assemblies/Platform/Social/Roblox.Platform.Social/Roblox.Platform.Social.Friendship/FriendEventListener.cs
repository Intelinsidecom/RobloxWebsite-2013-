using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream;
using Roblox.Platform.Social.Events;

namespace Roblox.Platform.Social.Friendship;

public static class FriendEventListener
{
	private static FriendshipEventPublisher _FriendshipEventPublisher;

	public static void Register(IFriendshipFactory friendshipFactory, IFriendshipCreator friendshipCreator, IEventStreamer eventStreamer, Func<FriendshipEventArgs> friendshipArgsGetter, ILogger logger)
	{
		if (friendshipFactory == null)
		{
			throw new PlatformArgumentNullException("friendshipFactory cannot be null");
		}
		_FriendshipEventPublisher = new FriendshipEventPublisher("Friending", eventStreamer, friendshipArgsGetter, logger);
		friendshipFactory.OnFriendRequestAccept += OnFriendRequestAccept;
		friendshipFactory.OnFriendRequestIgnore += OnFriendRequestIgnore;
		friendshipFactory.OnFriendRequestUnfriend += OnFriendRequestUnfriend;
		friendshipCreator.OnFriendRequestSent += OnFriendRequestSent;
	}

	private static void OnFriendRequestAccept(long senderUserId, long recipientUserId, bool isInGame, bool isInApp)
	{
		_FriendshipEventPublisher.HandleEvent(senderUserId, recipientUserId, FriendingEventType.Accept, isInGame, isInApp);
	}

	private static void OnFriendRequestIgnore(long senderUserId, long recipientUserId, bool isInGame, bool isInApp)
	{
		_FriendshipEventPublisher.HandleEvent(senderUserId, recipientUserId, FriendingEventType.Ignore, isInGame, isInApp);
	}

	private static void OnFriendRequestSent(long senderUserId, long recipientUserId, bool sentFromInGame, bool sentFromInApp)
	{
		_FriendshipEventPublisher.HandleEvent(senderUserId, recipientUserId, FriendingEventType.Request, sentFromInGame, sentFromInApp);
	}

	private static void OnFriendRequestUnfriend(long senderUserId, long recipientUserId, bool isInGame, bool isInApp)
	{
		_FriendshipEventPublisher.HandleEvent(senderUserId, recipientUserId, FriendingEventType.Unfriend, isInGame, isInApp);
	}
}
