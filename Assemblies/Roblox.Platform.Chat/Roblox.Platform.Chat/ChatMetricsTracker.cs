using System;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.Devices;

namespace Roblox.Platform.Chat;

public class ChatMetricsTracker : IChatMetricsTracker
{
	private readonly ChatPerformanceMonitor _ChatPerformanceMonitor;

	private readonly string _PerformanceCategoryBase;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private readonly ILogger _Logger;

	public ChatMetricsTracker(string performanceCategoryBase, IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
	{
		_ChatPerformanceMonitor = new ChatPerformanceMonitor(performanceCategoryBase);
		_PerformanceCategoryBase = performanceCategoryBase;
		_EphemeralCounterFactory = ephemeralCounterFactory;
		_Logger = logger;
	}

	public void RecordMessageSendAttemptedWithoutRealTime(IPlatform platform)
	{
		_ChatPerformanceMonitor.MessageSendAttemptedWithoutRealTimePerSecond.Increment();
		_ChatPerformanceMonitor.MessageSendAttemptedWithoutRealTimeByOperatingSystem(platform.OperatingSystemType).Increment();
	}

	public void RecordWhitelistChatModerated(string chatMessage)
	{
		try
		{
			string moderatedPhrase = chatMessage.ToLower().Replace(' ', '-');
			_EphemeralCounterFactory.GetCounter($"{_PerformanceCategoryBase}.Moderated_{moderatedPhrase}_Count").IncrementInBackground(1, delegate(Exception ex)
			{
				_Logger.Error(ex);
			});
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
		}
	}

	public void RecordChatsSent(IPlatform platform, int totalNumberOfRecipients)
	{
		try
		{
			_ChatPerformanceMonitor.ChatsGeneratedPerSecond.IncrementBy(totalNumberOfRecipients);
			_ChatPerformanceMonitor.ChatsGeneratedPerSecondByDevice(platform.DeviceType).IncrementBy(totalNumberOfRecipients);
			_ChatPerformanceMonitor.ChatsGeneratedPerSecondByOperatingSystem(platform.OperatingSystemType).IncrementBy(totalNumberOfRecipients);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void RecordChatsReceived(int totalNumberOfMessages)
	{
		try
		{
			_ChatPerformanceMonitor.ChatsReceivedPerSecond.IncrementBy(totalNumberOfMessages);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void RecordChatRedisHits(int totalNumberOfMessages)
	{
		try
		{
			_ChatPerformanceMonitor.ChatRedisHitsPerSecond.IncrementBy(totalNumberOfMessages);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void RecordChatRedisMisses(int totalNumberOfMessages)
	{
		try
		{
			_ChatPerformanceMonitor.ChatRedisMissesPerSecond.IncrementBy(totalNumberOfMessages);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void RecordChatsNotifiedImmediately(int totalNumberOfMessages)
	{
		if (totalNumberOfMessages == 0)
		{
			return;
		}
		try
		{
			_ChatPerformanceMonitor.ChatsNotifiedPerSecond.IncrementBy(totalNumberOfMessages);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void RecordParticipantConversationCacheMissingEntries()
	{
		_EphemeralCounterFactory.GetCounter($"{_PerformanceCategoryBase}.Usage.ParticipantConversationCacheMissingEntries").IncrementInBackground(1, delegate(Exception ex)
		{
			_Logger.Error(ex);
		});
	}

	public void RecordConversationRedisHits()
	{
		try
		{
			_ChatPerformanceMonitor.ConversationRedisHitsPerSecond.Increment();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void RecordConversationRedisMisses()
	{
		try
		{
			_ChatPerformanceMonitor.ConversationRedisMissesPerSecond.Increment();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void RecordParticipantRedisHit()
	{
		try
		{
			_ChatPerformanceMonitor.ParticipantRedisHitsPerSecond.Increment();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void RecordParticipantRedisMiss()
	{
		try
		{
			_ChatPerformanceMonitor.ParticipantRedisMissesPerSecond.Increment();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}
}
