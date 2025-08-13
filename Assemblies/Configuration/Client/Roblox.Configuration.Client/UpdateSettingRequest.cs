using System;
using System.Runtime.Serialization;

namespace Roblox.Configuration.Client;

[DataContract]
internal class UpdateSettingRequest
{
	[DataMember(Name = "id")]
	public int Id { get; set; }

	[DataMember(Name = "value")]
	public string Value { get; set; }

	[DataMember(Name = "comment")]
	public string Comment { get; set; }

	[DataMember(Name = "priority")]
	public int Priority { get; set; }

	[DataMember(Name = "conditions")]
	public SettingConditions Conditions { get; set; }

	[DataMember(Name = "flags")]
	public SettingFlags Flags { get; set; }

	[DataMember(Name = "lastModified")]
	public DateTime LastModified { get; set; }
}
