using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public static class AvatarAnimationAssetTypes
{
	/// <summary>
	/// The list of public avatar animation asset types
	/// The commented out animations have been created but are not in use and are not publicly visible yet
	/// </summary>
	private static readonly ReadOnlyCollection<AssetType> _AvatarAnimationAssetTypes = new ReadOnlyCollection<AssetType>(new AssetType[7]
	{
		AssetType.RunAnimation,
		AssetType.WalkAnimation,
		AssetType.FallAnimation,
		AssetType.JumpAnimation,
		AssetType.IdleAnimation,
		AssetType.SwimAnimation,
		AssetType.ClimbAnimation
	});

	private static readonly ReadOnlyCollection<int> _AvatarAnimationAssetTypeIds = new ReadOnlyCollection<int>(_AvatarAnimationAssetTypes.Select((AssetType at) => at.ToId()).ToList());

	public static IList<AssetType> GetAvatarAnimationAssetTypes => _AvatarAnimationAssetTypes;

	public static IList<int> GetAvatarAnimationAssetTypeIds => _AvatarAnimationAssetTypeIds;

	/// <summary>
	/// Used by the client in avatar-fetch endpoint
	/// Each animation has its own key
	/// </summary>
	/// <param name="assetTypeId"></param>
	/// <returns></returns>
	public static string GetKeyForAnimationAssetType(int assetTypeId)
	{
		AssetType? assetType = AssetTypeFactory.Singleton.GetAssetType(assetTypeId);
		if (!assetType.HasValue)
		{
			throw new PlatformArgumentException($"AssetType with ID does not exist: {assetTypeId}");
		}
		return assetType switch
		{
			AssetType.ClimbAnimation => "Climb", 
			AssetType.DeathAnimation => "Death", 
			AssetType.FallAnimation => "Fall", 
			AssetType.IdleAnimation => "Idle", 
			AssetType.JumpAnimation => "Jump", 
			AssetType.RunAnimation => "Run", 
			AssetType.SwimAnimation => "Swim", 
			AssetType.WalkAnimation => "Walk", 
			AssetType.PoseAnimation => "Pose", 
			_ => Roblox.AssetType.Get(assetTypeId).Value, 
		};
	}
}
