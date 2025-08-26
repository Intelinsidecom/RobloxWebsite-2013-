using System.Runtime.Serialization;

namespace Roblox.Configuration.Client;

[DataContract]
public class SettingConditions
{
	[DataMember(Name = "version")]
	public int Version { get; set; }

	[DataMember(Name = "roblox.primaryRegion")]
	public string PrimaryRegion { get; set; }

	[DataMember(Name = "request.isPrimaryRegion")]
	public bool? IsPrimaryRegion { get; set; }

	[DataMember(Name = "request.region")]
	public string[] Region { get; set; }

	[DataMember(Name = "request.regionState")]
	public string[] RegionState { get; set; }

	[DataMember(Name = "request.applicationName")]
	public string[] ApplicationName { get; set; }

	[DataMember(Name = "request.dataCenter", EmitDefaultValue = false)]
	public string[] DataCenter { get; set; }

	[DataMember(Name = "request.hostName", EmitDefaultValue = false)]
	public string[] HostName { get; set; }
}
