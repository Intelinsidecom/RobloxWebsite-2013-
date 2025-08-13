namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface represents an object that uniquely identifies a moderation task queue.
/// </summary>
public interface ITaskQueueIdentifier
{
	/// <summary>
	/// Constructs a string key that is being used to identify a client associated with 
	/// this task queue among all other queue clients.
	///
	/// Note: depending on the usage, the client can be a task publisher, or a task consumer etc.
	/// </summary>
	string GetKey();
}
