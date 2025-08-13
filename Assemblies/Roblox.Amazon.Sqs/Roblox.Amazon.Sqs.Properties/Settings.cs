using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Amazon.Sqs.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
internal sealed class Settings : ApplicationSettingsBase, ISettings
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
	[DefaultSettingValue("us-east-1")]
	public string RegionEndpointsCSV => (string)((SettingsBase)this)["RegionEndpointsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int SqsMessageBatchGetCount => (int)((SettingsBase)this)["SqsMessageBatchGetCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:03")]
	public TimeSpan ConsumerAdjustmentTimeout => (TimeSpan)((SettingsBase)this)["ConsumerAdjustmentTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public double SqsConsumerAdjustmentPredictionConfidence => (double)((SettingsBase)this)["SqsConsumerAdjustmentPredictionConfidence"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ConsumerCreationSurplusCapacityThreshold => (int)((SettingsBase)this)["ConsumerCreationSurplusCapacityThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SurplusCapacityRunningAverageEnabled => (bool)((SettingsBase)this)["SurplusCapacityRunningAverageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.1")]
	public double SurplusCapacityRunningAverageStartThreshold => (double)((SettingsBase)this)["SurplusCapacityRunningAverageStartThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.3")]
	public double SurplusCapacityRunningAverageStopThreshold => (double)((SettingsBase)this)["SurplusCapacityRunningAverageStopThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.3")]
	public double ConsumerCreationMultiplier => (double)((SettingsBase)this)["ConsumerCreationMultiplier"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60")]
	public int DefaultSqsVisibilityTimeoutSeconds => (int)((SettingsBase)this)["DefaultSqsVisibilityTimeoutSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DynamicallyAllocateConsumerThreadsEnabled => (bool)((SettingsBase)this)["DynamicallyAllocateConsumerThreadsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	public double SqsConsumerDestructionPredictionConfidence => (double)((SettingsBase)this)["SqsConsumerDestructionPredictionConfidence"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int DefaultRetryIterationLimit => (int)((SettingsBase)this)["DefaultRetryIterationLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:40")]
	public TimeSpan StreamSubscriberDefaultSqsClientTimeout => (TimeSpan)((SettingsBase)this)["StreamSubscriberDefaultSqsClientTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan StreamSubscriberDefaultSqsClientReadWriteTimeout => (TimeSpan)((SettingsBase)this)["StreamSubscriberDefaultSqsClientReadWriteTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:28")]
	public TimeSpan PercentileCounterUpdateInterval => (TimeSpan)((SettingsBase)this)["PercentileCounterUpdateInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsSqsClientCircuitBreakerEnabledByDefault => (bool)((SettingsBase)this)["IsSqsClientCircuitBreakerEnabledByDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsSqsClientAsyncRequestTimeoutEnabledByDefault => (bool)((SettingsBase)this)["IsSqsClientAsyncRequestTimeoutEnabledByDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:15:00")]
	public TimeSpan SqsClientDefaultRequestTimeout => (TimeSpan)((SettingsBase)this)["SqsClientDefaultRequestTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:30:00")]
	public TimeSpan SqsClientDefaultReadWriteTimeout => (TimeSpan)((SettingsBase)this)["SqsClientDefaultReadWriteTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int SqsClientDefaultFailuresAllowedBeforeCircuitBreakerTrip => (int)((SettingsBase)this)["SqsClientDefaultFailuresAllowedBeforeCircuitBreakerTrip"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00.2500000")]
	public TimeSpan SqsClientDefaultCircuitBreakerRetryInterval => (TimeSpan)((SettingsBase)this)["SqsClientDefaultCircuitBreakerRetryInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SqsClientDefaultMaxErrorRetry => (int)((SettingsBase)this)["SqsClientDefaultMaxErrorRetry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSqsClientThrottleRetriesEnabled => (bool)((SettingsBase)this)["IsSqsClientThrottleRetriesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:40")]
	public TimeSpan BatchSenderDefaultSqsClientTimeout => (TimeSpan)((SettingsBase)this)["BatchSenderDefaultSqsClientTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan BatchSenderDefaultSqsClientReadWriteTimeout => (TimeSpan)((SettingsBase)this)["BatchSenderDefaultSqsClientReadWriteTimeout"];

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
