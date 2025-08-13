using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Roblox.Platform.Games.Events;

/// <summary>
/// The type of an <see cref="T:Roblox.Platform.Games.Events.GamePlacesChangeEvent" />.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[DataContract]
public enum GamePlacesChangeType
{
	/// <summary>
	/// A place was added to the place.
	/// </summary>
	[EnumMember(Value = "placeAdded")]
	PlaceAdded,
	/// <summary>
	/// A place was removed from the game.
	/// </summary>
	[EnumMember(Value = "placeRemoved")]
	PlaceRemoved
}
