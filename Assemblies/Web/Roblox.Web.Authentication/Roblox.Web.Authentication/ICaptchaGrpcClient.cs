using Roblox.Captcha.Captcha.V1;

namespace Roblox.Web.Authentication;

/// <summary>
/// Bedev2 gRPC client to verify the captch token.
/// </summary>
public interface ICaptchaGrpcClient
{
	/// <summary>
	/// Verify the token on Bedev2 captcha service.
	/// </summary>
	/// <param name="captchaParameter"></param>
	/// <param name="actionType"></param>
	/// <returns><c>True</c> if captcha token is passed validation, <c>False</c> otherwise</returns>
	bool CaptchaPassed(ICaptchaParameter captchaParameter, ActionType actionType);
}
