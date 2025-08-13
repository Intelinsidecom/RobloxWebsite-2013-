namespace Roblox.Platform.Groups.Entities;

internal interface IStatusEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Groups.Entities.IStatusEntity" /> by its ID.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Groups.Entities.IStatusEntity" /> with the given id, or null if none existed.</returns>
	IStatusEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Groups.Entities.IStatusEntity" /> with the given group id
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Groups.Entities.IStatusEntity" /> with the given group id, or null if none existed.</returns>
	IStatusEntity GetByGroupId(long groupId);

	IStatusEntity UpdateOrCreate(long groupId, long userId, string message);
}
