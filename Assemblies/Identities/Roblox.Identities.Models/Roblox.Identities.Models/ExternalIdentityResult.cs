using System.Runtime.Serialization;

namespace Roblox.Identities.Models;

/// <summary>
/// An external identity.
/// </summary>
public class ExternalIdentityResult
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
	public ExternalIdentityType ExternalIdentityType { get; set; }
}
