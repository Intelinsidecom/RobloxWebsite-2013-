using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.CachingV2.Core;

public static class NullChecker
{
	public static void ThrowIfNull<T>(T obj, string name) where T : class
	{
		if (obj == null)
		{
			throw new ArgumentNullException(name);
		}
	}

	public static void ThrowIfNullObj(object obj, string name)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(name);
		}
	}

	public static void ThrowIfNullOrContainsNull<T>(IReadOnlyCollection<T> objects, string name)
	{
		if (objects == null)
		{
			throw new ArgumentNullException(name);
		}
		if (objects.Any((T obj) => obj == null))
		{
			throw new ArgumentNullException(name);
		}
	}
}
