using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class AccountStatusEntity
{
	[DataMember(Name = "id")]
	public byte Id { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }
}
