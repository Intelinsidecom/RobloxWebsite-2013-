using System.ComponentModel;
namespace Roblox.Moderation.Propertiespublic {
    interface ISqsConsumerSettings : ISqsSettings, INotifyPropertyChanged

{
	double HighPriorityAbuseQueueUsagePercentage { get; }

	double HighPriorityAbuseQueueMinimumUsagePercentage { get; }
}


}
