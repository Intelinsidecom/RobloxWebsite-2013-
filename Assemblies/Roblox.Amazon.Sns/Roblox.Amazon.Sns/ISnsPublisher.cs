namespace Roblox.Amazon.Sns;

public interface ISnsPublisher
{
	/// <summary>
	/// Run through all publishers in order, trying up to TotalNumberOfRetryAttemptsPerRegion each.
	/// </summary>
	/// <param name="message">Message to be serialized.</param>
	void Publish(object message);
}
