using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for getting WeChat IdentityData
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public struct GetWeChatIdentityDataRequest
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
}
