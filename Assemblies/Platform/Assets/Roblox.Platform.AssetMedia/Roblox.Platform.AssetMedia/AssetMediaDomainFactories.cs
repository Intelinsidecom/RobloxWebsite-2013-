using System;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.AssetMedia.Properties;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Assets.Interface;
using Roblox.Platform.Core;
using Roblox.Thumbs;

namespace Roblox.Platform.AssetMedia;

public class AssetMediaDomainFactories : DomainFactoriesBase
{
	public IAssetMediaThumbnailUploader ThumbnailUploader { get; }

	internal AssetDomainFactories AssetDomainFactories { get; }

	internal IAssetOwnershipAuthority AssetOwnershipAuthority { get; }

	internal IEphemeralCounterFactory EphemeralCounterFactory { get; }

	public ISettings Settings { get; }

	internal ILogger Logger { get; }

	public AssetMediaDomainFactories(ILogger logger, AssetDomainFactories assetDomainFactories, IAssetOwnershipAuthority assetOwnershipAuthority, IEphemeralCounterFactory ephemeralCounterFactory, ThumbnailDomainFactories thumbnailDomainFactories, IUploadFloodcheckerFactory uploadFloodCheckerFactory)
	{
		if (uploadFloodCheckerFactory == null)
		{
			throw new ArgumentNullException("uploadFloodCheckerFactory");
		}
		Logger = logger ?? throw new ArgumentNullException("logger");
		AssetDomainFactories = assetDomainFactories ?? throw new ArgumentNullException("assetDomainFactories");
		AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new ArgumentNullException("assetOwnershipAuthority");
		EphemeralCounterFactory = ephemeralCounterFactory ?? throw new ArgumentNullException("ephemeralCounterFactory");
		ThumbnailUploader = new AssetMediaThumbnailUploader(this, thumbnailDomainFactories, uploadFloodCheckerFactory);
		Settings = Roblox.Platform.AssetMedia.Properties.Settings.Default;
	}
}
