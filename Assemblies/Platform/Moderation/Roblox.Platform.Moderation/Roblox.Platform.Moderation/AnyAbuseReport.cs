using System;

namespace Roblox.Moderation;

/// <summary>
/// The newer AnyAbuseReport copied and modified from SCL. This uses a delegate instead of accessing 
/// static dependencies.
/// </summary>
public abstract class AnyAbuseReport
{
	protected GetUserRankGetter GetUserRank;

	protected AnyAbuseReport(GetUserRankGetter getUserRank)
	{
		GetUserRank = getUserRank ?? throw new ArgumentNullException("getUserRank");
	}
}
