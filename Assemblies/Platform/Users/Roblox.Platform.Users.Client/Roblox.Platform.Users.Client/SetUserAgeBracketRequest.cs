using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
namespace Roblox.Platform.Users.Client
{
[DataContract]
[ExcludeFromCodeCoverage]
internal class SetUserAgeBracketRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "ageBracket")]
	public UserAgeBracket AgeBracket { get; set; }
}

}
