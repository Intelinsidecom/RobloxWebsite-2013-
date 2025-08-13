using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

/// <summary>
/// Typed asset factory for YouTube videos. Provides the <see cref="M:Roblox.Platform.Assets.YouTubeVideoFactory.CreateYouTubeVideo(Roblox.Platform.Assets.AssetNameAndDescription,Roblox.Platform.Assets.AssetCreatorInfo,System.String,Roblox.Platform.MembershipCore.IUserIdentifier)" /> method for creating YouTube videos
/// from YouTube video id.
/// </summary>
public class YouTubeVideoFactory : AssetFactoryBase<IYouTubeVideo>, IYouTubeVideoFactory, IAssetFactoryBase<IYouTubeVideo>
{
	protected override int AssetTypeId => Roblox.AssetType.YouTubeVideoID;

	internal YouTubeVideoFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IYouTubeVideo BuildChildAsset(IAsset genericAsset)
	{
		return new YouTubeVideo(base.DomainFactories, genericAsset);
	}

	internal IYouTubeVideo GetYouTubeVideo(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Assets.IYouTubeVideoFactory.CreateYouTubeVideo(Roblox.Platform.Assets.AssetNameAndDescription,Roblox.Platform.Assets.AssetCreatorInfo,System.String,Roblox.Platform.MembershipCore.IUserIdentifier)" />
	public IYouTubeVideo CreateYouTubeVideo(AssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, string youTubeVideoId, IUserIdentifier actorUserIdentity)
	{
		if (assetNameAndDescription == null)
		{
			throw new ArgumentNullException("assetNameAndDescription");
		}
		if (assetCreatorInfo == null)
		{
			throw new ArgumentNullException("assetCreatorInfo");
		}
		if (youTubeVideoId == null)
		{
			throw new ArgumentNullException("youTubeVideoId");
		}
		if (actorUserIdentity == null)
		{
			throw new ArgumentNullException("actorUserIdentity");
		}
		IRawContent rawContent = base.DomainFactories.RawContentFactory.GetOrCreate(AssetTypeId, assetCreatorInfo.CreatorType, assetCreatorInfo.CreatorTargetId, youTubeVideoId);
		if (rawContent.IsReviewed && !rawContent.IsApproved)
		{
			throw new VideoDisapprovedException();
		}
		return Create(assetNameAndDescription, assetCreatorInfo, rawContent, actorUserIdentity);
	}
}
