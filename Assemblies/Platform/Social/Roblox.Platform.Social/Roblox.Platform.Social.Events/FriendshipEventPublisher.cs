using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream;
using Roblox.Platform.Social.Properties;

namespace Roblox.Platform.Social.Events;

internal sealed class FriendshipEventPublisher
{
	private readonly IEventStreamer _Streamer;

	private readonly Func<FriendshipEventArgs> _FriendShipArgsGetter;

	private readonly ILogger _Logger;

	private const string _EventName = "friending";

	public FriendshipEventPublisher(string actionName, IEventStreamer eventStreamer, Func<FriendshipEventArgs> friendShipArgsGetter, ILogger logger)
	{
		_Streamer = eventStreamer ?? throw new PlatformArgumentNullException("eventStream cannot be null");
		_FriendShipArgsGetter = friendShipArgsGetter ?? throw new PlatformArgumentNullException("friendShipArgsGetter cannot be null");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger cannot be null");
		if (string.IsNullOrEmpty(actionName.Trim()))
		{
			throw new PlatformArgumentNullException("actionName cannot be empty");
		}
	}

	public void HandleEvent(long senderUserId, long recipientUserId, string context, bool sentFromInGame = false, bool sentFromInApp = false)
	{
		if (!Settings.Default.FriendshipSendEventEnabled)
		{
			return;
		}
		try
		{
			FriendshipEventArgs args = _FriendShipArgsGetter();
			args.SenderId = senderUserId;
			args.RecipientId = recipientUserId;
			args.FromInApp = sentFromInApp;
			args.FromInGame = sentFromInGame;
			args.Context = context;
			new FriendshipEvent(_Streamer, "friending", args).Stream();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}
}
