using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Platform.EventStream.ChatTrainingData;

/// <summary>
/// An interface representing a factory that produces <see cref="T:Roblox.Platform.EventStream.IChatTrainingDataStreamer" />
/// </summary>
public interface IChatTrainingDataStreamerFactory
{
	/// <summary>
	/// Returns a <see cref="T:Roblox.Platform.EventStream.IChatTrainingDataStreamer" /> using the given <see cref="T:Roblox.EventLog.ILogger" />
	/// </summary>
	IChatTrainingDataStreamer GetStreamer(ICounterRegistry counterRegistry, ILogger logger);
}
