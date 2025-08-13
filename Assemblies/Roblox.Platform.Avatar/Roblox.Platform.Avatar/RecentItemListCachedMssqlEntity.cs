using System;
using Roblox.Entities;

namespace Roblox.Platform.Avatar;

internal class RecentItemListCachedMssqlEntity : IRecentItemListEntity, IEntity<long>
{
	public long Id { get; set; }

	public byte RecentItemListTypeId { get; set; }

	public long UserId { get; set; }

	public byte[] RecentItemTypeIds { get; set; }

	public long[] TargetIds { get; set; }

	public DateTime[] Dates { get; set; }

	public int Revision { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public bool Save()
	{
		RecentItemList cal = RecentItemList.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.RecentItemListTypeID = RecentItemListTypeId;
		cal.UserID = UserId;
		cal.Revision = Revision;
		bool updatedEntity;
		lock (cal.ReadWriteLock)
		{
			cal.RecentItemTypeIDs = RecentItemTypeIds;
			cal.TargetIDs = TargetIds;
			cal.Dates = Dates;
			updatedEntity = cal.Save();
			RecentItemTypeIds = cal.RecentItemTypeIDs.Clone() as byte[];
			TargetIds = cal.TargetIDs.Clone() as long[];
			Dates = cal.Dates.Clone() as DateTime[];
		}
		RecentItemListTypeId = cal.RecentItemListTypeID;
		UserId = cal.UserID;
		Revision = cal.Revision;
		Updated = cal.Updated;
		return updatedEntity;
	}

	public void Delete()
	{
		(RecentItemList.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
