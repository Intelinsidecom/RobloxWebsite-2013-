using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarTypeEntityFactory : IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarTypeEntity" /> with the given ID, or null if none existed.</returns>
	IUniverseAvatarTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarTypeEntity" /> with the given value
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarTypeEntity" /> with the given value
	/// </returns>
	IUniverseAvatarTypeEntity GetByValue(string value);
}
