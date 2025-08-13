using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream;
using Roblox.Platform.Social.Events;

namespace Roblox.Platform.Social.Follow;

public class FollowRequestSentEventListener
{
	private static CaptchaActionRequestEventPublisher _EventPublisher;

	public static void Register(ICounterRegistry counterRegistry, IFriendshipFactory friendshipFactory, IEventStreamer eventStreamer, Func<CaptchaActionEventArgs> captchaArgsGetter, ILogger logger)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (friendshipFactory == null)
		{
			throw new PlatformArgumentNullException("friendshipFactory cannot be null");
		}
		_EventPublisher = new CaptchaActionRequestEventPublisher(counterRegistry, "FollowRequest", eventStreamer, captchaArgsGetter, logger);
		friendshipFactory.OnFollowRequestSent += OnFollowRequestSent;
	}

	private static void OnFollowRequestSent(long senderUserId, long recipientUserId, bool sentFromInGame, bool sentFromInApp)
	{
		_EventPublisher.HandleEvent("followRequest", senderUserId, recipientUserId, sentFromInGame, sentFromInApp);
	}
}
