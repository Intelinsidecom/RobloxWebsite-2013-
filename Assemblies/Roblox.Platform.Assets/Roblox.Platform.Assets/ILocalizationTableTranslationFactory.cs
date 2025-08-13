using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public interface ILocalizationTableTranslationFactory : IAssetFactoryBase<ILocalizationTableTranslation>
{
	/// <summary>
	/// Returns an <see cref="T:Roblox.Platform.Assets.ILocalizationTableTranslation" /> asset while skipping the text filtering for the name and description.
	/// [Warning!] This text does not get filtered. Use with extreme care.
	/// </summary>
	/// <param name="trustedAssetTextInfo">The <see cref="T:Roblox.Platform.Assets.ITrustedAssetTextInfo" />.</param>
	/// <param name="assetCreatorInfo">The <see cref="T:Roblox.Platform.Assets.AssetCreatorInfo" />.</param>
	/// <param name="stream">The <see cref="T:Roblox.Platform.Assets.StreamCreatorInfo" />.</param>
	/// <param name="actorUserIdentity">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" />.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.ILocalizationTableTranslation" />.</returns>
	ILocalizationTableTranslation CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity);
}
