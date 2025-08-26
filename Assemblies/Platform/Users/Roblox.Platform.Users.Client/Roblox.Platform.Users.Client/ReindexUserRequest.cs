using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
namespace Roblox.Platform.Users.Client
{
[DataContract]
[ExcludeFromCodeCoverage]
internal class ReindexUserRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "flushCache")]
	public bool FlushCache { get; set; }
}

}
