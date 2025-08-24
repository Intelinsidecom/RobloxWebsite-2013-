using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Assets.Places.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
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
	public bool IsEntityImplementationUsingLegacyBLL => (bool)this["IsEntityImplementationUsingLegacyBLL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaxPlayersPerPlace => (int)this["MaxPlayersPerPlace"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MinPlayersPerPlace => (int)this["MinPlayersPerPlace"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaxPlayersPerBetaTesterPlace => (int)this["MaxPlayersPerBetaTesterPlace"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaxPlayersDefault => (int)this["MaxPlayersDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public int SocialSlotsDefault => (int)this["SocialSlotsDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.2")]
	public double SocialSlotsRatio1to10 => (double)this["SocialSlotsRatio1to10"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.2")]
	public double SocialSlotsRatio11to20 => (double)this["SocialSlotsRatio11to20"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.2")]
	public double SocialSlotsRatio21to30 => (double)this["SocialSlotsRatio21to30"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.2")]
	public double SocialSlotsRatio31to40 => (double)this["SocialSlotsRatio31to40"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.2")]
	public double SocialSlotsRatio41andAbove => (double)this["SocialSlotsRatio41andAbove"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSocialSlotTypesEnabledForSoothsayers => (bool)this["IsSocialSlotTypesEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSocialSlotTypesEnabledForBetaTesters => (bool)this["IsSocialSlotTypesEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SocialSlotTypesRolloutPercentage => (int)this["SocialSlotTypesRolloutPercentage"];

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
