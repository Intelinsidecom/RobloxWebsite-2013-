using System;
using Roblox.Entities;

namespace Roblox.Platform.Avatar;

internal interface IRecentItemListEntity : IEntity<long>
{
	byte RecentItemListTypeId { get; set; }

	long UserId { get; set; }

	byte[] RecentItemTypeIds { get; set; }

	long[] TargetIds { get; set; }

	DateTime[] Dates { get; set; }

	int Revision { get; set; }

	bool Save();
}
