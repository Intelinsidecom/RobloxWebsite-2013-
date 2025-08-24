using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Roblox.AuthenticationV2.Client;

/// <summary>
/// Request model for /DeletRobloxUserSession
/// </summary>
[DataContract]
public class DeleteRobloxUserSessionRequest
{
	/// <summary>
	/// Unique identifier for the session to delete
	/// </summary>
	[DataMember]
	[JsonProperty("token")]
	public Guid Token { get; set; }
}
