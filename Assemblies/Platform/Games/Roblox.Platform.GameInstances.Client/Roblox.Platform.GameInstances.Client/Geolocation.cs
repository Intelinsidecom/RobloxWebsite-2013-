using ProtoBuf;
using Roblox.GameInstances.Interfaces;

namespace Roblox.GameInstances.Client;

[ProtoContract]
public class Geolocation : IGeolocation
{
	[ProtoMember(1)]
	public double Latitude { get; set; }

	[ProtoMember(2)]
	public double Longitude { get; set; }

	[ProtoMember(3)]
	public int? CountryId { get; set; }
}
