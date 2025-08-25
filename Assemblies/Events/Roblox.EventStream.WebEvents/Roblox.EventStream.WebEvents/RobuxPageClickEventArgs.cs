namespace Roblox.Platform.EventStream.WebEvents;

public class RobuxPageClickEventArgs : WebEventArgs
{
	/// <summary>
	/// The page (Robux grid view or list view) which user clicks on.
	/// </summary>
	public string Page { get; set; }

	/// <summary>
	/// The name and product of the button user clicks.
	/// </summary>
	public string Context { get; set; }
}
