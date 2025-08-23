using System.ComponentModel;
using System.Net;

namespace BeIT.MemCached;

internal class FakeDnsSettings : IMemcachedClientDnsSettings, INotifyPropertyChanged
{
	public bool IsUpgradedDnsResolvingEnabled => false;

	public IPAddress[] Nameservers => null;

	#pragma warning disable 0067
	public event PropertyChangedEventHandler PropertyChanged;
	#pragma warning restore 0067
}
