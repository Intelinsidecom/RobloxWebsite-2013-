using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Roblox.AuthenticationV2.Client;

/// <summary>
/// Request model for /SyncRobloxUserSession
/// </summary>
[DataContract]
public class SyncRobloxUserSessionRequest
{
	/// <summary>
	/// The type of user sync to session for
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

	/// <summary>
	/// Unique identifier for this session
	/// </summary>
	[DataMember]
	[JsonProperty("token")]
	public Guid Token { get; set; }

	/// <summary>
	/// When this session should expire
	/// </summary>
	[DataMember]
	[JsonProperty("expiration")]
	public DateTime Expiration { get; set; }

	/// <summary>
	/// The IP this session started on
	/// </summary>
	[DataMember]
	[JsonProperty("ip-address-hash")]
	public string IPAddressHash { get; set; }

	/// <summary>
	/// How long this session should live
	/// </summary>
	[DataMember]
	[JsonProperty("ttl")]
	public TimeSpan TimeToLive { get; set; }
}
