using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Outfits.Properties;

namespace Roblox.Platform.Outfits;

/// <summary>
/// The <seealso cref="T:Roblox.Platform.Core.DomainFactoriesBase">DomainFactories</seealso> object for Roblox.Platform.Outfits.
/// </summary>
public class OutfitDomainFactories : DomainFactoriesBase
{
	public virtual IUserOutfitFactory UserOutfitFactory { get; }

	public virtual IOutfitRulesManager OutfitRulesManager { get; }

	public virtual IBodyColorSetFactory BodyColorSetFactory { get; }

	public virtual IBrickBodyColorSetFactory BrickBodyColorSetFactory { get; }

	public virtual IRawContentFactory RawContentFactory { get; }

	public virtual IBodyColorsXmlSerializer BodyColorsXmlSerializer { get; }

	public virtual IOutfitFactory OutfitFactory { get; }

	public virtual IBodyColorsPerformanceCounter BodyColorsPerformanceCounter { get; }

	public virtual IScaleFactory ScaleFactory { get; }

	public virtual IScaleAuthority ScaleAuthority { get; }

	public virtual IPlayerAvatarTypeEntityFactory PlayerAvatarTypeEntityFactory { get; }

	public virtual IOutfitAccoutrementFactory OutfitAccoutrementFactory { get; }

	public virtual ITemporaryOutfitFactory TemporaryOutfitFactory { get; }

	public virtual ScaleRules ScaleRules { get; }

	internal virtual IScaleEntityFactory ScaleEntityFactory { get; }

	internal virtual IAssetTypeFactory AssetTypeFactory { get; }

	internal virtual IAssetFactory AssetFactory { get; }

	internal virtual IUserOutfitEntityFactory UserOutfitEntityFactory { get; }

	internal virtual OutfitKeyGenerator OutfitKeyGenerator { get; }

	internal virtual IOutfitEntityFactory OutfitEntityFactory { get; }

	internal virtual ISettings Settings { get; }

	/// <summary>
	/// Only for use by unit tests
	/// </summary>
	internal OutfitDomainFactories()
	{
	}

	public OutfitDomainFactories(ICounterRegistry registry, IRawContentFactory rawContentFactory, IAssetTypeFactory assetTypeFactory, IAssetFactory assetFactory)
	{
		Settings = Roblox.Platform.Outfits.Properties.Settings.Default;
		OutfitFactory = new OutfitFactory(this);
		UserOutfitFactory = new UserOutfitFactory(this);
		UserOutfitEntityFactory = new UserOutfitEntityFactory(this);
		OutfitRulesManager = new OutfitRulesManager(this);
		BodyColorSetFactory = new BodyColorSetFactory(this);
		BrickBodyColorSetFactory = new BrickBodyColorSetFactory(this);
		BodyColorsXmlSerializer = new BodyColorsXmlSerializer(this);
		BodyColorsPerformanceCounter = new BodyColorsPerformanceCounter(registry);
		ScaleEntityFactory = new ScaleEntityFactory(this);
		ScaleFactory = new ScaleFactory(this);
		ScaleAuthority = new ScaleAuthority();
		PlayerAvatarTypeEntityFactory = new PlayerAvatarTypeEntityFactory(this);
		OutfitKeyGenerator = new OutfitKeyGenerator(this, RobloxEnvironment.WebsiteUrl);
		RawContentFactory = rawContentFactory ?? throw new PlatformArgumentNullException("rawContentFactory");
		AssetTypeFactory = assetTypeFactory ?? throw new PlatformArgumentNullException("assetTypeFactory");
		AssetFactory = assetFactory ?? throw new PlatformArgumentNullException("assetFactory");
		OutfitEntityFactory = new OutfitEntityFactory(this);
		TemporaryOutfitFactory = new TemporaryOutfitFactory(this);
		OutfitAccoutrementFactory = new OutfitAccoutrementFactory();
	}
}
