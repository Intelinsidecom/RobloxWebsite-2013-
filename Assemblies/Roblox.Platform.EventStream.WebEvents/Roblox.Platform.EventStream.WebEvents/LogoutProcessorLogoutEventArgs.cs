namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" /> for <see cref="T:Roblox.Platform.EventStream.WebEvents.LogoutProcessorLogoutEvent" />
/// </summary>
public class LogoutProcessorLogoutEventArgs : WebEventArgs
{
	/// <summary>
	/// Indicates whether the LogoutFromAllSessions initiated by the processor was successful.
	/// </summary>
	public bool Success { get; set; }
}
