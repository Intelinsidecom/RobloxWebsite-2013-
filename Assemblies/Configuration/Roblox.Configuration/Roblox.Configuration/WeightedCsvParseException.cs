using System;

namespace Roblox.Configuration;

public class WeightedCsvParseException : Exception
{
	public WeightedCsvParseException(string message)
		: base(message)
	{
	}
}
