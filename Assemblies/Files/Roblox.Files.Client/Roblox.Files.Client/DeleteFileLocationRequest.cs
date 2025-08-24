using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Files.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class DeleteFileLocationRequest
{
	[DataMember(Name = "Hash")]
	public string Hash { get; set; }

	[DataMember(Name = "FileContentLocation")]
	public FileContentLocation FileContentLocation { get; set; }
}
