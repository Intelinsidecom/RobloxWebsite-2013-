using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for getting QQ Identity Data by Account Id and Platform type
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public struct GetQQIdentityDataRequest
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
