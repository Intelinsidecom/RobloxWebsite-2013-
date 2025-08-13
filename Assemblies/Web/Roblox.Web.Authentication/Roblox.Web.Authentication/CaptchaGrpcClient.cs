using System;
using System.Threading;
using Grpc.Core;
using Roblox.Caching;
using Roblox.Captcha.Captcha.V1;
using Roblox.EventLog;

namespace Roblox.Web.Authentication;

public class CaptchaGrpcClient : ICaptchaGrpcClient
{
	private readonly LazyWithRetry<CaptchaAPIClient> _CaptchaApiClient;

	private readonly ILogger _Logger;

	public CaptchaGrpcClient(LazyWithRetry<CaptchaAPIClient> captchaApiClient, ILogger logger)
	{
		_CaptchaApiClient = captchaApiClient ?? throw new ArgumentNullException("captchaApiClient");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.ICaptchaGrpcClient.CaptchaPassed(Roblox.Web.Authentication.ICaptchaParameter,Roblox.Captcha.Captcha.V1.ActionType)" />
	public bool CaptchaPassed(ICaptchaParameter _CaptchaParameter, ActionType actionType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0069: Expected O, but got Unknown
		AllowedRequest allowedRequest = new AllowedRequest
		{
			ActionType = actionType,
			CaptchaToken = (_CaptchaParameter.CaptchaToken ?? ""),
			Provider = (Provider)1
		};
		try
		{
			return !_CaptchaApiClient.Value.Allowed(allowedRequest, (Metadata)null, (DateTime?)DateTime.UtcNow.Add(_CaptchaParameter.GrpcTimeOut), default(CancellationToken)).Challenge;
		}
		catch (RpcException val)
		{
			RpcException ex = val;
			_Logger.Error((Exception)(object)ex);
			return false;
		}
	}
}
