using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal interface IUniverseScaleTypeEntityFactory : IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Avatar.IUniverseScaleTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IUniverseScaleTypeEntity" /> with the given ID, or null if none existed.
	/// </returns>
	IUniverseScaleTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Avatar.IUniverseScaleTypeEntity" /> with the given value
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Avatar.IUniverseScaleTypeEntity" /> with the given value
	/// </returns>
	IUniverseScaleTypeEntity GetByValue(string value);
}
