using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Files.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class DeleteFileLocationResult
{
	[DataMember(Name = "Success")]
	public bool Success { get; set; }
}
