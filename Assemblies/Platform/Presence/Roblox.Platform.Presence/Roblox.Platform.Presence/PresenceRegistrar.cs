using System;
using System.Collections.Concurrent;
using System.Threading;
using Roblox.EventLog;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.Presence.Properties;
using Roblox.Presence.Client;
using Roblox.Properties;

namespace Roblox.Platform.Presence;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.Presence.IPresenceRegistrar" />.
/// </summary>
public class PresenceRegistrar : IPresenceRegistrar
{
	private readonly IPresenceClient _Client;

	private readonly IPresenceSessionProvider _PresenceSessionProvider;

	private readonly ILogger _Logger;

	private readonly IPlatformFactory _PlatformFactory;

	private readonly PresencePriorityComparer _PresencePriorityComparer;

	private readonly ConcurrentDictionary<string, VisitorPingInformation> _UserPresenceDictionary;

	private readonly ConcurrentDictionary<string, VisitorPingInformation> _GuestPresenceDictionary;

	private long _UserPresenceDictionaryCount;

	private long _GuestPresenceDictionaryCount;

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Presence.PresenceRegistrar" />.
	/// </summary>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="client"><see cref="T:Roblox.Presence.Client.IPresenceClient" /></param>
	/// <param name="presenceSessionProvider"><see cref="T:Roblox.Platform.Presence.IPresenceSessionProvider" /></param>
	/// <param name="platformFactory"><see cref="T:Roblox.Platform.Devices.IPlatformFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException">
	///  - <paramref name="logger" />
	///  - <paramref name="client" />
	///  - <paramref name="presenceSessionProvider" />
	///  - <paramref name="platformFactory" />
	/// </exception>
	public PresenceRegistrar(ILogger logger, IPresenceClient client, IPresenceSessionProvider presenceSessionProvider, IPlatformFactory platformFactory)
	{
		_Client = client ?? throw new ArgumentNullException("client");
		_PresenceSessionProvider = presenceSessionProvider ?? throw new ArgumentNullException("presenceSessionProvider");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_PlatformFactory = platformFactory ?? throw new ArgumentNullException("platformFactory");
		_PresencePriorityComparer = new PresencePriorityComparer();
		_UserPresenceDictionary = new ConcurrentDictionary<string, VisitorPingInformation>();
		_UserPresenceDictionaryCount = 0L;
		_GuestPresenceDictionary = new ConcurrentDictionary<string, VisitorPingInformation>();
		_GuestPresenceDictionaryCount = 0L;
	}

	[Obsolete("Use PingFromLogin with platformName parameter")]
	public void PingFromLogin(IUserIdentifier user, string location, byte platformTypeId)
	{
		PingFromLocation(user, LocationType.Page, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(user), platformTypeId);
	}

	[Obsolete("Use PingFromInGame with platformName parameter")]
	public void PingFromInGame(IVisitorIdentifier visitor, long placeId, Guid? gameId, byte platformTypeId)
	{
		string placeLocationIdentifier = placeId + "|" + gameId;
		PingFromLocation(visitor, LocationType.Game, placeLocationIdentifier, _PresenceSessionProvider.GetGameSessionIdForCurrentUser(visitor), platformTypeId);
	}

	[Obsolete("Use PingFromInCloudEdit with platformName parameter")]
	public void PingFromInCloudEdit(IVisitorIdentifier visitor, long placeId, Guid? gameId, byte platformTypeId)
	{
		string placeLocationIdentifier = placeId + "|" + gameId;
		PingFromLocation(visitor, LocationType.CloudEdit, placeLocationIdentifier, _PresenceSessionProvider.GetStudioSessionIdForCurrentUser(visitor), platformTypeId);
	}

	[Obsolete("Use PingFromInStudio with platformName parameter")]
	public void PingFromInStudio(IVisitorIdentifier visitor, long placeId, byte platformTypeId)
	{
		PingFromLocation(visitor, LocationType.Studio, placeId.ToString(), _PresenceSessionProvider.GetStudioSessionIdForCurrentUser(visitor), platformTypeId);
	}

	[Obsolete("Use PingFromWebsite with platformName parameter")]
	public void PingFromWebsite(IVisitorIdentifier visitor, string location, byte platformTypeId)
	{
		PingFromLocation(visitor, LocationType.Page, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), platformTypeId);
	}

	[Obsolete("Use PingFromMobileWebsite with platformName parameter")]
	public void PingFromMobileWebsite(IVisitorIdentifier visitor, string location, byte platformTypeId)
	{
		PingFromLocation(visitor, LocationType.MobileWebsite, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), platformTypeId);
	}

	[Obsolete("Use PingFromXbox with platformName parameter")]
	public void PingFromXbox(IVisitorIdentifier visitor, string location, byte platformTypeId)
	{
		PingFromLocation(visitor, LocationType.Xbox, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), platformTypeId);
	}

	[Obsolete("Use PingFromIos with platformName parameter")]
	public void PingFromIos(IVisitorIdentifier visitor, string location, byte platformTypeId)
	{
		PingFromLocation(visitor, LocationType.iOS, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), platformTypeId);
	}

	[Obsolete("Use PingFromAndroid with platformName parameter")]
	public void PingFromAndroid(IVisitorIdentifier visitor, string location, byte platformTypeId)
	{
		PingFromLocation(visitor, LocationType.Android, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), platformTypeId);
	}

	public void PingFromLogin(IUserIdentifier user, string location, string platformName)
	{
		PingFromLocation(user, LocationType.Page, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(user), null, platformName);
	}

	public void PingFromInGame(IVisitorIdentifier visitor, long placeId, Guid? gameId, string platformName, long universeId)
	{
		string placeLocationIdentifier = placeId + "|" + gameId;
		PingFromLocation(visitor, LocationType.Game, placeLocationIdentifier, _PresenceSessionProvider.GetGameSessionIdForCurrentUser(visitor), null, platformName, universeId);
	}

	public void PingFromInCloudEdit(IVisitorIdentifier visitor, long placeId, Guid? gameId, string platformName, long universeId)
	{
		string placeLocationIdentifier = placeId + "|" + gameId;
		PingFromLocation(visitor, LocationType.CloudEdit, placeLocationIdentifier, _PresenceSessionProvider.GetStudioSessionIdForCurrentUser(visitor), null, platformName, universeId);
	}

	public void PingFromInStudio(IVisitorIdentifier visitor, long placeId, string platformName)
	{
		PingFromLocation(visitor, LocationType.Studio, placeId.ToString(), _PresenceSessionProvider.GetStudioSessionIdForCurrentUser(visitor), null, platformName);
	}

	public void PingFromWebsite(IVisitorIdentifier visitor, string location, string platformName)
	{
		PingFromLocation(visitor, LocationType.Page, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), null, platformName);
	}

	public void PingFromMobileWebsite(IVisitorIdentifier visitor, string location, string platformName)
	{
		PingFromLocation(visitor, LocationType.MobileWebsite, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), null, platformName);
	}

	public void PingFromXbox(IVisitorIdentifier visitor, string location, string platformName)
	{
		PingFromLocation(visitor, LocationType.Xbox, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), null, platformName);
	}

	public void PingFromIos(IVisitorIdentifier visitor, string location, string platformName)
	{
		PingFromLocation(visitor, LocationType.iOS, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), null, platformName);
	}

	public void PingFromAndroid(IVisitorIdentifier visitor, string location, string platformName)
	{
		PingFromLocation(visitor, LocationType.Android, location, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor), null, platformName);
	}

	/// <summary>
	/// New PingFromLocation using platformName instead of platformTypeId
	/// </summary>
	private void PingFromLocation(IVisitorIdentifier visitor, LocationType locationType, string location, string sessionId, byte? platformTypeId = null, string platform = null, long? universeId = null)
	{
		if (sessionId == null && Roblox.Platform.Presence.Properties.Settings.Default.ShouldLogSessionAbsence)
		{
			_Logger.Error("Session Id was null for visitor Id:" + visitor?.Id);
			return;
		}
		visitor.VerifyIsNotNull();
		if (platformTypeId.HasValue)
		{
			platform = _PlatformFactory.GetById(platformTypeId.Value).PlatformName;
		}
		string clientLocationType = locationType.ToString();
		if (visitor is IUser)
		{
			if (Roblox.Platform.Presence.Properties.Settings.Default.IsDeduplicationOfPresenceWritesEnabled && _UserPresenceDictionaryCount < Roblox.Platform.Presence.Properties.Settings.Default.MaxNumberOfDeduplicationEntriesAllowed)
			{
				string key = GetUserPresenceKey(visitor.Id, sessionId);
				if (!DeDuplicateRegisterPresence(key, _UserPresenceDictionary, visitor, sessionId, location, clientLocationType, platform, universeId))
				{
					Interlocked.Increment(ref _UserPresenceDictionaryCount);
				}
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					DoPingFromLocationForUser(visitor, sessionId);
				});
			}
			else
			{
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					_Client.RegisterUserPresence(visitor.Id, location, clientLocationType, platform, sessionId, universeId);
				});
			}
		}
		else
		{
			if (!(visitor is IGuest))
			{
				return;
			}
			if (Roblox.Platform.Presence.Properties.Settings.Default.IsDeduplicationOfGuestPresenceWritesEnabled && _GuestPresenceDictionaryCount < Roblox.Platform.Presence.Properties.Settings.Default.MaxNumberOfDeduplicationGuestEntriesAllowed)
			{
				if (!DeDuplicateRegisterPresence(visitor.Id.ToString(), _GuestPresenceDictionary, visitor, sessionId, location, clientLocationType, platform))
				{
					Interlocked.Increment(ref _GuestPresenceDictionaryCount);
				}
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					DoPingFromLocationForGuest(visitor);
				});
			}
			else
			{
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					_Client.RegisterGuestPresence(visitor.Id, location, clientLocationType, platform);
				});
			}
		}
	}

	/// <summary>
	/// Old PingFromLocation to deprecate. platformTypeId obsolete
	/// </summary>
	[Obsolete("Use new PingFromLocation with platform name")]
	private void PingFromLocation(IVisitorIdentifier visitor, LocationType locationType, string location, string sessionId, byte platformTypeId)
	{
		if (sessionId == null && Roblox.Platform.Presence.Properties.Settings.Default.ShouldLogSessionAbsence)
		{
			_Logger.Error("Session Id was null for visitor Id:" + visitor?.Id);
			return;
		}
		visitor.VerifyIsNotNull();
		string platform = _PlatformFactory.GetById(platformTypeId).PlatformName;
		string clientLocationType = locationType.ToString();
		if (visitor is IUser)
		{
			if (Roblox.Platform.Presence.Properties.Settings.Default.IsDeduplicationOfPresenceWritesEnabled && _UserPresenceDictionaryCount < Roblox.Platform.Presence.Properties.Settings.Default.MaxNumberOfDeduplicationEntriesAllowed)
			{
				string key = GetUserPresenceKey(visitor.Id, sessionId);
				if (!DeDuplicateRegisterPresence(key, _UserPresenceDictionary, visitor, sessionId, location, clientLocationType, platform))
				{
					Interlocked.Increment(ref _UserPresenceDictionaryCount);
				}
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					DoPingFromLocationForUser(visitor, sessionId);
				});
			}
			else
			{
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					_Client.RegisterUserPresence(visitor.Id, location, clientLocationType, platform, sessionId, (long?)null);
				});
			}
		}
		else
		{
			if (!(visitor is IGuest))
			{
				return;
			}
			if (Roblox.Platform.Presence.Properties.Settings.Default.IsDeduplicationOfGuestPresenceWritesEnabled && _GuestPresenceDictionaryCount < Roblox.Platform.Presence.Properties.Settings.Default.MaxNumberOfDeduplicationGuestEntriesAllowed)
			{
				if (!DeDuplicateRegisterPresence(visitor.Id.ToString(), _GuestPresenceDictionary, visitor, sessionId, location, clientLocationType, platform))
				{
					Interlocked.Increment(ref _GuestPresenceDictionaryCount);
				}
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					DoPingFromLocationForGuest(visitor);
				});
			}
			else
			{
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					_Client.RegisterGuestPresence(visitor.Id, location, clientLocationType, platform);
				});
			}
		}
	}

	private bool DeDuplicateRegisterPresence(string visitorPresenceKey, ConcurrentDictionary<string, VisitorPingInformation> visitorDictionary, IVisitorIdentifier visitor, string sessionId, string location, string clientLocationType, string platform, long? universeId = null)
	{
		VisitorPingInformation pingInfo = new VisitorPingInformation
		{
			Location = location,
			ClientLocationType = clientLocationType,
			Platform = platform,
			SessionId = sessionId,
			TimeStamp = DateTime.Now,
			UniverseId = universeId
		};
		bool wasUpdated = false;
		visitorDictionary.AddOrUpdate(visitorPresenceKey, pingInfo, delegate(string k, VisitorPingInformation oldInfo)
		{
			wasUpdated = true;
			return (oldInfo.TimeStamp > pingInfo.TimeStamp) ? oldInfo : pingInfo;
		});
		return wasUpdated;
	}

	private void DoPingFromLocationForUser(IVisitorIdentifier visitor, string sessionId)
	{
		string key = GetUserPresenceKey(visitor.Id, sessionId);
		if (_UserPresenceDictionary.TryRemove(key, out var pingInfo))
		{
			try
			{
				_Client.RegisterUserPresence(visitor.Id, pingInfo.Location, pingInfo.ClientLocationType, pingInfo.Platform, pingInfo.SessionId, pingInfo.UniverseId);
			}
			finally
			{
				Interlocked.Decrement(ref _UserPresenceDictionaryCount);
			}
		}
	}

	private void DoPingFromLocationForGuest(IVisitorIdentifier visitor)
	{
		string key = visitor.Id.ToString();
		if (_GuestPresenceDictionary.TryRemove(key, out var pingInfo))
		{
			try
			{
				_Client.RegisterGuestPresence(visitor.Id, pingInfo.Location, pingInfo.ClientLocationType, pingInfo.Platform);
			}
			finally
			{
				Interlocked.Decrement(ref _GuestPresenceDictionaryCount);
			}
		}
	}

	private string GetUserPresenceKey(long visitorId, string sessionId)
	{
		return visitorId + sessionId;
	}

	public void RegisterAbsenceFromGame(IVisitorIdentifier visitor)
	{
		RegisterAbsence(visitor, _PresenceSessionProvider.GetGameSessionIdForCurrentUser(visitor));
	}

	public void RegisterAbsenceFromWebsite(IVisitorIdentifier visitor)
	{
		RegisterAbsence(visitor, _PresenceSessionProvider.GetWebSessionIdForCurrentUser(visitor));
	}

	public void RegisterAbsenceFromWebsiteSession(IVisitorIdentifier visitor, string currentWebSessionId)
	{
		RegisterAbsence(visitor, _PresenceSessionProvider.GetWebSessionIdForCurrentUserSession(visitor, currentWebSessionId));
	}

	public void RegisterAbsenceFromStudio(IVisitorIdentifier visitor)
	{
		RegisterAbsence(visitor, _PresenceSessionProvider.GetStudioSessionIdForCurrentUser(visitor));
	}

	private void RegisterAbsence(IVisitorIdentifier visitor, string sessionId)
	{
		if (!Roblox.Properties.Settings.Default.RegisterVisitorAbsence)
		{
			return;
		}
		visitor.VerifyIsNotNull();
		if (visitor is IUser)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				_Client.RegisterUserAbsence(visitor.Id, sessionId);
			});
		}
		else if (visitor is IGuest)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				_Client.RegisterGuestAbsence(visitor.Id);
			});
		}
	}
}
