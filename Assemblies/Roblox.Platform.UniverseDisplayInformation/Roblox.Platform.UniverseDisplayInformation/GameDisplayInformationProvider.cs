using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.UniverseDisplayInformation.Properties;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <inheritdoc />
public class GameDisplayInformationProvider : IGameDisplayInformationProvider
{
	private readonly IUniverseDisplayInformationAccessor _UniverseDisplayInformationAccessor;

	private readonly IGameDisplayInformationProviderSettings _Settings;

	private readonly Func<IAsset, string> _PlaceNameGetter;

	private readonly Func<IAsset, string> _PlaceDescriptionGetter;

	private readonly Func<IUniverse, string> _UniverseNameGetter;

	private readonly Func<IUniverse, string> _UniverseDescriptionGetter;

	internal GameDisplayInformationProvider(IUniverseDisplayInformationAccessor universeDisplayInformationAccessor, IGameDisplayInformationProviderSettings settings)
	{
		_UniverseDisplayInformationAccessor = universeDisplayInformationAccessor.AssignOrThrowIfNull("universeDisplayInformationAccessor");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_PlaceNameGetter = (IAsset place) => place.Name;
		_PlaceDescriptionGetter = (IAsset place) => place.Description;
		_UniverseNameGetter = (IUniverse universe) => universe?.Name;
		_UniverseDescriptionGetter = (IUniverse universe) => universe?.Description;
	}

	/// <summary>
	/// The constructor.
	/// </summary>
	/// <param name="universeDisplayInformationAccessor">The <see cref="T:Roblox.Platform.UniverseDisplayInformation.IUniverseDisplayInformationAccessor" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any null arguments.</exception>
	public GameDisplayInformationProvider(IUniverseDisplayInformationAccessor universeDisplayInformationAccessor)
		: this(universeDisplayInformationAccessor, Settings.Default)
	{
	}

	/// <inheritdoc />
	public string GetGameDisplayName(IUniverse universe, IAsset place, ISupportedLocale supportedLocale)
	{
		if (place == null)
		{
			throw new PlatformArgumentNullException("place");
		}
		return DoGetDisplayInformation(universe, place, supportedLocale, shouldUseUniverseInformation: true, _PlaceNameGetter, _UniverseNameGetter, _UniverseDisplayInformationAccessor.GetDisplayName, shouldGetValueFromAccessorEvenIfEmptyValue: false);
	}

	/// <inheritdoc />
	public string GetGameDisplayDescription(IUniverse universe, IAsset place, ISupportedLocale supportedLocale, bool? shouldUseUniverseDescription = null)
	{
		if (place == null)
		{
			throw new PlatformArgumentNullException("place");
		}
		return DoGetDisplayInformation(universe, place, supportedLocale, shouldUseUniverseDescription ?? _Settings.IsUniverseDescriptionInsteadOfPlaceDescriptionEnabled, _PlaceDescriptionGetter, _UniverseDescriptionGetter, _UniverseDisplayInformationAccessor.GetDisplayDescription, shouldGetValueFromAccessorEvenIfEmptyValue: true);
	}

	public IDictionary<IAsset, string> GetGameDisplayNames(IReadOnlyCollection<(IUniverse, IAsset)> universePlaceTuples, ISupportedLocale supportedLocale)
	{
		if (universePlaceTuples == null)
		{
			throw new PlatformArgumentNullException("universePlaceTuples");
		}
		return DoMultiGetGameDisplayInformation(universePlaceTuples, supportedLocale, shouldUseUniverseInformation: true, _PlaceNameGetter, _UniverseNameGetter, _UniverseDisplayInformationAccessor.GetDisplayNamesForUniverses, shouldGetValueFromAccessorEvenIfEmptyValue: false);
	}

	public IDictionary<IAsset, string> GetGameDisplayDescriptions(IReadOnlyCollection<(IUniverse, IAsset)> universePlaceTuples, ISupportedLocale supportedLocale, bool? shouldUseUniverseDescription = null)
	{
		if (universePlaceTuples == null)
		{
			throw new PlatformArgumentNullException("universePlaceTuples");
		}
		return DoMultiGetGameDisplayInformation(universePlaceTuples, supportedLocale, shouldUseUniverseDescription ?? _Settings.IsUniverseDescriptionInsteadOfPlaceDescriptionEnabled, _PlaceDescriptionGetter, _UniverseDescriptionGetter, _UniverseDisplayInformationAccessor.GetDisplayDescriptionsForUniverses, shouldGetValueFromAccessorEvenIfEmptyValue: true);
	}

	private string DoGetDisplayInformation(IUniverse universe, IAsset place, ISupportedLocale supportedLocale, bool shouldUseUniverseInformation, Func<IAsset, string> placePropertyGetter, Func<IUniverse, string> universePropertyGetter, Func<IUniverse, ISupportedLocale, string> getFromAccessor, bool shouldGetValueFromAccessorEvenIfEmptyValue)
	{
		string placeInformation = placePropertyGetter(place);
		bool shouldGetValueFromAccessor = (shouldUseUniverseInformation && (shouldGetValueFromAccessorEvenIfEmptyValue || !string.IsNullOrWhiteSpace(universePropertyGetter(universe)))) || IsShadowRolloutEnabled();
		if (universe == null || !shouldGetValueFromAccessor)
		{
			return placeInformation;
		}
		string displayInformationFromAccessor = getFromAccessor(universe, supportedLocale);
		if (!shouldUseUniverseInformation || string.IsNullOrWhiteSpace(displayInformationFromAccessor))
		{
			return placeInformation;
		}
		return displayInformationFromAccessor;
	}

	private IDictionary<IAsset, string> DoMultiGetGameDisplayInformation(IReadOnlyCollection<(IUniverse Universe, IAsset Place)> universePlaceTuples, ISupportedLocale supportedLocale, bool shouldUseUniverseInformation, Func<IAsset, string> placePropertyGetter, Func<IUniverse, string> universePropertyGetter, Func<IReadOnlyCollection<IUniverse>, ISupportedLocale, IDictionary<IUniverse, string>> multiGetFromAccessor, bool shouldGetValueFromAccessorEvenIfEmptyValue)
	{
		Dictionary<IAsset, string> placeDisplayInformationDictionary = universePlaceTuples.ToDictionary(((IUniverse Universe, IAsset Place) x) => x.Place, ((IUniverse Universe, IAsset Place) x) => placePropertyGetter(x.Place));
		bool shadowRolloutEnabled = IsShadowRolloutEnabled();
		if (!shouldUseUniverseInformation && !shadowRolloutEnabled)
		{
			return placeDisplayInformationDictionary;
		}
		List<IUniverse> universesToGetInformationFromAccessor = (from tuple in universePlaceTuples
			select tuple.Universe into universe
			where universe != null
			select universe).ToList();
		if (!shouldGetValueFromAccessorEvenIfEmptyValue && !shadowRolloutEnabled)
		{
			universesToGetInformationFromAccessor = universesToGetInformationFromAccessor.Where((IUniverse universe) => !string.IsNullOrWhiteSpace(universePropertyGetter(universe))).ToList();
		}
		IDictionary<IUniverse, string> displayInformationFromAccessor = multiGetFromAccessor(universesToGetInformationFromAccessor, supportedLocale);
		if (!shouldUseUniverseInformation)
		{
			return placeDisplayInformationDictionary;
		}
		foreach (var universePlaceTuple in universePlaceTuples)
		{
			if (universePlaceTuple.Universe != null && displayInformationFromAccessor.ContainsKey(universePlaceTuple.Universe) && !string.IsNullOrWhiteSpace(displayInformationFromAccessor[universePlaceTuple.Universe]))
			{
				placeDisplayInformationDictionary[universePlaceTuple.Place] = displayInformationFromAccessor[universePlaceTuple.Universe];
			}
		}
		return placeDisplayInformationDictionary;
	}

	private bool IsShadowRolloutEnabled()
	{
		if (_Settings.IsAccessingTranslationsEnabled)
		{
			return !_Settings.IsReturningTranslationsEnabled;
		}
		return false;
	}
}
