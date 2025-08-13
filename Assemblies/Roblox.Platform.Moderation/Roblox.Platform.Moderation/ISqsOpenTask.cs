namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface represents an open moderation task that is to be worked on by a moderator.
/// An effective wrapper around Sqs messsage with receipt and other necessary Sqs queue 
/// information in order for a moderator to work on and then to perform the removal of the 
/// message from the queue.
/// </summary>
public interface ISqsOpenTask : IOpenTask
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Moderation.OpenTaskIdentifier" /> that uniquely identify the task.
	/// </summary>
	OpenTaskIdentifier TaskIdentifier { get; }
}
