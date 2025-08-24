namespace Roblox.Platform.Assets.Places.Entities;

internal interface IGameConstraintEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Assets.Places.Entities.IGameConstraintEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.Places.Entities.IGameConstraintEntity" /> with the given ID, or null if none existed.</returns>
	IGameConstraintEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.Places.Entities.IGameConstraintEntity" /> for the given place id
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Assets.Places.Entities.IGameConstraintEntity" /> for the given place id, or null if none existed.</returns>
	IGameConstraintEntity GetByPlaceId(long placeId);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Assets.Places.Entities.IGameConstraintEntity" /> for the given place id
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.Places.Entities.IGameConstraintEntity" /> for the given place id</returns>
	IGameConstraintEntity GetOrCreate(long placeId, int defaultMaxPlayers);
}
