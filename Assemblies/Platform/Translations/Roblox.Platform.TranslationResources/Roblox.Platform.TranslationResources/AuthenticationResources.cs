using System;
using Roblox.TranslationResources.Authentication;

namespace Roblox.TranslationResources;

internal class AuthenticationResources : IAuthenticationResources, ITranslationResourcesNamespacesGroup
{
	private readonly Lazy<IAccountRecoveryResources> _IAccountRecoveryResources;

	private readonly Lazy<ICaptchaResources> _ICaptchaResources;

	private readonly Lazy<ILoginResources> _ILoginResources;

	private readonly Lazy<IResetPasswordResources> _IResetPasswordResources;

	private readonly Lazy<IReturnToStudioResources> _IReturnToStudioResources;

	private readonly Lazy<ISecurityNotificationResources> _ISecurityNotificationResources;

	private readonly Lazy<ISignUpResources> _ISignUpResources;

	private readonly Lazy<ISocialResources> _ISocialResources;

	private readonly Lazy<ITencentResources> _ITencentResources;

	private readonly Lazy<ITwoStepVerificationResources> _ITwoStepVerificationResources;

	private readonly Lazy<IWeChatResources> _IWeChatResources;

	public IAccountRecoveryResources AccountRecovery => _IAccountRecoveryResources.Value;

	public ICaptchaResources Captcha => _ICaptchaResources.Value;

	public ILoginResources Login => _ILoginResources.Value;

	public IResetPasswordResources ResetPassword => _IResetPasswordResources.Value;

	public IReturnToStudioResources ReturnToStudio => _IReturnToStudioResources.Value;

	public ISecurityNotificationResources SecurityNotification => _ISecurityNotificationResources.Value;

	public ISignUpResources SignUp => _ISignUpResources.Value;

	public ISocialResources Social => _ISocialResources.Value;

	public ITencentResources Tencent => _ITencentResources.Value;

	public ITwoStepVerificationResources TwoStepVerification => _ITwoStepVerificationResources.Value;

	public IWeChatResources WeChat => _IWeChatResources.Value;

	public AuthenticationResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		_IAccountRecoveryResources = new Lazy<IAccountRecoveryResources>(() => AccountRecoveryResourceFactory.GetResources(locale, state));
		_ICaptchaResources = new Lazy<ICaptchaResources>(() => CaptchaResourceFactory.GetResources(locale, state));
		_ILoginResources = new Lazy<ILoginResources>(() => LoginResourceFactory.GetResources(locale, state));
		_IResetPasswordResources = new Lazy<IResetPasswordResources>(() => ResetPasswordResourceFactory.GetResources(locale, state));
		_IReturnToStudioResources = new Lazy<IReturnToStudioResources>(() => ReturnToStudioResourceFactory.GetResources(locale, state));
		_ISecurityNotificationResources = new Lazy<ISecurityNotificationResources>(() => SecurityNotificationResourceFactory.GetResources(locale, state));
		_ISignUpResources = new Lazy<ISignUpResources>(() => SignUpResourceFactory.GetResources(locale, state));
		_ISocialResources = new Lazy<ISocialResources>(() => SocialResourceFactory.GetResources(locale, state));
		_ITencentResources = new Lazy<ITencentResources>(() => TencentResourceFactory.GetResources(locale, state));
		_ITwoStepVerificationResources = new Lazy<ITwoStepVerificationResources>(() => TwoStepVerificationResourceFactory.GetResources(locale, state));
		_IWeChatResources = new Lazy<IWeChatResources>(() => WeChatResourceFactory.GetResources(locale, state));
	}

	public ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace)
	{
		if (string.IsNullOrWhiteSpace(fullTranslationResourceNamespace))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "fullTranslationResourceNamespace");
		}
		return fullTranslationResourceNamespace switch
		{
			"Authentication.AccountRecovery" => AccountRecovery, 
			"Authentication.Captcha" => Captcha, 
			"Authentication.Login" => Login, 
			"Authentication.ResetPassword" => ResetPassword, 
			"Authentication.ReturnToStudio" => ReturnToStudio, 
			"Authentication.SecurityNotification" => SecurityNotification, 
			"Authentication.SignUp" => SignUp, 
			"Authentication.Social" => Social, 
			"Authentication.Tencent" => Tencent, 
			"Authentication.TwoStepVerification" => TwoStepVerification, 
			"Authentication.WeChat" => WeChat, 
			_ => null, 
		};
	}
}
