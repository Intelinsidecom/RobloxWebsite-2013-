using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push;
using Roblox.Platform.Notifications.Stream;

namespace Roblox.Platform.Notifications;

public class NotificationDistributor : INotificationDistributor
{
	public delegate void OnNotificationDelivery(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool wasSuccess);

	public delegate void OnDistributionComplete(NotificationSourceType notificationSourceType, Stopwatch timeToDistribute, int numberOfReceivers, int numberOfChannels);

	public delegate void OnNotificationUpdate(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool wasSuccess);

	public delegate void OnUpdateDistributionComplete(NotificationSourceType notificationSourceType, Stopwatch stopwatch);

	public delegate void OnUpdateLookupFailure(ReceiverNotificationStatus updatedStatus);

	private readonly INotificationChannelResolver _NotificationChannelResolver;

	private readonly INotificationReceiverResolverRegistry _NotificationReceiverResolverRegistry;

	private readonly ILogger _Logger;

	private readonly INotificationIdRegister _NotificationIdRegister;

	public event OnNotificationDelivery NotificationDelivered;

	public event OnDistributionComplete NotificationDistributionCompleted;

	public event OnNotificationUpdate NotificationUpdateDelivered;

	public event OnUpdateDistributionComplete NotificationUpdateDistributionCompleted;

	public event OnUpdateLookupFailure NotificationUpdateLookupFailure;

	public NotificationDistributor(ILogger logger, IPushRegistrar pushRegistrar, IUserFactory userFactory, IPushNotificationEventPublisher pushNotificationEventPublisher, IPushNotificationMetadataManager pushNotificationMetadataManager, INotificationStreamPersister notificationStreamPersister)
		: this(new NotificationChannelResolver(Accessors.NotificationBandAccessor, Accessors.PreferencesAccessor, Accessors.StreamPermissionChecker, pushRegistrar, userFactory, pushNotificationEventPublisher, pushNotificationMetadataManager, notificationStreamPersister), Accessors.NotificationReceiverResolverRegistry, Accessors.GetNotificationIdRegister(logger), Accessors.Logger)
	{
	}

	internal NotificationDistributor(INotificationChannelResolver channelResolver, INotificationReceiverResolverRegistry receiverResolverRegistry, INotificationIdRegister notificationIdRegister, ILogger logger)
	{
		_NotificationChannelResolver = channelResolver;
		_NotificationReceiverResolverRegistry = receiverResolverRegistry;
		_NotificationIdRegister = notificationIdRegister;
		_Logger = logger;
	}

	private void TryExecuteEventHandler(Action eventHandler)
	{
		try
		{
			eventHandler();
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void DistributeNotification(INotification message)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Dictionary<ReceiverDestinationType, INotificationChannel> channelNotificationChannelMap = new Dictionary<ReceiverDestinationType, INotificationChannel>();
		ICollection<IReceiver> receivers = _NotificationReceiverResolverRegistry.GetNotificationReceivers(message);
		List<INotificationChannel> channels = receivers.SelectMany((IReceiver receiver) => _NotificationChannelResolver.ResolveNotificationChannelsForNotification(message.SourceType, receiver, ReceiverNotificationStatus.Sent)).ToList();
		foreach (INotificationChannel channel2 in channels)
		{
			if (!channelNotificationChannelMap.ContainsKey(channel2.DestinationType))
			{
				channelNotificationChannelMap[channel2.DestinationType] = channel2;
			}
		}
		if (!channels.Any())
		{
			stopwatch.Stop();
			TryExecuteEventHandler(delegate
			{
				this.NotificationDistributionCompleted?.Invoke(message.SourceType, stopwatch, receivers.Count, channels.Count);
			});
			return;
		}
		Guid notificationId = Guid.NewGuid();
		_NotificationIdRegister.StoreNotificationSourceType(notificationId, message.SourceType);
		string notificationKey = message.GetMessageSpecificNotificationKey();
		if (!string.IsNullOrEmpty(notificationKey))
		{
			_NotificationIdRegister.StoreNotificationIdLookupByNotificationKey(notificationId, message.SourceType, notificationKey);
		}
		Dictionary<ReceiverDestinationType, string> channelNotificationIdMap = new Dictionary<ReceiverDestinationType, string>();
		foreach (KeyValuePair<ReceiverDestinationType, INotificationChannel> entry in channelNotificationChannelMap)
		{
			try
			{
				ReceiverDestinationType destinationType = entry.Key;
				INotificationChannel channel = entry.Value;
				string channelNotificationId = (channelNotificationIdMap[destinationType] = channel.Store(message));
				if (!string.IsNullOrEmpty(channelNotificationId))
				{
					_NotificationIdRegister.StoreNotificationDestinationTypeNotificationId(notificationId, channel.DestinationType, channelNotificationId);
					_NotificationIdRegister.StoreNotificationIdLookupByDestinationTypeNotificationId(notificationId, channel.DestinationType, channelNotificationId);
				}
			}
			catch (Exception e2)
			{
				_Logger.Error(e2);
			}
		}
		foreach (INotificationChannel channel3 in channels)
		{
			try
			{
				if (channelNotificationIdMap.ContainsKey(channel3.DestinationType))
				{
					channel3.Distribute(message, channelNotificationIdMap[channel3.DestinationType]);
					TryExecuteEventHandler(delegate
					{
						this.NotificationDelivered?.Invoke(message.SourceType, channel3.DestinationType, wasSuccess: true);
					});
				}
				else
				{
					TryExecuteEventHandler(delegate
					{
						this.NotificationDelivered?.Invoke(message.SourceType, channel3.DestinationType, wasSuccess: false);
					});
				}
			}
			catch (Exception e)
			{
				_Logger.Error(e);
				TryExecuteEventHandler(delegate
				{
					this.NotificationDelivered?.Invoke(message.SourceType, channel3.DestinationType, wasSuccess: false);
				});
			}
		}
		stopwatch.Stop();
		TryExecuteEventHandler(delegate
		{
			this.NotificationDistributionCompleted?.Invoke(message.SourceType, stopwatch, receivers.Count, channels.Count);
		});
	}

	public void UpdateNotificationStatusByNotificationKey(IReceiver receiver, NotificationSourceType sourceType, ReceiverNotificationStatus newStatus, string notificationKey)
	{
		UpdateNotificationStatus(receiver, newStatus, NotificationIdLookup);
		Guid? NotificationIdLookup()
		{
			return _NotificationIdRegister.RetrieveNotificationIdByNotificationKey(sourceType, notificationKey);
		}
	}

	public void UpdateNotificationStatusByChannelNotificationId(IReceiver receiver, ReceiverNotificationStatus newStatus, ReceiverDestinationType sourceDestinationType, string channelNotificationId)
	{
		UpdateNotificationStatus(receiver, newStatus, NotificationIdLookup);
		Guid? NotificationIdLookup()
		{
			return _NotificationIdRegister.RetrieveNotificationIdByDestinationTypeNotificationId(sourceDestinationType, channelNotificationId);
		}
	}

	private void UpdateNotificationStatus(IReceiver receiver, ReceiverNotificationStatus newStatus, Func<Guid?> notificationIdLookup)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Guid? notificationId = notificationIdLookup();
		if (!notificationId.HasValue)
		{
			stopwatch.Stop();
			TryExecuteEventHandler(delegate
			{
				this.NotificationUpdateLookupFailure?.Invoke(newStatus);
			});
			return;
		}
		NotificationDistributionData notificationDistributionData = _NotificationIdRegister.RetrieveNotificationDistributionData(notificationId.Value);
		if (notificationDistributionData == null)
		{
			TryExecuteEventHandler(delegate
			{
				this.NotificationUpdateLookupFailure?.Invoke(newStatus);
			});
			return;
		}
		NotificationSourceType sourceType = notificationDistributionData.NotificationSourceType;
		Dictionary<ReceiverDestinationType, string> destinationTypeNotificationIds = notificationDistributionData.DestinationTypeNotificationIds;
		foreach (INotificationChannel channel in _NotificationChannelResolver.ResolveNotificationChannelsForNotification(sourceType, receiver, newStatus))
		{
			try
			{
				if (destinationTypeNotificationIds.TryGetValue(channel.DestinationType, out var destinationTypeNotificationId))
				{
					channel.DistributeStatusUpdateForSingleNotification(sourceType, destinationTypeNotificationId, newStatus);
					TryExecuteEventHandler(delegate
					{
						this.NotificationUpdateDelivered?.Invoke(sourceType, channel.DestinationType, wasSuccess: true);
					});
				}
			}
			catch (Exception e)
			{
				_Logger.Error(e);
				TryExecuteEventHandler(delegate
				{
					this.NotificationUpdateDelivered?.Invoke(sourceType, channel.DestinationType, wasSuccess: false);
				});
			}
		}
		stopwatch.Stop();
		TryExecuteEventHandler(delegate
		{
			this.NotificationUpdateDistributionCompleted?.Invoke(sourceType, stopwatch);
		});
	}

	public void UpdateNotificationCategory(IReceiver receiver, NotificationSourceType notificationSourceType, string notificationCategory, ReceiverNotificationStatus notificationStatus, DateTime? eventDate = null)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		foreach (INotificationChannel channel in _NotificationChannelResolver.ResolveNotificationChannelsForNotification(notificationSourceType, receiver, notificationStatus))
		{
			try
			{
				channel.DistributeStatusUpdateForCategory(notificationSourceType, notificationCategory, notificationStatus, eventDate);
				TryExecuteEventHandler(delegate
				{
					this.NotificationUpdateDelivered?.Invoke(notificationSourceType, channel.DestinationType, wasSuccess: true);
				});
			}
			catch (Exception e)
			{
				_Logger.Error(e);
				TryExecuteEventHandler(delegate
				{
					this.NotificationUpdateDelivered?.Invoke(notificationSourceType, channel.DestinationType, wasSuccess: false);
				});
			}
		}
		stopwatch.Stop();
		TryExecuteEventHandler(delegate
		{
			this.NotificationUpdateDistributionCompleted?.Invoke(notificationSourceType, stopwatch);
		});
	}
}
