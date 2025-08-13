using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Roblox.AuthenticationV2.Client;

/// <summary>
/// Request model for /DeleteAllRobloxUserSessions
/// </summary>
[DataContract]
public class DeleteAllRobloxUserSessionsRequest
{
	/// <summary>
	/// The type of user to delete sessions for
	/// </summary>
	/// <example>RobloxUser</example>
	/// <example>RobloxUser_ST3</example>
	[DataMember]
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// Unique identifier for the user
	/// </summary>
	[DataMember]
	[JsonProperty("user")]
	public string User { get; set; }
}
