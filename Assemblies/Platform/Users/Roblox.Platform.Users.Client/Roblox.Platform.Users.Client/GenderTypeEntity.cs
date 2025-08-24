using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class GenderTypeEntity
{
	[DataMember(Name = "id")]
	public byte Id { get; set; }

	[DataMember(Name = "value")]
	public string Value { get; set; }
}
