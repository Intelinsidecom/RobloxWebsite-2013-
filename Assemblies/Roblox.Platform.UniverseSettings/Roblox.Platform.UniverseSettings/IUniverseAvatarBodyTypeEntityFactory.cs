using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarBodyTypeEntityFactory : IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarBodyTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarBodyTypeEntity" /> with the given ID, or null if none existed.</returns>
	IUniverseAvatarBodyTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarBodyTypeEntity" /> with the given value.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarBodyTypeEntity" /> with the given value.</returns>
	IUniverseAvatarBodyTypeEntity GetByValue(string value);
}
