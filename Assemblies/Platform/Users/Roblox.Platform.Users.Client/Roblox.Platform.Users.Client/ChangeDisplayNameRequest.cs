using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class ChangeDisplayNameRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "currentDisplayName")]
	public string CurrentDisplayName { get; set; }

	[DataMember(Name = "newDisplayName")]
	public string NewDisplayName { get; set; }

	[DataMember(Name = "recordHistory")]
	public bool RecordHistory { get; set; }
}
