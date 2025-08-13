using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Outfits.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	public int OutfitsMaxPerUser => (int)this["OutfitsMaxPerUser"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ResetBodyColorsWhenFetchFromS3Fails => (bool)this["ResetBodyColorsWhenFetchFromS3Fails"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.05")]
	public decimal ScaleHeightMax => (decimal)this["ScaleHeightMax"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.9")]
	public decimal ScaleHeightMin => (decimal)this["ScaleHeightMin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal ScaleHeightDefault => (decimal)this["ScaleHeightDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal ScaleWidthMax => (decimal)this["ScaleWidthMax"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.70")]
	public decimal ScaleWidthMin => (decimal)this["ScaleWidthMin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal ScaleWidthDefault => (decimal)this["ScaleWidthDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal ScaleHeadMax => (decimal)this["ScaleHeadMax"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.95")]
	public decimal ScaleHeadMin => (decimal)this["ScaleHeadMin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal ScaleHeadDefault => (decimal)this["ScaleHeadDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.01")]
	public decimal ScaleIncrement => (decimal)this["ScaleIncrement"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.5")]
	public decimal ScaleDepthMax => (decimal)this["ScaleDepthMax"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	public decimal ScaleDepthMin => (decimal)this["ScaleDepthMin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal ScaleDepthDefault => (decimal)this["ScaleDepthDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	public decimal ScaleDepthWidthRatio => (decimal)this["ScaleDepthWidthRatio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("11.4")]
	public double MinimumDeltaEColorDifference => (double)this["MinimumDeltaEColorDifference"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaximumAccoutrements => (int)this["MaximumAccoutrements"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.00")]
	public decimal ScaleProportionDefault => (decimal)this["ScaleProportionDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.00")]
	public decimal ScaleBodyTypeDefault => (decimal)this["ScaleBodyTypeDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.00")]
	public decimal ScaleBodyTypeMin => (decimal)this["ScaleBodyTypeMin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.30")]
	public decimal ScaleBodyTypeMax => (decimal)this["ScaleBodyTypeMax"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.00")]
	public decimal ScaleProportionMin => (decimal)this["ScaleProportionMin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal ScaleProportionMax => (decimal)this["ScaleProportionMax"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseThumbnailKeyV2Format => (bool)this["UseThumbnailKeyV2Format"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReadBodyColorsByHashFromDb => (bool)this["ReadBodyColorsByHashFromDb"];

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
