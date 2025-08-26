namespace extern {
    alias ConfMan;

using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using ConfManSystemConfiguration = ConfMan::System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.AccountPins.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
[ConfManSystemConfiguration.SettingsProvider(typeof(Provider))]
public sealed class Settings : ConfManSystemConfiguration.ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)ConfManSystemConfiguration.SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("False")]
	public bool IsAccountPinEnabledForSoothSayers => (bool)this["IsAccountPinEnabledForSoothSayers"];

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("False")]
	public bool IsAccountPinEnabledForRegularUser => (bool)this["IsAccountPinEnabledForRegularUser"];

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("00:05:00")]
	public TimeSpan PinEntryExpiration => (TimeSpan)this["PinEntryExpiration"];

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("4")]
	public int AccountPinLength => (int)this["AccountPinLength"];

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("0123456789")]
	public string AccountPinCharacters => (string)this["AccountPinCharacters"];

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("5")]
	public int AccountPinInputFloodCheckerLimit => (int)this["AccountPinInputFloodCheckerLimit"];

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("00:20:00")]
	public TimeSpan AccountPinInputFloodCheckerExpiry => (TimeSpan)this["AccountPinInputFloodCheckerExpiry"];

	[ConfManSystemConfiguration.ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[ConfManSystemConfiguration.DefaultSettingValue("False")]
	public bool IsAccountPinHashesTableAuditingEnabled => (bool)this["IsAccountPinHashesTableAuditingEnabled"];

	/// <summary>
	/// Gets or sets the <see cref="T:System.Object" /> with the specified property name.
	/// </summary>
	/// <value>
	/// The <see cref="T:System.Object" />.
	/// </value>
	/// <param name="propertyName">Name of the property.</param>
	/// <returns></returns>
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

	/// <summary>
	/// Raises the <see cref="E:System.Configuration.ApplicationSettingsBase.SettingsLoaded" /> event.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.Configuration.SettingsLoadedEventArgs" /> that contains the event data.</param>
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


