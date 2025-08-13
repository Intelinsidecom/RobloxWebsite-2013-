using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseScaleTypeEntityFactory : IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.UniverseSettings.IUniverseScaleTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseScaleTypeEntity" /> with the given ID, or null if none existed.
	/// </returns>
	IUniverseScaleTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.UniverseSettings.IUniverseScaleTypeEntity" /> with the given value
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseScaleTypeEntity" /> with the given value
	/// </returns>
	IUniverseScaleTypeEntity GetByValue(string value);
}
