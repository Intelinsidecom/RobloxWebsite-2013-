using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class CaptchaResources_en_us : TranslationResourcesBase, ICaptchaResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToLoad"
	/// Displayed when we fail to load captcha javascript from a third party provider. This has been known to occur in FireFox when "block trackers" is enabled - we need to let the user know that it might be due to their browser without implying that we are intentionally forcing them to turn off their ad/content blockers.
	/// English String: "We need to verify that you are human. Please disable your browser blocker or try a different browser."
	/// </summary>
	public virtual string ResponseCaptchaErrorFailedToLoad => "We need to verify that you are human. Please disable your browser blocker or try a different browser.";

	/// <summary>
	/// Key: "Response.CaptchaErrorFailedToVerify"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes."
	/// </summary>
	public virtual string ResponseCaptchaErrorFailedToVerify => "Temporary error. Please try again in a few minutes.";

	/// <summary>
	/// Key: "Response.CaptchaErrorVerifyFailed"
	/// Displayed if the user successfully solves a captcha bit is still unable to proceed. Should rarely be shown.
	/// English String: "Temporary error. Please try again in a few minutes"
	/// </summary>
	public virtual string ResponseCaptchaErrorVerifyFailed => "Temporary error. Please try again in a few minutes";

	public CaptchaResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Response.CaptchaErrorFailedToLoad",
				_GetTemplateForResponseCaptchaErrorFailedToLoad()
			},
			{
				"Response.CaptchaErrorFailedToVerify",
				_GetTemplateForResponseCaptchaErrorFailedToVerify()
			},
			{
				"Response.CaptchaErrorVerifyFailed",
				_GetTemplateForResponseCaptchaErrorVerifyFailed()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.Captcha";
	}

	protected virtual string _GetTemplateForResponseCaptchaErrorFailedToLoad()
	{
		return "We need to verify that you are human. Please disable your browser blocker or try a different browser.";
	}

	protected virtual string _GetTemplateForResponseCaptchaErrorFailedToVerify()
	{
		return "Temporary error. Please try again in a few minutes.";
	}

	protected virtual string _GetTemplateForResponseCaptchaErrorVerifyFailed()
	{
		return "Temporary error. Please try again in a few minutes";
	}
}
