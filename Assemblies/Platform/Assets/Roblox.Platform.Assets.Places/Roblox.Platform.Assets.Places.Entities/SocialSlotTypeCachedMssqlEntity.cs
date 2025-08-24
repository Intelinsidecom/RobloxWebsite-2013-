using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class SocialSlotTypeCachedMssqlEntity : ISocialSlotTypeEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		SocialSlotType cal = SocialSlotType.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Value = Value;
		cal.Save();
		Updated = cal.UpdatedUtc;
	}

	public void Delete()
	{
		(SocialSlotType.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
