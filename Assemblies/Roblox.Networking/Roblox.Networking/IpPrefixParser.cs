using System;
using System.Collections.Generic;

namespace Roblox.Networking;

/// <summary>
/// IP Prefix Parser
/// </summary>
public class IpPrefixParser
{
	private const int _Mask = 1;

	/// <summary>
	/// Parses an IP Prefix into list of IP addresses
	/// </summary>
	/// <param name="ipPrefix">IP prefix</param>
	/// <returns>list of IP Addresses</returns>
	public static List<string> ComputeIpAddressesFromPrefix(string ipPrefix)
	{
		string text = ipPrefix.Substring(0, ipPrefix.IndexOf('/'));
		int fixedBits = int.Parse(ipPrefix.Substring(ipPrefix.LastIndexOf('/') + 1));
		string[] baseIpaddressOctets = text.Split(new char[1] { '.' });
		int baseIpBits = (int.Parse(baseIpaddressOctets[0]) << 24) | (int.Parse(baseIpaddressOctets[1]) << 16) | (int.Parse(baseIpaddressOctets[2]) << 8) | int.Parse(baseIpaddressOctets[3]);
		for (int i = fixedBits; i < 32; i++)
		{
			baseIpBits &= ~(1 << 31 - i);
		}
		int baseIpBitsInt = baseIpBits;
		List<string> results = new List<string>((int)Math.Pow(2.0, 32 - fixedBits));
		for (int maskVariation = 0; maskVariation < (int)Math.Pow(2.0, 32 - fixedBits); maskVariation++)
		{
			int nextIpBits = baseIpBitsInt | maskVariation;
			results.Add(string.Join(".", ((nextIpBits & -16777216) >> 24) & 0xFF, (nextIpBits & 0xFF0000) >> 16, (nextIpBits & 0xFF00) >> 8, nextIpBits & 0xFF));
		}
		return results;
	}
}
