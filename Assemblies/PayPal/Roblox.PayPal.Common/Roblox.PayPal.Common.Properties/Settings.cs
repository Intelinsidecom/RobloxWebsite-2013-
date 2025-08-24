using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.PayPal.Common.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Upgrades/PayPal.aspx?Billing=new&ap={0}")]
	public string PayPal_CancelPage => (string)this["PayPal_CancelPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("pilot-payflowpro.paypal.com")]
	public string PayPal_Connection => (string)this["PayPal_Connection"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("info@roblox.com")]
	public string PayPal_MerchantInformation => (string)this["PayPal_MerchantInformation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX Corporation")]
	public string PayPal_MerchantName => (string)this["PayPal_MerchantName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int PayPal_NumDaysToRetry => (int)this["PayPal_NumDaysToRetry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PayPal")]
	public string PayPal_Partner => (string)this["PayPal_Partner"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PayPal_Password => (string)this["PayPal_Password"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Upgrades/PayPalPayment.aspx?Billing=new&Order={0}")]
	public string PayPal_ReturnPage => (string)this["PayPal_ReturnPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("images/Logo/roblox_logo_224x59_04052017.png")]
	public string PayPal_RobloxLogo => (string)this["PayPal_RobloxLogo"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PayPal_ThrottleEnabled => (bool)this["PayPal_ThrottleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PayPal_ThrottleMaxPerMinute => (int)this["PayPal_ThrottleMaxPerMinute"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20000")]
	public int PayPal_ThrottleMaxWaitInMsBeforeException => (int)this["PayPal_ThrottleMaxWaitInMsBeforeException"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX")]
	public string PayPal_UserName => (string)this["PayPal_UserName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PayPal_UseTestMode => (bool)this["PayPal_UseTestMode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_express-checkout&useraction=commit&token=")]
	public string PayPal_ExpressCheckoutURL => (string)this["PayPal_ExpressCheckoutURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebSiteBaseUrl => (string)this["WebSiteBaseUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PayPalInternationalEnabled => (bool)this["PayPalInternationalEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PayPal_DefaultHostPort => (int)this["PayPal_DefaultHostPort"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PayPal_DefaultTimeOutSeconds => (int)this["PayPal_DefaultTimeOutSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClassicAPI_User => (string)this["ClassicAPI_User"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClassicAPI_Password => (string)this["ClassicAPI_Password"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClassicAPI_Signature => (string)this["ClassicAPI_Signature"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClassicAPI_UseProductionMode => (bool)this["ClassicAPI_UseProductionMode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX")]
	public string PayPal_Vendor => (string)this["PayPal_Vendor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("false")]
	public bool PayPal_IsCorrectPayflowMappingEnabled => (bool)this["PayPal_IsCorrectPayflowMappingEnabled"];

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propName]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
