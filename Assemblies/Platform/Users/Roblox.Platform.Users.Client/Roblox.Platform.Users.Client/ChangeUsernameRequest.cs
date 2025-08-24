using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class ChangeUsernameRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "currentName")]
	public string CurrentName { get; set; }

	[DataMember(Name = "newName")]
	public string NewName { get; set; }

	[DataMember(Name = "recordHistory")]
	public bool RecordHistory { get; set; }
}
