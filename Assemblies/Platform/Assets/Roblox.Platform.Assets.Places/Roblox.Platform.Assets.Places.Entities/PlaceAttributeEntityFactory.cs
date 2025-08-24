using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Assets.Places;
using Roblox.Platform.Assets.Places.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class PlaceAttributeEntityFactory : IPlaceAttributeEntityFactory, IDomainFactory<PlaceAttributesDomainFactories>, IDomainObject<PlaceAttributesDomainFactories>
{
	/// <summary>
	/// We used to have a second value for this, but that feature got deleted. Now there is literally only one value for PlaceType
	/// in our code and DB, so we may as well hardcode this default until a new feature that uses this is developed.
	/// </summary>
	private byte? _DefaultPlaceTypeId;

	internal virtual bool IsUsingLegacyBLL => Settings.Default.IsEntityImplementationUsingLegacyBLL;

	internal virtual byte DefaultPlaceTypeId
	{
		get
		{
			if (!_DefaultPlaceTypeId.HasValue)
			{
				_DefaultPlaceTypeId = PlaceTypes.PublicServer.ID;
			}
			return _DefaultPlaceTypeId.Value;
		}
	}

	public PlaceAttributesDomainFactories DomainFactories { get; }

	public IPlaceAttributeEntity GetOrCreate(long placeId)
	{
		if (IsUsingLegacyBLL)
		{
			return CalToCachedMssql(Roblox.Assets.Places.PlaceAttribute.GetOrCreate(placeId, DefaultPlaceTypeId));
		}
		return CalToCachedMssql(PlaceAttributeCAL.GetByPlaceIdOrCreateByPlaceIdAndPlaceTypeId(placeId, DefaultPlaceTypeId));
	}

	public IEnumerable<IPlaceAttributeEntity> GetByUniverseIdAndIsFilteringEnabledEnumerative(long? universeId, bool? isFilteringEnabled, int count, long exclusiveStartId = 0L)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		if (IsUsingLegacyBLL)
		{
			return Roblox.Assets.Places.PlaceAttribute.GetPlaceAttributesByUniverseIDAndIsFilteringEnabled(universeId, isFilteringEnabled, count, exclusiveStartId).Select(CalToCachedMssql);
		}
		return PlaceAttributeCAL.GetPlaceAttributesByUniverseIDAndIsFilteringEnabled(universeId, isFilteringEnabled, count, exclusiveStartId).Select(CalToCachedMssql);
	}

	public IPlaceAttributeEntity Get(long id)
	{
		if (IsUsingLegacyBLL)
		{
			return CalToCachedMssql(Roblox.Assets.Places.PlaceAttribute.Get(id));
		}
		return CalToCachedMssql(PlaceAttributeCAL.Get(id));
	}

	public IPlaceAttributeEntity GetByPlaceId(long placeId)
	{
		if (IsUsingLegacyBLL)
		{
			return CalToCachedMssql(Roblox.Assets.Places.PlaceAttribute.GetByPlaceID(placeId));
		}
		return CalToCachedMssql(PlaceAttributeCAL.GetByPlaceID(placeId));
	}

	private static IPlaceAttributeEntity CalToCachedMssql(Roblox.Assets.Places.PlaceAttribute cal)
	{
		if (cal != null)
		{
			return new PlaceAttributeBLLCachedMssqlEntity
			{
				Id = cal.ID,
				PlaceId = cal.PlaceID,
				Created = cal.Created,
				Updated = cal.Updated,
				UsePlaceMediaForThumb = cal.UsePlaceMediaForThumb,
				OverridesDefaultAvatar = cal.OverridesDefaultAvatar,
				UsePortraitMode = cal.UsePortraitMode,
				UniverseId = cal.UniverseID,
				IsFilteringEnabled = cal.IsFilteringEnabled
			};
		}
		return null;
	}

	public PlaceAttributeEntityFactory(PlaceAttributesDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	private static IPlaceAttributeEntity CalToCachedMssql(PlaceAttributeCAL cal)
	{
		if (cal != null)
		{
			return new PlaceAttributeCachedMssqlEntity
			{
				Id = cal.ID,
				PlaceId = cal.PlaceID,
				Created = cal.Created,
				Updated = cal.Updated,
				UsePlaceMediaForThumb = cal.UsePlaceMediaForThumb,
				OverridesDefaultAvatar = cal.OverridesDefaultAvatar,
				UsePortraitMode = cal.UsePortraitMode,
				UniverseId = cal.UniverseID,
				IsFilteringEnabled = cal.IsFilteringEnabled
			};
		}
		return null;
	}
}
