using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Roblox.DataV2.Core;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetUsernameHistoryByUserIdRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "count")]
	public int Count { get; set; }

	[DataMember(Name = "sortOrder")]
	public SortOrder SortOrder { get; set; }

	[DataMember(Name = "exclusiveStartId")]
	public long? ExclusiveStartId { get; set; }
}
