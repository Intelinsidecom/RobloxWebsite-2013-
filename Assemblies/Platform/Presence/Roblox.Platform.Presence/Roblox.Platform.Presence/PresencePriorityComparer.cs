using System.Collections.Generic;

namespace Roblox.Platform.Presence;

internal class PresencePriorityComparer : IComparer<IPresence>
{
	private static readonly Dictionary<LocationType, int> _PresencePriority = new Dictionary<LocationType, int>
	{
		{
			LocationType.Game,
			1
		},
		{
			LocationType.CloudEdit,
			2
		},
		{
			LocationType.Studio,
			3
		}
	};

	public int Compare(IPresence a, IPresence b)
	{
		if (a == null && b == null)
		{
			return 0;
		}
		if (b == null || (a != null && a.IsOnline && !b.IsOnline))
		{
			return -1;
		}
		if (a == null || (!a.IsOnline && b.IsOnline))
		{
			return 1;
		}
		int aPriority = ((a.LocationType.HasValue && _PresencePriority.ContainsKey(a.LocationType.Value)) ? _PresencePriority[a.LocationType.Value] : int.MaxValue);
		int bPriority = ((b.LocationType.HasValue && _PresencePriority.ContainsKey(b.LocationType.Value)) ? _PresencePriority[b.LocationType.Value] : int.MaxValue);
		if (aPriority < bPriority)
		{
			return -1;
		}
		if (aPriority > bPriority)
		{
			return 1;
		}
		return 0;
	}
}
