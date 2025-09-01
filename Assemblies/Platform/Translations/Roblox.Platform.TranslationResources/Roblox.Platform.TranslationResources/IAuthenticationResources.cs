using System;
using System.Collections.Generic;
using Roblox.Platform.TranslationResources.Authentication;
namespace Roblox.Platform.TranslationResources
{
    public interface IAuthenticationResources : ITranslationResourcesNamespacesGroup

{
	IAccountRecoveryResources AccountRecovery { get; }

	ICaptchaResources Captcha { get; }

	ILoginResources Login { get; }

	IResetPasswordResources ResetPassword { get; }

	IReturnToStudioResources ReturnToStudio { get; }

	ISecurityNotificationResources SecurityNotification { get; }

	ISignUpResources SignUp { get; }

	ISocialResources Social { get; }

	ITencentResources Tencent { get; }

	ITwoStepVerificationResources TwoStepVerification { get; }

	IWeChatResources WeChat { get; }
}


}
