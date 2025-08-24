namespace Roblox.Platform.Captcha.Interfaces;

internal interface IActionFactory
{
	Action GetUserCaptchaAction(string username);

	Action GetIpCaptchaAction(string ipAddress);
}
