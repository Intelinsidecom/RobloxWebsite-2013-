using System;
using System.Linq;
using Roblox.FloodCheckers;
using Roblox.Platform.Authentication;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker to flood check user credentials by ip address, <see cref="T:Roblox.Platform.Authentication.CredentialsType" /> and credentials value.
/// </summary>
public class UserCredentialsFloodChecker : FloodChecker
{
	private const int _IpAddressMaxLength = 39;

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Web.Authentication.Floodcheckers.UserCredentialsFloodChecker" />.
	/// </summary>
	/// <param name="ipAddress">The user's ip address.</param>
	/// <param name="credentialsType">The <see cref="T:Roblox.Platform.Authentication.CredentialsType" />.</param>
	/// <param name="credentialsValue">The credential value.</param>
	/// <exception cref="T:System.ArgumentException">
	///     <paramref name="credentialsValue" /> was null or whitespace.
	/// </exception>
	public UserCredentialsFloodChecker(string ipAddress, CredentialsType credentialsType, string credentialsValue)
		: base(GetUserCredentialsFloodCheckerKeyName(ipAddress, credentialsType, credentialsValue), Settings.Default.UserCredentialsFloodCheckLimit, Settings.Default.UserCredentialsFloodCheckExpiry)
	{
		if (string.IsNullOrWhiteSpace(ipAddress))
		{
			throw new ArgumentException(string.Format("{0} must not be null or whitespace.", "ipAddress"), "ipAddress");
		}
		if (ipAddress.Length > 39)
		{
			throw new ArgumentException(string.Format("{0} is longer than {1}. Is this a valid IP address?", "ipAddress", 39), "ipAddress");
		}
		if (string.IsNullOrWhiteSpace(credentialsValue))
		{
			throw new ArgumentException("CredentialsValue can not be null or whitespace", "credentialsValue");
		}
	}

	internal static string GetUserCredentialsFloodCheckerKeyName(string ipAddress, CredentialsType credentialsType, string credentialsValue)
	{
		if (credentialsType == CredentialsType.PhoneNumber)
		{
			credentialsValue = new string(credentialsValue.Where(char.IsNumber).ToArray());
		}
		return $"UserCredentialsFloodChecker_IpAddress:{ipAddress}_Type:{credentialsType}_HashedValue:{HashFunctions.ComputeMd5HashString(credentialsValue)}";
	}
}
