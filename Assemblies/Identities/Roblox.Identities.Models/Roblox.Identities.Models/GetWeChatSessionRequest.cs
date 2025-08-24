using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for getting WeChat Session
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public struct GetWeChatSessionRequest
{
	/// <summary>
	/// The account identifier
	/// </summary>
	[DataMember(Name = "accountId")]
	public long? AccountId;

	/// <summary>
	/// The platform
	/// </summary>
	[DataMember(Name = "identityPlatform")]
	public WeChatIdentityPlatform? IdentityPlatform;

	/// <summary>
	/// The open identifier
	/// </summary>
	[DataMember(Name = "openId")]
	public string OpenId;
}
