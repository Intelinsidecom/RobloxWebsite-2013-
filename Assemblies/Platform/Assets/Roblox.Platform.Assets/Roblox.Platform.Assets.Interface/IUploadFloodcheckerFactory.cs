using Roblox.FloodCheckers.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Assets.Interface;

public interface IUploadFloodcheckerFactory
{
	IRetryAfterFloodChecker GetImageUploadFloodchecker(IUser user);

	/// <summary>
	/// Gets a floodchecker meant for thumbnail image uploads by user.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns><see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /></returns>
	IFloodChecker GetFreeThumbnailImageUploadFloodChecker(IUser user);

	/// <summary>
	/// Gets a floodchecker meant for asset uploads by creator and asset type.
	/// </summary>
	/// <param name="creatorType">The <see cref="T:Roblox.Platform.Assets.CreatorType" />.</param>
	/// <param name="creatorTargetId">The creator target Id.</param>
	/// <param name="assetType">The <see cref="T:Roblox.Platform.Assets.AssetType" />.</param>
	/// <returns><see cref="T:Roblox.FloodCheckers.Core.IRetryAfterFloodChecker" /></returns>
	IRetryAfterFloodChecker GetCreatorAssetTypeUploadFloodChecker(CreatorType creatorType, long creatorTargetId, AssetType assetType);
}
