namespace Roblox.Platform.EventStream.WebEvents;

public class FavoriteEvent : WebEventBase
{
	private const string _Name = "favorite";

	/// <summary>
	/// Initializes a new instance of the <see cref="!:deviceHandleRequestedEvent" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" />.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.FavoriteEventArgs" /> instance containing the event data.</param>
	/// <exception cref="!:PlatformInvalidEnumArgumentException">Thrown if <paramref name="args.Target.Target" /> is not <see cref="F:Roblox.Platform.EventStream.WebEvents.EventTarget.Www" />.</exception>
	public FavoriteEvent(EventStreamer streamer, FavoriteEventArgs args)
		: base(streamer, "favorite", args)
	{
		AddEventArg("assetId", args.AssetId.ToString());
		if (args.AssetType != null)
		{
			AddEventArg("assetType", args.AssetType);
		}
		if (args.Favorite.HasValue)
		{
			AddEventArg("favorite", args.Favorite.ToString());
		}
		AddEventArg("success", args.Success.ToString());
		if (!string.IsNullOrWhiteSpace(args.FailureReason))
		{
			AddEventArg("failureReason", args.FailureReason);
		}
		AddEventArg("favoriteCount", args.FavoriteCount.ToString());
	}
}
