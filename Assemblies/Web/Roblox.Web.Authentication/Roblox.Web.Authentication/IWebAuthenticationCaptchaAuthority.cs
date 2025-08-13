namespace Roblox.Web.Authentication;

internal interface IWebAuthenticationCaptchaAuthority : ICaptchaAuthority
{
	bool IsCredentialValueExemptFromAttemptCaptcha(string credentialsValue);
}
