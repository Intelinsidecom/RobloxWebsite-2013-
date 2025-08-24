using System.ComponentModel;
using System.Net;

namespace BeIT.MemCached;

internal class FakeDnsSettings : IMemcachedClientDnsSettings, INotifyPropertyChanged
{
	public bool IsUpgradedDnsResolvingEnabled => false;

	public IPAddress[] Nameservers => null;

	public event PropertyChangedEventHandler PropertyChanged;
}
