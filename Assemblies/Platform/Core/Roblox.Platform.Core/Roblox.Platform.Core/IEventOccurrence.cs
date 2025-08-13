using System;

namespace Roblox.Platform.Core;

/// <summary>
/// Provides a common interface for an occurence of an event.
/// </summary>
/// <typeparam name="TEvent">The type of the event that occurred.</typeparam>
public interface IEventOccurrence<out TEvent> where TEvent : IEvent
{
	/// <summary>
	/// Gets the event.
	/// </summary>
	/// <value>
	/// The event.
	/// </value>
	TEvent Event { get; }

	/// <summary>
	/// Gets the time of the occurrence.
	/// </summary>
	/// <value>
	/// The time of occurrence.
	/// </value>
	DateTime TimeOfOccurrence { get; }
}
