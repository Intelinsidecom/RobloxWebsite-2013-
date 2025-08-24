using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public interface IImageFactory : IAssetFactoryBase<IImage>
{
	/// <summary>
	/// Create an <see cref="T:Roblox.Platform.Assets.IImage" /> asset while skipping the text filtering for the name and description.
	/// </summary>
	/// <remarks>
	/// [Warning!] This text does not get filtered.Use with extreme care.
	/// [Warning!] This should only be used to generate assets with trusted/filtered name and description.
	/// </remarks>
	IImage CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity, string localeCodeOverride = null);
}
