using System;
using System.ComponentModel;

namespace Roblox.Redis;

public interface ISelfHealingConnectionMultiplexerSettings : INotifyPropertyChanged
{
	TimeSpan DetectionInterval { get; }

	int DetectionThreshold { get; }

	TimeSpan ResetGracePeriod { get; }

	bool FeatureEnabled { get; }
}
