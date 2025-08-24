using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

/// <inheritdoc cref="T:Roblox.Platform.Assets.ILocalizationTableManifestFactory" />
public class LocalizationTableManifestFactory : AssetFactoryBase<ILocalizationTableManifest>, ILocalizationTableManifestFactory, IAssetFactoryBase<ILocalizationTableManifest>
{
	protected override int AssetTypeId => Roblox.AssetType.LocalizationTableManifestID;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Assets.LocalizationTableManifestFactory" />
	/// </summary>
	/// <param name="domainFactories">The <see cref="T:Roblox.Platform.Assets.AssetDomainFactories" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null.</exception>
	public LocalizationTableManifestFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ILocalizationTableManifest BuildChildAsset(IAsset genericAsset)
	{
		return new LocalizationTableManifest(base.DomainFactories, genericAsset);
	}

	internal ILocalizationTableManifest GetLocalizationTableManifest(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Assets.ILocalizationTableManifestFactory.CreateWithTrustedAssetText(Roblox.Platform.Assets.ITrustedAssetTextInfo,Roblox.Platform.Assets.AssetCreatorInfo,Roblox.Platform.Assets.StreamCreatorInfo,Roblox.Platform.MembershipCore.IUserIdentifier)" />&gt;
	public ILocalizationTableManifest CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity)
	{
		return Create(trustedAssetTextInfo, assetCreatorInfo, stream, actorUserIdentity);
	}
}
