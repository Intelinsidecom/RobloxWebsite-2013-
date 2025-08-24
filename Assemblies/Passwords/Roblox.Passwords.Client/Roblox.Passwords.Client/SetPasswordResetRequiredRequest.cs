using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Passwords.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class SetPasswordResetRequiredRequest
{
	[DataMember(Name = "passwordOwnerType")]
	public PasswordOwnerType PasswordOwnerType { get; set; }

	[DataMember(Name = "passwordOwnerId")]
	public long PasswordOwnerId { get; set; }

	[DataMember(Name = "needsReset")]
	public bool NeedsReset { get; set; }
}
