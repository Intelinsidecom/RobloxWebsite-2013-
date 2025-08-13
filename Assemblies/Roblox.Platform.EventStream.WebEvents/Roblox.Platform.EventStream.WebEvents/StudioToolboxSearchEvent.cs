using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class StudioToolboxSearchEvent : WebEventBase
{
	private const string _Name = "studioToolboxSearch";

	/// <summary>
	/// The event that represents a studio toolbox search.
	/// </summary>
	public StudioToolboxSearchEvent(IEventStreamer streamer, StudioToolboxSearchEventArgs eventArgs)
		: base(streamer, "studioToolboxSearch", eventArgs)
	{
		Validate("eventArgs.Category", eventArgs.Category);
		AddEventArg("kwd", eventArgs.Keyword);
		AddEventArg("category", eventArgs.Category);
		AddEventArg("sort", eventArgs.Sort);
		AddEventArg("assetsReturned", eventArgs.AssetsReturned);
		AddEventArg("algorithm", eventArgs.AlgorithmName);
		AddEventArg("pageNumber", eventArgs.PageNumber);
	}

	private static void Validate(string paramName, string paramValue)
	{
		if (string.IsNullOrWhiteSpace(paramValue))
		{
			throw new ArgumentException(paramName + " is required");
		}
	}
}
