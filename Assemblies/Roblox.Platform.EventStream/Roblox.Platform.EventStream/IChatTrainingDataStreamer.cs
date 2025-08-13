namespace Roblox.Platform.EventStream;

public interface IChatTrainingDataStreamer
{
	/// <summary>
	/// Stream a chat training data object to AWS kinesis firehose
	/// </summary>
	/// <param name="data"> a filled chat tgraining data object</param>
	void StreamChatTrainingData(IChatTrainingData data);
}
