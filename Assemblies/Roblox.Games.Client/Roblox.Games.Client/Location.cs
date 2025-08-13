using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Roblox.Games.Client;

public class Location
{
	[JsonConverter(typeof(StringEnumConverter))]
	public LocationType LocationType { get; set; }

	public long LocationTargetId { get; set; }
}
