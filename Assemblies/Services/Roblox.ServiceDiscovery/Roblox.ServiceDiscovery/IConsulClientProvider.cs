using System.ComponentModel;
using Consul;

namespace Roblox.ServiceDiscovery;

public interface IConsulClientProvider : INotifyPropertyChanged
{
	IConsulClient Client { get; }
}
