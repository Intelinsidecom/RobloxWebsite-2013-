using Roblox.Instrumentation;

namespace Roblox.Amazon.Firehose;

internal class AmazonKinesisFirehosePerformanceMonitor
{
	internal readonly string _Category = "Roblox.AmazonKinesisFirehoseSenderV1";

	internal IRateOfCountsPerSecondCounter MessagesSentPerSecond { get; }

	internal IRateOfCountsPerSecondCounter BatchSendsPerSecond { get; }

	internal IAverageValueCounter BatchSendAverageDuration { get; }

	internal IRateOfCountsPerSecondCounter BatchSendAverageDurationBase { get; }

	internal IRawValueCounter TotalMessagesSent { get; }

	internal IRateOfCountsPerSecondCounter ErrorsPerSecond { get; }

	internal IRawValueCounter TotalErrors { get; }

	public AmazonKinesisFirehosePerformanceMonitor(ICounterRegistry counterRegistry, string instanceName)
	{
		MessagesSentPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(_Category, "MessagesSentPerSecond", instanceName);
		BatchSendsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(_Category, "BatchSendsPerSecond", instanceName);
		BatchSendAverageDuration = counterRegistry.GetAverageValueCounter(_Category, "BatchSendAverageDuration", instanceName);
		BatchSendAverageDurationBase = counterRegistry.GetRateOfCountsPerSecondCounter(_Category, "BatchSendAverageDurationBase", instanceName);
		TotalMessagesSent = counterRegistry.GetRawValueCounter(_Category, "TotalMessagesSent", instanceName);
		ErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(_Category, "ErrorsPerSecond", instanceName);
		TotalErrors = counterRegistry.GetRawValueCounter(_Category, "TotalErrors", instanceName);
	}
}
