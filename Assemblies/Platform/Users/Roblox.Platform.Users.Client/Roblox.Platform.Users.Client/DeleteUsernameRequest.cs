using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
namespace Roblox.Platform.Users.Client
{
[DataContract]
[ExcludeFromCodeCoverage]
internal class DeleteUsernameRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }
}

}
