namespace Roblox.Platform.EventStream.WebEvents;

public class AvatarChangedEvent : WebEventBase
{
	private const string _Name = "avatarChanged";

	public AvatarChangedEvent(IEventStreamer streamer, AvatarChangedEventArgs args)
		: base(streamer, "avatarChanged", args)
	{
		AddEventArg("userId", args.UserId.ToString());
		AddEventArg("browserType", args.BrowserType);
		AddEventArg("avatarChangeSource", args.AvatarChangeSource.ToString());
		AddEventArg("avatarChangeType", args.AvatarChangeType.ToString());
		AddEventArg("deviceType", args.DeviceType.ToString());
		AddEventArg("currentUrl", args.CurrentUrl.ToString());
		if (args.WearAssetId.HasValue)
		{
			AddEventArg("wearAssetId", args.WearAssetId.ToString());
		}
		if (args.RemoveAssetId.HasValue)
		{
			AddEventArg("removeAssetId", args.RemoveAssetId.ToString());
		}
		if (args.WearAvatarAssetGroup.HasValue)
		{
			AddEventArg("wearAvatarAssetGroup", args.WearAvatarAssetGroup.ToString());
		}
		if (args.RemoveAvatarAssetGroup.HasValue)
		{
			AddEventArg("removeAvatarAssetGroup", args.RemoveAvatarAssetGroup.ToString());
		}
		if (args.WearAssetTypeId.HasValue)
		{
			AddEventArg("wearAssetTypeId", args.WearAssetTypeId.ToString());
		}
		if (args.RemoveAssetTypeId.HasValue)
		{
			AddEventArg("removeAssetTypeId", args.RemoveAssetTypeId.ToString());
		}
		if (args.SetPlayerAvatarType.HasValue)
		{
			AddEventArg("setPlayerAvatarType", args.SetPlayerAvatarType.ToString());
		}
		if (args.ScaleDescription.HasValue)
		{
			AddEventArg("scaleDescription", args.ScaleDescription.ToString());
		}
		if (args.SetHeadScale.HasValue)
		{
			AddEventArg("setHeadScale", args.SetHeadScale.ToString());
		}
		if (args.SetWidthScale.HasValue)
		{
			AddEventArg("setWidthScale", args.SetWidthScale.ToString());
		}
		if (args.SetHeightScale.HasValue)
		{
			AddEventArg("setHeightScale", args.SetHeightScale.ToString());
		}
	}
}
