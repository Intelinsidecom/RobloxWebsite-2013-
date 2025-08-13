using System;

namespace Roblox.Caching;

internal class MigrationStateChangeParseException : Exception
{
	public MigrationStateChangeParseException(string message)
		: base(message)
	{
	}
}
