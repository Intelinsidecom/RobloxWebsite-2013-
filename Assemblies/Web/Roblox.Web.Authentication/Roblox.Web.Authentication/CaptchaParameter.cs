using System;

namespace Roblox.Web.Authentication;

public class CaptchaParameter : ICaptchaParameter
{
	/// <inheritdoc cref="P:Roblox.Web.Authentication.ICaptchaParameter.CaptchaToken" />
	public string CaptchaToken { get; private set; }

	/// <inheritdoc cref="P:Roblox.Web.Authentication.ICaptchaParameter.CaptchaProvider" />
	public string CaptchaProvider { get; private set; }

	/// <inheritdoc cref="P:Roblox.Web.Authentication.ICaptchaParameter.GrpcTimeOut" />
	public TimeSpan GrpcTimeOut { get; private set; }

	/// <inheritdoc cref="P:Roblox.Web.Authentication.ICaptchaParameter.IsBedev2ForBackendWebLoginEnabled" />
	public bool IsBedev2ForBackendWebLoginEnabled { get; private set; }

	/// <summary>
	/// Constructor to initialize a <see cref="T:Roblox.Web.Authentication.CaptchaParameter" />
	/// </summary>
	/// <param name="captchaToken"></param>
	/// <param name="captchaProvider"></param>
	/// <param name="grpcTimeOut"></param>
	/// <param name="isBedev2CaptchaEnabled"></param>
	public CaptchaParameter(string captchaToken, string captchaProvider, TimeSpan grpcTimeOut, bool isBedev2CaptchaEnabled)
	{
		CaptchaToken = captchaToken;
		CaptchaProvider = captchaProvider;
		GrpcTimeOut = grpcTimeOut;
		IsBedev2ForBackendWebLoginEnabled = isBedev2CaptchaEnabled;
	}
}
