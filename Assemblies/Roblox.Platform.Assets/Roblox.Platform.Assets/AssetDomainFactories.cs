using System;
using Roblox.Agents;
using Roblox.Assets.Client;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets.Entities;
using Roblox.Platform.Assets.Entities.AssetHash;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Assets.Events;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.TextFilter;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Assets;

/// <summary>
/// A container object for factories (and other stateless objects) of Platform.Assets.
/// </summary>
public class AssetDomainFactories : DomainFactoriesBase
{
	internal virtual IAgentFactory AgentFactory { get; }

	internal virtual ILogger Logger { get; }

	internal virtual IAssetEntityFactory AssetEntityFactory { get; }

	internal virtual IAssetTextFilter AssetTextFilter { get; }

	internal virtual IAssetsAuditEntryEntityFactory AssetsAuditEntriesEntityFactory { get; }

	internal virtual IAssetsAuditMetadataEntityFactory AssetsAuditMetadataEntityFactory { get; }

	internal virtual IAssetChangeTypesEntityFactory AssetChangeTypesEntityFactory { get; }

	internal virtual IAssetHashEntityFactory AssetHashEntityFactory { get; }

	internal virtual AssetChangeReporter AssetChangeReporter { get; }

	internal virtual IAssetVersionCreationEventPublisher AssetVersionCreationEventPublisher { get; }

	/// <summary>
	/// An <see cref="P:Roblox.Platform.Assets.AssetDomainFactories.AssetTypeFactory" /> with internal methods exposed to the rest of this assembly.
	/// </summary>
	internal virtual AssetTypeFactory AssetTypeFactoryInternal { get; }

	/// <summary>
	/// An <see cref="T:Roblox.Platform.Assets.AssetFactoryInstantiable" /> with internal methods exposed to the rest of this assembly.
	/// </summary>
	internal virtual AssetFactoryInstantiable AssetFactoryInternal { get; set; }

	/// <summary>
	/// An <see cref="T:Roblox.Platform.Assets.IAssetVersionFactory_Internal" /> with internal methods exposed to the rest of this assembly.
	/// </summary>
	internal virtual IAssetVersionFactory_Internal AssetVersionFactoryInternal { get; }

	public virtual ISettings Settings { get; }

	public virtual IAssetTypeFactory AssetTypeFactory => AssetTypeFactoryInternal;

	public virtual IAssetFactory AssetFactory => AssetFactoryInternal;

	public virtual IAssetVersionFactory AssetVersionFactory => AssetVersionFactoryInternal;

	public IRawContentFactory RawContentFactory { get; }

	public RobloxContentValidator RobloxContentValidator { get; }

	public virtual IAliasFactory AliasFactory { get; }

	public virtual IBadgeTypeFactory BadgeTypeFactory { get; }

	public virtual IAssetsClient AssetsClient { get; }

	public virtual AnimationFactory AnimationFactory { get; }

	public virtual ArmsFactory ArmsFactory { get; }

	public virtual AudioFactory AudioFactory { get; }

	public virtual BackAccessoryFactory BackAccessoryFactory { get; }

	public virtual BadgeFactory BadgeFactory { get; }

	public virtual DecalFactory DecalFactory { get; }

	public virtual FaceAccessoryFactory FaceAccessoryFactory { get; }

	public virtual FaceFactory FaceFactory { get; }

	public virtual FrontAccessoryFactory FrontAccessoryFactory { get; }

	public virtual GamePassFactory GamePassFactory { get; }

	public virtual GearFactory GearFactory { get; }

	public virtual HairAccessoryFactory HairAccessoryFactory { get; }

	public virtual HatFactory HatFactory { get; }

	public virtual HeadFactory HeadFactory { get; }

	public virtual HtmlFactory HtmlFactory { get; }

	public virtual ImageFactory ImageFactory { get; }

	public virtual LeftArmFactory LeftArmFactory { get; }

	public virtual LeftLegFactory LeftLegFactory { get; }

	public virtual LegsFactory LegsFactory { get; }

	public virtual LuaFactory LuaFactory { get; }

	public virtual MeshFactory MeshFactory { get; }

	public virtual MeshPartFactory MeshPartFactory { get; }

	public virtual ModelFactory ModelFactory { get; }

	public virtual NeckAccessoryFactory NeckAccessoryFactory { get; }

	public virtual PackageFactory PackageFactory { get; }

	public virtual PantsFactory PantsFactory { get; }

	public virtual PlaceFactory PlaceFactory { get; }

	public virtual PluginFactory PluginFactory { get; }

	public virtual RightArmFactory RightArmFactory { get; }

	public virtual RightLegFactory RightLegFactory { get; }

	public virtual ShirtFactory ShirtFactory { get; }

	public virtual ShoulderAccessoryFactory ShoulderAccessoryFactory { get; }

	public virtual SolidModelFactory SolidModelFactory { get; }

	public virtual TeeShirtFactory TeeShirtFactory { get; }

	public virtual TextFactory TextFactory { get; }

	public virtual TorsoFactory TorsoFactory { get; }

	public virtual WaistAccessoryFactory WaistAccessoryFactory { get; }

	public virtual YouTubeVideoFactory YouTubeVideoFactory { get; }

	public virtual ClimbAnimationFactory ClimbAnimationFactory { get; }

	public virtual DeathAnimationFactory DeathAnimationFactory { get; }

	public virtual FallAnimationFactory FallAnimationFactory { get; }

	public virtual IdleAnimationFactory IdleAnimationFactory { get; }

	public virtual JumpAnimationFactory JumpAnimationFactory { get; }

	public virtual RunAnimationFactory RunAnimationFactory { get; }

	public virtual SwimAnimationFactory SwimAnimationFactory { get; }

	public virtual WalkAnimationFactory WalkAnimationFactory { get; }

	public virtual PoseAnimationFactory PoseAnimationFactory { get; }

	public virtual LocalizationTableManifestFactory LocalizationTableManifestFactory { get; }

	public virtual LocalizationTableTranslationFactory LocalizationTableTranslationFactory { get; }

	public virtual EmoteAnimationFactory EmoteAnimationFactory { get; }

	public virtual VideoFactory VideoFactory { get; }

	public virtual IAccoutrementPackageItemFactory AccoutrementPackageItemFactory { get; }

	public virtual AccessChecker AccessChecker { get; }

	public virtual TexturePackFactory TexturePackFactory { get; }

	public virtual IAssetOptionFactory AssetOptionFactory { get; }

	/// <summary>
	/// Internal constructor for unit tests only
	/// </summary>
	internal AssetDomainFactories()
	{
	}

	/// <summary>
	/// AssetDomainFactories constructor - only using deprecated TextFilter
	/// </summary>
	/// <param name="agentFactory"><see cref="T:Roblox.Agents.IAgentFactory" /></param>
	/// <param name="textFilter"><see cref="T:Roblox.TextFilter.ITextFilter" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <remarks>The <see cref="T:Roblox.Platform.Assets.Events.AssetEventsPublisher" /> and <see cref="T:Roblox.Platform.Assets.AssetArchivalEventsPublisher" /> are not passed in by default, which is ppropriate for all cases except testing or when you must disable events to SNS.</remarks>
	[Obsolete]
	public AssetDomainFactories(IAgentFactory agentFactory, ITextFilter textFilter, ILogger logger, ICounterRegistry counterRegistry)
		: this(agentFactory, textFilter, null, logger, new AssetEventsPublisher(logger, counterRegistry), new AssetArchivalEventsPublisher(logger, counterRegistry), counterRegistry)
	{
	}

	/// <summary>
	/// AssetDomainFactories constructor - only using TextFilterClientV2
	/// </summary>
	/// <param name="agentFactory"><see cref="T:Roblox.Agents.IAgentFactory" /></param>
	/// <param name="textFilterClientV2"><see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <remarks>The <see cref="T:Roblox.Platform.Assets.Events.AssetEventsPublisher" /> and <see cref="T:Roblox.Platform.Assets.AssetArchivalEventsPublisher" /> are not passed in by default, which is ppropriate for all cases except testing or when you must disable events to SNS.</remarks>
	public AssetDomainFactories(IAgentFactory agentFactory, ITextFilterClientV2 textFilterClientV2, ILogger logger, ICounterRegistry counterRegistry)
		: this(agentFactory, null, textFilterClientV2, logger, new AssetEventsPublisher(logger, counterRegistry), new AssetArchivalEventsPublisher(logger, counterRegistry), counterRegistry)
	{
	}

	/// <summary>
	/// AssetDomainFactories constructor
	/// </summary>
	/// <param name="agentFactory"><see cref="T:Roblox.Agents.IAgentFactory" /></param>
	/// <param name="textFilter"><see cref="T:Roblox.TextFilter.ITextFilter" /></param>
	/// <param name="textFilterClientV2"><see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <remarks>The <see cref="T:Roblox.Platform.Assets.Events.AssetEventsPublisher" /> and <see cref="T:Roblox.Platform.Assets.AssetArchivalEventsPublisher" /> are not passed in by default, which is ppropriate for all cases except testing or when you must disable events to SNS.</remarks>
	public AssetDomainFactories(IAgentFactory agentFactory, ITextFilter textFilter, ITextFilterClientV2 textFilterClientV2, ILogger logger, ICounterRegistry counterRegistry)
		: this(agentFactory, textFilter, textFilterClientV2, logger, new AssetEventsPublisher(logger, counterRegistry), new AssetArchivalEventsPublisher(logger, counterRegistry), counterRegistry)
	{
	}

	/// <summary>
	/// AssetDomainFactories constructor - only using deprecated TextFilter
	/// </summary>
	/// <param name="agentFactory"><see cref="T:Roblox.Agents.IAgentFactory" /></param>
	/// <param name="textFilter"><see cref="T:Roblox.TextFilter.ITextFilter" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="assetEventsObserver"><see cref="T:Roblox.Platform.Assets.Events.AssetEventsPublisher" /></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <param name="assetArchivalEventsObserver"><see cref="T:Roblox.Platform.Assets.AssetArchivalEventsPublisher" /></param>
	[Obsolete]
	public AssetDomainFactories(IAgentFactory agentFactory, ITextFilter textFilter, ILogger logger, IAssetEventsObserver assetEventsObserver, IAssetEventsObserver assetArchivalEventsObserver, ICounterRegistry counterRegistry)
		: this(agentFactory, textFilter, null, logger, assetEventsObserver, assetArchivalEventsObserver, counterRegistry)
	{
	}

	/// <summary>
	/// AssetDomainFactories constructor - only using TextFilterClientV2
	/// </summary>
	/// <param name="agentFactory"><see cref="T:Roblox.Agents.IAgentFactory" /></param>
	/// <param name="textFilterClientV2"><see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="assetEventsObserver"><see cref="T:Roblox.Platform.Assets.Events.AssetEventsPublisher" /></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <param name="assetArchivalEventsObserver"><see cref="T:Roblox.Platform.Assets.AssetArchivalEventsPublisher" /></param>
	public AssetDomainFactories(IAgentFactory agentFactory, ITextFilterClientV2 textFilterClientV2, ILogger logger, IAssetEventsObserver assetEventsObserver, IAssetEventsObserver assetArchivalEventsObserver, ICounterRegistry counterRegistry)
		: this(agentFactory, null, textFilterClientV2, logger, assetEventsObserver, assetArchivalEventsObserver, counterRegistry)
	{
	}

	/// <summary>
	/// AssetDomainFactories constructor
	/// </summary>
	/// <param name="agentFactory"><see cref="T:Roblox.Agents.IAgentFactory" /></param>
	/// <param name="textFilter"><see cref="T:Roblox.TextFilter.ITextFilter" /></param>
	/// <param name="textFilterClientV2"><see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="assetEventsObserver"><see cref="T:Roblox.Platform.Assets.Events.AssetEventsPublisher" /></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <param name="assetArchivalEventsObserver"><see cref="T:Roblox.Platform.Assets.AssetArchivalEventsPublisher" /></param>
	public AssetDomainFactories(IAgentFactory agentFactory, ITextFilter textFilter, ITextFilterClientV2 textFilterClientV2, ILogger logger, IAssetEventsObserver assetEventsObserver, IAssetEventsObserver assetArchivalEventsObserver, ICounterRegistry counterRegistry)
		: this(agentFactory, textFilter, textFilterClientV2, logger, assetEventsObserver, assetArchivalEventsObserver, counterRegistry, Roblox.Platform.Assets.Properties.Settings.Default)
	{
	}

	/// <summary>
	/// AssetDomainFactories constructor - With settings as a parameter. For internal testing only.
	/// </summary>
	/// <param name="agentFactory"><see cref="T:Roblox.Agents.IAgentFactory" /></param>
	/// <param name="textFilter"><see cref="T:Roblox.TextFilter.ITextFilter" /></param>
	/// <param name="textFilterClientV2"><see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="assetEventsObserver"><see cref="T:Roblox.Platform.Assets.Events.AssetEventsPublisher" /></param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <param name="assetArchivalEventsObserver"><see cref="T:Roblox.Platform.Assets.AssetArchivalEventsPublisher" /></param>
	/// <param name="settings"><see cref="T:Roblox.Platform.Assets.Properties.ISettings" /></param>
	internal AssetDomainFactories(IAgentFactory agentFactory, ITextFilter textFilter, ITextFilterClientV2 textFilterClientV2, ILogger logger, IAssetEventsObserver assetEventsObserver, IAssetEventsObserver assetArchivalEventsObserver, ICounterRegistry counterRegistry, ISettings settings)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		if (assetEventsObserver == null)
		{
			throw new PlatformArgumentNullException("assetEventsObserver");
		}
		if (assetArchivalEventsObserver == null)
		{
			throw new PlatformArgumentNullException("assetArchivalEventsObserver");
		}
		AgentFactory = agentFactory ?? throw new PlatformArgumentNullException("agentFactory");
		Logger = logger ?? throw new PlatformArgumentNullException("logger");
		AssetChangeReporter assetChangeReporter = (AssetChangeReporter = new AssetChangeReporter());
		assetEventsObserver.Subscribe(assetChangeReporter);
		assetArchivalEventsObserver.Subscribe(assetChangeReporter);
		AssetsClient = (IAssetsClient)new AssetsClient((Func<string>)(() => Roblox.Platform.Assets.Properties.Settings.Default.AssetsClientAPIKey));
		Factories.SetSingleton(this);
		AssetEntityFactory = new AssetEntityFactory(this);
		AssetsAuditEntriesEntityFactory = new AssetsAuditEntryEntityFactory(this);
		AssetsAuditMetadataEntityFactory = new AssetsAuditMetadataEntityFactory(this);
		AssetChangeTypesEntityFactory = new AssetChangeTypeEntityFactory(this);
		Settings = settings;
		if (textFilterClientV2 == null)
		{
			if (settings.DisableAssetTextFilter)
			{
				throw new PlatformArgumentNullException("textFilterClientV2");
			}
			if (textFilter == null)
			{
				throw new PlatformArgumentNullException("textFilter");
			}
			AssetTextFilter = new AssetTextFilter(textFilter, settings);
		}
		else
		{
			AssetTextFilter = new AssetTextFilterV2(textFilterClientV2, settings);
		}
		AssetHashEntityFactory = new AssetHashEntityFactory();
		AssetVersionCreationEventPublisher = new AssetVersionCreationEventPublisher(settings, counterRegistry);
		Roblox.Platform.Assets.AssetTypeFactory.Singleton = (AssetTypeFactoryInternal = new AssetTypeFactory());
		Roblox.Platform.Assets.AssetVersionFactory.Singleton = (AssetVersionFactoryInternal = new AssetVersionFactory(this));
		RobloxContentValidator robloxContentValidator = (RobloxContentValidator = new RobloxContentValidator(logger));
		RawContentFactory = new RawContentFactory(AssetHashEntityFactory, robloxContentValidator);
		AliasFactory = new AliasFactory();
		IBadgeTypeFactory badgeTypeFactory = (BadgeTypeFactory = new BadgeTypeFactory());
		AnimationFactory = new AnimationFactory(this);
		ArmsFactory = new ArmsFactory(this);
		AudioFactory = new AudioFactory(this);
		BackAccessoryFactory = new BackAccessoryFactory(this);
		BadgeFactory = new BadgeFactory(this, badgeTypeFactory);
		DecalFactory = new DecalFactory(this);
		FaceAccessoryFactory = new FaceAccessoryFactory(this);
		FaceFactory = new FaceFactory(this);
		FrontAccessoryFactory = new FrontAccessoryFactory(this);
		GamePassFactory = new GamePassFactory(this);
		GearFactory = new GearFactory(this);
		HairAccessoryFactory = new HairAccessoryFactory(this);
		HatFactory = new HatFactory(this);
		HeadFactory = new HeadFactory(this);
		HtmlFactory = new HtmlFactory(this);
		ImageFactory = new ImageFactory(this);
		LeftArmFactory = new LeftArmFactory(this);
		LeftLegFactory = new LeftLegFactory(this);
		LegsFactory = new LegsFactory(this);
		LuaFactory = new LuaFactory(this);
		MeshFactory = new MeshFactory(this);
		MeshPartFactory = new MeshPartFactory(this);
		ModelFactory = new ModelFactory(this);
		NeckAccessoryFactory = new NeckAccessoryFactory(this);
		PackageFactory = new PackageFactory(this);
		PantsFactory = new PantsFactory(this);
		PlaceFactory = new PlaceFactory(this);
		PluginFactory = new PluginFactory(this);
		RightArmFactory = new RightArmFactory(this);
		RightLegFactory = new RightLegFactory(this);
		ShirtFactory = new ShirtFactory(this);
		ShoulderAccessoryFactory = new ShoulderAccessoryFactory(this);
		SolidModelFactory = new SolidModelFactory(this);
		TeeShirtFactory = new TeeShirtFactory(this);
		TextFactory = new TextFactory(this);
		TorsoFactory = new TorsoFactory(this);
		WaistAccessoryFactory = new WaistAccessoryFactory(this);
		YouTubeVideoFactory = new YouTubeVideoFactory(this);
		LocalizationTableManifestFactory = new LocalizationTableManifestFactory(this);
		LocalizationTableTranslationFactory = new LocalizationTableTranslationFactory(this);
		EmoteAnimationFactory = new EmoteAnimationFactory(this);
		VideoFactory = new VideoFactory(this);
		TexturePackFactory = new TexturePackFactory(this);
		ClimbAnimationFactory = new ClimbAnimationFactory(this);
		DeathAnimationFactory = new DeathAnimationFactory(this);
		FallAnimationFactory = new FallAnimationFactory(this);
		IdleAnimationFactory = new IdleAnimationFactory(this);
		JumpAnimationFactory = new JumpAnimationFactory(this);
		RunAnimationFactory = new RunAnimationFactory(this);
		SwimAnimationFactory = new SwimAnimationFactory(this);
		WalkAnimationFactory = new WalkAnimationFactory(this);
		PoseAnimationFactory = new PoseAnimationFactory(this);
		AccoutrementPackageItemFactory = new AccoutrementPackageItemFactory();
		AssetOwnershipAuthority assetOwnershipAuthorityLocal = new AssetOwnershipAuthority((long assetId) => AssetEntityFactory.MustGet(assetId).TypeId, "Roblox.Platform.Assets", logger);
		AccessChecker = new AccessChecker(assetOwnershipAuthorityLocal);
		Roblox.Platform.Assets.AssetFactory.Singleton = (AssetFactoryInternal = new AssetFactoryInstantiable(this));
		AssetOptionFactory = new AssetOptionFactory(AssetsClient, Logger);
	}

	public virtual IAssetsAuditCompositeEntryFactory GetAssetsAuditCompositeEntryFactory(IUserFactory userFactory)
	{
		return new AssetsAuditCompositeEntryFactory(this, userFactory);
	}
}
