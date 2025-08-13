using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarCollisionTypeEntityFactory : IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarCollisionTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarCollisionTypeEntity" /> with the given ID, or null if none existed.</returns>
	IUniverseAvatarCollisionTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarCollisionTypeEntity" /> with the given value.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarCollisionTypeEntity" /> with the given value.</returns>
	IUniverseAvatarCollisionTypeEntity GetByValue(string value);
}
