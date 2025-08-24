using System.Collections.Generic;
using System.Net;
using Roblox.Configuration;
using Roblox.Networking;
using Roblox.Platform.Throttling.Properties;

namespace Roblox.Platform.Throttling.Implementation;

public class FlaggedIpRangesAuthority : IFlaggedIpAddressAuthority
{
	private IReadOnlyCollection<IpAddressRange> _IpAddressRanges;

	public FlaggedIpRangesAuthority()
	{
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.FlaggedIpAddressRangesList, SetIpRanges);
	}

	public bool IsIpAddressStringFlagged(string ipAddressString)
	{
		if (IPAddress.TryParse(ipAddressString, out var ipAddress))
		{
			return IsIpAddressFlagged(ipAddress);
		}
		return false;
	}

	public bool IsIpAddressFlagged(IPAddress ipAddress)
	{
		foreach (IpAddressRange ipAddressRange in _IpAddressRanges)
		{
			if (ipAddressRange.IsInRange(ipAddress))
			{
				return true;
			}
		}
		return false;
	}

	private void SetIpRanges(string ipRanges)
	{
		_IpAddressRanges = IpAddressRange.ParseStringList(ipRanges);
	}
}
