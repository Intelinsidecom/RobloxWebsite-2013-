using System;

namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface represents an object that is responsible for retrieving or deleting a moderation task message from the 
/// specific Sqs queue based on the provided locale Id and the priority.
/// </summary>
public interface IModerationTaskConsumer : IDisposable
{
	/// <summary>
	/// To delete a message from the specific Sqs queue based on the <see cref="T:Roblox.Platform.Moderation.ISqsOpenTask" /> associated with the message.
	/// </summary>
	/// <param name="openTask">The <see cref="T:Roblox.Platform.Moderation.ISqsOpenTask" /> associated with the message to be deleted</param>
	/// <exception cref="T:System.ArgumentNullException">Throws when the input parameter openTask is null.</exception>
	void DeleteMessage(ISqsOpenTask openTask);
}
