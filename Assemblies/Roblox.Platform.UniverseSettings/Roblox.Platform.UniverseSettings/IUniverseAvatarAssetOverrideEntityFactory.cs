using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal interface IUniverseAvatarAssetOverrideEntityFactory : IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarAssetOverrideEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.UniverseSettings.IUniverseAvatarAssetOverrideEntity" /> with the given ID, or null if none existed.</returns>
	IUniverseAvatarAssetOverrideEntity Get(long id);
}
