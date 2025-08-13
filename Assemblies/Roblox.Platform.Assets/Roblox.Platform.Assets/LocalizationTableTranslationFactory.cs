using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class LocalizationTableTranslationFactory : AssetFactoryBase<ILocalizationTableTranslation>, ILocalizationTableTranslationFactory, IAssetFactoryBase<ILocalizationTableTranslation>
{
	protected override int AssetTypeId => Roblox.AssetType.LocalizationTableTranslationID;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Assets.LocalizationTableTranslationFactory" />
	/// </summary>
	/// <param name="domainFactories">The <see cref="T:Roblox.Platform.Assets.AssetDomainFactories" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null.</exception>
	public LocalizationTableTranslationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ILocalizationTableTranslation BuildChildAsset(IAsset genericAsset)
	{
		return new LocalizationTableTranslation(base.DomainFactories, genericAsset);
	}

	internal ILocalizationTableTranslation GetLocalizationTableTranslation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	/// <inheritdoc cref="!:ILocalizationTableTranslation.CreateWithTrustedAssetText" />&gt;
	public ILocalizationTableTranslation CreateWithTrustedAssetText(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity)
	{
		return Create(trustedAssetTextInfo, assetCreatorInfo, stream, actorUserIdentity);
	}
}
