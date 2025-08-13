using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Files.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class AddFileResult
{
	[DataMember(Name = "md5hash")]
	public string Md5Hash { get; set; }
}
