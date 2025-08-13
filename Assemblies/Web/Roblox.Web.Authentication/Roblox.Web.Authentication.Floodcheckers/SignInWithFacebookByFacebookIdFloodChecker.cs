using Roblox.FloodCheckers;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker for signing in with Facebook by facebookId
/// </summary>
internal class SignInWithFacebookByFacebookIdFloodChecker : FloodChecker
{
	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Authentication.Floodcheckers.SignInWithFacebookByFacebookIdFloodChecker" />
	/// </summary>
	/// <param name="facebookId">An <see cref="T:System.UInt64" />.</param>
	public SignInWithFacebookByFacebookIdFloodChecker(ulong facebookId)
		: base($"SignInWithFacebookFloodChecker_FacebookId:{facebookId}", Settings.Default.SignInWithFacebookByFacebookIdFloodCheckerLimit, Settings.Default.SignInWithFacebookByFacebookIdFloodCheckerExpiry)
	{
	}
}
