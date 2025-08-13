using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Exposed to public methods and consumers
/// </summary>
public class RecentAvatarItem : IEquatable<RecentAvatarItem>
{
	public readonly long TargetId;

	public readonly RecentItemTypeEnum Type;

	public readonly DateTime Date;

	internal RecentAvatarItem(long targetId, RecentItemTypeEnum type, DateTime date)
	{
		TargetId = targetId;
		Type = type;
		Date = date;
	}

	public bool Equals(RecentAvatarItem other)
	{
		if (other == null)
		{
			throw new PlatformArgumentNullException(string.Format("Cannot compare {0} to null", "RecentAvatarItem"));
		}
		if (TargetId == other.TargetId)
		{
			return Type == other.Type;
		}
		return false;
	}

	public string GetUniqueCode()
	{
		return $"{TargetId}_{Type}";
	}

	public override int GetHashCode()
	{
		throw new NotImplementedException(string.Format("Attempt to call {0} for {1}, this is not implemented", "GetHashCode", "RecentAvatarItem"));
	}
}
