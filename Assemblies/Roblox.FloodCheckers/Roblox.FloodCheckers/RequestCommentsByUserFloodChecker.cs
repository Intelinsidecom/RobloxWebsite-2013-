using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

/// <summary>
/// Represents a <see cref="T:Roblox.FloodCheckers.FloodChecker" /> that flood checks commenting on a per-user per-asset basis.
/// </summary>
public class RequestCommentsByUserFloodChecker : FloodChecker
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.FloodCheckers.RequestCommentsByUserFloodChecker" /> class
	/// for user with the given user ID requesting comments.
	/// </summary>
	/// <param name="userId">The ID of the user requesting comments.</param>
	public RequestCommentsByUserFloodChecker(long userId)
		: base($"RequestCommentsByUserFloodCheck_UserID:{userId}", Settings.Default.RequestCommentsByUserFloodCheckLimit, Settings.Default.RequestCommentsByUserFloodCheckExpiry)
	{
	}
}
