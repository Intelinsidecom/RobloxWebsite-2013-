using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents {
    public class BundleFavoriteEvent : WebEventBase

{
	private const string _Name = "bundlefavorite";

	/// <summary>
	/// Initializes a new instance of the <see cref="!:deviceHandleRequestedEvent" /> class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.IEventStreamer" />.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.FavoriteEventArgs" /> instance containing the event data.</param>
	/// <exception cref="!:PlatformInvalidEnumArgumentException">Thrown if <paramref name="args.Target.Target" /> is not <see cref="F:Roblox.Platform.EventStream.WebEvents.EventTarget.Www" />.</exception>
	public BundleFavoriteEvent(IEventStreamer streamer, BundleFavoriteEventArgs args)
		: base(streamer, "bundlefavorite", args)
	{
		AddEventArg("bundleId", args.BundleId.ToString());
		if (args.BundleType != null)
		{
			AddEventArg("bundleType", args.BundleType);
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


}






