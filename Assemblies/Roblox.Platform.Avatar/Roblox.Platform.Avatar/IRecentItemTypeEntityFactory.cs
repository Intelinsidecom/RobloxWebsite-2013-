using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal interface IRecentItemTypeEntityFactory : IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	IRecentItemTypeEntity Asset { get; }

	IRecentItemTypeEntity Outfit { get; }

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Avatar.IRecentItemTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IRecentItemTypeEntity" /> with the given ID, or null if none existed.
	/// </returns>
	IRecentItemTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Avatar.IRecentItemTypeEntity" /> with the given value
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IRecentItemTypeEntity" /> with the given value
	/// </returns>
	IRecentItemTypeEntity GetByValue(string value);
}
