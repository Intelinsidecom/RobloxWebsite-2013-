using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.AssetOwnership;

public static class Helpers
{
	public static void CheckExclusiveStartKeyValidity(IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo, IReadOnlyCollection<int> allowedPageSizes)
	{
		ThrowIfNull(exclusiveStartKeyInfo, "exclusiveStartKeyInfo");
		if (!allowedPageSizes.Contains(exclusiveStartKeyInfo.Count))
		{
			throw new PlatformArgumentException(string.Format("{0} has invalid count! Must be in {1}", "exclusiveStartKeyInfo", "allowedPageSizes"));
		}
	}

	public static void ThrowIfDefault<T>(T val, string name)
	{
		if (val.Equals(default(T)))
		{
			throw new PlatformArgumentException($"Required value not specified:{name}");
		}
	}

	public static void ThrowIfNull<T>(T val, string name)
	{
		if (val.Equals(default(T)))
		{
			throw new PlatformArgumentNullException($"Required value was null or default:{name}");
		}
	}
}
