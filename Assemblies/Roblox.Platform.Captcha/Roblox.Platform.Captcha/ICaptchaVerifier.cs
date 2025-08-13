namespace Roblox.Platform.Captcha;

public interface ICaptchaVerifier
{
	/// <summary>
	/// Checks if Captcha is enabled based on Settings
	/// </summary>
	bool IsCaptchaEnabled { get; }

	/// <summary>
	/// Checks the Floodchecker, action and settings and returns whether Captcha Is needed.
	/// </summary>
	/// <param name="inApp">set to true if the request is being made from mobile app.</param>
	/// <returns>true if Captcha is needed</returns>
	bool IsCaptchaNeeded(bool inApp = false);
}
