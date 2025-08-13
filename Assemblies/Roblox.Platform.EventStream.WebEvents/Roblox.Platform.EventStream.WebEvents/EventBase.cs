using System;
using System.Collections.Generic;
using Roblox.Common;

namespace Roblox.Platform.EventStream.WebEvents;

public abstract class EventBase
{
	private readonly Lazy<List<KeyValuePair<string, string>>> _ExtraParameters = new Lazy<List<KeyValuePair<string, string>>>(() => new List<KeyValuePair<string, string>>());

	private readonly IEventStreamer _Streamer;

	private readonly string _ClientIp;

	private readonly string _EventName;

	private readonly string _Target;

	protected readonly BasicEventArgs _Args;

	public bool IsTrustedSource { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" /> used to stream the event.</param>
	/// <param name="eventName">The name of the event.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" /> containing event info.</param>
	/// <exception cref="!:PlatformArgumentNullException">Thrown if <paramref name="streamer" />, <paramref name="eventName" />, or <paramref name="args" /> is null.</exception>
	/// <exception cref="!:PlatformInvalidEnumArgumentException">Thrown if <paramref name="args.Target.Target" /> is not a supported <see cref="T:Roblox.Platform.EventStream.WebEvents.EventTarget" />.</exception>
	protected EventBase(IEventStreamer streamer, string eventName, BasicEventArgs args)
	{
		if (streamer == null)
		{
			throw new ArgumentNullException("streamer");
		}
		if (eventName == null)
		{
			throw new ArgumentNullException("eventName");
		}
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		string target = args.Target.ToDescription();
		if (string.IsNullOrWhiteSpace(target))
		{
			throw new ArgumentException("Unrecognized EventTarget value " + args.Target);
		}
		_ClientIp = args.ClientIp;
		_Streamer = streamer;
		_EventName = eventName;
		_Target = target;
		_Args = args;
	}

	/// <summary>
	/// Adds an event argument to the <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" />'s arguments.
	/// </summary>
	/// <param name="name">The name of the argument.</param>
	/// <param name="value"></param>        
	protected void AddEventArg(string name, long value)
	{
		AddEventArg(name, value.ToString());
	}

	/// <summary>
	/// Adds an event argument to the <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" />'s arguments.
	/// </summary>
	/// <param name="name">The name of the argument.</param>
	/// <param name="value"></param>        
	protected void AddEventArg(string name, Guid value)
	{
		AddEventArg(name, value.ToString());
	}

	/// <summary>
	/// Adds an event argument to the <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" />'s arguments.
	/// </summary>
	/// <param name="name">The name of the argument.</param>
	/// <param name="value"></param>        
	protected void AddEventArg(string name, byte value)
	{
		AddEventArg(name, value.ToString());
	}

	/// <summary>
	/// Adds an event argument to the <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" />'s arguments.
	/// </summary>
	/// <param name="name">The name of the argument.</param>
	/// <param name="value"></param>        
	protected void AddEventArg(string name, int value)
	{
		AddEventArg(name, value.ToString());
	}

	/// <summary>
	/// Adds an event argument to the <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" />'s arguments.
	/// </summary>
	/// <param name="name">The name of the argument.</param>
	/// <param name="value"></param>
	/// <exception cref="!:PlatformArgumentNullException">Thrown if <paramref name="name" /> is null.</exception>
	/// <exception cref="!:PlatformArgumentNullException">Thrown if <paramref name="value" /> is null.</exception>
	protected void AddEventArg(string name, string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		_ExtraParameters.Value.Add(new KeyValuePair<string, string>(name, value));
	}

	protected void AddEventArgIfNotNullDoesNotThrow(string name, string value)
	{
		if (!string.IsNullOrEmpty(name) && value != null)
		{
			AddEventArg(name, value);
		}
	}

	/// <summary>
	/// Streams the <see cref="T:Roblox.Platform.EventStream.WebEvents.EventBase" />.
	/// </summary>
	public virtual void Stream()
	{
		List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
		if (_ExtraParameters.IsValueCreated)
		{
			keyValuePairs.AddRange(_ExtraParameters.Value);
		}
		_Streamer.StreamEvent(_Target, _EventName, keyValuePairs, _ClientIp, IsTrustedSource);
	}
}
