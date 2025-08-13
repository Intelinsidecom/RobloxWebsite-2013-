using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class MultiGetUsersByNamesRequest
{
	[DataMember(Name = "names")]
	public ISet<string> Names { get; set; }

	[DataMember(Name = "includeUsernameHistory")]
	public bool IncludeUsernameHistory { get; set; }
}
