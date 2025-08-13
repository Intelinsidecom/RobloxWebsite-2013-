using System;
using System.ComponentModel;

namespace Roblox.Caching.Properties;

public interface ISettings : INotifyPropertyChanged
{
	TimeSpan DelayBeforeDisposingClientOnAddressesChangeForGroupClients { get; }

	TimeSpan RampUpTime { get; }

	bool IsReadingFromWriteCacheForMigrationInBackground { get; }

	bool IsLoggingMigrationConfigurationErrorsEnabled { get; }

	TimeSpan RemoteCacheableExpiration { get; }

	bool IsTypeSpecificRampUpEnabledV2 { get; }

	bool IsEntityDeserializationFailureLoggingEnabled { get; }

	bool IsEntityDeserializationFailureCounterEnabled { get; }
}
