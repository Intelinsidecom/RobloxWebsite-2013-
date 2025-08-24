using System.Runtime.Serialization;

namespace Roblox.Platform.UniverseSettings;

[DataContract]
public class UniverseAvatarAssetOverrideResponseModel
{
	[DataMember(Name = "assetID")]
	public long AssetID { get; set; }

	[DataMember(Name = "assetTypeID")]
	public int AssetTypeID { get; set; }

	[DataMember(Name = "isPlayerChoice")]
	public bool IsPlayerChoice { get; set; }
}
