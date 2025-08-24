using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Http.Client;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.AuthenticationV2.Client.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : ApplicationSettingsBase, ISettings, IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private readonly DefaultHttpClientSettings _DefaultHttpClientSettings = new DefaultHttpClientSettings();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	string IHttpClientSettings.UserAgent => _DefaultHttpClientSettings.UserAgent;

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

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Endpoint => (string)this["Endpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AuthenticationV2Client")]
	public string ClientName => (string)this["ClientName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.2500000")]
	public TimeSpan RetryInterval => (TimeSpan)this["RetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int FailuresAllowedBeforeTrip => (int)this["FailuresAllowedBeforeTrip"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.5000000")]
	public TimeSpan RequestTimeout => (TimeSpan)this["RequestTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int MaxRedirects => (int)this["MaxRedirects"];

	/// <inheritdoc cref="E:Roblox.Http.Client.IHttpClientSettings.SettingChanged" />
	public event Action<string> SettingChanged;

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			this.SettingChanged?.Invoke(args.PropertyName);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}
}
