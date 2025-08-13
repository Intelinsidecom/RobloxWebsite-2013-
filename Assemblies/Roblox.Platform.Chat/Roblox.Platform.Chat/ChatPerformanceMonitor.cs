using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Roblox.Diagnostics;
using Roblox.Platform.Devices;

namespace Roblox.Platform.Chat;

internal class ChatPerformanceMonitor
{
	private readonly Dictionary<DeviceType, PerformanceCounter> _TotalChatsGeneratedPerSecondByDeviceTypeLookup;

	private readonly Dictionary<OperatingSystemType, PerformanceCounter> _TotalChatsGeneratedPerSecondByOperatingSystemLookup;

	private readonly Dictionary<OperatingSystemType, PerformanceCounter> _TotalMessageSendAttemptedWithoutRealTimePerSecondByOperatingSystemLookup;

	internal PerformanceCounter ChatsGeneratedPerSecond { get; set; }

	internal PerformanceCounter MessageSendAttemptedWithoutRealTimePerSecond { get; set; }

	internal PerformanceCounter ChatsReceivedPerSecond { get; set; }

	internal PerformanceCounter ChatsNotifiedPerSecond { get; set; }

	internal PerformanceCounter ChatRedisHitsPerSecond { get; set; }

	internal PerformanceCounter ChatRedisMissesPerSecond { get; set; }

	internal PerformanceCounter ConversationRedisHitsPerSecond { get; set; }

	internal PerformanceCounter ConversationRedisMissesPerSecond { get; set; }

	internal PerformanceCounter ParticipantRedisHitsPerSecond { get; set; }

	internal PerformanceCounter ParticipantRedisMissesPerSecond { get; set; }

	internal ChatPerformanceMonitor(string performanceCounterCategoryBase)
	{
		string usagePerformanceCounterCategory = performanceCounterCategoryBase + ".Usage";
		CounterDescriptor[] usageCollection = new CounterDescriptor[4]
		{
			new CounterDescriptor(() => ChatsGeneratedPerSecond, delegate(PerformanceCounter v)
			{
				ChatsGeneratedPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => MessageSendAttemptedWithoutRealTimePerSecond, delegate(PerformanceCounter v)
			{
				MessageSendAttemptedWithoutRealTimePerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ChatsReceivedPerSecond, delegate(PerformanceCounter v)
			{
				ChatsReceivedPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ChatsNotifiedPerSecond, delegate(PerformanceCounter v)
			{
				ChatsNotifiedPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance(usagePerformanceCounterCategory, "_Total", usageCollection);
		string botDetectionPerformanceCounterCategory = performanceCounterCategoryBase + ".BotDetection";
		CounterDescriptor[] botDetectionCollection = new CounterDescriptor[1]
		{
			new CounterDescriptor(() => MessageSendAttemptedWithoutRealTimePerSecond, delegate(PerformanceCounter v)
			{
				MessageSendAttemptedWithoutRealTimePerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance(botDetectionPerformanceCounterCategory, "_Total", botDetectionCollection);
		_TotalChatsGeneratedPerSecondByDeviceTypeLookup = new Dictionary<DeviceType, PerformanceCounter>();
		_TotalChatsGeneratedPerSecondByOperatingSystemLookup = new Dictionary<OperatingSystemType, PerformanceCounter>();
		_TotalMessageSendAttemptedWithoutRealTimePerSecondByOperatingSystemLookup = new Dictionary<OperatingSystemType, PerformanceCounter>();
		foreach (DeviceType enumValue2 in Enum.GetValues(typeof(DeviceType)).Cast<DeviceType>())
		{
			string enumName2 = enumValue2.ToString();
			PerformanceCounter counter = CreateMultiInstanceChatsGeneratedPerSecondCounter(usagePerformanceCounterCategory, () => ChatsGeneratedPerSecond, "DeviceType_" + enumName2);
			_TotalChatsGeneratedPerSecondByDeviceTypeLookup.Add(enumValue2, counter);
		}
		foreach (OperatingSystemType enumValue in Enum.GetValues(typeof(OperatingSystemType)).Cast<OperatingSystemType>())
		{
			string enumName = enumValue.ToString();
			PerformanceCounter chatsCounter = CreateMultiInstanceChatsGeneratedPerSecondCounter(usagePerformanceCounterCategory, () => ChatsGeneratedPerSecond, "OSType_" + enumName);
			_TotalChatsGeneratedPerSecondByOperatingSystemLookup.Add(enumValue, chatsCounter);
			PerformanceCounter messageSendAttemptedWithoutRealTimeCounter = CreateMultiInstanceChatsGeneratedPerSecondCounter(botDetectionPerformanceCounterCategory, () => MessageSendAttemptedWithoutRealTimePerSecond, "OSType_" + enumName);
			_TotalMessageSendAttemptedWithoutRealTimePerSecondByOperatingSystemLookup.Add(enumValue, messageSendAttemptedWithoutRealTimeCounter);
		}
		string redisHitRatesPerformanceCounterCategory = performanceCounterCategoryBase + ".RedisHitRates";
		CounterDescriptor[] redisHitRatesCollection = new CounterDescriptor[2]
		{
			new CounterDescriptor(() => ChatRedisHitsPerSecond, delegate(PerformanceCounter v)
			{
				ChatRedisHitsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ChatRedisMissesPerSecond, delegate(PerformanceCounter v)
			{
				ChatRedisMissesPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance(redisHitRatesPerformanceCounterCategory, "_Total", redisHitRatesCollection);
		string conversationRedisHitRatesPerformanceMonitorCategory = performanceCounterCategoryBase + ".ParticipantConversationRedisHitRates";
		CounterDescriptor[] conversationRedisHitRatesCollection = new CounterDescriptor[2]
		{
			new CounterDescriptor(() => ConversationRedisHitsPerSecond, delegate(PerformanceCounter v)
			{
				ConversationRedisHitsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ConversationRedisMissesPerSecond, delegate(PerformanceCounter v)
			{
				ConversationRedisMissesPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeSingleInstance(conversationRedisHitRatesPerformanceMonitorCategory, conversationRedisHitRatesCollection);
		string participantRedisHitRatesPerformanceMonitorCategory = performanceCounterCategoryBase + ".ConversationParticipantRedisHitRates";
		CounterDescriptor[] participantRedisHitRatesCollection = new CounterDescriptor[2]
		{
			new CounterDescriptor(() => ParticipantRedisHitsPerSecond, delegate(PerformanceCounter v)
			{
				ParticipantRedisHitsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ParticipantRedisMissesPerSecond, delegate(PerformanceCounter v)
			{
				ParticipantRedisMissesPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeSingleInstance(participantRedisHitRatesPerformanceMonitorCategory, participantRedisHitRatesCollection);
	}

	internal PerformanceCounter ChatsGeneratedPerSecondByDevice(DeviceType deviceType)
	{
		return _TotalChatsGeneratedPerSecondByDeviceTypeLookup[deviceType];
	}

	internal PerformanceCounter ChatsGeneratedPerSecondByOperatingSystem(OperatingSystemType operatingSystem)
	{
		return _TotalChatsGeneratedPerSecondByOperatingSystemLookup[operatingSystem];
	}

	internal PerformanceCounter MessageSendAttemptedWithoutRealTimeByOperatingSystem(OperatingSystemType operatingSystem)
	{
		return _TotalMessageSendAttemptedWithoutRealTimePerSecondByOperatingSystemLookup[operatingSystem];
	}

	private static PerformanceCounter CreateMultiInstanceChatsGeneratedPerSecondCounter(string performanceCounterCategory, Expression<Func<object>> totalCounterForName, string enumName)
	{
		PerformanceCounter counter = null;
		CounterDescriptor[] deviceTypeCollection = new CounterDescriptor[1]
		{
			new CounterDescriptor(totalCounterForName, delegate(PerformanceCounter v)
			{
				counter = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance(performanceCounterCategory, enumName, deviceTypeCollection);
		return counter;
	}
}
