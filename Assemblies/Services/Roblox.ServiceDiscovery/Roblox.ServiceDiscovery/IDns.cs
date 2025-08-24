using System.Net;

namespace Roblox.ServiceDiscovery;

public interface IDns
{
	string GetHostName();

	IPHostEntry GetHostEntry(string hostNameOrAddress);
}
