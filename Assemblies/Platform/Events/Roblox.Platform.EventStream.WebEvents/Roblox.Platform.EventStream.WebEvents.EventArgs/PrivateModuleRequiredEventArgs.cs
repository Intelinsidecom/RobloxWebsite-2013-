namespace Roblox.Platform.EventStream.WebEvents.EventArgs;

public class PrivateModuleRequiredEventArgs : WebEventArgs
{
	/// <summary>
	/// The ID of the place which required the module.
	/// </summary>
	public long PlaceId { get; set; }

	/// <summary>
	/// The ID of the module which was required.
	/// </summary>
	public long AssetId { get; set; }
}
