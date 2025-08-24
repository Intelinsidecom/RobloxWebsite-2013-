using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Roblox.Serialization.Json;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class UserData
{
	[DataMember(Name = "id")]
	public long Id { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "displayName")]
	public string DisplayName { get; set; }

	[DataMember(Name = "description")]
	public string Description { get; set; }

	[DataMember(Name = "accountId")]
	public long AccountId { get; set; }

	[DataMember(Name = "moderationStatus")]
	public UserModerationStatus ModerationStatus { get; set; }

	[DataMember(Name = "gender")]
	public UserGender Gender { get; set; }

	[DataMember(Name = "ageBracket")]
	public UserAgeBracket AgeBracket { get; set; }

	[DataMember(Name = "birthdate")]
	public DateTime? Birthdate { get; set; }

	[DataMember(Name = "created")]
	[JsonConverter(typeof(KindAwareDateTimeConverter))]
	public DateTime Created { get; set; }

	[DataMember(Name = "updated")]
	[JsonConverter(typeof(KindAwareDateTimeConverter))]
	public DateTime Updated { get; set; }
}
