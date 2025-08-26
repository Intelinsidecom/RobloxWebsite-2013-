using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
namespace Roblox.Platform.Users.Client
{
[DataContract]
[ExcludeFromCodeCoverage]
public class Username
{
	[DataMember(Name = "id")]
	public long Id { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "userId")]
	public long UserId { get; set; }
}

}
