using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Economy;

namespace Roblox.Platform.AssetMedia.Properties;

/// <summary>
/// Externally-defined settings.
/// </summary>
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
public sealed class Settings : ApplicationSettingsBase, ISettings
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
	public bool IsDefaultCameraGeneratedThumbnailRemovalEnabled => (bool)this["IsDefaultCameraGeneratedThumbnailRemovalEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan DefaultCameraGeneratedThumbnailTimeout => (TimeSpan)this["DefaultCameraGeneratedThumbnailTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:15")]
	public TimeSpan DownloadImageTimeout => (TimeSpan)this["DownloadImageTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("600")]
	public int GeneratedThumbnailWidth => (int)this["GeneratedThumbnailWidth"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("600")]
	public int GeneratedThumbnailHeight => (int)this["GeneratedThumbnailHeight"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("900")]
	public int MaximumUploadedImageWidthOrHeight => (int)this["MaximumUploadedImageWidthOrHeight"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("32")]
	public int MaximumYouTubeVideoUploadLengthInSeconds => (int)this["MaximumYouTubeVideoUploadLengthInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsVideoThumbnailUploadDisabledForUnder13Users => (bool)this["IsVideoThumbnailUploadDisabledForUnder13Users"];

	/// <inheritdoc cref="P:Roblox.Platform.AssetMedia.Properties.ISettings.YouTubeVideoPurchasePrice" />
	public long YouTubeVideoPurchasePrice => Product.YouTubeMediaItem.PriceInRobux ?? 500;

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}
}
