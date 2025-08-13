using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class FormValidationFailedEvent : WebEventBase
{
	private const string _Name = "formValidation";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.FormValidationFailedEvent" />  class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.IEventStreamer" /> used to stream the event.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.BasicEventArgs" /> containing event info.</param>
	/// <exception cref="!:PlatformArgumentException">Thrown if <paramref name="args" /> has invalid field.</exception>
	/// <exception cref="!:PlatformArgumentException">Thrown if <paramref name="args" /> has invalid context.</exception>
	public FormValidationFailedEvent(IEventStreamer streamer, FormValidationFailedEventArgs args)
		: base(streamer, "formValidation", args)
	{
		if (string.IsNullOrWhiteSpace(args.Field))
		{
			throw new ArgumentException("args.Field is required");
		}
		if (string.IsNullOrWhiteSpace(args.Context))
		{
			throw new ArgumentException("args.Context is required");
		}
		AddEventArg("ctx", args.Context);
		AddEventArg("field", args.Field);
		if (!string.IsNullOrWhiteSpace(args.Input))
		{
			AddEventArg("input", args.Input);
		}
		if (!string.IsNullOrWhiteSpace(args.Message))
		{
			AddEventArg("msg", args.Message);
		}
		AddEventArg("vis", args.IsVisible.ToString());
	}
}
