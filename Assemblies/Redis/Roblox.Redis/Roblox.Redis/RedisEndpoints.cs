using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;

namespace Roblox.Redis;

[TypeConverter(typeof(RedisEndpointsConverter))]
[SettingsSerializeAs(SettingsSerializeAs.String)]
public class RedisEndpoints
{
	public string Source { get; }

	public ICollection<string> Endpoints { get; }

	public RedisEndpoints(string hostsWithPorts)
	{
		Source = hostsWithPorts;
		Endpoints = ParseConfiguration(hostsWithPorts);
	}

	private List<string> ParseConfiguration(string hostsWithPorts)
	{
		return (from str in hostsWithPorts.Split(new char[1] { ',' }).SelectMany(ParseEntry)
			orderby str
			select str).ToList();
	}

	private List<string> ParseEntry(string hostWithPorts)
	{
		string[] array = hostWithPorts.Split(new char[1] { ':' });
		if (array.Length != 2)
		{
			throw new RedisEndpointParseException($"Entry did not contain and host and port/port-range pair: \"{hostWithPorts}\"");
		}
		string arg = array[0];
		string[] array2 = array[1].Split(new char[1] { '-' });
		if (array2.Length == 1)
		{
			return new List<string> { hostWithPorts };
		}
		if (array2.Length == 2)
		{
			try
			{
				int num = int.Parse(array2[0]);
				int num2 = int.Parse(array2[1]);
				if (num2 < num)
				{
					throw new RedisEndpointParseException($"Entry's end port is lower than the start port: \"{hostWithPorts}\"");
				}
				List<string> list = new List<string>();
				for (int i = num; i <= num2; i++)
				{
					list.Add($"{arg}:{i}");
				}
				return list;
			}
			catch (FormatException)
			{
				throw new RedisEndpointParseException($"Entry has unparseable start and end port numbers: \"{hostWithPorts}\"");
			}
		}
		throw new RedisEndpointParseException($"Entry has unparseable port range: \"{hostWithPorts}\"");
	}

	public bool HasTheSameEndpoints(RedisEndpoints otherEndpoints)
	{
		if (otherEndpoints != null)
		{
			return Endpoints.SequenceEqual(otherEndpoints.Endpoints);
		}
		return false;
	}

	public override string ToString()
	{
		return string.Join(",", Endpoints);
	}
}
