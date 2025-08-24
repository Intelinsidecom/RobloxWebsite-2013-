using Roblox.Platform.Membership;

namespace Roblox.Platform.StaticContent;

/// <summary>
/// Used to decide whether or not all content returned should be enabled and validated.
/// </summary>
public interface IContentValidationApprover
{
	/// <summary>
	/// Whether or not invalidated content can be accessed.
	/// </summary>
	/// <remarks>
	/// Based on the implementation of this interface.
	/// </remarks>
	/// <returns><c>true</c> if invalidated content should be returned.</returns>
	bool CanAccessInvalidatedContent(IUser user);
}
