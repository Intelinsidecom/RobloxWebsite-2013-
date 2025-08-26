using System.Runtime.Serialization;

namespace Roblox.Configuration.Client;

[DataContract]
internal class CreateSettingRequest
{
	[DataMember(Name = "groupName")]
	public string GroupName { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "type")]
	public string Type { get; set; }

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
}
