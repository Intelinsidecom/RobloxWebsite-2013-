extern alias ConfMan;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using ConfManSystemConfiguration = ConfMan::System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.AbTesting.Core.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[ConfManSystemConfiguration.SettingsProvider(typeof(Provider))]
internal sealed class Settings : ConfManSystemConfiguration.ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)ConfManSystemConfiguration.SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("False")]
	public bool IsEnrollmentDeclinationRemoteCacheEnabled => (bool)this["IsEnrollmentDeclinationRemoteCacheEnabled"];

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("False")]
	public bool IsEnrollmentRemoteCacheEnabled => (bool)this["IsEnrollmentRemoteCacheEnabled"];

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

	protected override void OnSettingsLoaded(object sender, ConfManSystemConfiguration.SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
