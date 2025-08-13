using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.EventStream.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

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
	[DefaultSettingValue("False")]
	public bool StreamToAmazonKinesisFirehoseEventEnabled => (bool)this["StreamToAmazonKinesisFirehoseEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonKinesisFirehoseAwsAccessKey => (string)this["AmazonKinesisFirehoseAwsAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonKinesisFirehoseAwsAccessSecretKey => (string)this["AmazonKinesisFirehoseAwsAccessSecretKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonKinesisFirehoseDeliveryStreamName => (string)this["AmazonKinesisFirehoseDeliveryStreamName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int AmazonKinesisFirehoseMaxMessagesPerBatchRequest => (int)this["AmazonKinesisFirehoseMaxMessagesPerBatchRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int AmazonKinesisFirehoseMaxTimeoutPerMessage => (int)this["AmazonKinesisFirehoseMaxTimeoutPerMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public int AmazonKinesisFirehoseMaxBufferSizeOfRecord => (int)this["AmazonKinesisFirehoseMaxBufferSizeOfRecord"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonKinesisFirehoseAssetHandlerStreamName => (string)this["AmazonKinesisFirehoseAssetHandlerStreamName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetHandlerDataStreamToAmazonKinesisFirehoseEnabled => (bool)this["AssetHandlerDataStreamToAmazonKinesisFirehoseEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int AmazonKinesisFirehoseMaxAssetHandlerMessagesPerBatchRequest => (int)this["AmazonKinesisFirehoseMaxAssetHandlerMessagesPerBatchRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("dummy")]
	public string AmazonKinesisFirehoseGDPRStreamName => (string)this["AmazonKinesisFirehoseGDPRStreamName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("dummy")]
	public string AmazonKinesisFirehoseNonGDPRStreamName => (string)this["AmazonKinesisFirehoseNonGDPRStreamName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int AmazonKinesisFirehoseMaxChatTrainingDataMessagesPerBatchRequest => (int)this["AmazonKinesisFirehoseMaxChatTrainingDataMessagesPerBatchRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StreamToChatTrainingDataAmazonKinesisFirehoseEnabled => (bool)this["StreamToChatTrainingDataAmazonKinesisFirehoseEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonKinesisFirehoseUnitedStatesStreamName => (string)this["AmazonKinesisFirehoseUnitedStatesStreamName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStreamPushNotificationDataEnabled => (bool)this["IsStreamPushNotificationDataEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonKinesisFirehosePushNotificationStreamName => (string)this["AmazonKinesisFirehosePushNotificationStreamName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonKinesisFirehoseAwsPushNotificationAccessKey => (string)this["AmazonKinesisFirehoseAwsPushNotificationAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AmazonKinesisFirehoseAwsPushNotificationAccessSecretKey => (string)this["AmazonKinesisFirehoseAwsPushNotificationAccessSecretKey"];

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
