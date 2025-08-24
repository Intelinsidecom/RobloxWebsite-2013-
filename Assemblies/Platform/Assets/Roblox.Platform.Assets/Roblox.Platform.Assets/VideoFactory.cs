using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class VideoFactory : AssetFactoryBase<IVideo>
{
	protected override int AssetTypeId => Roblox.AssetType.VideoID;

	internal VideoFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IVideo BuildChildAsset(IAsset genericAsset)
	{
		return new Video(base.DomainFactories, genericAsset);
	}

	internal IVideo GetVideo(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	/// <summary>
	/// Create an <see cref="T:Roblox.Platform.Assets.IVideo" /> asset while skipping the text filtering for the name and description.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used to generate assets with trusted/filtered name and description.
	/// </summary>
	public IVideo CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity)
	{
		return Create(trustedAssetTextInfo, assetCreatorInfo, stream, actorUserIdentity);
	}
}
