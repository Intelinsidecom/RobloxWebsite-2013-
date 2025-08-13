namespace Roblox.Coordination.Interface;

public interface IConsumer : IBackgroundWorker
{
	int BatchSize { get; set; }

	int SurplusCapacity { get; }

	bool MessageDeliveryWasThrottled { get; }
}
