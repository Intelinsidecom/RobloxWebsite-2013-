using System;

namespace Roblox.Instrumentation.LegacySupport;

internal class NoCountersSpecifiedForCategoryException : Exception
{
	public NoCountersSpecifiedForCategoryException(string categoryName)
		: base(categoryName)
	{
	}
}
