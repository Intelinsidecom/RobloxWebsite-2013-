using System;
using Newtonsoft.Json;

namespace Roblox.Platform.Notifications.Core;

/// <summary>
/// Represents the event target field on any notification field. 
/// Can either be a <see cref="T:System.String" /> or a <see cref="T:System.Int64" /> depending on the consumer of the notification subsystem.
/// </summary>
/// <remarks>
/// This class is essentially a wrapper around an event target in it's <see cref="T:System.String" /> representation to provide a consolidated place where the transformations are taking place.
/// It is furthermore overloading several operators for different reasons:
///
/// 1.  It is implementing the <see cref="T:System.IEquatable`1" />, <see cref="T:System.IEquatable`1" /> and <see cref="T:System.IEquatable`1" /> interface to provide backwards compatibility
///     with code which is expecting to deal with long values which have a different equality behaviour as compared to classes. This class is implementing equality based on the content
///     of the event target string.
/// 2.  To fulfill it's main purpose, it is overloading the implicit operator string and implicit operator long as well as the inverse ones which allow this class to be implictly cast
///     from/to a string/long. This allows the consumers of the notification subsystem which are always using longs for the event target to use this class as a <see cref="T:System.Int64" /> without
///     having to replicate the same parsing logic in different places. 
///
/// In addition, it also has a custom <see cref="T:Newtonsoft.Json.JsonConverter" /> so it is seralized as a simple string instead of as an object.
/// </remarks>
[JsonConverter(typeof(EventTargetSerializer))]
public class EventTarget : IEquatable<EventTarget>, IEquatable<string>, IEquatable<long>
{
	private readonly string _Id;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" />.
	/// </summary>
	/// <param name="id">The event target representation as a <see cref="T:System.String" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="id" /> is null</exception>
	public EventTarget(string id)
	{
		_Id = id ?? throw new ArgumentNullException("id");
	}

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" />.
	/// </summary>
	/// <param name="id">The event target representation as a <see cref="T:System.Int64" /></param>
	public EventTarget(long id)
	{
		_Id = id.ToString();
	}

	public static implicit operator long(EventTarget eventTarget)
	{
		if (eventTarget == null)
		{
			return 0L;
		}
		if (!long.TryParse(eventTarget._Id, out var convertedEventTarget))
		{
			throw new InvalidCastException("Cannot convert the Event Target's string representation to long");
		}
		return convertedEventTarget;
	}

	public static implicit operator string(EventTarget eventTarget)
	{
		if (!(eventTarget != null))
		{
			return null;
		}
		return eventTarget._Id;
	}

	public static implicit operator EventTarget(long eventTarget)
	{
		return new EventTarget(eventTarget.ToString());
	}

	public static implicit operator EventTarget(string eventTarget)
	{
		return new EventTarget(eventTarget);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is EventTarget eventTargetObject)
		{
			return Equals(eventTargetObject);
		}
		if (obj is string eventTargetString)
		{
			return Equals(eventTargetString);
		}
		if (obj is long eventTargetLong)
		{
			return Equals(eventTargetLong);
		}
		return false;
	}

	public bool Equals(EventTarget target)
	{
		return _Id == target?.ToString();
	}

	public bool Equals(string target)
	{
		return _Id == target;
	}

	public bool Equals(long target)
	{
		return _Id == target.ToString();
	}

	public override int GetHashCode()
	{
		return _Id.GetHashCode();
	}

	public static bool operator ==(EventTarget leftEventTarget, EventTarget rightEventTarget)
	{
		if ((object)leftEventTarget == rightEventTarget)
		{
			return true;
		}
		if ((object)leftEventTarget == null)
		{
			return false;
		}
		if ((object)rightEventTarget == null)
		{
			return false;
		}
		return leftEventTarget.Equals(rightEventTarget);
	}

	public static bool operator !=(EventTarget leftEventTarget, EventTarget rightEventTarget)
	{
		return !(leftEventTarget == rightEventTarget);
	}

	public override string ToString()
	{
		return _Id;
	}
}
