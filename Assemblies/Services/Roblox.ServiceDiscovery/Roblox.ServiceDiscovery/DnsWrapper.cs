using System.Net;

namespace Roblox.ServiceDiscovery;

internal class DnsWrapper : IDns
{
	public string GetHostName()
	{
		return Dns.GetHostName();
	}

	public IPHostEntry GetHostEntry(string hostNameOrAddress)
	{
		return Dns.GetHostEntry(hostNameOrAddress);
	}
}
