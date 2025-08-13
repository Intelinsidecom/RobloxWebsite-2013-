using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Assets.Places;
using Roblox.Entities;

namespace Roblox.Platform.Assets.Places.Entities;

/// <summary>
/// This class implements the <see cref="T:Roblox.Platform.Assets.Places.Entities.IPlaceAttributeEntity" /> using the old BLL class as the Cache Access Layer
/// </summary>
[ExcludeFromCodeCoverage]
internal class PlaceAttributeBLLCachedMssqlEntity : IPlaceAttributeEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long PlaceId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public bool? UsePlaceMediaForThumb { get; set; }

	public bool? OverridesDefaultAvatar { get; set; }

	public bool? UsePortraitMode { get; set; }

	public long? UniverseId { get; set; }

	public bool? IsFilteringEnabled { get; set; }

	public void Update()
	{
		Roblox.Assets.Places.PlaceAttribute cal = Roblox.Assets.Places.PlaceAttribute.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.PlaceID = PlaceId;
		cal.UsePlaceMediaForThumb = UsePlaceMediaForThumb;
		cal.OverridesDefaultAvatar = OverridesDefaultAvatar;
		cal.UsePortraitMode = UsePortraitMode;
		cal.UniverseID = UniverseId;
		cal.IsFilteringEnabled = IsFilteringEnabled;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(Roblox.Assets.Places.PlaceAttribute.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
