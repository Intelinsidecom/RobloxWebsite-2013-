namespace Roblox.Platform.EventStream;

/// <summary>
/// Interface for classes who will publish chat data to an AWS Kinesis Firehose
/// </summary>
public interface IChatTrainingDataSender
{
	/// <summary>
	/// Method to publish an instantiation of an IChatTrainingData object 
	/// to an AWS Kinesis Firehose
	/// </summary>
	/// <param name="data">a filled IChatTrainingData object representing
	/// a community sift request</param>
	void PublishData(IChatTrainingData data);
}
