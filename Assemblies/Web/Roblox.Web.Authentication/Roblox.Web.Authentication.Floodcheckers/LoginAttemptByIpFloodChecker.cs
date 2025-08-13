using System;
using Roblox.FloodCheckers;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker to flood check logins by ip.
/// </summary>
public class LoginAttemptByIpFloodChecker : FloodChecker
{
	private const int _IpAddressMaxLength = 39;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Authentication.Floodcheckers.LoginAttemptByIpFloodChecker" />
	/// </summary>
	/// <param name="ipAddress">The ip address.</param>
	/// <param name="isEnabled">Whether or not this floodchecker is enabled.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="ipAddress" /> is null, whitespace, or longer than <see cref="F:Roblox.Web.Authentication.Floodcheckers.LoginAttemptByIpFloodChecker._IpAddressMaxLength" /> characters.</exception>
	public LoginAttemptByIpFloodChecker(string ipAddress, bool isEnabled)
		: base($"LoginAttemptFloodChecker_IPAddress:{ipAddress.Substring(0, Math.Min(39, ipAddress.Length))}", Settings.Default.LoginAttemptByIpFloodCheckLimit, Settings.Default.LoginAttemptByIpFloodCheckExpiry, isEnabled)
	{
		if (string.IsNullOrWhiteSpace(ipAddress))
		{
			throw new ArgumentException(string.Format("{0} must not be null or whitespace.", "ipAddress"), "ipAddress");
		}
		if (ipAddress.Length > 39)
		{
			throw new ArgumentException(string.Format("{0} is longer than {1}. Is this a valid IP address?", "ipAddress", 39), "ipAddress");
		}
	}
}
