using Roblox.Platform.Assets;
using Roblox.Platform.Avatar;
using Roblox.Platform.Devices;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event arguments for tracking Cookie Conversion.
/// </summary>
public class AvatarChangedEventArgs : WebEventArgs
{
	public DeviceType DeviceType { get; set; }

	public string BrowserType { get; set; }

	public string CurrentUrl { get; set; }

	public AvatarChangeTypeEnum AvatarChangeType { get; set; }

	public AvatarChangeSourceEnum AvatarChangeSource { get; set; }

	public long? WearAssetId { get; set; }

	public long? RemoveAssetId { get; set; }

	public AvatarAssetGroupsEnum? WearAvatarAssetGroup { get; set; }

	public AvatarAssetGroupsEnum? RemoveAvatarAssetGroup { get; set; }

	public int? WearAssetTypeId { get; set; }

	public int? RemoveAssetTypeId { get; set; }

	public PlayerAvatarType? SetPlayerAvatarType { get; set; }

	public ScaleDescriptionEnum? ScaleDescription { get; set; }

	public decimal? SetHeadScale { get; set; }

	public decimal? SetWidthScale { get; set; }

	public decimal? SetHeightScale { get; set; }

	public decimal? SetProportionScale { get; set; }

	public decimal? SetBodyTypeScale { get; set; }

	/// <summary>
	/// During evaluation of this eventArgs, have we already filled in deviceType, etc. from webEventArgsFactory?
	/// </summary>
	public bool RequestDataSetup { get; set; }

	public AvatarChangedEventArgs(long userId, AvatarChangeTypeEnum avatarChangeType, AvatarAssetGroupsEnum? avatarAssetGroup, long assetId, int assetTypeId, bool wear)
	{
		base.UserId = userId;
		AvatarChangeType = avatarChangeType;
		if (wear)
		{
			WearAvatarAssetGroup = avatarAssetGroup;
			WearAssetId = assetId;
			WearAssetTypeId = assetTypeId;
		}
		else
		{
			RemoveAvatarAssetGroup = avatarAssetGroup;
			RemoveAssetId = assetId;
			RemoveAssetTypeId = assetTypeId;
		}
	}

	public AvatarChangedEventArgs(long userId, AvatarChangeTypeEnum avatarChangeType, long wearAssetId, int wearAssetTypeId)
	{
		base.UserId = userId;
		AvatarChangeType = avatarChangeType;
		WearAssetId = wearAssetId;
		WearAssetTypeId = wearAssetTypeId;
	}

	public AvatarChangedEventArgs(long userId, AvatarChangeTypeEnum avatarChangeType)
	{
		base.UserId = userId;
		AvatarChangeType = avatarChangeType;
	}

	public AvatarChangedEventArgs(long userId, AvatarChangeTypeEnum avatarChangeType, PlayerAvatarType playerAvatarType)
	{
		base.UserId = userId;
		AvatarChangeType = avatarChangeType;
		SetPlayerAvatarType = playerAvatarType;
	}

	public AvatarChangedEventArgs(long userId, AvatarChangeTypeEnum avatarChangeType, ScaleDescriptionEnum scaleDescription, decimal headScale, decimal heightScale, decimal widthScale, decimal proportionScale, decimal bodyTypeScale)
	{
		base.UserId = userId;
		AvatarChangeType = avatarChangeType;
		ScaleDescription = scaleDescription;
		SetHeadScale = headScale;
		SetHeightScale = heightScale;
		SetWidthScale = widthScale;
		SetProportionScale = proportionScale;
		SetBodyTypeScale = bodyTypeScale;
	}
}
