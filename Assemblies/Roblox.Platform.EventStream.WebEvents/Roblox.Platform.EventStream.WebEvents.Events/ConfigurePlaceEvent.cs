namespace Roblox.Platform.EventStream.WebEvents.Events;

public class ConfigurePlaceEvent : WebEventBase
{
	private const string _Name = "configurePlace";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.Events.ConfigurePlaceEvent" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.IEventStreamer" />.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.ConfigurePlaceEventArgs" /> instance containing the event data.</param>
	/// <exception cref="!:PlatformInvalidEnumArgumentException">Thrown if <paramref name="args.Target.Target" /> is not <see cref="F:Roblox.Platform.EventStream.WebEvents.EventTarget.Www" />.</exception>
	public ConfigurePlaceEvent(IEventStreamer streamer, ConfigurePlaceEventArgs args)
		: base(streamer, "configurePlace", args)
	{
		AddEventArg("placeId", args.PlaceId.ToString());
		if (args.UniverseId.HasValue)
		{
			AddEventArg("universeId", args.UniverseId.ToString());
		}
		if (!string.IsNullOrWhiteSpace(args.OldName))
		{
			AddEventArg("oldName", args.OldName.ToString());
		}
		if (!string.IsNullOrWhiteSpace(args.NewName))
		{
			AddEventArg("newName", args.NewName.ToString());
		}
		if (!string.IsNullOrWhiteSpace(args.OldDescription))
		{
			AddEventArg("oldDescription", args.OldDescription.ToString());
		}
		if (!string.IsNullOrWhiteSpace(args.NewDescription))
		{
			AddEventArg("newDescription", args.NewDescription.ToString());
		}
		if (!string.IsNullOrWhiteSpace(args.OldImageIconUrl))
		{
			AddEventArg("oldImageIconUrl", args.OldImageIconUrl.ToString());
		}
		if (!string.IsNullOrWhiteSpace(args.NewImageIconUrl))
		{
			AddEventArg("newImageIconUrl", args.NewImageIconUrl.ToString());
		}
		if (!string.IsNullOrWhiteSpace(args.FailureReason))
		{
			AddEventArg("failureReason", args.FailureReason);
		}
	}
}
