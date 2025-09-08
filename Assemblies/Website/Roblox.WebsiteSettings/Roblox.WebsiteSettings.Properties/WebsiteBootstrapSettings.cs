using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
public sealed class WebsiteBootstrapSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static WebsiteBootstrapSettings defaultInstance = (WebsiteBootstrapSettings)SettingsBase.Synchronized(new WebsiteBootstrapSettings());

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

	public static WebsiteBootstrapSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("RW1.Roblox.Website")]
	public string GeneralEventLogSource => (string)this["GeneralEventLogSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Warning")]
	public string GeneralEventLogLevel => (string)this["GeneralEventLogLevel"];

	internal WebsiteBootstrapSettings()
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
