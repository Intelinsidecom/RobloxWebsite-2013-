using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Presence;
using Roblox.Platform.Universes;
using Roblox.Time;
using Roblox.Web.Presence.Enums;
using Roblox.Web.Presence.Implementation;
using Roblox.Web.Presence.Interfaces;

namespace Roblox.Web.Presence;

/// <summary>
/// Converts <see cref="T:Roblox.Platform.Presence.IPresence" />s to <see cref="T:Roblox.Web.Presence.Interfaces.IUserPresence" />s.
/// </summary>
public class UserPresenceBuilder
{
	private class UniverseInfo
	{
		public IUniverse Universe { get; set; }

		public string UniverseDisplayName { get; set; }
	}

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IPlaceFactory _PlaceFactory;

	private readonly IPresenceDescriber _PresenceDescriber;

	private readonly ILogger _Logger;

	public UserPresenceBuilder(ILogger logger, IUniverseFactory universeFactory, IPlaceFactory placeFactory, IPresenceDescriber presenceDescriber)
	{
		_UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		_PresenceDescriber = presenceDescriber ?? throw new ArgumentNullException("presenceDescriber");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public IUserPresence BuildUserPresence(IPresence presence, ISupportedLocale supportedLocale)
	{
		UserPresence userPresence = new UserPresence
		{
			UserPresenceType = GetUserPresenceType(presence.IsOnline, presence.LocationType),
			LastLocation = _PresenceDescriber.Describe(presence, supportedLocale),
			UserId = presence.VisitorId,
			PlaceId = presence.PlaceId,
			GameId = presence.GameId,
			LastOnline = UtcInstant.CoerceFrom(presence.LastOnline)
		};
		if (userPresence.PlaceId.HasValue)
		{
			try
			{
				IUniverse universe = _UniverseFactory?.GetPlaceUniverse(userPresence.PlaceId.Value);
				userPresence.UniverseId = universe?.Id;
				userPresence.RootPlaceId = universe?.RootPlaceId;
			}
			catch (Exception ex)
			{
				_Logger.Error(ex);
			}
		}
		return userPresence;
	}

	public IReadOnlyCollection<IUserPresence> BuildUserPresences(IReadOnlyCollection<IPresence> presences, ISupportedLocale supportedLocale)
	{
		List<IUserPresence> userPresences = new List<IUserPresence>();
		if (presences.Count == 0)
		{
			return userPresences;
		}
		Dictionary<long, IUniverse> placeUniverseLookup = new Dictionary<long, IUniverse>();
		Dictionary<long, string> visitorLocalizedLocationNameLookup = new Dictionary<long, string>();
		HashSet<long> placeIds = new HashSet<long>();
		int queryUniversesBatchSize = PresenceDescriber.MaximumUniversesInMultiGet;
		for (int i = 0; i < presences.Count; i += queryUniversesBatchSize)
		{
			try
			{
				List<long> placesToQueryUniverseFor = (from presence in presences.Skip(i).Take(queryUniversesBatchSize)
					where presence?.PlaceId.HasValue ?? false
					select presence.PlaceId.Value into placeId
					where placeIds.Add(placeId)
					select placeId).ToList();
				List<IPlace> places = _PlaceFactory.Get(placesToQueryUniverseFor)?.Where((IPlace place) => place != null).ToList();
				Dictionary<long, IUniverse> placeUniverseLookUpForBatchedPlaces = _UniverseFactory.GetUniverseByPlaces(places)?.Where((KeyValuePair<IPlace, IUniverse> keyValuePair) => keyValuePair.Key != null && keyValuePair.Value != null).ToDictionary((KeyValuePair<IPlace, IUniverse> keyValuePair) => keyValuePair.Key.Id, (KeyValuePair<IPlace, IUniverse> keyValuePair) => keyValuePair.Value);
				if (placeUniverseLookUpForBatchedPlaces == null)
				{
					continue;
				}
				foreach (KeyValuePair<long, IUniverse> placeUniversePair in placeUniverseLookUpForBatchedPlaces)
				{
					if (!placeUniverseLookup.ContainsKey(placeUniversePair.Key))
					{
						placeUniverseLookup.Add(placeUniversePair.Key, placeUniversePair.Value);
					}
				}
				foreach (KeyValuePair<long, string> visitorLocationPair in _PresenceDescriber.Describe(presences, supportedLocale, placeUniverseLookup))
				{
					if (!visitorLocalizedLocationNameLookup.ContainsKey(visitorLocationPair.Key))
					{
						visitorLocalizedLocationNameLookup.Add(visitorLocationPair.Key, visitorLocationPair.Value);
					}
				}
			}
			catch (Exception e)
			{
				_Logger.Error(e);
			}
		}
		foreach (IPresence presence2 in presences)
		{
			string locationName;
			UserPresence userPresence = new UserPresence
			{
				UserPresenceType = GetUserPresenceType(presence2.IsOnline, presence2.LocationType),
				UserId = presence2.VisitorId,
				PlaceId = presence2.PlaceId,
				GameId = presence2.GameId,
				LastOnline = UtcInstant.CoerceFrom(presence2.LastOnline),
				LastLocation = (visitorLocalizedLocationNameLookup.TryGetValue(presence2.VisitorId, out locationName) ? locationName : string.Empty)
			};
			if (userPresence.PlaceId.HasValue && placeUniverseLookup.TryGetValue(userPresence.PlaceId.Value, out var universe))
			{
				userPresence.UniverseId = universe?.Id;
				userPresence.RootPlaceId = universe?.RootPlaceId;
			}
			userPresences.Add(userPresence);
		}
		return userPresences;
	}

	public IReadOnlyCollection<IUserPresence> BuildUserPresencesWithUniverseLookUp(IReadOnlyCollection<IPresence> presences, ISupportedLocale supportedLocale)
	{
		List<IUserPresence> userPresences = new List<IUserPresence>();
		if (presences == null || presences.Count == 0)
		{
			return userPresences;
		}
		Dictionary<long, UniverseInfo> universeLookup = new Dictionary<long, UniverseInfo>();
		int queryUniversesBatchSize = PresenceDescriber.MaximumUniversesInMultiGet;
		for (int i = 0; i < presences.Count; i += queryUniversesBatchSize)
		{
			try
			{
				List<long> universeIdsToQuery = (from presence in presences.Skip(i).Take(queryUniversesBatchSize)
					where presence?.UniverseId.HasValue ?? false
					select presence.UniverseId.Value into universeId
					where !universeLookup.ContainsKey(universeId)
					select universeId).ToList();
				List<IUniverse> universes = _UniverseFactory.GetUniverses(universeIdsToQuery)?.Where((IUniverse universe) => universe != null).ToList();
				if (universes == null)
				{
					continue;
				}
				Dictionary<long, IUniverse> dictionary = universes.ToDictionary((IUniverse universe) => universe.Id, (IUniverse universe) => universe);
				IDictionary<IUniverse, string> universeDisplayNames = _PresenceDescriber.GetUniverseDisplayName(universes, supportedLocale);
				foreach (KeyValuePair<long, IUniverse> universePair in dictionary)
				{
					UniverseInfo universeInfo = new UniverseInfo
					{
						Universe = universePair.Value
					};
					if (universePair.Value != null)
					{
						universeInfo.UniverseDisplayName = universeDisplayNames[universePair.Value];
					}
					universeLookup.Add(universePair.Key, universeInfo);
				}
			}
			catch (Exception e)
			{
				_Logger.Error(e);
			}
		}
		foreach (IPresence presence2 in presences)
		{
			UserPresence userPresence = new UserPresence
			{
				UserPresenceType = GetUserPresenceType(presence2.IsOnline, presence2.LocationType),
				UserId = presence2.VisitorId,
				PlaceId = presence2.PlaceId,
				GameId = presence2.GameId,
				LastOnline = UtcInstant.CoerceFrom(presence2.LastOnline),
				LastLocation = PresenceDescriber.GetLocationForPresence(presence2, NameGetter),
				UniverseId = presence2.UniverseId
			};
			if (userPresence.UniverseId.HasValue && universeLookup.TryGetValue(userPresence.UniverseId.Value, out var universeInfo2))
			{
				userPresence.RootPlaceId = universeInfo2?.Universe?.RootPlaceId;
			}
			userPresences.Add(userPresence);
		}
		return userPresences;
		string NameGetter(long? universeId, long? placeId)
		{
			if (universeId.HasValue && universeLookup.TryGetValue(universeId.Value, out var universeInfo3) && universeInfo3?.Universe != null)
			{
				return universeInfo3.UniverseDisplayName;
			}
			if (!placeId.HasValue)
			{
				return string.Empty;
			}
			try
			{
				return _PlaceFactory.Get(placeId.Value)?.Name;
			}
			catch (Exception e2)
			{
				_Logger.Error(e2);
				return string.Empty;
			}
		}
	}

	private Roblox.Web.Presence.Enums.PresenceType GetUserPresenceType(bool isOnline, LocationType? locationType)
	{
		if (isOnline)
		{
			switch (locationType)
			{
			case LocationType.Game:
				return Roblox.Web.Presence.Enums.PresenceType.InGame;
			case LocationType.Studio:
			case LocationType.CloudEdit:
				return Roblox.Web.Presence.Enums.PresenceType.InStudio;
			default:
				return Roblox.Web.Presence.Enums.PresenceType.Online;
			}
		}
		return Roblox.Web.Presence.Enums.PresenceType.Offline;
	}
}
