using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Assets;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Presence;
using Roblox.Platform.UniverseDisplayInformation;
using Roblox.Platform.Universes;
using Roblox.Web.Presence.Properties;

namespace Roblox.Web.Presence;

/// <summary>
/// The default <see cref="T:Roblox.Web.Presence.IPresenceDescriber" />.
/// </summary>
public class PresenceDescriber : IPresenceDescriber
{
	private const string _WebsiteName = "Website";

	private const string _MobileWebsiteName = "Mobile Website";

	private const string _iOSName = "iOS";

	private const string _XboxName = "Xbox One App";

	private readonly IPlaceFactory _PlaceFactory;

	private readonly IUniverseDisplayInformationAccessor _UniverseDisplayInfomationAccessor;

	private readonly IUniverseFactory _UniverseFactory;

	internal static int MaximumUniversesInMultiGet => Settings.Default.MaximumUniversesInMultiGet;

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Web.Presence.PresenceDescriber" />.
	/// </summary>
	/// <param name="placeFactory"><see cref="T:Roblox.Platform.Assets.IPlaceFactory" /></param>
	/// <param name="universeFactory"><see cref="T:Roblox.Platform.Universes.IUniverseFactory" /></param>
	/// <param name="universeDisplayInformationAccessor"><see cref="T:Roblox.Platform.UniverseDisplayInformation.IUniverseDisplayInformationAccessor" /></param>
	/// <exception cref="T:System.ArgumentNullException">
	///  - <paramref name="placeFactory" />
	///  - <paramref name="universeFactory" />
	///  - <paramref name="universeDisplayInformationAccessor" />
	/// </exception>
	public PresenceDescriber(IPlaceFactory placeFactory, IUniverseFactory universeFactory, IUniverseDisplayInformationAccessor universeDisplayInformationAccessor)
	{
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		_UniverseDisplayInfomationAccessor = universeDisplayInformationAccessor ?? throw new ArgumentNullException("universeDisplayInformationAccessor");
		_UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
	}

	/// <inheritdoc cref="M:Roblox.Web.Presence.IPresenceDescriber.Describe(Roblox.Platform.Presence.IPresence,Roblox.Platform.Localization.Core.ISupportedLocale)" />
	public string Describe(IPresence presence, ISupportedLocale supportedLocale)
	{
		if (presence == null)
		{
			throw new ArgumentNullException("presence");
		}
		if (supportedLocale == null)
		{
			throw new ArgumentNullException("supportedLocale");
		}
		return Describe((IReadOnlyCollection<IPresence>)(object)new IPresence[1] { presence }, supportedLocale).First();
	}

	/// <inheritdoc cref="M:Roblox.Web.Presence.IPresenceDescriber.Describe(System.Collections.Generic.IReadOnlyCollection{Roblox.Platform.Presence.IPresence},Roblox.Platform.Localization.Core.ISupportedLocale)" />
	public IEnumerable<string> Describe(IReadOnlyCollection<IPresence> presences, ISupportedLocale supportedLocale)
	{
		if (presences == null)
		{
			throw new ArgumentNullException("presences");
		}
		if (!presences.Any())
		{
			throw new ArgumentException(string.Format("{0} is empty.", "presences"), "presences");
		}
		if (presences.Count > MaximumUniversesInMultiGet)
		{
			throw new ArgumentException(string.Format("{0} has {1} members, {2} allowed.", "presences", presences.Count, MaximumUniversesInMultiGet), "presences");
		}
		if (supportedLocale == null)
		{
			throw new ArgumentNullException("supportedLocale");
		}
		Func<long, string> nameGetter = BuildPlaceToUniverseNameLookup(presences, supportedLocale);
		foreach (IPresence presence in presences)
		{
			yield return GetLocationForPresence(presence, nameGetter);
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Presence.IPresenceDescriber.Describe(System.Collections.Generic.IReadOnlyCollection{Roblox.Platform.Presence.IPresence},Roblox.Platform.Localization.Core.ISupportedLocale,System.Collections.Generic.IDictionary{System.Int64,Roblox.Platform.Universes.IUniverse})" />
	public IReadOnlyDictionary<long, string> Describe(IReadOnlyCollection<IPresence> presences, ISupportedLocale supportedLocale, IDictionary<long, IUniverse> placeUniverseLookup)
	{
		if (presences == null)
		{
			throw new ArgumentNullException("presences");
		}
		if (!presences.Any())
		{
			throw new ArgumentException(string.Format("{0} is empty.", "presences"), "presences");
		}
		if (supportedLocale == null)
		{
			throw new ArgumentNullException("supportedLocale");
		}
		Func<long, string> nameGetter = BuildPlaceToUniverseNameLookup(presences, supportedLocale, placeUniverseLookup);
		return presences.ToDictionary((IPresence presence) => presence.VisitorId, (IPresence presence) => GetLocationForPresence(presence, nameGetter));
	}

	private Func<long, string> BuildPlaceToUniverseNameLookup(IEnumerable<IPresence> presences, ISupportedLocale supportedLocale, IDictionary<long, IUniverse> placeUniverseLookup = null)
	{
		long[] placeIds = (from p in presences
			where p.LocationType == LocationType.Game || p.LocationType == LocationType.CloudEdit || p.LocationType == LocationType.Studio
			where p.PlaceId.HasValue
			select p.PlaceId.Value).Distinct().ToArray();
		if (placeUniverseLookup == null)
		{
			placeUniverseLookup = _UniverseFactory.GetUniverseByPlaces((IReadOnlyCollection<long>)(object)placeIds);
		}
		IUniverse[] universes = placeUniverseLookup.Select((KeyValuePair<long, IUniverse> u) => u.Value).ToArray();
		IDictionary<IUniverse, string> universeNames = _UniverseDisplayInfomationAccessor.GetDisplayNamesForUniverses((IReadOnlyCollection<IUniverse>)(object)universes, supportedLocale);
		return nameGetter;
		string nameGetter(long placeId)
		{
			if (!placeUniverseLookup.ContainsKey(placeId))
			{
				return string.Empty;
			}
			IUniverse universe = placeUniverseLookup[placeId];
			if (universe == null)
			{
				return _PlaceFactory.Get(placeId)?.Name;
			}
			return universeNames[universe];
		}
	}

	public IDictionary<IUniverse, string> GetUniverseDisplayName(IReadOnlyCollection<IUniverse> universes, ISupportedLocale supportedLocale)
	{
		return _UniverseDisplayInfomationAccessor.GetDisplayNamesForUniverses(universes, supportedLocale);
	}

	private string GetLocationForPresence(IPresence presence, Func<long, string> nameGetterForPlaceIdFunc)
	{
		switch (presence.LocationType)
		{
		case LocationType.Game:
		case LocationType.CloudEdit:
			return nameGetterForPlaceIdFunc(presence.PlaceId ?? 0);
		case LocationType.MobileWebsite:
			return "Mobile Website";
		case LocationType.Studio:
			return $"Studio - {nameGetterForPlaceIdFunc(presence.PlaceId ?? 0)}";
		case LocationType.iOS:
			return "iOS";
		case LocationType.Xbox:
			return "Xbox One App";
		default:
			return "Website";
		}
	}

	internal static string GetLocationForPresence(IPresence presence, Func<long?, long?, string> nameGetterForPlaceIdFunc)
	{
		switch (presence.LocationType)
		{
		case LocationType.Game:
		case LocationType.CloudEdit:
			return nameGetterForPlaceIdFunc(presence.UniverseId, presence.PlaceId);
		case LocationType.MobileWebsite:
			return "Mobile Website";
		case LocationType.Studio:
			return $"Studio - {nameGetterForPlaceIdFunc(presence.UniverseId, presence.PlaceId)}";
		case LocationType.iOS:
			return "iOS";
		case LocationType.Xbox:
			return "Xbox One App";
		default:
			return "Website";
		}
	}
}
