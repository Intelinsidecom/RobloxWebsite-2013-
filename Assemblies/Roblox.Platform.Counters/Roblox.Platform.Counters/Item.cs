using System.Collections.Generic;

namespace Roblox.Platform.Counters;

/// <summary>
/// The item being used for impression counters.
/// </summary>
public class Item : IEqualityComparer<Item>
{
	public long TargetId;

	public ItemType Type;

	public Item(long targetId, ItemType type)
	{
		TargetId = targetId;
		Type = type;
	}

	public bool Equals(Item x, Item y)
	{
		if (x == null || y == null)
		{
			return false;
		}
		if (x.TargetId == y.TargetId)
		{
			return x.Type == y.Type;
		}
		return false;
	}

	private int Elegant(long x, int y)
	{
		if (x >= y)
		{
			return (int)x * (int)x + (int)x + y;
		}
		return y * y + (int)x;
	}

	int IEqualityComparer<Item>.GetHashCode(Item obj)
	{
		long x = obj.TargetId;
		int y = (int)obj.Type;
		if (x < 0)
		{
			if (y < 0)
			{
				return 3 + 4 * Elegant(-x - 1, -y - 1);
			}
			return 2 + 4 * Elegant(-x - 1, y);
		}
		if (y < 0)
		{
			return 1 + 4 * Elegant(x, -y - 1);
		}
		return 4 * Elegant(x, y);
	}
}
