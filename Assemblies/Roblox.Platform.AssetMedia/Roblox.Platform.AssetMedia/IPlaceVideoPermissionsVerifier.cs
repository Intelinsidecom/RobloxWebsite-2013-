using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Checks whether users are allowed to add place video.
/// </summary>
public interface IPlaceVideoPermissionsVerifier
{
	/// <summary>
	/// Tests if the provided user can add YouTube videos as place thumbnails.
	/// </summary>
	/// <param name="user">User to test.</param>
	/// <returns><c>True</c> if the user is allowed to add YouTube videos as place thumbnails, or <c>False</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="user" />
	/// </exception>
	bool CanUserAddPlaceVideos(IUser user);
}
