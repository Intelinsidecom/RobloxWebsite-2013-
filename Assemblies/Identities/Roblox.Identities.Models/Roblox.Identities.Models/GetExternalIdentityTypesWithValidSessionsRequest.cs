using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for getting the valid external identity types with valid sessions
/// </summary>
[DataContract]
public struct GetExternalIdentityTypesWithValidSessionsRequest
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
