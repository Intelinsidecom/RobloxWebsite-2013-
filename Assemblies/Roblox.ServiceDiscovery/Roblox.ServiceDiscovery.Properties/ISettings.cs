using System;
using System.ComponentModel;

namespace Roblox.ServiceDiscovery.Properties;

internal interface ISettings : INotifyPropertyChanged
{
	TimeSpan ConsulLongPollingMaxWaitTime { get; }

	string ConsulAddress { get; }

	TimeSpan ConsulBackoffBase { get; }

	TimeSpan MaximumConsulBackoff { get; }
}
