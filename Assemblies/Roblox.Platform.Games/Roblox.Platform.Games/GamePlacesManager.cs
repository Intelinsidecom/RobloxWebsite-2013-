using System;
using System.Linq;
using Roblox.Platform.Assets;
using Roblox.Platform.Assets.Places;
using Roblox.Platform.Assets.Places.Entities;
using Roblox.Platform.Games.Events;
using Roblox.Platform.Games.Properties;
using Roblox.Platform.Universes;
using Roblox.Universes.Client;

namespace Roblox.Platform.Games;

internal class GamePlacesManager : IGamePlacesManager
{
	private readonly GamesDomainFactories _DomainFactories;

	private readonly IUniversesClient _UniversesClient;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IPlaceAttributeEntityFactory _PlaceAttributeEntityFactory;

	internal virtual bool IsPlaceAttributesReadyToEvaluateIsSecure => Settings.Default.IsPlaceAttributesReadyToEvaluateIsSecure;

	internal virtual bool IsBruteForceIsSecureCheckEnabled => Settings.Default.IsBruteForceIsSecureCheckEnabled;

	public GamePlacesManager(GamesDomainFactories domainFactories, IUniversesClient client, IUniverseFactory universeFactory, PlaceAttributesDomainFactories placeAttributesDomainFactories)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_UniversesClient = client ?? throw new ArgumentNullException("client");
		_UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
		_PlaceAttributeEntityFactory = placeAttributesDomainFactories?.AttributeEntityFactory ?? throw new ArgumentNullException("placeAttributesDomainFactories");
	}

	public void AddPlaceToUniverse(IPlace place, IUniverse universe, bool isCreatedByUniverse)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		if (IsBruteForceIsSecureCheckEnabled)
		{
			AddPlaceToUniverseWithBruteForceIsSecureCheck(place, universe, isCreatedByUniverse);
		}
		else
		{
			AddPlaceToUniverseWithSmartIsSecureCheck(place, universe, isCreatedByUniverse);
		}
	}

	public void RemovePlaceFromUniverse(IPlace place, IUniverse universe)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		IPlaceAttributeEntity placeAttributesEntity = _PlaceAttributeEntityFactory.GetOrCreate(place.Id);
		long? oldUniverseId = placeAttributesEntity.UniverseId;
		bool needToResyncOldUniverseIsSecure = !(placeAttributesEntity.IsFilteringEnabled ?? false);
		try
		{
			_UniversesClient.RemovePlaceUniverse(place.Id, universe.Id);
			placeAttributesEntity.UniverseId = null;
			placeAttributesEntity.Update();
			_DomainFactories.GamePlacesChangeReporter.EntityChanged(universe.Id, GamePlacesChangeType.PlaceRemoved, place.Id);
		}
		catch (Exception e)
		{
			_DomainFactories.Logger.Error(e);
			_SyncPlaceAttributeUniverseId(place);
			throw;
		}
		finally
		{
			if (needToResyncOldUniverseIsSecure || IsBruteForceIsSecureCheckEnabled)
			{
				SyncGameSecureness(oldUniverseId);
			}
		}
	}

	public void SetPlaceIsFilteringEnabled(IPlace place, bool isFilteringEnabled)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		IUniverse universe = _UniverseFactory.GetPlaceUniverse(place);
		IPlaceAttributeEntity placeAttributesEntity = _PlaceAttributeEntityFactory.GetOrCreate(place.Id);
		long? oldUniverseId = placeAttributesEntity.UniverseId;
		if (placeAttributesEntity.IsFilteringEnabled == isFilteringEnabled)
		{
			return;
		}
		bool wasFilteringEnabled = placeAttributesEntity.IsFilteringEnabled ?? false;
		try
		{
			placeAttributesEntity.UniverseId = universe?.Id;
			placeAttributesEntity.IsFilteringEnabled = isFilteringEnabled;
			placeAttributesEntity.Update();
			if (universe != null)
			{
				IGameAttributes gameAttributes = _DomainFactories.GameAttributesFactory.GetOrCreateGameAttributes(universe);
				if (!isFilteringEnabled)
				{
					gameAttributes.SetIsSecure(isSecure: false);
				}
				else if (!gameAttributes.IsSecure)
				{
					SyncGameSecureness(universe);
				}
			}
		}
		catch (Exception e)
		{
			_DomainFactories.Logger.Error(e);
			if (universe != null && !isFilteringEnabled)
			{
				SyncGameSecureness(universe);
			}
		}
		finally
		{
			if (oldUniverseId != universe?.Id && !wasFilteringEnabled)
			{
				SyncGameSecureness(oldUniverseId);
			}
		}
	}

	public bool IsAnyPlaceInUniverseNotFilteringEnabled(IUniverse universe)
	{
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		if (_PlaceAttributeEntityFactory.GetByUniverseIdAndIsFilteringEnabledEnumerative(universe.Id, false, 1, 0L).Any())
		{
			return true;
		}
		if (_PlaceAttributeEntityFactory.GetByUniverseIdAndIsFilteringEnabledEnumerative(universe.Id, null, 1, 0L).Any())
		{
			return true;
		}
		return false;
	}

	internal virtual void SyncGameSecureness(long? universeId)
	{
		if (universeId.HasValue)
		{
			IUniverse universe = _UniverseFactory.GetUniverse(universeId.Value);
			SyncGameSecureness(universe);
		}
	}

	internal virtual void SyncGameSecureness(IUniverse universe)
	{
		if (universe == null)
		{
			return;
		}
		IGameAttributes gameAttributes = _DomainFactories.GameAttributesFactory.GetOrCreateGameAttributes(universe);
		if (IsPlaceAttributesReadyToEvaluateIsSecure)
		{
			if (IsAnyPlaceInUniverseNotFilteringEnabled(universe))
			{
				gameAttributes.SetIsSecure(isSecure: false);
			}
			else
			{
				gameAttributes.SetIsSecure(isSecure: true);
			}
		}
	}

	internal void AddPlaceToUniverseWithSmartIsSecureCheck(IPlace place, IUniverse universe, bool isCreatedByUniverse)
	{
		IPlaceAttributeEntity placeAttributeEntity = _PlaceAttributeEntityFactory.GetOrCreate(place.Id);
		if (placeAttributeEntity?.IsFilteringEnabled ?? false)
		{
			DoAddPlaceToUniverse(place, universe, isCreatedByUniverse, placeAttributeEntity);
			return;
		}
		IGameAttributes gameAttributes = _DomainFactories.GameAttributesFactory.GetOrCreateGameAttributes(universe);
		if (gameAttributes == null || !gameAttributes.IsSecure)
		{
			DoAddPlaceToUniverse(place, universe, isCreatedByUniverse, placeAttributeEntity);
			return;
		}
		try
		{
			DoAddPlaceToUniverse(place, universe, isCreatedByUniverse, placeAttributeEntity);
			gameAttributes.SetIsSecure(isSecure: false);
		}
		catch (Exception e)
		{
			_DomainFactories.Logger.Error(e);
			SyncGameSecureness(universe);
			throw;
		}
	}

	internal void AddPlaceToUniverseWithBruteForceIsSecureCheck(IPlace place, IUniverse universe, bool isCreatedByUniverse)
	{
		IPlaceAttributeEntity placeAttributeEntity = _PlaceAttributeEntityFactory.GetOrCreate(place.Id);
		try
		{
			DoAddPlaceToUniverse(place, universe, isCreatedByUniverse, placeAttributeEntity);
		}
		catch (Exception e)
		{
			_DomainFactories.Logger.Error(e);
			throw;
		}
		finally
		{
			SyncGameSecureness(universe);
		}
	}

	/// <summary>
	/// Workhorse bookkeeping method for adding an <see cref="T:Roblox.Platform.Assets.IPlace" />(<paramref name="place" />) to a game (<paramref name="universe" />).
	/// </summary>
	/// <remarks>
	/// This method does the following work:
	///   1) Sets <paramref name="place" />'s universe to be <paramref name="universe" /> via the Universes Service.
	///   2) Updates the <see cref="T:Roblox.Platform.Assets.Places.Entities.IPlaceAttributeEntity" /> information about <paramref name="place" /> to reflect its new <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	///   3) Reports a change to <paramref name="place" /> via an <see cref="T:Roblox.Platform.Games.Events.GamePlacesChangeReporter" />.
	///   4) Syncs the secureness of <paramref name="place" />'s previous <see cref="T:Roblox.Platform.Universes.IUniverse" /> (if necessary).
	/// </remarks>
	/// <param name="place">The <see cref="T:Roblox.Platform.Assets.IPlace" /> to add to <paramref name="universe" />.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" /> to add <paramref name="place" /> to.</param>
	/// <param name="isCreatedByUniverse"><c>true</c> if <paramref name="place" /> was created by <paramref name="universe" />, <c>false</c> otherwise.</param>
	/// <param name="placeAttributeEntity">An <see cref="T:Roblox.Platform.Assets.Places.Entities.IPlaceAttributeEntity" /> containing current attribute information about <paramref name="place" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universe" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="placeAttributeEntity" /></exception>
	/// <exception cref="T:System.ArgumentException">If <paramref name="place" /> is already part of an <see cref="T:Roblox.Platform.Universes.IUniverse" /> other than <paramref name="universe" />.</exception>
	internal virtual void DoAddPlaceToUniverse(IPlace place, IUniverse universe, bool isCreatedByUniverse, IPlaceAttributeEntity placeAttributeEntity)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		if (placeAttributeEntity == null)
		{
			throw new ArgumentNullException("placeAttributeEntity");
		}
		bool needToSyncGameSecureness = ((!placeAttributeEntity.IsFilteringEnabled) ?? true) || IsBruteForceIsSecureCheckEnabled;
		IUniverse oldUniverse = (needToSyncGameSecureness ? _UniverseFactory.GetPlaceUniverse(place) : null);
		try
		{
			_UniversesClient.SetPlaceUniverse(place.Id, universe.Id, isCreatedByUniverse);
			placeAttributeEntity.UniverseId = universe.Id;
			placeAttributeEntity.Update();
			_DomainFactories.GamePlacesChangeReporter.EntityChanged(universe.Id, GamePlacesChangeType.PlaceAdded, place.Id);
		}
		catch (Exception e)
		{
			_DomainFactories.Logger.Error(e);
			_SyncPlaceAttributeUniverseId(place);
			throw;
		}
		finally
		{
			if (needToSyncGameSecureness && oldUniverse != null && oldUniverse.Id != universe.Id)
			{
				SyncGameSecureness(oldUniverse);
			}
		}
	}

	private void _SyncPlaceAttributeUniverseId(IPlace place)
	{
		IUniverse universe = _UniverseFactory.GetPlaceUniverse(place);
		IPlaceAttributeEntity placeAttributesEntity = _PlaceAttributeEntityFactory.GetOrCreate(place.Id);
		if (placeAttributesEntity.UniverseId != universe?.Id)
		{
			long? oldUniverseId = placeAttributesEntity.UniverseId;
			placeAttributesEntity.UniverseId = universe?.Id;
			placeAttributesEntity.Update();
			SyncGameSecureness(oldUniverseId);
		}
	}
}
