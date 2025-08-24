using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class SetUserDescriptionRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "description")]
	public string Description { get; set; }
}
