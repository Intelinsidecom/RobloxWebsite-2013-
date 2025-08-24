using System;

namespace Roblox.Diagnostics;

internal class NoCountersSpecifiedForCategoryException : Exception
{
	public NoCountersSpecifiedForCategoryException(string categoryName)
		: base(categoryName)
	{
	}
}
