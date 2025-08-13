using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream;
using Roblox.Platform.Social.Friendship;
using Roblox.Platform.Social.Properties;

namespace Roblox.Platform.Social.Events;

internal sealed class CaptchaActionRequestEventPublisher
{
	private readonly CaptchaControlledActionPerformanceMonitor _SendRequestPerformanceMonitor;

	private readonly IEventStreamer _Streamer;

	private readonly Func<CaptchaActionEventArgs> _CaptchaArgsGetter;

	private readonly ILogger _Logger;

	public CaptchaActionRequestEventPublisher(ICounterRegistry counterRegistry, string actionName, IEventStreamer eventStreamer, Func<CaptchaActionEventArgs> captchaArgsGetter, ILogger logger)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_Streamer = eventStreamer ?? throw new PlatformArgumentNullException("eventStream cannot be null");
		_CaptchaArgsGetter = captchaArgsGetter ?? throw new PlatformArgumentNullException("captchaArgsGetter cannot be null");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger cannot be null");
		if (string.IsNullOrEmpty(actionName.Trim()))
		{
			throw new PlatformArgumentNullException("actionName cannot be empty");
		}
		_SendRequestPerformanceMonitor = new CaptchaControlledActionPerformanceMonitor(counterRegistry, actionName);
	}

	public void HandleEvent(string eventName, long senderUserId, long recipientUserId, bool sentFromInGame, bool sentFromInApp)
	{
		if (_SendRequestPerformanceMonitor == null)
		{
			return;
		}
		if (Settings.Default.CaptchaActionSendEventEnabled)
		{
			try
			{
				CaptchaActionEventArgs args = _CaptchaArgsGetter();
				args.SenderId = senderUserId;
				args.RecipientId = recipientUserId;
				args.FromInApp = sentFromInApp;
				args.FromInGame = sentFromInGame;
				new CaptchaActionEvent(_Streamer, eventName, args).Stream();
			}
			catch (Exception ex2)
			{
				_Logger.Error(ex2);
			}
		}
		if (!Settings.Default.CaptchaActionLogToPerfmonEnabled)
		{
			return;
		}
		try
		{
			if (sentFromInGame && sentFromInApp)
			{
				_SendRequestPerformanceMonitor.SentFromInGameInAppPerSecond.Increment();
			}
			else if (sentFromInApp)
			{
				_SendRequestPerformanceMonitor.SentFromInAppPerSecond.Increment();
			}
			else if (sentFromInGame)
			{
				_SendRequestPerformanceMonitor.SentFromInGamePerSecond.Increment();
			}
			else
			{
				_SendRequestPerformanceMonitor.OtherSentPerSecond.Increment();
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}
}
