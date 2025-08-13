using Roblox.FloodCheckers;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker for signing in with Facebook by IP address and facebookId
/// </summary>
internal class SignInWithFacebookByIpAndFacebookIdFloodChecker : FloodChecker
{
	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Authentication.Floodcheckers.SignInWithFacebookByIpAndFacebookIdFloodChecker" />
	/// </summary>
	/// <param name="ipAddress">A <see cref="T:System.String" />.</param>
	/// <param name="facebookId">A <see cref="T:System.UInt64" />.</param>
	public SignInWithFacebookByIpAndFacebookIdFloodChecker(string ipAddress, ulong facebookId)
		: base($"SignInWithFacebookFloodChecker_IpAddress:{ipAddress}_FacebookId:{facebookId}", Settings.Default.SignInWithFacebookByIpAndFacebookIdFloodCheckerLimit, Settings.Default.SignInWithFacebookByIpAndFacebookIdFloodCheckerExpiry)
	{
	}
}
