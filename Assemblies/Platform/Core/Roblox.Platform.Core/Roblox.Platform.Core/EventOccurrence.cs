using System;

namespace Roblox.Platform.Core;

/// <summary>
/// Represents an occurrence of an event.
/// </summary>
/// <typeparam name="TEvent">The type of the event.</typeparam>
public class EventOccurrence<TEvent> : IEventOccurrence<TEvent> where TEvent : IEvent
{
	public TEvent Event { get; private set; }

	public DateTime TimeOfOccurrence { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.EventOccurrence`1" /> class.
	/// </summary>
	/// <param name="e">The <see cref="T:Roblox.Platform.Core.IEvent" />.</param>
	/// <param name="timeOfOccurrence">The time of occurrence.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">e</exception>
	public EventOccurrence(TEvent e, DateTime timeOfOccurrence)
	{
		if (e == null)
		{
			throw new PlatformArgumentNullException("e");
		}
		Event = e;
		TimeOfOccurrence = timeOfOccurrence;
	}
}
