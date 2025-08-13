using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Amazon.Firehose.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => ((ApplicationSettingsBase)this)[propName]);
		}
		set
		{
			((ApplicationSettingsBase)this)[propertyName] = value;
		}
	}

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendOneEventPerFirehoseRecord => (bool)((SettingsBase)this)["SendOneEventPerFirehoseRecord"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsFirehoseClientCircuitBreakerEnabledByDefault => (bool)((SettingsBase)this)["IsFirehoseClientCircuitBreakerEnabledByDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan FirehoseClientDefaultRequestTimeout => (TimeSpan)((SettingsBase)this)["FirehoseClientDefaultRequestTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:02:00")]
	public TimeSpan FirehoseClientDefaultReadWriteTimeout => (TimeSpan)((SettingsBase)this)["FirehoseClientDefaultReadWriteTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int FirehoseClientDefaultFailuresAllowedBeforeCircuitBreakerTrip => (int)((SettingsBase)this)["FirehoseClientDefaultFailuresAllowedBeforeCircuitBreakerTrip"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.2500000")]
	public TimeSpan FirehoseClientDefaultCircuitBreakerRetryInterval => (TimeSpan)((SettingsBase)this)["FirehoseClientDefaultCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FirehoseClientDefaultMaxErrorRetry => (int)((SettingsBase)this)["FirehoseClientDefaultMaxErrorRetry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFirehoseClientThrottleRetriesEnabled => (bool)((SettingsBase)this)["IsFirehoseClientThrottleRetriesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsFirehoseClientAsyncRequestTimeoutEnabledByDefault => (bool)((SettingsBase)this)["IsFirehoseClientAsyncRequestTimeoutEnabledByDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public int DefaultMaxBufferSize => (int)((SettingsBase)this)["DefaultMaxBufferSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int DefaultMaxMessagesPerBatchRequest => (int)((SettingsBase)this)["DefaultMaxMessagesPerBatchRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int DefaultMaxTimeoutPerMessage => (int)((SettingsBase)this)["DefaultMaxTimeoutPerMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("us-east-1")]
	public string FirehoseBatchEventSenderDefaultAwsRegionEndpoint => (string)((SettingsBase)this)["FirehoseBatchEventSenderDefaultAwsRegionEndpoint"];

	internal Settings()
	{
		((ApplicationSettingsBase)this).PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		((ApplicationSettingsBase)this).OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}
}
