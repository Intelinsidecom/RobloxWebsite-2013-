using System;
using Roblox.FloodCheckers;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker by ip address for floodchecking if it's possible to send a verification message for given credentials.
/// </summary>
public class CanSendVerificationMessageByIpFloodChecker : FloodChecker
{
	private const int _IpAddressMaxLength = 39;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Authentication.Floodcheckers.CanSendVerificationMessageByIpFloodChecker" />
	/// </summary>
	/// <param name="ipAddress">The IP address.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="ipAddress" /> is null, whitespace, or longer than <see cref="F:Roblox.Web.Authentication.Floodcheckers.CanSendVerificationMessageByIpFloodChecker._IpAddressMaxLength" /> characters.</exception>
	public CanSendVerificationMessageByIpFloodChecker(string ipAddress)
		: base($"CanSendVerificationMessageFloodChecker_IPAddress:{ipAddress}", Settings.Default.CanSendVerificationMessageByIpFloodCheckLimit, Settings.Default.CanSendVerificationMessageByIpFloodCheckExpiry)
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
