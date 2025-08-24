using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// The request model to disconnect an external identity
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
public class DisconnectExternalIdentityRequest
{
	/// <summary>
	/// The Account ID.
	/// </summary>
	[DataMember(Name = "accountId")]
	public long AccountId { get; set; }

	/// <summary>
	/// The type of the external ID
	/// </summary>
	[DataMember(Name = "externalIdentityType")]
	public ExternalIdentityType ExternalIdentityType { get; set; }
}
