using System;
using System.Web;
using Roblox.Platform.Captcha;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication;

public class LoginCaptchaAction : Roblox.Platform.Captcha.Action
{
	protected override TimeSpan Expiration => LoginCaptchaSettings.Default.LoginCaptchaActionSuccessExpirationTime;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Web.Authentication.LoginCaptchaAction" /> from the given credential value and <see cref="T:Roblox.Platform.Captcha.Factories" />.
	/// </summary>
	/// <param name="credentialValue">The credential value.</param>
	/// <param name="factories"></param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="credentialValue" /> is null.</exception>
	public LoginCaptchaAction(string credentialValue, Factories factories)
		: base(ConstructIdentifierFromCredentialValue(credentialValue), ActionType.Login, factories)
	{
	}

	/// <summary>
	/// Constructs an <see cref="T:Roblox.Platform.Captcha.Identifier" /> from a credential value.
	/// </summary>
	/// <param name="credentialValue">The credential value to construct the <see cref="T:Roblox.Platform.Captcha.Identifier" /> from.</param>
	/// <returns>The constructed <see cref="T:Roblox.Platform.Captcha.Identifier" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="credentialValue" /> is null.</exception>
	private static Identifier ConstructIdentifierFromCredentialValue(string credentialValue)
	{
		if (credentialValue == null)
		{
			throw new ArgumentNullException("credentialValue");
		}
		string captchaIdentifierValue = HttpUtility.UrlEncode(credentialValue);
		if (Settings.Default.IsLoginCaptchaHashingEnabled)
		{
			captchaIdentifierValue = HashFunctions.ComputeMd5HashString(credentialValue);
		}
		Identifier result = default(Identifier);
		result.TargetType = IdentifierTargetType.Username;
		result.Value = captchaIdentifierValue;
		return result;
	}
}
