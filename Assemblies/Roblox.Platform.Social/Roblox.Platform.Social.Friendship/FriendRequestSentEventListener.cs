using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream;
using Roblox.Platform.Social.Events;

namespace Roblox.Platform.Social.Friendship;

public static class FriendRequestSentEventListener
{
	private static CaptchaActionRequestEventPublisher _EventPublisher;

	public static void Register(ICounterRegistry counterRegistry, IFriendshipCreator friendshipCreator, IEventStreamer eventStreamer, Func<CaptchaActionEventArgs> captchaArgsGetter, ILogger logger)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (friendshipCreator == null)
		{
			throw new PlatformArgumentNullException("friendshipCreator cannot be null");
		}
		_EventPublisher = new CaptchaActionRequestEventPublisher(counterRegistry, "FriendRequest", eventStreamer, captchaArgsGetter, logger);
		friendshipCreator.OnFriendRequestSent += OnFriendRequestSent;
	}

	private static void OnFriendRequestSent(long senderUserId, long recipientUserId, bool sentFromInGame, bool sentFromInApp)
	{
		_EventPublisher.HandleEvent("friendRequest", senderUserId, recipientUserId, sentFromInGame, sentFromInApp);
	}
}
