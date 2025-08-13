namespace Roblox.Platform.Assets.Places.Entities;

internal interface ISocialSlotTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Assets.Places.Entities.ISocialSlotTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.Places.Entities.ISocialSlotTypeEntity" /> with the given ID, or null if none existed.</returns>
	ISocialSlotTypeEntity Get(int id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.Places.Entities.ISocialSlotTypeEntity" /> with the given Value.
	/// </summary>
	/// <param name="value">The Value.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.Places.Entities.ISocialSlotTypeEntity" /> with the given Value, or null if none existed.</returns>
	ISocialSlotTypeEntity GetByValue(string value);
}
