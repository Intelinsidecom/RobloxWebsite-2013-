using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.DataV2.Core;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Universes.Events;
using Roblox.Platform.Universes.Properties;
using Roblox.Universes.Client;

namespace Roblox.Platform.Universes;

internal class UniverseFactory : IUniverseFactory
{
	private readonly IUniversesClient _Client;

	private readonly UniverseDomainFactories _UniverseDomainFactories;

	private readonly ISettings _Settings;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.UniverseFactory" /> class.
	/// </summary>
	/// <param name="client">An <see cref="T:Roblox.Universes.Client.IUniversesClient" /></param>
	/// <param name="domainFactories">A <see cref="T:Roblox.Platform.Universes.UniverseDomainFactories" /></param>
	/// <exception cref="T:System.ArgumentNullException">
	/// Thrown if either of the arguments is null.
	/// </exception>
	public UniverseFactory(IUniversesClient client, UniverseDomainFactories domainFactories)
		: this(client, domainFactories, Settings.Default)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.UniverseFactory" /> class.
	/// </summary>
	/// <param name="client">An <see cref="T:Roblox.Universes.Client.IUniversesClient" /></param>
	/// <param name="domainFactories">A <see cref="T:Roblox.Platform.Universes.UniverseDomainFactories" /></param>
	/// <param name="settings">Universe settings.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// Thrown if either of the arguments is null.
	/// </exception>
	internal UniverseFactory(IUniversesClient client, UniverseDomainFactories domainFactories, ISettings settings)
	{
		_Client = client ?? throw new ArgumentNullException("client");
		_UniverseDomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <inheritdoc />
	public IEnumerable<IUniverse> GetUniverses(IEnumerable<long> universeIds)
	{
		if (universeIds == null)
		{
			throw new ArgumentNullException("universeIds");
		}
		return _Client.MultiGetUniverses((ICollection<long>)universeIds.ToList()).Select(ConvertClientToPlatformUniverse);
	}

	/// <inheritdoc />
	public long CreateUniverse(IPlace rootPlace, long shopId, string privacyType)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		if (rootPlace == null)
		{
			throw new ArgumentNullException("rootPlace");
		}
		Roblox.Platform.Core.CreatorType creatorType = rootPlace.CreatorType switch
		{
			Roblox.Platform.Assets.CreatorType.Group => Roblox.Platform.Core.CreatorType.Group, 
			Roblox.Platform.Assets.CreatorType.User => Roblox.Platform.Core.CreatorType.User, 
			_ => throw new ArgumentException($"Root place has invalid creator type {rootPlace.CreatorType.ToString()}", "rootPlace"), 
		};
		PrivacyType clientPrivacyType;
		if (privacyType != null)
		{
			if (!Enum.TryParse<PrivacyType>(privacyType, out clientPrivacyType))
			{
				throw new ArgumentException($"The provided privacy type value of {privacyType} is invalid", "privacyType");
			}
		}
		else if (!Enum.TryParse<PrivacyType>(_Settings.DefaultUniversePrivacyType, out clientPrivacyType))
		{
			throw new InvalidOperationException($"The default universe privacy type of {_Settings.DefaultUniversePrivacyType} is not recognized");
		}
		long universeId = _Client.CreateUniverse(rootPlace.Name, rootPlace.Description, (long?)rootPlace.Id, creatorType.ToString(), rootPlace.CreatorTargetId, shopId, (PrivacyType?)clientPrivacyType);
		_UniverseDomainFactories.UniverseChangeReporter.EntityChanged(universeId, UniverseChangeType.Created);
		return universeId;
	}

	[Obsolete("Please use GetCreatorUniverses instead.")]
	public IEnumerable<IUniverse> GetCreatorUniversesPaged(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, int page, out long totalCount)
	{
		PagedResult<long, Universe> universePagedResult = _Client.GetCreatorUniverses(creatorType.ToString(), creatorTargetId, (int?)page, false);
		IEnumerable<IUniverse> result = universePagedResult.PageItems.Select(ConvertClientToPlatformUniverse);
		totalCount = universePagedResult.Count;
		return result;
	}

	[Obsolete("Please use GetCreatorUniverses instead.")]
	public IEnumerable<IUniverse> GetCreatorUniversesPaged(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, int startIndex, int count, out long totalCount)
	{
		int page = startIndex / 50 + 1;
		int skip = startIndex % 50;
		List<IUniverse> results = new List<IUniverse>((Math.Max(0, skip + count - 1) / 50 + 1) * 50);
		results.AddRange(GetCreatorUniversesPaged(creatorType, creatorTargetId, page, out totalCount));
		int lastFetchCount = results.Count;
		while (results.Count < skip + count && lastFetchCount >= 50)
		{
			page++;
			int originalCount = results.Count;
			results.AddRange(GetCreatorUniversesPaged(creatorType, creatorTargetId, page, out var _));
			lastFetchCount = results.Count - originalCount;
		}
		return results.Skip(skip).Take(count);
	}

	public IEnumerable<IUniverse> GetCreatorPublicUniversesPaged(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, int page, out long totalCount)
	{
		PagedResult<long, Universe> universePagedResult = _Client.GetCreatorPublicUniversesPaged(creatorType.ToString(), creatorTargetId, (int?)page, false);
		IEnumerable<IUniverse> result = universePagedResult.PageItems.Select(ConvertClientToPlatformUniverse);
		totalCount = universePagedResult.Count;
		return result;
	}

	public IEnumerable<IUniverse> GetCreatorPublicUniversesPaged(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, int startIndex, int count, out long totalCount)
	{
		int page = startIndex / 50 + 1;
		int skip = startIndex % 50;
		List<IUniverse> results = new List<IUniverse>((Math.Max(0, skip + count - 1) / 50 + 1) * 50);
		results.AddRange(GetCreatorPublicUniversesPaged(creatorType, creatorTargetId, page, out totalCount));
		int lastFetchCount = results.Count;
		while (results.Count < skip + count && lastFetchCount >= 50)
		{
			page++;
			int originalCount = results.Count;
			results.AddRange(GetCreatorPublicUniversesPaged(creatorType, creatorTargetId, page, out var _));
			lastFetchCount = results.Count - originalCount;
		}
		return results.Skip(skip).Take(count);
	}

	public IPlatformPageResponse<long, IUniverse> GetCreatorUniverses(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		Roblox.ApiClientBase.SortOrder sortOrder = (exclusiveStartKeyInfo.GetDatabaseRequestSortOrder().Equals(Roblox.DataV2.Core.SortOrder.Asc) ? Roblox.ApiClientBase.SortOrder.Asc : Roblox.ApiClientBase.SortOrder.Desc);
		return new PlatformPageResponse<long, IUniverse>(_Client.GetCreatorUniverses(creatorType.ToString(), creatorTargetId, exclusiveStartKeyInfo.GetNullableExclusiveStartKey(), exclusiveStartKeyInfo.Count + 1, sortOrder, false).Select(ConvertClientToPlatformUniverse).ToArray(), exclusiveStartKeyInfo, (IUniverse u) => u.Id);
	}

	public IPlatformPageResponse<long, IUniverse> GetCreatorPublicUniverses(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		Roblox.ApiClientBase.SortOrder sortOrder = (exclusiveStartKeyInfo.GetDatabaseRequestSortOrder().Equals(Roblox.DataV2.Core.SortOrder.Asc) ? Roblox.ApiClientBase.SortOrder.Asc : Roblox.ApiClientBase.SortOrder.Desc);
		return new PlatformPageResponse<long, IUniverse>(_Client.GetCreatorPublicUniverses(creatorType.ToString(), creatorTargetId, exclusiveStartKeyInfo.GetNullableExclusiveStartKey(), exclusiveStartKeyInfo.Count + 1, sortOrder, false).Select(ConvertClientToPlatformUniverse).ToArray(), exclusiveStartKeyInfo, (IUniverse u) => u.Id);
	}

	public long? GetUniverseShopId(long universeId)
	{
		return _Client.GetUniverseShop(universeId);
	}

	public IUniverse GetUniverseByShopId(long shopId)
	{
		Universe clientUniverse = _Client.GetUniverseByShopId(shopId);
		return ConvertClientToPlatformUniverse(clientUniverse);
	}

	public IUniverse GetPlaceUniverse(IPlace place)
	{
		place.VerifyIsNotNull();
		return GetPlaceUniverse(place.Id);
	}

	public virtual IUniverse GetPlaceUniverse(long placeId)
	{
		Universe clientUniverse = _Client.GetPlaceUniverse(placeId);
		return ConvertClientToPlatformUniverse(clientUniverse);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniverseFactory.GetUniverseByPlaces(System.Collections.Generic.IReadOnlyCollection{System.Int64})" />
	public IDictionary<long, IUniverse> GetUniverseByPlaces(IReadOnlyCollection<long> placeIds)
	{
		if (placeIds == null)
		{
			throw new ArgumentNullException("placeIds");
		}
		return _Client.MultiGetPlaceUniverses((IEnumerable<long>)placeIds).ToDictionary((KeyValuePair<long, Universe> p) => p.Key, (KeyValuePair<long, Universe> p) => ConvertClientToPlatformUniverse(p.Value));
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniverseFactory.GetUniverseByPlaces(System.Collections.Generic.IReadOnlyCollection{Roblox.Platform.Assets.IPlace})" />
	public IDictionary<IPlace, IUniverse> GetUniverseByPlaces(IReadOnlyCollection<IPlace> places)
	{
		if (places == null)
		{
			throw new ArgumentNullException("places");
		}
		if (places.Any((IPlace p) => p == null))
		{
			throw new ArgumentException(string.Format("{0} contained a null entry.", "places"), "places");
		}
		long[] placeIds = places.Select((IPlace p) => p.Id).ToArray();
		Dictionary<long, IPlace> placeLookup = places.ToDictionary((IPlace p) => p.Id);
		return GetUniverseByPlaces((IReadOnlyCollection<long>)(object)placeIds).ToDictionary((KeyValuePair<long, IUniverse> p) => placeLookup[p.Key], (KeyValuePair<long, IUniverse> p) => p.Value);
	}

	public IUniverse GetUniverse(long universeId)
	{
		Universe clientUniverse = _Client.GetUniverse(universeId);
		return ConvertClientToPlatformUniverse(clientUniverse);
	}

	[Obsolete("Please use GetUniversePlaces, or GetUniverseCreationPlaces instead.")]
	public IEnumerable<long> GetUniversePlaceIdsPaged(long universeId, int page, out long totalCount, bool isUniverseCreation)
	{
		PagedResult<long, long> pagedResult = _Client.GetUniversePlaces(universeId, (int?)page, isUniverseCreation);
		totalCount = pagedResult.Count;
		return pagedResult.PageItems.ToArray();
	}

	[Obsolete("Please use GetUniversePlaces, or GetUniverseCreationPlaces instead.")]
	public IEnumerable<IPlace> GetUniversePlacesPaged(long universeId, int page, out long totalCount, bool isUniverseCreation)
	{
		PagedResult<long, long> pagedResult = _Client.GetUniversePlaces(universeId, (int?)page, isUniverseCreation);
		totalCount = pagedResult.Count;
		return pagedResult.PageItems.ToArray().Select(_UniverseDomainFactories.PlaceFactory.Get).ToArray();
	}

	public IPlatformPageResponse<long, IPlace> GetUniversePlaces(long universeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		return GetUniversePlaceIds(universeId, isUniverseCreation: false, exclusiveStartKeyInfo);
	}

	public IPlatformPageResponse<long, IPlace> GetUniverseCreationPlaces(long universeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		return GetUniversePlaceIds(universeId, isUniverseCreation: true, exclusiveStartKeyInfo);
	}

	public void SetUniverseCreator(long universeId, string creatorType, long creatorTargetId)
	{
		_Client.SetUniverseCreator(universeId, creatorType, creatorTargetId);
		_UniverseDomainFactories.UniverseChangeReporter.EntityChanged(universeId, UniverseChangeType.CreatorChanged);
	}

	public int GetCreatorPublicUniverseCount(string creatorType, long creatorTargetId)
	{
		return _Client.GetCreatorPublicUniverseCount(creatorType, creatorTargetId);
	}

	private IUniverse ConvertClientToPlatformUniverse(Universe clientUniverse)
	{
		if (clientUniverse == null)
		{
			return null;
		}
		return new Universe(clientUniverse, _UniverseDomainFactories);
	}

	private PlatformPageResponse<long, IPlace> GetUniversePlaceIds(long universeId, bool isUniverseCreation, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		Roblox.ApiClientBase.SortOrder sortOrder = (exclusiveStartKeyInfo.GetDatabaseRequestSortOrder().Equals(Roblox.DataV2.Core.SortOrder.Asc) ? Roblox.ApiClientBase.SortOrder.Asc : Roblox.ApiClientBase.SortOrder.Desc);
		long exclusiveStartId = exclusiveStartKeyInfo.GetDefaultExclusiveStartId();
		return new PlatformPageResponse<long, IPlace>(_Client.GetUniversePlaceIds(universeId, isUniverseCreation, exclusiveStartId, exclusiveStartKeyInfo.Count + 1, sortOrder).Select(_UniverseDomainFactories.PlaceFactory.Get).ToArray(), exclusiveStartKeyInfo, (IPlace place) => place.Id);
	}
}
