using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class PlaceAttributeCachedMssqlEntity : IPlaceAttributeEntity, IUpdateableEntity<long>, IEntity<long>
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
		PlaceAttributeCAL cal = PlaceAttributeCAL.Get(Id);
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
		(PlaceAttributeCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
