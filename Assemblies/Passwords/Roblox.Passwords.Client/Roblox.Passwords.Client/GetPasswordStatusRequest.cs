using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Passwords.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetPasswordStatusRequest
{
	[DataMember(Name = "passwordOwnerType")]
	public PasswordOwnerType PasswordOwnerType { get; set; }

	[DataMember(Name = "passwordOwnerId")]
	public long PasswordOwnerId { get; set; }
}
