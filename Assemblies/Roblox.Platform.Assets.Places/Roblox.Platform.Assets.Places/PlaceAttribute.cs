using System;
using Roblox.Data;
using Roblox.Platform.Assets.Places.Entities;

namespace Roblox.Platform.Assets.Places;

internal class PlaceAttribute : IPlaceAttribute
{
	internal readonly PlaceAttributesDomainFactories _DomainFactories;

	internal long Id { get; }

	public long PlaceId { get; }

	public bool UsePlaceMediaForThumb { get; private set; }

	public bool OverridesDefaultAvatar { get; private set; }

	public bool UsePortraitMode { get; private set; }

	public bool IsFilteringEnabled { get; private set; }

	public PlaceAttribute(IPlaceAttributeEntity entity, PlaceAttributesDomainFactories domainFactories)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		Id = entity.Id;
		PlaceId = entity.PlaceId;
		UsePlaceMediaForThumb = entity.UsePlaceMediaForThumb ?? false;
		OverridesDefaultAvatar = entity.OverridesDefaultAvatar ?? false;
		UsePortraitMode = entity.UsePortraitMode ?? false;
		IsFilteringEnabled = entity.IsFilteringEnabled ?? false;
	}

	public void SetUsePlaceMediaForThumb(bool usePlaceMediaForThumb)
	{
		IPlaceAttributeEntity entity = _DomainFactories.AttributeEntityFactory.Get(Id);
		if (entity == null)
		{
			throw new DataIntegrityException("Unable to get entity to update");
		}
		if (entity.UsePlaceMediaForThumb != usePlaceMediaForThumb)
		{
			entity.UsePlaceMediaForThumb = usePlaceMediaForThumb;
			entity.Update();
			UsePlaceMediaForThumb = usePlaceMediaForThumb;
		}
	}

	public void SetOverridesDefaultAvatar(bool overridesDefaultAvatar)
	{
		IPlaceAttributeEntity entity = _DomainFactories.AttributeEntityFactory.Get(Id);
		if (entity == null)
		{
			throw new DataIntegrityException("Unable to get entity to update");
		}
		if (entity.OverridesDefaultAvatar != overridesDefaultAvatar)
		{
			entity.OverridesDefaultAvatar = overridesDefaultAvatar;
			entity.Update();
			OverridesDefaultAvatar = overridesDefaultAvatar;
		}
	}

	public void SetUsePortraitMode(bool usePortraitMode)
	{
		IPlaceAttributeEntity entity = _DomainFactories.AttributeEntityFactory.Get(Id);
		if (entity == null)
		{
			throw new DataIntegrityException("Unable to get entity to update");
		}
		if (entity.UsePortraitMode != usePortraitMode)
		{
			entity.UsePortraitMode = usePortraitMode;
			entity.Update();
			UsePortraitMode = usePortraitMode;
		}
	}
}
