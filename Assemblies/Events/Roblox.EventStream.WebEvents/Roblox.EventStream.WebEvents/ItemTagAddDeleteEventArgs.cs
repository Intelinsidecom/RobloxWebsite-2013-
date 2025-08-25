namespace Roblox.Platform.EventStream.WebEvents;

public class ItemTagAddDeleteEventArgs : WebEventArgs
{
	public string ItemTagId { get; set; }

	public string ItemIdNamespace { get; set; }

	public string ItemId { get; set; }

	public string TagId { get; set; }

	public string TagName { get; set; }

	public bool WasItemTagAdded { get; set; }
}
