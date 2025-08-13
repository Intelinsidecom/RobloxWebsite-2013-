using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// Data model for getting External Identity Data from external id and type
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public struct GetExternalIdentityByExternalIdAndTypeRequest
{
	/// <summary>
	/// The external account identifier
	/// </summary>
	[DataMember(Name = "externalId")]
	public string ExternalId;

	/// <summary>
	/// The type of the external id
	/// </summary>
	[DataMember(Name = "externalIdentityType")]
	public ExternalIdentityType? IdentityType;
}
