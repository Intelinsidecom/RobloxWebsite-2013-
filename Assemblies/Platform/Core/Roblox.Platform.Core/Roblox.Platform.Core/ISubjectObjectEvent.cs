namespace Roblox.Platform.Core;

/// <summary>
/// Provides a common interface for an event that has a subject (what performed the action) and an object (what received the action).
/// </summary>
/// <typeparam name="TSubject">The type of the subject.</typeparam>
/// <typeparam name="TObject">The type of the object.</typeparam>
public interface ISubjectObjectEvent<out TSubject, out TObject> : IEvent
{
	/// <summary>
	/// Gets the subject.
	/// </summary>
	/// <value>
	/// The subject.
	/// </value>
	TSubject Subject { get; }

	/// <summary>
	/// Gets the object.
	/// </summary>
	/// <value>
	/// The object.
	/// </value>
	TObject Object { get; }
}
