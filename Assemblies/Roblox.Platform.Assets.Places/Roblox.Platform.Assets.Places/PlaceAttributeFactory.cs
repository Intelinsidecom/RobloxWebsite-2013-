using System;
using Roblox.Platform.Assets.Places.Entities;

namespace Roblox.Platform.Assets.Places;

internal class PlaceAttributeFactory : IPlaceAttributeFactory
{
	internal readonly PlaceAttributesDomainFactories _DomainFactories;

	public PlaceAttributeFactory(PlaceAttributesDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
	}

	public IPlaceAttribute GetByPlaceId(long placeId)
	{
		IPlaceAttributeEntity entity = _DomainFactories.AttributeEntityFactory.GetByPlaceId(placeId);
		return Get(entity);
	}

	public IPlaceAttribute GetByPlace(IPlace place)
	{
		if (place == null)
		{
			return null;
		}
		return GetByPlaceId(place.Id);
	}

	public IPlaceAttribute GetOrCreate(long placeId)
	{
		IPlaceAttributeEntity entity = _DomainFactories.AttributeEntityFactory.GetOrCreate(placeId);
		return Get(entity);
	}

	public IPlaceAttribute GetOrCreate(IPlace place)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		IPlaceAttributeEntity entity = _DomainFactories.AttributeEntityFactory.GetOrCreate(place.Id);
		return Get(entity);
	}

	private IPlaceAttribute Get(IPlaceAttributeEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new PlaceAttribute(entity, _DomainFactories);
	}
}
