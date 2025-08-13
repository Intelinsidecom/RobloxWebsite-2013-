using System;
using Gigya.Socialize.SDK;
using Roblox.Gigya.Properties;

namespace Roblox.Gigya;

internal class GigyaNotifyLoginResponse : GigyaResponseBase, IGigyaNotifyLoginResponse, IGigyaResponse, IGigyaValidatable
{
	public string UID { get; private set; }

	public string Signature { get; private set; }

	public int Timestamp { get; private set; }

	public override bool IsValid { get; internal set; }

	public string CookieName { get; private set; }

	public string CookieValue { get; private set; }

	public string CookieDomain { get; private set; }

	public string CookiePath { get; private set; }

	/// <summary>
	/// Should this respose be validated upon creation?.
	/// </summary>
	protected virtual bool IsValidationEnabled => Settings.Default.IsGigyaNotifyLoginResponseValidationEnabled;

	public GigyaNotifyLoginResponse(GSResponse response)
		: this(response, new GigyaValidator())
	{
	}

	public GigyaNotifyLoginResponse(GSResponse response, IGigyaValidator gigyaValidator)
		: base(response)
	{
		if (gigyaValidator == null)
		{
			throw new ArgumentNullException("gigyaValidator");
		}
		UID = base.ResponseData.GetString("UID", string.Empty);
		Signature = base.ResponseData.GetString("UIDSignature", string.Empty);
		Timestamp = base.ResponseData.GetInt("signatureTimestamp", 0);
		if (IsValidationEnabled)
		{
			IsValid = gigyaValidator.Validate(this, out var errorMessage);
			base.ErrorMessage = errorMessage;
		}
		else
		{
			IsValid = true;
		}
		CookieName = base.ResponseData.GetString("cookieName", string.Empty);
		CookieValue = base.ResponseData.GetString("cookieValue", string.Empty);
		CookieDomain = base.ResponseData.GetString("cookieDomain", string.Empty);
		CookiePath = base.ResponseData.GetString("cookiePath", string.Empty);
		if (string.IsNullOrEmpty(CookieName) || string.IsNullOrEmpty(CookieValue) || string.IsNullOrEmpty(CookieDomain) || string.IsNullOrEmpty(CookiePath))
		{
			IsValid = false;
			base.ErrorMessage = $"Incomplete cookie information for UID={UID}";
		}
	}
}
