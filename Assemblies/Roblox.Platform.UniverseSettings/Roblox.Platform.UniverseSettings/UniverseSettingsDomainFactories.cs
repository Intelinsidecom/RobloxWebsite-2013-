using Roblox.Instrumentation;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Outfits;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseSettings;

public sealed class UniverseSettingsDomainFactories : DomainFactoriesBase
{
	/// <summary>
	/// storage for per-universe related settings.  For now, there are only avatar-related settings.
	/// </summary>
	internal IUniverseAvatarTypeEntityFactory UniverseAvatarTypeEntityFactory { get; }

	internal IUniverseScaleTypeEntityFactory UniverseScaleTypeEntityFactory { get; }

	internal IUniverseAvatarAnimationTypeEntityFactory UniverseAvatarAnimationTypeEntityFactory { get; }

	internal IUniverseAvatarCollisionTypeEntityFactory UniverseAvatarCollisionTypeEntityFactory { get; }

	internal IUniverseAvatarBodyTypeEntityFactory UniverseAvatarBodyTypeEntityFactory { get; }

	internal IUniverseAvatarJointPositioningTypeEntityFactory UniverseAvatarJointPositioningTypeEntityFactory { get; }

	internal IUniverseAvatarSettingsEntityFactory UniverseAvatarSettingsEntityFactory { get; }

	internal IScaleFactory ScaleFactory { get; }

	public IUniverseSettingsFactory UniverseSettingsFactory { get; }

	public IUniverseSettingsFactoryForAdmins UniverseSettingsFactoryForAdmins { get; }

	/// <summary>
	/// Factory to manipulate AssetOverrides in UniverseAvatarSettings
	/// </summary>
	public IUniverseAvatarAssetOverrideFactory UniverseAvatarAssetOverrideFactory { get; }

	/// <summary>
	/// Factory to manipulate AvatarScales in UniverseAvatarSettings
	/// </summary>
	public IUniverseAvatarScaleFactory UniverseAvatarScaleFactory { get; }

	public UniverseSettingsDomainFactories(UniverseDomainFactories universeDomainFactories, GroupMembershipFactory groupMembershipFactory, IRawContentFactory rawContentFactory, IAssetTypeFactory assetTypeFactory, IAssetFactory assetFactory, ICounterRegistry counterRegistry)
	{
		OutfitDomainFactories outfitDomainFactories = new OutfitDomainFactories(counterRegistry, rawContentFactory, assetTypeFactory, assetFactory);
		IScaleFactory scaleFactory = (ScaleFactory = outfitDomainFactories.ScaleFactory);
		UniverseScaleTypeEntityFactory = new UniverseScaleTypeEntityFactory(this);
		UniverseAvatarTypeEntityFactory = new UniverseAvatarTypeEntityFactory(this);
		UniverseAvatarAnimationTypeEntityFactory = new UniverseAvatarAnimationTypeEntityFactory(this);
		UniverseAvatarCollisionTypeEntityFactory = new UniverseAvatarCollisionTypeEntityFactory(this);
		UniverseAvatarBodyTypeEntityFactory = new UniverseAvatarBodyTypeEntityFactory(this);
		UniverseAvatarJointPositioningTypeEntityFactory = new UniverseAvatarJointPositioningTypeEntityFactory(this);
		UniverseAvatarAssetOverrideEntityFactory universeAvatarAssetOverrideEntityFactory = new UniverseAvatarAssetOverrideEntityFactory(this);
		UniverseAvatarSettingsEntityFactory = new UniverseAvatarSettingsEntityFactory(this);
		UniverseAvatarAssetOverrideFactory = new UniverseAvatarAssetOverrideFactory(assetFactory, universeAvatarAssetOverrideEntityFactory);
		UniverseSettingsFactory universeSettingsFactory = new UniverseSettingsFactory(UniverseAvatarSettingsEntityFactory, UniverseAvatarAssetOverrideFactory, universeDomainFactories, groupMembershipFactory, scaleFactory, outfitDomainFactories);
		UniverseAvatarScaleFactory = new UniverseAvatarScaleFactory(universeSettingsFactory, outfitDomainFactories);
		UniverseSettingsFactory = universeSettingsFactory;
		UniverseSettingsFactoryForAdmins = new UniverseSettingsFactory(UniverseAvatarSettingsEntityFactory, UniverseAvatarAssetOverrideFactory, universeDomainFactories, groupMembershipFactory, scaleFactory, outfitDomainFactories);
	}
}
