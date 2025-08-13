using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// The request model to create an external identity
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public class CreateExternalIdentityRequest
{
	/// <summary>
	/// The Account ID.
	/// </summary>
	[DataMember(Name = "accountId")]
	public long AccountId { get; set; }

	/// <summary>
	/// The External ID.
	/// </summary>
	[DataMember(Name = "externalId")]
	public string ExternalId { get; set; }

	/// <summary>
	/// The type of the external ID
	/// </summary>
	[DataMember(Name = "externalIdentityType")]
	public ExternalIdentityType IdentityType { get; set; }
}
