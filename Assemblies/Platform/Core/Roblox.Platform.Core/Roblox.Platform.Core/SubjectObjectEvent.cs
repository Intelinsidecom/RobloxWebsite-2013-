namespace Roblox.Platform.Core;

/// <summary>
/// Represents an <see cref="T:Roblox.Platform.Core.IEvent" /> that has a subject and an object.
/// </summary>
/// <typeparam name="TSubject">The type of the subject.</typeparam>
/// <typeparam name="TObject">The type of the object.</typeparam>
public class SubjectObjectEvent<TSubject, TObject> : ISubjectObjectEvent<TSubject, TObject>, IEvent
{
	public TSubject Subject { get; private set; }

	public TObject Object { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.SubjectObjectEvent`2" /> class.
	/// </summary>
	/// <param name="subject">The subject.</param>
	/// <param name="o">The object.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// subject
	/// or
	/// o
	/// </exception>
	public SubjectObjectEvent(TSubject subject, TObject o)
	{
		if (subject == null)
		{
			throw new PlatformArgumentNullException("subject");
		}
		if (o == null)
		{
			throw new PlatformArgumentNullException("o");
		}
		Subject = subject;
		Object = o;
	}
}
