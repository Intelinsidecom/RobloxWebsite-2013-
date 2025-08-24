namespace Roblox.AuthenticationV2;

/// <summary>
/// AuthenticationV2 flows to track
/// </summary>
public enum Counter
{
	/// <summary>
	/// Flow related to /SyncRobloxUserSession
	/// </summary>
	SyncRobloxUserSession,
	/// <summary>
	/// Flow related to /DeleteRobloxUserSession
	/// </summary>
	DeleteRobloxUserSession,
	/// <summary>
	/// Flow related to /DeleteAllRobloxUserSessions
	/// </summary>
	DeleteAllRobloxUserSessions
}
