using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal class RecentItem : IEquatable<RecentItem>
{
	public readonly long TargetId;

	public readonly byte TypeId;

	public readonly DateTime Date;

	internal RecentItem(long targetId, IRecentItemTypeEntity type, DateTime date)
	{
		TargetId = targetId;
		TypeId = type.Id;
		Date = date;
	}

	public bool Equals(RecentItem other)
	{
		if (other == null)
		{
			throw new PlatformArgumentNullException(string.Format("Cannot compare {0} to null", "RecentItem"));
		}
		if (TargetId == other.TargetId)
		{
			return TypeId == other.TypeId;
		}
		return false;
	}

	public string GetUniqueCode()
	{
		return $"{TargetId}_{TypeId}";
	}

	public override int GetHashCode()
	{
		throw new NotImplementedException(string.Format("Attempt to call {0} for {1}, this is not implemented", "GetHashCode", "RecentItem"));
	}
}
