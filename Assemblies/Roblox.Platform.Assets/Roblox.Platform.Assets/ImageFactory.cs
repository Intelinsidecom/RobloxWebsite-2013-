using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class ImageFactory : AssetFactoryBase<IImage>, IImageFactory, IAssetFactoryBase<IImage>
{
	protected override int AssetTypeId => Roblox.AssetType.ImageID;

	internal ImageFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IImage BuildChildAsset(IAsset genericAsset)
	{
		return new Image(base.DomainFactories, genericAsset);
	}

	internal IImage GetImage(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Assets.IImageFactory.CreateWithTrustedAssetText(Roblox.Platform.Assets.ITrustedAssetTextInfo,Roblox.Platform.Assets.AssetCreatorInfo,Roblox.Platform.Assets.StreamCreatorInfo,Roblox.Platform.MembershipCore.IUserIdentifier,System.String)" />
	public IImage CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity, string localeCodeOverride = null)
	{
		return Create(trustedAssetTextInfo, assetCreatorInfo, stream, actorUserIdentity, localeCodeOverride);
	}
}
