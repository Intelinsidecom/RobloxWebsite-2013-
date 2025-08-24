using System;

namespace Roblox.Diagnostics;

internal class CountersAlreadyCreatedException : Exception
{
	public CountersAlreadyCreatedException(string message)
		: base(message)
	{
	}
}
