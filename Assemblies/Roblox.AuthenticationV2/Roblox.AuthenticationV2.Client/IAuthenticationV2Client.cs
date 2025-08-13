using System;

namespace Roblox.AuthenticationV2.Client;

/// <summary>
/// A client to communicate with the AuthenticationV2 Service
/// </summary>
public interface IAuthenticationV2Client
{
	/// <summary>
	/// Syncs Roblox User sessions with AuthenticationV2
	/// </summary>
	/// <param name="type">The type of user</param>
	/// <param name="user">Unique identifier for the user</param>
	/// <param name="token">Unique identifier for this session</param>
	/// <param name="expiration">When this session should expire?</param>
	/// <param name="ip">The Ip this session started on</param>
	/// <param name="timeToLive">How long should this session live?</param>
	/// <returns>AuthenticationV2 External Jwt representation of the provided session.</returns>
	string SyncRobloxUserSession(string type, string user, Guid token, DateTime expiration, string ip, TimeSpan timeToLive);

	/// <summary>
	/// Deletes the Roblox User session from AuthenticationV2
	/// </summary>
	/// <param name="token">Unique identifier for the session</param>
	void DeleteRobloxUserSession(Guid token);

	/// <summary>
	/// Deletes all Roblox User sessions from AuthenticationV2 for the specified user
	/// </summary>
	/// <param name="type">The type of user</param>
	/// <param name="user">Unique identifier for the user</param>
	void DeleteAllRobloxUserSessions(string type, string user);
}
