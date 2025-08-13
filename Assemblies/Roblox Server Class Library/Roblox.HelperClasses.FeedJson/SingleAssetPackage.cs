using System.Runtime.Serialization;

namespace Roblox.HelperClasses.FeedJson;

[DataContract]
public class SingleAssetPackage
{
	[DataMember]
	public long AssetID;
}
