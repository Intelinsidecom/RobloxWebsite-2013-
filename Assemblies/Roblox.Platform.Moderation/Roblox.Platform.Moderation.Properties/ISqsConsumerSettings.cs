using System.ComponentModel;

namespace Roblox.Platform.Moderation.Properties;

public interface ISqsConsumerSettings : ISqsSettings, INotifyPropertyChanged
{
	double HighPriorityAbuseQueueUsagePercentage { get; }

	double HighPriorityAbuseQueueMinimumUsagePercentage { get; }
}
