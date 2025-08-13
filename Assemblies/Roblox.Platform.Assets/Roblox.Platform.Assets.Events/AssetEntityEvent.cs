using System.Runtime.Serialization;

namespace Roblox.Platform.Assets.Events;

[DataContract]
public class AssetEntityEvent
{
	[DataMember(Name = "assetId", IsRequired = true)]
	public long AssetId { get; }

	[DataMember(Name = "assetType", IsRequired = true)]
	public string AssetType { get; }

	[DataMember(Name = "assetChangeType", IsRequired = false)]
	public string AssetChangeType { get; set; }

	[DataMember(Name = "authorUserId", IsRequired = false)]
	public long? AuthorUserId { get; set; }

	internal AssetEntityEvent(long assetId, AssetType assetType, AssetChangeType assetChangeType, long? authorUserId = null)
	{
		AssetId = assetId;
		AssetType = assetType.ToString();
		AssetChangeType = assetChangeType.ToString();
		AuthorUserId = authorUserId;
	}
}
