using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class MeshFactory : AssetFactoryBase<IMesh>
{
	protected override int AssetTypeId => Roblox.AssetType.MeshID;

	internal MeshFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IMesh BuildChildAsset(IAsset genericAsset)
	{
		return new Mesh(base.DomainFactories, genericAsset);
	}

	internal IMesh GetMesh(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	/// <summary>
	/// Create an <see cref="T:Roblox.Platform.Assets.IMesh" /> asset while skipping the text filtering for the name and description.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// [Warning!] This should only be used to generate assets with trusted/filtered name and description.
	/// </summary>
	public IMesh CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity)
	{
		return Create(trustedAssetTextInfo, assetCreatorInfo, stream, actorUserIdentity);
	}
}
