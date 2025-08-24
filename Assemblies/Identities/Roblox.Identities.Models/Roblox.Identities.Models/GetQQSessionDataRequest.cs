using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for getting QQ Session Data by Account Id and Platform type
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public struct GetQQSessionDataRequest
{
	/// <summary>
	/// The account Id
	/// </summary>
	[DataMember(Name = "accountId")]
	public long? AccountId;

	/// <summary>
	/// The platform type
	/// </summary>
	[DataMember(Name = "platformType")]
	public ExternalIdentityPlatformType PlatformType;
}
