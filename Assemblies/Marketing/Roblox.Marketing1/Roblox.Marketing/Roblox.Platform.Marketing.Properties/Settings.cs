using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Marketing.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ABTestFrameworkEnabled => (bool)this["ABTestFrameworkEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.VideoPreroll.HideVideoPrerollForFirstNDays")]
	public string HidePrerollForFirstNDaysExperimentName => (string)this["HidePrerollForFirstNDaysExperimentName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8.00:00:00")]
	public TimeSpan PrerollHiddenTimespan => (TimeSpan)this["PrerollHiddenTimespan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	public double PrerollSimplePercentageChance => (double)this["PrerollSimplePercentageChance"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double PrerollSimplePercentageChanceForDFP => (double)this["PrerollSimplePercentageChanceForDFP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPrerollShownEveryXMinutesEnabled => (bool)this["IsPrerollShownEveryXMinutesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DaysBeforeShowPrerollToNewUser => (int)this["DaysBeforeShowPrerollToNewUser"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool TakeoverFrequencyCapEnabled => (bool)this["TakeoverFrequencyCapEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHomeSpecialLowValueTakeoverVisibleForAllUsers => (bool)this["IsHomeSpecialLowValueTakeoverVisibleForAllUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSponsoredPageDevicesSelectorEnabled => (bool)this["IsSponsoredPageDevicesSelectorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSponsoredPageAgeRatingEnabled => (bool)this["IsSponsoredPageAgeRatingEnabled"];

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
