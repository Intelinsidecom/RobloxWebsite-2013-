using Roblox.Entities;

namespace Roblox.Platform.Assets.Places.Entities;

/// <summary>
/// Constraints applicable to each instance of a game.
///
/// Keeping the old naming convention for entities because this is what is in the database, but the matching platform
/// object is IGameInstanceConstraint
/// </summary>
internal interface IGameConstraintEntity : IUpdateableEntity<long>, IEntity<long>
{
	long PlaceId { get; set; }

	int MaxPlayers { get; set; }

	int? SocialSlots { get; set; }

	int? SocialSlotTypeID { get; set; }
}
