using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class CreateUserRequest
{
	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "gender")]
	public UserGender? Gender { get; set; }

	[DataMember(Name = "birthdate")]
	public DateTime? Birthdate { get; set; }

	[DataMember(Name = "ageBracket")]
	public UserAgeBracket? AgeBracket { get; set; }
}
