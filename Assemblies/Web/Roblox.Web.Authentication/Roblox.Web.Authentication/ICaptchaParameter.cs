using System;

namespace Roblox.Web.Authentication;

/// <summary>
/// ICaptchaParameter represents the required captcha information to validate.
/// </summary>
public interface ICaptchaParameter
{
	/// <summary>
	/// CaptchaToken need be validated by provider.
	/// </summary>
	string CaptchaToken { get; }

	/// <summary>
	/// Current captcha provider.
	/// </summary>
	string CaptchaProvider { get; }

	/// <summary>
	/// The gRPC timeout for client.
	/// </summary>
	TimeSpan GrpcTimeOut { get; }

	/// <summary>
	/// Whether bedev2 captcha flow is enabled for web login.
	/// </summary>
	/// <returns><c>True</c> if the configuration flag "IsBEDEV2CaptchaEnabledForWebLoginForAll" is turned on, <c>False</c> otherwise</returns>
	bool IsBedev2ForBackendWebLoginEnabled { get; }
}
