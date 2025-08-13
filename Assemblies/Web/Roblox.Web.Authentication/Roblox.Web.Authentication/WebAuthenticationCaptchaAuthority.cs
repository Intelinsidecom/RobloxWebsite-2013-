using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Roblox.Configuration;
using Roblox.Web.Authentication.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Authentication;

internal class WebAuthenticationCaptchaAuthority : CaptchaAuthorityBase, IWebAuthenticationCaptchaAuthority, ICaptchaAuthority
{
	private HashSet<string> _CaptchaExemptCredentialsValueList;

	protected internal override ICaptchaSettingsModel CaptchaSettingsModel { get; }

	public WebAuthenticationCaptchaAuthority(IClientDeviceIdentifier clientDeviceIdentifier)
		: base(clientDeviceIdentifier)
	{
		CaptchaSettingsModel = new WebAuthenticationCaptchaSettingsModel();
		LoginCaptchaSettings.Default.ReadValueAndMonitorChanges((Expression<Func<LoginCaptchaSettings, string>>)((LoginCaptchaSettings s) => s.LoginCaptchaExemptCredentialValuesList), (Action)delegate
		{
			_CaptchaExemptCredentialsValueList = MultiValueSettingParser.ParseCommaDelimitedListString(LoginCaptchaSettings.Default.LoginCaptchaExemptCredentialValuesList);
		});
	}

	public bool IsCredentialValueExemptFromAttemptCaptcha(string credentialValue)
	{
		return _CaptchaExemptCredentialsValueList.Contains(credentialValue);
	}
}
