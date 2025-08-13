using System;
using System.Linq;
using Roblox.FloodCheckers;
using Roblox.Platform.Authentication;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker to flood check user credentials by ip address, <see cref="T:Roblox.Platform.Authentication.CredentialsType" /> and credentials value.
/// </summary>
public class SendVerificationMessageByIpAndCredentialsFloodChecker : FloodChecker
{
	private const int _IpAddressMaxLength = 39;

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Web.Authentication.Floodcheckers.SendVerificationMessageByIpAndCredentialsFloodChecker" />.
	/// </summary>
	/// <param name="ipAddress">The user's ip address.</param>
	/// <param name="credentialsType">The <see cref="T:Roblox.Platform.Authentication.CredentialsType" />.</param>
	/// <param name="credentialsValue">The credential value.</param>
	/// <exception cref="T:System.ArgumentException">
	///     <paramref name="ipAddress" /> was null, whitespace, or longer than <see cref="F:Roblox.Web.Authentication.Floodcheckers.SendVerificationMessageByIpAndCredentialsFloodChecker._IpAddressMaxLength" />
	///     <paramref name="credentialsValue" /> was null or whitespace.
	/// </exception>
	public SendVerificationMessageByIpAndCredentialsFloodChecker(string ipAddress, CredentialsType credentialsType, string credentialsValue)
		: base(GetCredentialsFloodCheckerKeyName(ipAddress, credentialsType, credentialsValue), Settings.Default.SendVerificationMessageByIpAndCredentialsFloodCheckLimit, Settings.Default.SendVerificationMessageByIpAndCredentialsFloodCheckExpiry)
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

	private static string GetCredentialsFloodCheckerKeyName(string ipAddress, CredentialsType credentialsType, string credentialsValue)
	{
		if (credentialsType == CredentialsType.PhoneNumber)
		{
			credentialsValue = new string(credentialsValue.Where(char.IsNumber).ToArray());
		}
		return $"SendVerificationMessageFloodCheckerIpAddress:{ipAddress}_Type:{credentialsType}_HashedValue:{HashFunctions.ComputeMd5HashString(credentialsValue)}";
	}
}
