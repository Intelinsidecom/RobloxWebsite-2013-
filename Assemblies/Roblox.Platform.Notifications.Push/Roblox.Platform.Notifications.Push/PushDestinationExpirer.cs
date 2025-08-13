using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Common.NetStandard;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Push.Entities;
using Roblox.Platform.Notifications.Push.Properties;

namespace Roblox.Platform.Notifications.Push;

public class PushDestinationExpirer : IPushDestinationExpirer
{
	internal delegate void DestinationExpiryHandler(PushApplicationType application, PushPlatformType platform, int? receiverTypeId, long? receiverTargetId);

	private readonly PushDomainFactory _PushDomainFactory;

	private readonly IPushNotificationMetadataManager _MetadataManager;

	private readonly ILogger _Logger;

	private readonly TypeLookups _TypeLookups;

	private const long _PageSize = 50L;

	internal event DestinationExpiryHandler OnDestinationExpiry;

	public PushDestinationExpirer(PushDomainFactory pushDomainFactory, IPushNotificationMetadataManager metadataManager, ILogger logger)
	{
		_PushDomainFactory = pushDomainFactory;
		_MetadataManager = metadataManager;
		_Logger = logger;
		_TypeLookups = new TypeLookups(pushDomainFactory);
	}

	public void ExpireDestinationBasedOnDeliveryReceipt(string deliveryReceiptId)
	{
		long? destinationId = _MetadataManager.GetDestinationIdFromDeliveryReceipt(deliveryReceiptId);
		if (destinationId.HasValue)
		{
			ExpireDestinationById(destinationId.Value);
		}
	}

	public void ExpireDestinationById(long destinationId)
	{
		IDestinationEntity destination = _PushDomainFactory.DestinationEntityFactory.Get(destinationId);
		if (destination == null)
		{
			return;
		}
		ICollection<IReceiverDestinationEntity> allPaged = CollectionsHelper.GetAllPaged((long start, long rows) => _PushDomainFactory.ReceiverDestinationEntityFactory.GetByDestinationIdAndIsActivePaged(destinationId, isActive: true, start, rows).ToList(), 50L);
		int? receiverTypeId = null;
		long? receiverTargetId = null;
		foreach (IReceiverDestinationEntity receiverDestination in allPaged)
		{
			receiverTypeId = receiverDestination.ReceiverTypeId;
			receiverTargetId = receiverDestination.ReceiverTargetId;
			if (!Settings.Default.IsOnlyDeactivateReceiverDestinationsOnExpiryEnabled)
			{
				receiverDestination.Delete();
				continue;
			}
			receiverDestination.IsActive = false;
			receiverDestination.Update();
		}
		if (!Settings.Default.IsOnlyDeactivateReceiverDestinationsOnExpiryEnabled)
		{
			foreach (IReceiverDestinationEntity item in CollectionsHelper.GetAllPaged((long start, long rows) => _PushDomainFactory.ReceiverDestinationEntityFactory.GetByDestinationIdAndIsActivePaged(destinationId, isActive: false, start, rows).ToList(), 50L))
			{
				item.Delete();
			}
			destination.Delete();
		}
		try
		{
			IDestinationTypeEntity destinationType = _PushDomainFactory.DestinationTypeEntityFactory.Get(destination.DestinationTypeId);
			PushApplicationType applicationType = _TypeLookups.Applications.LookupEnum(destinationType.ApplicationTypeId);
			PushPlatformType platformType = _TypeLookups.Platforms.LookupEnum(destinationType.PlatformTypeId);
			this.OnDestinationExpiry?.Invoke(applicationType, platformType, receiverTypeId, receiverTargetId);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}
}
