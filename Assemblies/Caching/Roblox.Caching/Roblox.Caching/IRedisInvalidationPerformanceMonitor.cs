using Roblox.Instrumentation;

namespace Roblox.Caching;

internal interface IRedisInvalidationPerformanceMonitor
{
	IRateOfCountsPerSecondCounter MessagesPublishedPerSecond { get; set; }

	IRateOfCountsPerSecondCounter MessagesReceivedPerSecond { get; set; }

	IRawValueCounter TotalMessagesPublished { get; set; }

	IRawValueCounter TotalMessagesReceived { get; set; }

	double GetMessagesReceivedPerSecond();
}
