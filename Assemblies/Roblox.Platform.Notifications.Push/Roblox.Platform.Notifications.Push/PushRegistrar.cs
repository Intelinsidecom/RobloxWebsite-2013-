using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Roblox.Common.NetStandard;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Platform.Authentication;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push.Entities;
using Roblox.Platform.Notifications.Push.Events;
using Roblox.Platform.Notifications.Push.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Notifications.Push;

public class PushRegistrar : IPushRegistrar
{
	internal delegate void RegistrationHandler(PushApplicationType application, PushPlatformType platform, bool userInitiated, bool newReceiverDestinationCreated);

	internal delegate void RegistrationEventHandler(PushApplicationType application, PushPlatformType platform, PushRegistrationEventType registrationEventType);

	private const int _GetAllPageSize = 50;

	private IRedisClient _RedisClient;

	private readonly PushDomainFactory _PushDomainFactory;

	private readonly ILogger _Logger;

	private readonly string _LogSource;

	private readonly PushServiceClientFactory _PushServiceClientFactory;

	private readonly IUserFactory _UserFactory;

	private readonly TypeLookups _TypeLookups;

	private readonly IDestinationEntityFactory _DestinationFactory;

	private readonly IReceiverDestinationEntityFactory _ReceiverDestinationFactory;

	private readonly IDestinationTypeEntityFactory _DestinationTypeFactory;

	[CompilerGenerated]
	private RegistrationEventHandler m_OnRegistrationEvent;

	internal event RegistrationHandler OnRegistration;

	internal event RegistrationEventHandler OnRegistrationEvent
	{
		[CompilerGenerated]
		add
		{
			RegistrationEventHandler registrationEventHandler = this.OnRegistration;
			RegistrationEventHandler registrationEventHandler2;
			do
			{
				registrationEventHandler2 = registrationEventHandler;
				RegistrationEventHandler value2 = (RegistrationEventHandler)Delegate.Combine(registrationEventHandler2, value);
				registrationEventHandler = Interlocked.CompareExchange(ref this.OnRegistration, value2, registrationEventHandler2);
			}
			while ((object)registrationEventHandler != registrationEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RegistrationEventHandler registrationEventHandler = this.OnRegistration;
			RegistrationEventHandler registrationEventHandler2;
			do
			{
				registrationEventHandler2 = registrationEventHandler;
				RegistrationEventHandler value2 = (RegistrationEventHandler)Delegate.Remove(registrationEventHandler2, value);
				registrationEventHandler = Interlocked.CompareExchange(ref this.OnRegistration, value2, registrationEventHandler2);
			}
			while ((object)registrationEventHandler != registrationEventHandler2);
		}
	}

	public event PushNotificationSettingChangedEventHandler PushNotificationSettingChanged;

	public PushRegistrar(PushDomainFactory pushDomainFactory, IUserFactory userFactory, string logSource, ILogger logger)
	{
		_PushDomainFactory = pushDomainFactory;
		_Logger = logger;
		_LogSource = logSource;
		_PushServiceClientFactory = new PushServiceClientFactory(logger);
		_UserFactory = userFactory;
		_TypeLookups = new TypeLookups(pushDomainFactory);
		_DestinationFactory = _PushDomainFactory.DestinationEntityFactory;
		_ReceiverDestinationFactory = _PushDomainFactory.ReceiverDestinationEntityFactory;
		_DestinationTypeFactory = _PushDomainFactory.DestinationTypeEntityFactory;
		InitializeRedisClient();
		Settings.Default.MonitorChanges((Settings s) => s.IsUseRedisConnectionPoolEnabled, InitializeRedisClient);
	}

	private void InitializeRedisClient()
	{
		_Logger.LifecycleEvent("Initializing PushRegistrar Redis Clients with " + $"useRedisConnectionPool set to {Settings.Default.IsUseRedisConnectionPoolEnabled} and " + $"redisConnectionPoolSize set to {Settings.Default.PushNotificationsRedisConnectionPoolSize}");
		_RedisClient = RedisClientProvider.GetRedisClient(_LogSource, _Logger, Settings.Default.IsUseRedisConnectionPoolEnabled);
	}

	/// <summary>
	/// Register a device as a Destination and ReceiverDestination for the specified user
	/// </summary>
	/// <param name="applicationType"></param>
	/// <param name="platformType"></param>
	/// <param name="user"></param>
	/// <param name="sessionToken"></param>
	/// <param name="notificationToken"></param>
	/// <param name="notificationEndpoint"></param>
	/// <param name="initiatedByUser">This should indicate if this is being triggered by an explicit user action. If it is then the receiverDestination 
	/// will be marked as Authorized as well as active, otherwise any existing settings will be preserved.</param>
	/// <param name="deviceName">Friendly user-facing name of the device being registered</param>
	/// <returns>Registration</returns>
	public IUserPushDestination Register(PushApplicationType applicationType, PushPlatformType platformType, IUser user, ISessionToken sessionToken, string notificationToken, string notificationEndpoint, bool authorizationRequested, bool authorizeByDefault, string deviceName)
	{
		if (user == null)
		{
			throw new PlatformArgumentException("User cannot be null");
		}
		if (sessionToken == null)
		{
			throw new PlatformArgumentException("SessionToken cannot be null");
		}
		IDestinationTypeEntity destinationType = GetDestinationTypeEntity(applicationType, platformType);
		IPushPlatform pushPlatform = PushPlatformFactory.GetPushPlatform(_PushServiceClientFactory, platformType, destinationType, _UserFactory, _TypeLookups.Receivers, _Logger);
		if (!pushPlatform.IsNotificationTokenValid(notificationToken))
		{
			throw new PlatformArgumentException("NotificationToken is invalid");
		}
		IReceiver receiver = user.ToReceiver(_TypeLookups.Receivers);
		using RedisLeasedLock redisLeasedLock = new RedisLeasedLock($"PushNotificationRegistration_Platform:{platformType}_NotificationToken:{notificationToken}", TimeSpan.FromSeconds(2.0), delegate(Exception ex)
		{
			_Logger.Error(ex);
		});
		if (!redisLeasedLock.TryAcquire())
		{
			throw new PushNotificationRegistrationLockException();
		}
		IDestinationEntity destination = _DestinationFactory.GetByDestinationTypeIdAndExternalServiceDestinationId(destinationType.Id, notificationToken);
		bool num = destination != null;
		if (!num)
		{
			string destinationAmazonNotificationEndpoint = pushPlatform.GetPushServiceClient().GetDevicePushPublishEndpoint(destinationType, notificationToken, notificationEndpoint);
			destination = _DestinationFactory.Create(destinationType.Id, notificationToken, DestinationUtilities.ComputeDestinationServiceIDHash(notificationToken), destinationAmazonNotificationEndpoint);
		}
		IReceiverDestinationEntity receiverDestination = null;
		if (num)
		{
			ICollection<IReceiverDestinationEntity> allPaged = CollectionsHelper.GetAllPaged((long start, long size) => _ReceiverDestinationFactory.GetByDestinationIdAndIsActivePaged(destination.Id, isActive: true, start, size).ToList(), 50L);
			bool controlSeized = false;
			foreach (IReceiverDestinationEntity existingReceiverDestination in allPaged)
			{
				IReceiver existingReceiver = existingReceiverDestination.GetReceiver();
				if (!existingReceiver.IsUser(_TypeLookups.Receivers) || existingReceiver.ToUserId(_TypeLookups.Receivers) != user.Id)
				{
					existingReceiverDestination.IsActive = false;
					existingReceiverDestination.Update();
					controlSeized = true;
				}
			}
			receiverDestination = _ReceiverDestinationFactory.GetByReceiverTypeIdReceiverTargetIdAndDestinationId(receiver.TypeId, receiver.TargetId, destination.Id);
			if (controlSeized)
			{
				CallOnRegistrationEvent(applicationType, platformType, PushRegistrationEventType.DestinationOwnershipChanged);
			}
		}
		IAuthenticationTypeEntity sessionTokenAuth = _TypeLookups.Authentications.ToEntity(PushAuthenticationType.SessionToken);
		foreach (IReceiverDestinationEntity existingSessionDestination in CollectionsHelper.GetAllPaged((long start, long size) => _ReceiverDestinationFactory.GetByReceiverTypeIdReceiverTargetIdAuthenticationTypeIdAndAuthenticationValuePaged(receiver.TypeId, receiver.TargetId, sessionTokenAuth.Id, sessionToken.Value, start, size).ToList(), 50L))
		{
			if (existingSessionDestination.DestinationId == destination.Id)
			{
				continue;
			}
			if (receiverDestination == null)
			{
				receiverDestination = existingSessionDestination;
				receiverDestination.DestinationId = destination.Id;
				CallOnRegistrationEvent(applicationType, platformType, PushRegistrationEventType.UpdatedExistingSessionReceiverDestination);
				continue;
			}
			try
			{
				existingSessionDestination.Delete();
				CallOnRegistrationEvent(applicationType, platformType, PushRegistrationEventType.ExcessExistingSessionReceiverDestinationRemoved);
			}
			catch (Exception e)
			{
				_Logger.Error(e);
			}
		}
		bool newAuthorization = false;
		bool newReceiverDestination = receiverDestination == null;
		if (receiverDestination != null)
		{
			receiverDestination.IsActive = true;
			if (authorizationRequested)
			{
				newAuthorization = !receiverDestination.IsAuthorizedByReceiver;
				receiverDestination.IsAuthorizedByReceiver = true;
			}
			receiverDestination.AuthenticationTypeId = sessionTokenAuth.Id;
			receiverDestination.AuthenticationValue = sessionToken.Value;
			receiverDestination.Update();
		}
		else
		{
			newAuthorization = authorizationRequested || authorizeByDefault;
			receiverDestination = _ReceiverDestinationFactory.Create(receiver.TypeId, receiver.TargetId, destination.Id, sessionTokenAuth.Id, sessionToken.Value, deviceName, isActive: true, newAuthorization);
		}
		CallOnRegistration(applicationType, platformType, newAuthorization, newReceiverDestination);
		if (authorizationRequested)
		{
			this.PushNotificationSettingChanged?.Invoke(user, isEnabled: true, platformType.ToString(), receiverDestination.Id.ToString());
		}
		return Translate(user, receiverDestination);
	}

	/// <summary>
	/// Deauthorizes the current destination for the user's session to indicate they no longer want to receive notifications at that destination.
	/// Only one destination should be registered per session. Any superfluous records for the current session will be removed.
	/// </summary>
	/// <param name="application">The notification application to consider</param>
	/// <param name="user">User</param>
	/// <param name="sessionToken">The session token of the session the user's current session</param>
	/// <returns>True if successful, false if not</returns>
	public bool DeauthorizeSessionDestinations(PushApplicationType application, IUser user, ISessionToken sessionToken)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		if (sessionToken == null)
		{
			throw new PlatformArgumentNullException("SessionToken cannot be null");
		}
		IApplicationTypeEntity applicationTypeEntity = _TypeLookups.Applications.ToEntity(application);
		IReceiver receiver = user.ToReceiver(_TypeLookups.Receivers);
		IAuthenticationTypeEntity sessionAuthentication = _TypeLookups.Authentications.ToEntity(PushAuthenticationType.SessionToken);
		ICollection<IReceiverDestinationEntity> allPaged = CollectionsHelper.GetAllPaged((int start, int size) => _ReceiverDestinationFactory.GetByReceiverTypeIdReceiverTargetIdAuthenticationTypeIdAndAuthenticationValuePaged(receiver.TypeId, receiver.TargetId, sessionAuthentication.Id, sessionToken.Value, start, size).ToList(), 50);
		bool first = true;
		foreach (IReceiverDestinationEntity receiverDestination in allPaged)
		{
			IDestinationEntity destination = _DestinationFactory.Get(receiverDestination.DestinationId);
			IDestinationTypeEntity destinationType = _DestinationTypeFactory.Get(destination.DestinationTypeId);
			if (destinationType.ApplicationTypeId != applicationTypeEntity.Id)
			{
				continue;
			}
			if (first)
			{
				receiverDestination.IsAuthorizedByReceiver = false;
				receiverDestination.Update();
				first = false;
				PushPlatformType pushPlatformType2 = _TypeLookups.Platforms.LookupEnum(destinationType.PlatformTypeId);
				CallOnRegistrationEvent(application, pushPlatformType2, PushRegistrationEventType.ReceiverDestinationDeauthorized);
				this.PushNotificationSettingChanged?.Invoke(user, isEnabled: false, pushPlatformType2.ToString(), receiverDestination.Id.ToString());
			}
			else
			{
				try
				{
					receiverDestination.Delete();
					PushPlatformType pushPlatformType = _TypeLookups.Platforms.LookupEnum(destinationType.PlatformTypeId);
					CallOnRegistrationEvent(application, pushPlatformType, PushRegistrationEventType.ExcessExistingSessionReceiverDestinationRemoved);
				}
				catch (Exception e)
				{
					_Logger.Error(e);
				}
			}
		}
		return true;
	}

	public bool DeauthorizeAllDestinations(PushApplicationType application, IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		IReceiver receiver = user.ToReceiver(_TypeLookups.Receivers);
		IApplicationTypeEntity applicationTypeEntity = _TypeLookups.Applications.ToEntity(application);
		foreach (IReceiverDestinationEntity receiverDestination in from uand in _ReceiverDestinationFactory.GetByReceiverTypeIdReceiverTargetIdIsAuthorizedByReceiverAndIsActivePaged(receiver.TypeId, receiver.TargetId, isAuthorizedByReceiver: true, isActive: true, 0L, Settings.Default.MaxPushNotificationDestinationsPerUser)
			where uand.IsOfApplicationType(applicationTypeEntity, _PushDomainFactory)
			select uand)
		{
			receiverDestination.IsAuthorizedByReceiver = false;
			receiverDestination.Update();
			CallOnRegistrationEvent(application, receiverDestination.ToPlatformType(_PushDomainFactory, _TypeLookups.Platforms), PushRegistrationEventType.ReceiverDestinationDeauthorized);
		}
		return true;
	}

	/// <summary>
	/// Gets all valid push notification destinations for the specified user and application. That is destinations that are both active and authorized for the passed user
	/// </summary>
	/// <param name="application"></param>
	/// <param name="user"></param>
	/// <returns>The valid destinations</returns>
	public IEnumerable<IUserPushDestination> GetValidDestinations(PushApplicationType application, IUser user)
	{
		IReceiver receiver = user.ToReceiver(_TypeLookups.Receivers);
		IApplicationTypeEntity applicationType = _TypeLookups.Applications.ToEntity(application);
		return (from uand in _ReceiverDestinationFactory.GetByReceiverTypeIdReceiverTargetIdIsAuthorizedByReceiverAndIsActivePaged(receiver.TypeId, receiver.TargetId, isAuthorizedByReceiver: true, isActive: true, 0L, Settings.Default.MaxPushNotificationDestinationsPerUser)
			where uand.IsOfApplicationType(applicationType, _PushDomainFactory)
			select uand into x
			select Translate(user, x)).ToList();
	}

	public IUserPushDestination GetUserPushDestinationByDestinationId(long destinationId)
	{
		IReceiverDestinationEntity userNotificationDestination = _ReceiverDestinationFactory.Get(destinationId);
		IReceiverTypeEntity receiverTypeEntity = _PushDomainFactory.ReceiverTypeEntityFactory.Get(userNotificationDestination.ReceiverTypeId);
		if ((ReceiverType)Enum.Parse(typeof(ReceiverType), receiverTypeEntity.Value) != 0)
		{
			return null;
		}
		IUser user = _UserFactory.GetUser(userNotificationDestination.ReceiverTargetId);
		return Translate(user, userNotificationDestination);
	}

	/// <summary>
	/// Gets the push notification destination associated with the user's session, if one exists and it is valid.
	/// </summary>
	/// <param name="application"></param>
	/// <param name="user"></param>
	/// <param name="sessionToken"></param>
	/// <returns>The destination if one exists, otherwise null</returns>
	public IUserPushDestination GetSessionDestination(PushApplicationType application, IUser user, ISessionToken sessionToken)
	{
		IApplicationTypeEntity applicationType = _TypeLookups.Applications.ToEntity(application);
		IReceiver receiver = user.ToReceiver(_TypeLookups.Receivers);
		IAuthenticationTypeEntity sessionAuthentication = _TypeLookups.Authentications.ToEntity(PushAuthenticationType.SessionToken);
		IReceiverDestinationEntity receiverDestination = CollectionsHelper.GetAllPaged((int start, int size) => _ReceiverDestinationFactory.GetByReceiverTypeIdReceiverTargetIdAuthenticationTypeIdAndAuthenticationValuePaged(receiver.TypeId, receiver.TargetId, sessionAuthentication.Id, sessionToken.Value, start, size).ToList(), 50).FirstOrDefault((IReceiverDestinationEntity rd) => rd.IsOfApplicationType(applicationType, _PushDomainFactory) && rd.IsActive && rd.IsAuthorizedByReceiver);
		return Translate(user, receiverDestination);
	}

	/// <summary>
	/// Gets the push notification destination associated with the user's session, if it matches the specified notification token.
	/// </summary>
	/// <param name="application"></param>
	/// <param name="user"></param>
	/// <param name="sessionToken"></param>
	/// <param name="notificationToken">The current notification token passed in from the client.</param>
	/// <returns></returns>
	public IUserPushDestination GetSessionDestination(PushApplicationType application, IUser user, ISessionToken sessionToken, string notificationToken)
	{
		IUserPushDestination sessionDestination = GetSessionDestination(application, user, sessionToken);
		if (sessionDestination == null || sessionDestination.NotificationToken != notificationToken)
		{
			return null;
		}
		return sessionDestination;
	}

	/// <summary>
	/// Gets the unique Destination Type defined by the application and platform types specified.
	/// </summary>
	/// <param name="application"></param>
	/// <param name="platform"></param>
	/// <returns>The Destination Type if it exists, otherwise null</returns>
	public IPushDestinationType GetDestinationType(PushApplicationType application, PushPlatformType platform)
	{
		return Translate(GetDestinationTypeEntity(application, platform));
	}

	/// <summary>
	/// Get the Destination Types for all defined Platform Types for the specified Application Type
	/// </summary>
	/// <param name="application"></param>
	/// <returns></returns>
	public IEnumerable<IPushDestinationType> GetDestinationTypes(PushApplicationType application)
	{
		IApplicationTypeEntity applicationType = _TypeLookups.Applications.ToEntity(application);
		return CollectionsHelper.GetAllPaged((int start, int size) => _DestinationTypeFactory.GetByApplicationTypeIdPaged(applicationType.Id, start, size).ToList(), 50).Select(Translate);
	}

	/// <summary>
	/// Create a new Destination Type for the specified Application and Platform Types specified. Will throw an exception if
	/// a Destination Type with that combination already exists.
	/// </summary>
	/// <param name="application"></param>
	/// <param name="platform"></param>
	/// <param name="registrationEndpoint"></param>
	public void CreateDestinationType(PushApplicationType application, PushPlatformType platform, string registrationEndpoint)
	{
		IApplicationTypeEntity applicationType = _TypeLookups.Applications.ToEntity(application);
		IPlatformTypeEntity platformType = _TypeLookups.Platforms.ToEntity(platform);
		if (_DestinationTypeFactory.GetByApplicationTypeIdAndPlatformTypeId(applicationType.Id, platformType.Id) != null)
		{
			throw new PushNotificationDestinationTypeAlreadyExistsException();
		}
		_DestinationTypeFactory.Create(applicationType.Id, platformType.Id, registrationEndpoint);
	}

	/// <summary>
	/// Update the Destination Type defined by the unique combination of Application and Platform type specified. Will throw
	/// an exception if the Destination Type does not exist.
	/// </summary>
	/// <param name="application"></param>
	/// <param name="platform"></param>
	/// <param name="registrationEndpoint"></param>
	public void UpdateDestinationType(PushApplicationType application, PushPlatformType platform, string registrationEndpoint)
	{
		IApplicationTypeEntity applicationType = _TypeLookups.Applications.ToEntity(application);
		IPlatformTypeEntity platformType = _TypeLookups.Platforms.ToEntity(platform);
		IDestinationTypeEntity obj = _DestinationTypeFactory.GetByApplicationTypeIdAndPlatformTypeId(applicationType.Id, platformType.Id) ?? throw new PushNotificationDestinationTypeDoesntExistException();
		obj.RegistrationEndpoint = registrationEndpoint;
		obj.Update();
	}

	public bool UpdateDestinationHash(long destinationId)
	{
		IDestinationEntity destination = _DestinationFactory.Get(destinationId);
		if (destination.ExternalServiceDestinationIdHash == null)
		{
			destination.ExternalServiceDestinationIdHash = DestinationUtilities.ComputeDestinationServiceIDHash(destination.ExternalServiceDestinationId);
			destination.Update();
			return true;
		}
		return false;
	}

	private IDestinationTypeEntity GetDestinationTypeEntity(PushApplicationType application, PushPlatformType platform)
	{
		IApplicationTypeEntity applicationType = _TypeLookups.Applications.ToEntity(application);
		IPlatformTypeEntity platformType = _TypeLookups.Platforms.ToEntity(platform);
		return _DestinationTypeFactory.GetByApplicationTypeIdAndPlatformTypeId(applicationType.Id, platformType.Id);
	}

	private IPushDestinationType Translate(IDestinationTypeEntity destinationType)
	{
		if (destinationType == null)
		{
			return null;
		}
		return new PushDestinationType
		{
			ID = destinationType.Id,
			ApplicationType = _TypeLookups.Applications.LookupEnum(destinationType.ApplicationTypeId),
			PlatformType = _TypeLookups.Platforms.LookupEnum(destinationType.PlatformTypeId),
			RegistrationEndpoint = destinationType.RegistrationEndpoint,
			Created = destinationType.Created,
			Updated = destinationType.Updated
		};
	}

	private UserPushDestination Translate(IUser user, IReceiverDestinationEntity receiverDestination)
	{
		if (receiverDestination == null)
		{
			return null;
		}
		return Translate(user, receiverDestination, _DestinationFactory.Get(receiverDestination.DestinationId));
	}

	private UserPushDestination Translate(IUser user, IReceiverDestinationEntity receiverDestination, IDestinationEntity destination)
	{
		if (receiverDestination == null)
		{
			return null;
		}
		IDestinationTypeEntity destinationType = _DestinationTypeFactory.Get(destination.DestinationTypeId);
		PushApplicationType applicationType = _TypeLookups.Applications.LookupEnum(destinationType.ApplicationTypeId);
		PushPlatformType platformType = _TypeLookups.Platforms.LookupEnum(destinationType.PlatformTypeId);
		return new UserPushDestination
		{
			User = user,
			UserPushNotificationDestinationId = receiverDestination.Id,
			Name = receiverDestination.Name,
			NotificationToken = destination.ExternalServiceDestinationId,
			Application = applicationType,
			Platform = platformType,
			SupportsUpdateNotifications = PushPlatformFactory.GetPushPlatform(_PushServiceClientFactory, platformType, destinationType, _UserFactory, _TypeLookups.Receivers, _Logger).SupportsNotificationUpdates
		};
	}

	private void CallOnRegistration(PushApplicationType application, PushPlatformType platform, bool userInitiated, bool newReceiverDestination)
	{
		try
		{
			this.OnRegistration?.Invoke(application, platform, userInitiated, newReceiverDestination);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}

	private void CallOnRegistrationEvent(PushApplicationType application, PushPlatformType platform, PushRegistrationEventType registrationEventType)
	{
		try
		{
			this.OnRegistration?.Invoke(application, platform, registrationEventType);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}
}
