using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class ItemTagAddDeleteEvent : WebEventBase
{
	private const string _Name = "itemTagAddDeleteEvent";

	public ItemTagAddDeleteEvent(IEventStreamer streamer, ItemTagAddDeleteEventArgs eventArgs)
		: base(streamer, "itemTagAddDeleteEvent", eventArgs)
	{
		PopulateArgs(eventArgs);
	}

	protected ItemTagAddDeleteEvent(IEventStreamer streamer, ItemTagAddDeleteEventArgs eventArgs, string name)
		: base(streamer, name, eventArgs)
	{
		PopulateArgs(eventArgs);
	}

	private void PopulateArgs(ItemTagAddDeleteEventArgs eventArgs)
	{
		if (eventArgs == null)
		{
			throw new ArgumentNullException("eventArgs");
		}
		AddEventArg("itemTagId", eventArgs.ItemTagId);
		AddEventArg("wasItemTagAdded", eventArgs.WasItemTagAdded.ToString());
		AddEventArg("itemId", eventArgs.ItemId);
		AddEventArg("tagId", eventArgs.TagId);
		AddEventArgIfNotNullDoesNotThrow("itemIdNamespace", eventArgs.ItemIdNamespace);
		AddEventArgIfNotNullDoesNotThrow("tagName", eventArgs.TagName);
	}
}
