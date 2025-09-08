using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class WebSecurity : ApplicationSettingsBase
{
	private static WebSecurity defaultInstance = (WebSecurity)SettingsBase.Synchronized(new WebSecurity());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static WebSecurity Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WebsiteHstsHeaderEnabled => (bool)this["WebsiteHstsHeaderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int WebsiteHstsHeaderMaxAgeInSeconds => (int)this["WebsiteHstsHeaderMaxAgeInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEnhancedSecurityCheckForBannedUsersAllowedUrlsEnabled => (bool)this["IsEnhancedSecurityCheckForBannedUsersAllowedUrlsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/login/,/css/,/membership/,/loginredirect.aspx,/help/,/info/,/request-error,/support/")]
	public string BannedUsersAllowedUrlsCsv => (string)this["BannedUsersAllowedUrlsCsv"];

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

	internal WebSecurity()
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
