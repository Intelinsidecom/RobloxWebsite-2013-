using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar;
using Roblox.Platform.Badges;
using Roblox.Platform.Core;
using Roblox.Platform.Thumbnails.Repository;
using Roblox.Platform.Universes;
using Roblox.Thumbnails.Client;
using Roblox.Thumbnails.RequestValidation;
using Roblox.Thumbs.Properties;
using Roblox.Web.Thumbnails;

namespace Roblox.Thumbs;

public class ThumbnailDomainFactories : DomainFactoriesBase
{
	private ICounterRegistry _CounterRegistry;

	internal ILogger Logger { get; }

	internal IThumbnailsClient ThumbnailsClient { get; }

	internal ThumbnailRepository ThumbnailRepository { get; }

	internal UniverseDomainFactories UniverseDomainFactories { get; }

	internal AssetDomainFactories AssetDomainFactories { get; }

	internal AvatarDomainFactories AvatarDomainFactories { get; }

	internal AvatarPlaceSettingsResolver AvatarPlaceSettingsResolver { get; }

	public IUniverseFactory UniverseFactory { get; }

	public IAssetAudioPropertyProvider AssetAudioPropertyProvider { get; }

	public ThumbnailRequestValidator ThumbnailRequestValidator { get; }

	public IAssetThumbnail Asset { get; }

	public IAvatarThumbnail Avatar { get; }

	public IStaticImages StaticImages { get; }

	public IThumbnailInvalidator ThumbnailInvalidator { get; }

	public IThumbnailDependenciesInvalidator ThumbnailDependenciesInvalidator { get; }

	public ThumbnailDomainFactories(ICounterRegistry counterRegistry, ILogger logger, AssetDomainFactories assetDomainFactories, AvatarDomainFactories avatarDomainFactories, UniverseDomainFactories universeDomainFactories, IBadgeReader badgeReader, IThumbnailsClient thumbnailsClient = null)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		if (badgeReader == null)
		{
			throw new ArgumentNullException("badgeReader");
		}
		Logger = logger ?? throw new ArgumentNullException("logger");
		if (thumbnailsClient == null)
		{
			ThumbnailsClient client = new ThumbnailsClient(logger, _CounterRegistry, (Func<string>)(() => Settings.Default.WebSiteApiKey));
			new ThumbnailHashEventStreamRegistrar(_CounterRegistry, client, Logger).RegisterEvents();
			ThumbnailsClient = (IThumbnailsClient)(object)client;
		}
		AssetDomainFactories = assetDomainFactories ?? throw new ArgumentNullException("assetDomainFactories");
		AvatarDomainFactories = avatarDomainFactories ?? throw new ArgumentNullException("avatarDomainFactories");
		UniverseDomainFactories = universeDomainFactories ?? throw new ArgumentNullException("universeDomainFactories");
		UniverseFactory = UniverseDomainFactories.UniverseFactory ?? throw new ArgumentNullException("UniverseFactory");
		ThumbnailRepository = new ThumbnailRepository();
		AvatarPlaceSettingsResolver = new AvatarPlaceSettingsResolver(Logger);
		AssetAudioPropertyProvider = new AssetAudioPropertyProvider();
		ThumbnailRequestValidator = new ThumbnailRequestValidator();
		Asset = new AssetThumbnail(this, badgeReader, assetDomainFactories.ImageFactory);
		Avatar = new AvatarThumbnail(this);
		StaticImages = new StaticImages(this);
		ThumbnailInvalidator = new ThumbnailInvalidator(this);
		ThumbnailDependenciesInvalidator = new ThumbnailDependenciesInvalidator(this);
	}
}
