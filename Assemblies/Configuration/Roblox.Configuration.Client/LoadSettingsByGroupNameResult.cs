using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Roblox.Serialization.Json;

namespace Roblox.Configuration.Client;

[DataContract]
public class LoadSettingsByGroupNameResult
{
	[DataMember(Name = "settings")]
	public IReadOnlyCollection<Setting> Settings { get; set; }

	[DataMember(Name = "lastModified")]
	[JsonConverter(typeof(KindAwareDateTimeConverter))]
	public DateTime LastModified { get; set; }
}
