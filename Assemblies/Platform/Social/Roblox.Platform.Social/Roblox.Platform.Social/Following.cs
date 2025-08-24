using System;
using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Social;

[ExcludeFromCodeCoverage]
internal class Following : IFollowing
{
	public long? Id { get; set; }

	public long UserId { get; set; }

	public long FollowerUserId { get; set; }

	public DateTime FollowerSince { get; set; }
}
