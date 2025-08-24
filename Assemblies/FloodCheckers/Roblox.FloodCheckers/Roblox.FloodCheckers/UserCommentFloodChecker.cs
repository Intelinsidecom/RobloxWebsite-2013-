using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

/// <summary>
/// Represents a <see cref="T:Roblox.FloodCheckers.FloodChecker" /> that flood checks commenting on a per-user basis.
/// </summary>
public class UserCommentFloodChecker : FloodChecker
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.FloodCheckers.UserCommentFloodChecker" /> class for a
	/// user with the given user ID.
	/// </summary>
	/// <param name="userId">The user's ID.</param>
	public UserCommentFloodChecker(long userId)
		: base($"CommentFloodCheck_UserID:{userId}", Settings.Default.UserCommentFloodCheckerLimit, Settings.Default.UserCommentFloodCheckerExpiry, Settings.Default.UserCommentFloodCheckerEnabled)
	{
	}
}
