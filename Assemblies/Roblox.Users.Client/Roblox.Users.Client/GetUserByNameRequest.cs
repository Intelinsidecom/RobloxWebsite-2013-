using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetUserByNameRequest
{
	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "includeUsernameHistory")]
	public bool IncludeUsernameHistory { get; set; }
}
