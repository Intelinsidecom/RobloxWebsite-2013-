using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemListCachedMssqlEntity : IGrantedItemListEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public string Name { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		GrantedItemListEntity cal = GrantedItemListEntity.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Name = Name;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(GrantedItemListEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
