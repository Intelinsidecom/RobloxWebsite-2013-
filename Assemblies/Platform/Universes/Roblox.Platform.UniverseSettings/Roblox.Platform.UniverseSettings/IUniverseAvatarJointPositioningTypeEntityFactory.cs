using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarJointPositioningTypeEntityFactory : IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarJointPositioningTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarJointPositioningTypeEntity" /> with the given ID, or null if none existed.</returns>
	IUniverseAvatarJointPositioningTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarJointPositioningTypeEntity" /> with the given value.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarJointPositioningTypeEntity" /> with the given value.</returns>
	IUniverseAvatarJointPositioningTypeEntity GetByValue(string value);
}
