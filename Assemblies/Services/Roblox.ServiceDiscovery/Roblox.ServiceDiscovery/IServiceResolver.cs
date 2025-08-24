using System.Collections.Generic;
using System.ComponentModel;
using System.Net;

namespace Roblox.ServiceDiscovery;

public interface IServiceResolver : INotifyPropertyChanged
{
	ISet<IPEndPoint> EndPoints { get; }
}
