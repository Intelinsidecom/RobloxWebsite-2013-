using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class CaptchaResources_en_us : TranslationResourcesBase, ICaptchaResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public virtual string ResponseCaptchaNotEnteredError => "Please fill out the Captcha";

	public CaptchaResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string> { 
		{
			"Response.CaptchaNotEnteredError",
			_GetTemplateForResponseCaptchaNotEnteredError()
		} });
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.Captcha";
	}

	protected virtual string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Please fill out the Captcha";
	}
}
