namespace Roblox.Amazon.Sqs;

public interface ISqsSender
{
	/// <summary>
	/// Send a message to the AWS SQS queue.
	/// </summary>
	/// <param name="message">The message to be sent to SQS.</param>
	void SendMessage(string message);
}
