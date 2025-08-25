namespace Roblox.Platform.EventStream.WebEvents.EventArgs;

public class AssetTypeHeaderMismatchEventArgs : WebEventArgs
{
	public string ActualType { get; set; }

	public long AssetId { get; set; }

	public string ExpectedType { get; set; }
}
