using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Platform.AudioRightsManagement;

[DataContract]
[ExcludeFromCodeCoverage]
internal class AudioReviewEventsMessage
{
	[DataMember(Name = "assetVersionId")]
	public long AssetVersionId { get; set; }
}
