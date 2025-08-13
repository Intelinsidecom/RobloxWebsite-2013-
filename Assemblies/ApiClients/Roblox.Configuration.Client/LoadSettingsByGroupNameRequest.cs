using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Roblox.Serialization.Json;

namespace Roblox.Configuration.Client;

[DataContract]
internal class LoadSettingsByGroupNameRequest
{
	[DataMember(Name = "groupName")]
	public string GroupName { get; set; }

	[DataMember(Name = "lastModified")]
	[JsonConverter(typeof(KindAwareDateTimeConverter))]
	public DateTime LastModified { get; set; }
}
