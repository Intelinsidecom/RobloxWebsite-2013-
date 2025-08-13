using System;
using Roblox.Avatar.Client;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;
using Roblox.Redis;
using Roblox.ServiceDiscovery;

namespace Roblox.Platform.Avatar;

public class AvatarDomainFactories : DomainFactoriesBase
{
	private const string _RedisPerformanceMonitorCategory = "Roblox.Platform.Avatar.Redis";

	/// <summary>
	/// Type table for RecentItemListType
	/// </summary>
	internal virtual IRecentItemListTypeEntityFactory RecentItemListTypeEntityFactory { get; }

	/// <summary>
	/// Type table for RecentItemType
	/// </summary>
	internal virtual IRecentItemTypeEntityFactory RecentItemTypeEntityFactory { get; }

	/// <summary>
	/// Table that contains rows that represent lists of recently worn avatar items
	/// </summary>
	internal virtual IRecentItemListEntityFactory RecentItemListEntityFactory { get; }

	internal virtual IAvatarTracker AvatarTracker { get; }

	public virtual IAvatarFactory AvatarFactory { get; }

	public virtual IUserAvatarFactory UserAvatarFactory { get; }

	public virtual IAccoutrementFactory AccoutrementFactory { get; }

	public virtual IAccoutrementBuilder AccoutrementBuilder { get; }

	public virtual IRecentAvatarItemPublisher RecentAvatarItemPublisher { get; }

	internal virtual IRecentAvatarItemListener RecentAvatarItemListener { get; }

	internal virtual IUserAvatarListener UserAvatarListener { get; }

	public virtual IAvatarPermissionVerifier AvatarPermissionVerifier { get; }

	public virtual ITryOnFactory TryOnFactory { get; }

	internal virtual IAssetFactory AssetFactory { get; }

	public virtual IAssetTypeFactory AssetTypeFactory { get; }

	internal virtual IAvatarAssetGroupFactory AvatarAssetGroupFactory { get; }

	public virtual OutfitDomainFactories OutfitDomainFactories { get; set; }

	public virtual DefaultClothingEnforcer DefaultClothingEnforcer { get; }

	public virtual AvatarKeyGenerator AvatarKeyGenerator { get; }

	public virtual IAvatarOwnershipFactory AvatarOwnershipFactory { get; }

	internal virtual IAccoutrementPackageItemFactory AccoutrementPackageItemFactory { get; }

	internal virtual IAssetFactoryBase<IPackage> PackageFactory { get; }

	public virtual IRawContentFactory RawContentFactory { get; }

	public AvatarPlaceSettingsResolver AvatarPlaceSettingsResolver { get; }

	public virtual AccoutrementRulesAuthority AccoutrementRulesAuthority { get; }

	internal virtual IAvatarChangeIdentifier AvatarChangeIdentifier { get; }

	internal IAssetOwnershipAuthority AssetOwnershipAuthority { get; }

	internal IEmoteConfigurationEntityFactory EmoteConfigurationEntityFactory { get; }

	internal IEmoteConfigurationCache EmoteConfigurationRedisCache { get; }

	internal EntityPerformanceMonitor EntityPerformanceMonitor { get; }

	public virtual ILogger Logger { get; }

	internal virtual ISettings Settings { get; }

	public bool TrackingEnabled()
	{
		return AvatarTracker != null;
	}

	/// <summary>
	/// Used only for tests
	/// </summary>
	internal AvatarDomainFactories()
	{
	}

	/// <summary>
	/// If avatarTracker is not null, logging to diag and eventstream will happen automatically
	/// </summary>
	[Obsolete("Use the other constructor.")]
	public AvatarDomainFactories(ILogger logger, IAvatarClient avatarClient, IAvatarTracker avatarTracker = null)
		: this(new MembershipDomainFactories(logger, StaticCounterRegistry.Instance).UserFactory, Factories.DomainFactories.AssetFactory, new AssetOwnershipAuthority(Asset.LookupAssetTypeId, "Roblox.Platform.Avatar", logger), Factories.DomainFactories.AssetTypeFactory, new OutfitDomainFactories(StaticCounterRegistry.Instance, Factories.DomainFactories.RawContentFactory, Factories.DomainFactories.AssetTypeFactory, Factories.DomainFactories.AssetFactory), Factories.DomainFactories.RawContentFactory, logger, avatarClient, avatarTracker)
	{
	}

	/// <summary>
	/// If avatarTracker is not null, logging to diag and eventstream will happen automatically
	/// </summary>
	public AvatarDomainFactories(IUserFactory userFactory, IAssetFactory assetFactory, IAssetOwnershipAuthority assetOwnershipAuthority, IAssetTypeFactory assetTypeFactory, OutfitDomainFactories outfitDomainFactories, IRawContentFactory rawContentFactory, ILogger logger, IAvatarClient avatarClient, IAvatarTracker avatarTracker = null)
	{
		if (userFactory == null)
		{
			throw new PlatformArgumentNullException("userFactory");
		}
		if (avatarClient == null)
		{
			throw new PlatformArgumentNullException("avatarClient");
		}
		Logger = logger ?? throw new PlatformArgumentNullException("logger");
		OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
		AssetFactory = assetFactory ?? throw new PlatformArgumentNullException("assetFactory");
		AssetTypeFactory = assetTypeFactory ?? throw new PlatformArgumentNullException("assetTypeFactory");
		AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new PlatformArgumentNullException("assetOwnershipAuthority");
		Settings settings = Roblox.Platform.Avatar.Properties.Settings.Default;
		Settings = settings;
		DefaultClothingEnforcer = new DefaultClothingEnforcer();
		AvatarKeyGenerator = new AvatarKeyGenerator(outfitDomainFactories, RobloxEnvironment.WebsiteUrl, logger);
		AvatarTracker = avatarTracker;
		CounterRegistry counterRegistry = new CounterRegistry();
		CounterReporter.CreateAndStart(counterRegistry, logger.Error);
		EntityPerformanceMonitor = new EntityPerformanceMonitor(counterRegistry, logger);
		Accoutrement.EntityCRUD += EntityPerformanceMonitor.AccoutrementCRUDEvent;
		Accoutrement.AvatarClient = avatarClient;
		LocalConsulClientProvider consulClientProvider = new LocalConsulClientProvider();
		ConsulHttpServiceResolver consulServiceResolver = new ConsulHttpServiceResolver(logger, consulClientProvider, Roblox.Platform.Avatar.Properties.Settings.Default.ToSingleSetting((Settings s) => s.RedisServiceName));
		HybridRedisClientProvider redisClientFactory = new HybridRedisClientProvider(logger, counterRegistry, consulServiceResolver, "Roblox.Platform.Avatar.Redis", Roblox.Platform.Avatar.Properties.Settings.Default.ToSingleSetting((Settings s) => s.IsRedisServiceDiscoveryEnabled), Roblox.Platform.Avatar.Properties.Settings.Default.ToSingleSetting((Settings s) => s.RedisEndpoints));
		RecentItemListTypeEntityFactory = new RecentItemListTypeEntityFactory(this);
		RecentItemTypeEntityFactory = new RecentItemTypeEntityFactory(this);
		RecentItemListEntityFactory = new RecentItemListEntityFactory(this);
		UserAvatarFactory userAvatarFactory = (UserAvatarFactory)(UserAvatarFactory = new UserAvatarFactory(this));
		AccoutrementBuilder accoutrementBuilder = new AccoutrementBuilder();
		AccoutrementBuilder = accoutrementBuilder;
		AccoutrementFactory accoutrementFactory = (AccoutrementFactory)(AccoutrementFactory = new AccoutrementFactory());
		AccoutrementPackageItemFactory = new AccoutrementPackageItemFactory();
		PackageFactory = new PackageFactory(Factories.DomainFactories);
		EmoteConfigurationEntityFactory = new EmoteConfigurationEntityFactory(this);
		EmoteConfigurationRedisCache = new EmoteConfigurationRedisCache(redisClientFactory.Client);
		AvatarOwnershipFactory avatarOwnershipFactory = new AvatarOwnershipFactory(assetOwnershipAuthority);
		AvatarOwnershipFactory = avatarOwnershipFactory;
		AvatarFactory = new AvatarFactory(userFactory, this);
		AvatarAssetGroupFactory = new AvatarAssetGroupFactory();
		RecentAvatarItemPublisher = new RecentAvatarItemPublisher(this, userFactory);
		RecentAvatarItemListener = new RecentAvatarItemListener(this, logger);
		UserAvatarListener = new UserAvatarListener(userAvatarFactory, accoutrementFactory);
		AvatarChangeIdentifier = new AvatarChangeIdentifier();
		AccoutrementRulesAuthority = new AccoutrementRulesAuthority(this);
		RawContentFactory = rawContentFactory;
		AvatarPermissionVerifier = new AvatarPermissionVerifier();
		AvatarPlaceSettingsResolver = new AvatarPlaceSettingsResolver(logger);
		TryOnFactory = new TryOnFactory(this);
	}

	/// <summary>
	/// Methods to register event handlers for Recent Avatar Item changes and clear thumbnail events for UserAvatars
	/// Do NOT override these methods unless you know what you're doing - they are virtual to facilitate testability.
	/// </summary>
	public virtual void RegisterListeners()
	{
		UserAvatarListener.Register();
		RecentAvatarItemListener.Register();
	}

	/// <summary>
	/// Methods to unregister event handlers for Recent Avatar Item changes and clear thumbnail events for UserAvatars
	/// Do NOT override these methods unless you know what you're doing - they are virtual to facilitate testability.
	/// </summary>
	public virtual void UnregisterListeners()
	{
		UserAvatarListener?.Unregister();
		RecentAvatarItemListener?.Unregister();
	}
}
