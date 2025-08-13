using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Files.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class AddFileLocationResult
{
	[DataMember(Name = "FileContentLocation")]
	public FileContentLocation FileContentLocation { get; set; }
}
