using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Instrumentation.Infrastructure;

public class InfluxOutputSharder
{
	private readonly string[] _InfluxEndpoints;

	public InfluxOutputSharder(IEnumerable<string> influxEndpoints)
	{
		_InfluxEndpoints = influxEndpoints.OrderBy((string s) => s).ToArray();
	}

	public string GetInfluxUrl(string partitionKey)
	{
		int num = Math.Abs(GetStableHashCode(partitionKey) % _InfluxEndpoints.Length);
		return _InfluxEndpoints[num];
	}

	public IReadOnlyCollection<string> GetAllInfluxUrls()
	{
		return (IReadOnlyCollection<string>)(object)_InfluxEndpoints;
	}

	private static int GetStableHashCode(string str)
	{
		int num = 5381;
		int num2 = num;
		for (int i = 0; i < str.Length && str[i] != 0; i += 2)
		{
			num = ((num << 5) + num) ^ str[i];
			if (i == str.Length - 1 || str[i + 1] == '\0')
			{
				break;
			}
			num2 = ((num2 << 5) + num2) ^ str[i + 1];
		}
		return num + num2 * 1566083941;
	}
}
