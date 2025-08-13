using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Files.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class GetUriResult
{
	[DataMember(Name = "uri")]
	public Uri Uri { get; set; }
}
