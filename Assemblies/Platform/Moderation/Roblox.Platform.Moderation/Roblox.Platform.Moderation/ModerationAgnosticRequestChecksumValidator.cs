using System;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using Roblox.Configuration;
using Roblox.Platform.Core;
using Roblox.Platform.Moderation.Properties;

namespace Roblox.Platform.Moderation;

/// <summary>
/// Computes and validates checksum hash wich is related to moderation agnostic request data 
/// </summary>
public class ModerationAgnosticRequestChecksumValidator
{
	private static HMACSHA256 _Hmacsha256;

	/// <summary>
	/// Initializes the <see cref="T:Roblox.Platform.Moderation.ModerationAgnosticRequestChecksumValidator" /> class.
	/// </summary>
	static ModerationAgnosticRequestChecksumValidator()
	{
		Settings.Default.ReadValueAndMonitorChanges((Expression<Func<Settings, string>>)((Settings s) => s.ModerationAgnosticAssetRequestSecretKey), (Action)delegate
		{
			_Hmacsha256 = new HMACSHA256(Encoding.ASCII.GetBytes(Settings.Default.ModerationAgnosticAssetRequestSecretKey));
		});
	}

	/// <summary>
	/// Computes the check sum string.
	/// </summary>
	/// <param name="value">The string value.</param>
	/// <returns>computed checksum hash as string</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">value argument is null or empty</exception>
	public string ComputeChecksumString(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw new PlatformArgumentException(string.Format("{0} argument is null or empty", "value"));
		}
		return BitConverter.ToString(_Hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", "").ToLower();
	}

	/// <summary>
	/// Validates the specified checksum
	/// </summary>
	/// <param name="specifiedChecksum">The specified check sum.</param>
	/// <param name="correspondingValue">The corrsponding value.</param>
	/// <returns>
	/// True if valid, otherwise false
	/// </returns>
	public bool ValidateChecksum(string specifiedChecksum, string correspondingValue)
	{
		if (string.IsNullOrEmpty(specifiedChecksum))
		{
			return false;
		}
		string validChecksum = ComputeChecksumString(correspondingValue);
		return specifiedChecksum == validChecksum;
	}
}
