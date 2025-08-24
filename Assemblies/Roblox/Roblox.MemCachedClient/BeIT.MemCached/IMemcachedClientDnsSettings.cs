using System.ComponentModel;
using System.Net;

namespace BeIT.MemCached;

public interface IMemcachedClientDnsSettings : INotifyPropertyChanged
{
	bool IsUpgradedDnsResolvingEnabled { get; }

	IPAddress[] Nameservers { get; }
}
