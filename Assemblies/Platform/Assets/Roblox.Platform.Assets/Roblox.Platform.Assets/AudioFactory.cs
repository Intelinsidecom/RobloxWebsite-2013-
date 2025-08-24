using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class AudioFactory : AssetFactoryBase<IAudio>
{
	protected override int AssetTypeId => Roblox.AssetType.AudioID;

	internal AudioFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IAudio BuildChildAsset(IAsset genericAsset)
	{
		return new Audio(base.DomainFactories, genericAsset);
	}

	internal IAudio GetAudio(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	/// <summary>
	/// Create an <see cref="T:Roblox.Platform.Assets.IAudio" /> asset while skipping the text filtering for the name and description.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used to generate assets with trusted/filtered name and description.
	/// </summary>
	public IAudio CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity)
	{
		return Create(trustedAssetTextInfo, assetCreatorInfo, stream, actorUserIdentity);
	}
}
