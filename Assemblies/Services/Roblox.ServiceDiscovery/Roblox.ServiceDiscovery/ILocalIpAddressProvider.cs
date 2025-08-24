using System.Collections.Generic;
using System.ComponentModel;
using System.Net;

namespace Roblox.ServiceDiscovery;

public interface ILocalIpAddressProvider : INotifyPropertyChanged
{
	IPAddress AddressV4 { get; }

	IPAddress AddressV6 { get; }

	IList<IPAddress> GetIpAddressesV4();

	IList<IPAddress> GetIpAddressesV6();
}
