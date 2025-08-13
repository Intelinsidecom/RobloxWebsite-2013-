using System;
using Roblox.EventLog;
using Roblox.FloodCheckers;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push.Entities;
using Roblox.Platform.Notifications.Push.Properties;
using Roblox.Platform.Privacy;

namespace Roblox.Platform.Notifications.Push;

public class PushNotificationDeliverer : IPushNotificationDeliverer
{
	internal delegate void DeliveryHandler(string notificationType, PushApplicationType application, PushPlatformType platform, DeliveryAttemptType attempt);

	internal delegate void DestinationAndTypeCombinationFloodedHandler(string notificationType, PushApplicationType application);

	internal delegate void DestinationFloodedHandler(PushApplicationType application, PushPlatformType platform);

	private readonly PushDomainFactory _PushDomainFactory;

	private readonly ILogger _Logger;

	private readonly PushServiceClientFactory _PushServiceClientFactory;

	private readonly IUserFactory _UserFactory;

	private readonly IPushNotificationMetadataManager _PushNotificationMetadataManager;

	private readonly INotificationBuilderRegistry<IPushNotificationContentBuilder> _PushNotificationContentBuilderRegistry;

	private readonly IPushDestinationExpirer _PushDestinationExpirer;

	private readonly IPushNotificationEventPublisher _PushNotificationEventPublisher;

	private readonly IChatPrivacySettingAccessor _ChatPrivacySettingAccessor;

	private readonly string _FloodCheckerCategoryBase;

	private readonly TypeLookups _TypeLookups;

	internal event DeliveryHandler OnDelivery;

	internal event DestinationAndTypeCombinationFloodedHandler OnDestinationAndTypeCombinationFlooded;

	internal event DestinationFloodedHandler OnDestinationFlooded;

	public PushNotificationDeliverer(PushDomainFactory pushDomainFactory, IUserFactory userFactory, IPushNotificationMetadataManager pushNotificationMetadataManager, INotificationBuilderRegistry<IPushNotificationContentBuilder> pushNotificationContentBuilderRegistry, IPushDestinationExpirer pushDestinationExpirer, IPushNotificationEventPublisher pushNotificationEventPublisher, IChatPrivacySettingAccessor chatPrivacySettingAccessor, ILogger logger)
	{
		_PushDomainFactory = pushDomainFactory;
		_Logger = logger;
		_PushServiceClientFactory = new PushServiceClientFactory(logger);
		_UserFactory = userFactory;
		_PushNotificationMetadataManager = pushNotificationMetadataManager;
		_PushNotificationContentBuilderRegistry = pushNotificationContentBuilderRegistry;
		_PushDestinationExpirer = pushDestinationExpirer;
		_PushNotificationEventPublisher = pushNotificationEventPublisher;
		_ChatPrivacySettingAccessor = chatPrivacySettingAccessor;
		_FloodCheckerCategoryBase = GetType().FullName;
		_TypeLookups = new TypeLookups(pushDomainFactory);
	}

	/// <summary>
	/// Deliver a push notification to the third party push service. Should only be called in the context of a processor or background task
	/// </summary>
	/// <param name="specification"></param>
	/// <param name="attempt"></param>
	/// <returns>True if successful, false if not</returns>
	public PushDeliveryResult Deliver(IPushNotificationSpecification specification, DeliveryAttemptType attempt)
	{
		try
		{
			IExtendedReceiverDestination deliveryTarget = GetReceiverDestinationInFull(specification.ReceiverDestinationId);
			if (!ValidateReceiverDestination(deliveryTarget, specification))
			{
				return PushDeliveryResult.InvalidReceiverDestination;
			}
			IPushPlatform pushPlatform = PushPlatformFactory.GetPushPlatform(_PushServiceClientFactory, deliveryTarget.PlatformType, deliveryTarget.DestinationType, _UserFactory, _TypeLookups.Receivers, _Logger);
			if (!IsDeliveryAllowed(specification, pushPlatform, deliveryTarget))
			{
				return PushDeliveryResult.DeliveryNotAllowed;
			}
			if (!AttemptAllowed(attempt, specification, deliveryTarget))
			{
				return PushDeliveryResult.AttemptNotAllowed;
			}
			PerformDelivery(specification, pushPlatform, deliveryTarget, attempt);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
			return PushDeliveryResult.UnknownError;
		}
		return PushDeliveryResult.Success;
	}

	private bool AttemptAllowed(DeliveryAttemptType attempt, IPushNotificationSpecification specification, IExtendedReceiverDestination deliveryTarget)
	{
		switch (attempt)
		{
		case DeliveryAttemptType.Primary:
			return true;
		case DeliveryAttemptType.Fallback:
		{
			UserPushDestinationCore upc = new UserPushDestinationCore
			{
				Platform = deliveryTarget.PlatformType,
				Application = deliveryTarget.ApplicationType,
				UserPushNotificationDestinationId = deliveryTarget.ReceiverDestination.Id
			};
			return !_PushNotificationMetadataManager.HasNotificationBeenReceived(upc, specification.NotificationId);
		}
		default:
			return false;
		}
	}

	private bool ValidateReceiverDestination(IExtendedReceiverDestination extendedReceiverDestination, IPushNotificationSpecification specification)
	{
		if (extendedReceiverDestination?.ReceiverDestination == null)
		{
			_Logger.Error("Invalid UserPushNotificationDestination reference");
			return false;
		}
		IReceiverDestinationEntity receiverDestination = extendedReceiverDestination.ReceiverDestination;
		if (!receiverDestination.IsAuthorizedByReceiver || !receiverDestination.IsActive)
		{
			return false;
		}
		if (!AuthenticationIsValid(receiverDestination))
		{
			receiverDestination.IsActive = false;
			receiverDestination.Update();
			return false;
		}
		if (extendedReceiverDestination.ApplicationType != specification.Application)
		{
			return false;
		}
		return true;
	}

	private bool IsDeliveryAllowed(IPushNotificationSpecification specification, IPushPlatform pushPlatform, IExtendedReceiverDestination deliveryTarget)
	{
		if (IsChatRelatedPushNotification(specification) && deliveryTarget.ReceiverDestination.ReceiverTypeId == _TypeLookups.Receivers.User.Id)
		{
			IUser receiverUser = _UserFactory.GetUser(deliveryTarget.ReceiverDestination.ReceiverTargetId);
			if (_ChatPrivacySettingAccessor.GetOrCreateAppChatPrivacyLevel(receiverUser).PrivacyLevel == UserPrivacyLevelType.NoOne)
			{
				return false;
			}
		}
		if (specification.Intent != PushNotificationIntent.NewContent && !pushPlatform.SupportsNotificationUpdates)
		{
			return false;
		}
		if (!pushPlatform.DeliveryAllowed(deliveryTarget.ReceiverDestination.GetReceiver(), specification))
		{
			return false;
		}
		if (IsDestinationFlooded(specification, deliveryTarget))
		{
			return false;
		}
		return true;
	}

	private bool IsChatRelatedPushNotification(IPushNotificationSpecification specification)
	{
		if (specification.NewContentNotificationType.HasValue)
		{
			if (specification.NewContentNotificationType.Value != NotificationSourceType.ChatNewMessage && specification.NewContentNotificationType.Value != NotificationSourceType.PartyInviteReceived)
			{
				return specification.NewContentNotificationType.Value == NotificationSourceType.PartyMemberJoined;
			}
			return true;
		}
		return false;
	}

	private void PerformDelivery(IPushNotificationSpecification specification, IPushPlatform platformHelper, IExtendedReceiverDestination deliveryTarget, DeliveryAttemptType attempt)
	{
		string message = platformHelper.ProduceNotificationPayload(specification, attempt, _PushNotificationMetadataManager, _PushNotificationContentBuilderRegistry, deliveryTarget);
		if (attempt == DeliveryAttemptType.Primary)
		{
			_PushNotificationMetadataManager.RecordNotificationPrimaryDelivery(specification.NotificationId, deliveryTarget.ReceiverDestination.Id);
		}
		else if (attempt == DeliveryAttemptType.Fallback)
		{
			_PushNotificationMetadataManager.RecordNotificationFallbackDelivery(specification.NotificationId, deliveryTarget.ReceiverDestination.Id);
		}
		PublishNotificationResult result = platformHelper.GetPushServiceClient().PublishNotificationToDestination(deliveryTarget.Destination.NotificationDeliveryEndpoint, message);
		if (result.Status == PublishNotificationStatus.Published)
		{
			if (!string.IsNullOrEmpty(result.Receipt))
			{
				_PushNotificationMetadataManager.StoreDeliveryReceiptDestinationMapping(result.Receipt, deliveryTarget.Destination.Id);
			}
			Try(delegate
			{
				this.OnDelivery?.Invoke(GetNotificationTypeString(specification), deliveryTarget.ApplicationType, deliveryTarget.PlatformType, attempt);
			});
		}
		else if (result.Status == PublishNotificationStatus.DestinationExpired)
		{
			_PushDestinationExpirer.ExpireDestinationById(deliveryTarget.Destination.Id);
		}
		RequeueIfNecessary(specification, result, platformHelper, deliveryTarget, attempt);
	}

	private void RequeueIfNecessary(IPushNotificationSpecification specification, PublishNotificationResult result, IPushPlatform platformHelper, IExtendedReceiverDestination deliveryTarget, DeliveryAttemptType currentDeliveryAttempt)
	{
		if (currentDeliveryAttempt != DeliveryAttemptType.Fallback && currentDeliveryAttempt == DeliveryAttemptType.Primary && result.Status == PublishNotificationStatus.Published && platformHelper.FallbackRequired(deliveryTarget.ReceiverDestination.GetReceiver(), specification))
		{
			_PushNotificationEventPublisher.PublishFallbackNotification(specification);
		}
	}

	private string GetNotificationReportingString(IPushNotificationSpecification specification)
	{
		if (Settings.Default.IsNewStringRepresentationOfPushTypeUsedForReporting)
		{
			return GetNotificationTypeString(specification);
		}
		return LegacyStoredPushNotificationFormat.GetLegacyNotificationType(specification.Intent, specification.NewContentNotificationType);
	}

	private string GetNotificationTypeString(IPushNotificationSpecification specification)
	{
		string notificationTypeString = specification.Intent.ToString();
		if (specification.NewContentNotificationType.HasValue)
		{
			notificationTypeString = notificationTypeString + "-" + specification.NewContentNotificationType.Value;
		}
		return notificationTypeString;
	}

	/// <summary>
	/// Ensure no destination is delivered an exorbitant number of notifications, both for the user's sake and to ensure
	/// we don't hit any rate-limiting issues with the external notification service. Also limit the number of notifications 
	/// of any particular type to a destination to ensure no rogue notification producer can flood a user's device and prevent 
	/// other notification types from getting through.
	/// </summary>
	/// <returns>Whether any of the floodcheckers has tripped</returns>
	private bool IsDestinationFlooded(IPushNotificationSpecification specification, IExtendedReceiverDestination target)
	{
		FloodChecker destinationAndTypeCombinationFloodChecker = new FloodChecker($"{_FloodCheckerCategoryBase}.DestinationAndTypeCombination", $"PushNotificationDelivery_Destination:{target.ReceiverDestination.Id}_Type:{GetNotificationTypeString(specification)}", Settings.Default.DeliveryDestinationAndTypeCombinationFloodCheckLimit, Settings.Default.DeliveryDestinationAndTypeCombinationFloodCheckExpiry, Settings.Default.DeliveryDestinationAndTypeCombinationFloodCheckEnabled);
		if (destinationAndTypeCombinationFloodChecker.IsFlooded())
		{
			Try(delegate
			{
				this.OnDestinationAndTypeCombinationFlooded?.Invoke(GetNotificationReportingString(specification), target.ApplicationType);
			});
			return true;
		}
		destinationAndTypeCombinationFloodChecker.UpdateCount();
		FloodChecker destinationOverallFloodChecker = new FloodChecker($"{_FloodCheckerCategoryBase}.Destination", $"PushNotificationDelivery_Destination:{target.Destination.Id}", Settings.Default.DeliveryDestinationFloodCheckLimit, Settings.Default.DeliveryDestinationFloodCheckExpiry, Settings.Default.DeliveryDestinationFloodCheckEnabled);
		if (destinationOverallFloodChecker.IsFlooded())
		{
			Try(delegate
			{
				this.OnDestinationFlooded?.Invoke(target.ApplicationType, target.PlatformType);
			});
			return true;
		}
		destinationOverallFloodChecker.UpdateCount();
		return false;
	}

	private bool AuthenticationIsValid(IReceiverDestinationEntity receiverDestination)
	{
		PushAuthenticationType authentication = _TypeLookups.Authentications.LookupEnum(receiverDestination.AuthenticationTypeId);
		switch (authentication)
		{
		case PushAuthenticationType.None:
			return true;
		case PushAuthenticationType.SessionToken:
		{
			IReceiver receiver = receiverDestination.GetReceiver();
			if (!receiver.IsUser(_TypeLookups.Receivers))
			{
				throw new PushNotificationAuthenticationException("Only user receivers can be authenticated by SessionTokens");
			}
			return SessionTokenFactory.Build(receiverDestination.AuthenticationValue).IsValid(_UserFactory.GetUser(receiver.ToUserId(_TypeLookups.Receivers))) == AuthenticationSessionValidationStatus.Success;
		}
		default:
			throw new PushNotificationAuthenticationException("Unsupported Authentication Type specified: " + authentication);
		}
	}

	private IExtendedReceiverDestination GetReceiverDestinationInFull(long receiverDestinationId)
	{
		IReceiverDestinationEntity receiverDestination = _PushDomainFactory.ReceiverDestinationEntityFactory.Get(receiverDestinationId);
		if (receiverDestination == null)
		{
			return null;
		}
		IDestinationEntity destination = _PushDomainFactory.DestinationEntityFactory.Get(receiverDestination.DestinationId);
		IDestinationTypeEntity destinationType = _PushDomainFactory.DestinationTypeEntityFactory.Get(destination.DestinationTypeId);
		return new ExtendedReceiverDestination
		{
			ReceiverDestination = receiverDestination,
			Destination = destination,
			DestinationType = destinationType,
			PlatformType = _TypeLookups.Platforms.LookupEnum(destinationType.PlatformTypeId),
			ApplicationType = _TypeLookups.Applications.LookupEnum(destinationType.ApplicationTypeId)
		};
	}

	private void Try(Action action)
	{
		try
		{
			action();
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}
}
