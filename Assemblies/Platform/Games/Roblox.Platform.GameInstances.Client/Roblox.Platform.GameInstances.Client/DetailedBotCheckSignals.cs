using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.GameInstances.Interfaces;

namespace Roblox.GameInstances.Client;

public class DetailedBotCheckSignals : Dictionary<DetailedBotCheckSignalKey, DetailedBotCheckSignalValue>, IDetailedBotCheckSignals
{
	public DetailedBotCheckSignals()
	{
	}

	public DetailedBotCheckSignals(Dictionary<DetailedBotCheckSignalKey, DetailedBotCheckSignalValue> input)
		: base((IDictionary<DetailedBotCheckSignalKey, DetailedBotCheckSignalValue>)input)
	{
	}

	public DetailedBotCheckSignals(Dictionary<string, string> input)
		: base((IDictionary<DetailedBotCheckSignalKey, DetailedBotCheckSignalValue>)input.ToDictionary((KeyValuePair<string, string> entry) => Enum.TryParse<DetailedBotCheckSignalKey>(entry.Key, out var result2) ? result2 : DetailedBotCheckSignalKey.Unrecognized, (KeyValuePair<string, string> entry) => Enum.TryParse<DetailedBotCheckSignalValue>(entry.Value, out var result) ? result : DetailedBotCheckSignalValue.Unrecognized))
	{
	}

	public static implicit operator DetailedBotCheckSignals(Dictionary<string, string> input)
	{
		return new DetailedBotCheckSignals(input);
	}

	public static explicit operator Dictionary<int, int>(DetailedBotCheckSignals input)
	{
		return input.ToDictionary((KeyValuePair<DetailedBotCheckSignalKey, DetailedBotCheckSignalValue> entry) => (int)entry.Key, (KeyValuePair<DetailedBotCheckSignalKey, DetailedBotCheckSignalValue> entry) => (int)entry.Value);
	}
}
