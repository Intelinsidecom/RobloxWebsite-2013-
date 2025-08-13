using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Caching.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
internal sealed class InvalidationSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static InvalidationSettings defaultInstance = (InvalidationSettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new InvalidationSettings());

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

	public static InvalidationSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RedisEndpointsForInvalidation => (string)((SettingsBase)this)["RedisEndpointsForInvalidation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public int NumberOfAttemptsForInvalidationMessageDelivery => (int)((SettingsBase)this)["NumberOfAttemptsForInvalidationMessageDelivery"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int NumberOfAttemptsForTopicSubscription => (int)((SettingsBase)this)["NumberOfAttemptsForTopicSubscription"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public int RetryIntervalForTopicSubscriptionsInMilliSeconds => (int)((SettingsBase)this)["RetryIntervalForTopicSubscriptionsInMilliSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan DelayToStartPublishingAfterNodeAddition => (TimeSpan)((SettingsBase)this)["DelayToStartPublishingAfterNodeAddition"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan DelayToStopSubscribingAfterNodeRemoval => (TimeSpan)((SettingsBase)this)["DelayToStopSubscribingAfterNodeRemoval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100000")]
	public int RedisInvalidationQueueSize => (int)((SettingsBase)this)["RedisInvalidationQueueSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ThrowOnInitializationErrorEnabled => (bool)((SettingsBase)this)["ThrowOnInitializationErrorEnabled"];

	internal InvalidationSettings()
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
