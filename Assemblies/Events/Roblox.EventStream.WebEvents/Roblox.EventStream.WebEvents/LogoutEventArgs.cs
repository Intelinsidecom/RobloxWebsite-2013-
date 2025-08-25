namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" /> for <see cref="T:Roblox.Platform.EventStream.WebEvents.LogoutEvent" />
/// </summary>
public class LogoutEventArgs : WebEventArgs
{
	/// <summary>
	/// Is this logout for all sessions?
	/// </summary>
	public bool IsFromAllSessions { get; set; }

	/// <summary>
	/// The reason this logout occurred.
	/// </summary>
	public byte LogoutReason { get; set; }
}
