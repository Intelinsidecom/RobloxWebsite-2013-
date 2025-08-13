using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemCachedMssqlEntity : IGrantedItemEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long GrantedItemListId { get; set; }

	public long GrantedItemTargetId { get; set; }

	public byte GrantedItemTypeId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		GrantedItemEntity cal = GrantedItemEntity.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.GrantedItemListID = GrantedItemListId;
		cal.GrantedItemTargetID = GrantedItemTargetId;
		cal.GrantedItemTypeID = GrantedItemTypeId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(GrantedItemEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
