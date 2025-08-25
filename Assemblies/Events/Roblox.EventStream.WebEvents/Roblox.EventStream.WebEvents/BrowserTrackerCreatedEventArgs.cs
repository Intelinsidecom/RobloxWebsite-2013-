namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event arguments for tracking BrowserTracker creation.
/// </summary>
public class BrowserTrackerCreatedEventArgs : WebEventArgs
{
	/// <summary>
	/// Gets or sets the request URL.
	/// </summary>
	/// <value>
	/// The request URL.
	/// </value>
	public string RequestUrl { get; set; }
}
