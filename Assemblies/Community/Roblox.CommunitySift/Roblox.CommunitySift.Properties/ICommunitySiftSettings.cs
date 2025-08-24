using System;
using System.ComponentModel;

namespace Roblox.CommunitySift.Properties;

public interface ICommunitySiftSettings : INotifyPropertyChanged
{
	string CommunitySiftApiEndpoint { get; }

	string CommunitySiftApiKey { get; }

	string CommunitySiftChatEndpoint { get; }

	string CommunitySiftChatNoContextEndpoint { get; }

	TimeSpan CommunitySiftCircuitBreakerRetryInterval { get; }

	TimeSpan CommunitySiftClientTimeoutInterval { get; }

	string CommunitySiftDoubleChatEndpoint { get; }

	bool CommunitySiftForSoothsayersEnabled { get; }

	string CommunitySiftLongTextEndpoint { get; }

	int CommunitySiftTextFiltering13AndOverRule { get; }

	int CommunitySiftTextFilteringUnder13Rule { get; }

	double CommunitySiftTextFilterPercentage { get; }

	string CommunitySiftUserNameEndpoint { get; }

	int CommunitySiftUserNameFiltering13AndOverRule { get; }

	int CommunitySiftUserNameFilteringUnder13Rule { get; }

	bool IsDetailedCommunitySiftErrorLoggingEnabled { get; }

	int CommunitySiftCircuitBreakerTimeoutsBeforeTrip { get; }

	TimeSpan CommunitySiftCircuitBreakerTimeoutInterval { get; }
}
