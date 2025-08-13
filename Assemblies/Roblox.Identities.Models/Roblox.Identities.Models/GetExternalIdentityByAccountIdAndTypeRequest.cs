using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for getting External Identity Data from the account id and type of the external id
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public struct GetExternalIdentityByAccountIdAndTypeRequest
{
	/// <summary>
	/// The  account identifier
	/// </summary>
	[DataMember(Name = "accountId")]
	public long? AccountId;

	/// <summary>
	/// The type of the external id
	/// </summary>
	[DataMember(Name = "externalIdentityType")]
	public ExternalIdentityType? IdentityType;
}
