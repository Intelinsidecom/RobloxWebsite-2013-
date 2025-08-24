using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Presence;

namespace Roblox.Platform.Social.Comparers;

public class UserPresenceTypeComparer : IComparer<IPresence>
{
	private static readonly SortedDictionary<PresenceType, int> _SortingOrder = new SortedDictionary<PresenceType, int>
	{
		{
			PresenceType.InGame,
			1
		},
		{
			PresenceType.Online,
			2
		},
		{
			PresenceType.InStudio,
			3
		},
		{
			PresenceType.Offline,
			4
		}
	};

	internal static readonly PresenceType[] PresenceOrder = (from presence in _SortingOrder
		orderby presence.Value
		select presence into pair
		select pair.Key).ToArray();

	/// <summary>
	/// Return a list of PresenceType enums handled by the comparer for sorting list of User Presences
	/// </summary>
	/// <returns> list of presenceType <see cref="T:Roblox.Platform.Presence.PresenceType" /></returns>
	public IReadOnlyCollection<PresenceType> GetSortingOrderKeysCollection()
	{
		return _SortingOrder.Keys.ToList();
	}

	/// <inheritdoc />
	public int Compare(IPresence x, IPresence y)
	{
		int xWeight = int.MaxValue;
		if (x != null)
		{
			_SortingOrder.TryGetValue(x.PresenceType, out xWeight);
		}
		int yWeight = int.MaxValue;
		if (y != null)
		{
			_SortingOrder.TryGetValue(y.PresenceType, out yWeight);
		}
		int result = xWeight.CompareTo(yWeight);
		if (result != 0)
		{
			return result;
		}
		DateTime xLastOnline = x?.LastOnline ?? DateTime.MinValue;
		return (y?.LastOnline ?? DateTime.MinValue).CompareTo(xLastOnline);
	}
}
