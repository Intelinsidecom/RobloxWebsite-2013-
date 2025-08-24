using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class AcquirePlaceholderUsernameRequest
{
	[DataMember(Name = "accountId")]
	public long AccountId { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }
}
