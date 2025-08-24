using Roblox.Entities;

namespace Roblox.Platform.Assets.Places.Entities;

/// <summary>
/// Social Slot Types
///
/// object is ISocialSlotTypesConstraint
/// </summary>
internal interface ISocialSlotTypeEntity : IUpdateableEntity<int>, IEntity<int>
{
	new int Id { get; set; }

	string Value { get; set; }
}
