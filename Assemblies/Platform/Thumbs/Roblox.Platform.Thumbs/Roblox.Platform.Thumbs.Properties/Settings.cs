using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Thumbs.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
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
	[DefaultSettingValue("")]
	public string WebSiteApiKey => (string)this["WebSiteApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://s3.amazonaws.com/images.roblox.com/325472601571f31e1bf00674c368d335.gif")]
	public string EmptyPixelHttpUrl => (string)this["EmptyPixelHttpUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://imagesak.roblox.com/325472601571f31e1bf00674c368d335.gif")]
	public string EmptyPixelHttpsUrl => (string)this["EmptyPixelHttpsUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsAccessKey => (string)this["AwsAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsSecretAccessKey => (string)this["AwsSecretAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string InvalidationQueueUrl => (string)this["InvalidationQueueUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AudioPlaybackEnabled => (bool)this["AudioPlaybackEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Hat,Gear,Package,Head,Torso,Right Arm,Left Arm,Right Leg,Left Leg,Shirt,Pants")]
	public string ThreeDeeThumbsSupportedAssetTypeValuesCSV => (string)this["ThreeDeeThumbsSupportedAssetTypeValuesCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDefaultCameraGeneratedThumbnailRemovalEnabled => (bool)this["IsDefaultCameraGeneratedThumbnailRemovalEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowFirstGameVersionAsDefaultThumbnailEnabled => (bool)this["ShowFirstGameVersionAsDefaultThumbnailEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AnimatedAvatarAnimationSupportedAssetTypeValuesCSV => (string)this["AnimatedAvatarAnimationSupportedAssetTypeValuesCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MultiGetThumbnailsParallelism => (int)this["MultiGetThumbnailsParallelism"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox")]
	public string EventLogSource => (string)this["EventLogSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Warning")]
	public string EventLogLevel => (string)this["EventLogLevel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFaceAssetThumbnailedAsFaceInsteadOfDecal => (bool)this["IsFaceAssetThumbnailedAsFaceInsteadOfDecal"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ArchivedAssetThumbnailBlockingEnabled => (bool)this["ArchivedAssetThumbnailBlockingEnabled"];

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
