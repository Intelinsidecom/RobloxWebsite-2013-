using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
public sealed class AdSlotNamesSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static AdSlotNamesSettings defaultInstance = (AdSlotNamesSettings)SettingsBase.Synchronized(new AdSlotNamesSettings());

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

	public static AdSlotNamesSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Games_Right_300x600")]
	public string GamesRight300x600 => (string)this["GamesRight300x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Catalog_Skin_Left_400x1180")]
	public string CatalogSkinLeft400x1180 => (string)this["CatalogSkinLeft400x1180"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Catalog_Skin_Right_400x1180")]
	public string CatalogSkinRight400x1180 => (string)this["CatalogSkinRight400x1180"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_ItemPage_Skin_Left_308x901")]
	public string ItemPageSkinLeft308x901 => (string)this["ItemPageSkinLeft308x901"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_ItemPage_Skin_Right_308x900")]
	public string ItemPageSkinRight308x900 => (string)this["ItemPageSkinRight308x900"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Item_Roadblock_728x90")]
	public string U13ItemRoadblock728x90 => (string)this["U13ItemRoadblock728x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_ItemPage_Top_970x90")]
	public string ItemPageTop970x90 => (string)this["ItemPageTop970x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_ItemPage_Top_728x90")]
	public string ItemPageTop728x90 => (string)this["ItemPageTop728x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Item_Roadblock_160x600")]
	public string U13ItemRoadblock160x600 => (string)this["U13ItemRoadblock160x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Home_Floor")]
	public string HomeFloor => (string)this["HomeFloor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_MyHomeSpecial_Skin_Left_400x1180")]
	public string MyHomeSpecialSkinLeft400x1180 => (string)this["MyHomeSpecialSkinLeft400x1180"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_MyHome_Skin_Left_400x1180")]
	public string MyHomeSkinLeft400x1180 => (string)this["MyHomeSkinLeft400x1180"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_MyHomeSpecial_Skin_Right_400x1180")]
	public string MyHomeSpecialSkinRight400x1180 => (string)this["MyHomeSpecialSkinRight400x1180"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_MyHome_Skin_Right_400x1180")]
	public string MyHomeSkinRight400x1180 => (string)this["MyHomeSkinRight400x1180"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_MyHome_Rt_300x600")]
	public string MyHomeRt300x600 => (string)this["MyHomeRt300x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Games_Skin_Left_400x1180")]
	public string GamesSkinLeft400x1180 => (string)this["GamesSkinLeft400x1180"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Games_Skin_Right_400x1180")]
	public string GamesSkinRight400x1180 => (string)this["GamesSkinRight400x1180"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_GamesDetailsPage_Skin_Left_308x901")]
	public string GamesDetailsPageSkinLeft308x901 => (string)this["GamesDetailsPageSkinLeft308x901"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_GamesDetailsPage_Skin_Right_308x900")]
	public string GamesDetailsPageSkinRight308x900 => (string)this["GamesDetailsPageSkinRight308x900"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Games_Details_Roadblock_728x90")]
	public string U13GamesDetailsRoadblock728x90 => (string)this["U13GamesDetailsRoadblock728x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_GamesDetailsPage_Top_970x90")]
	public string GamesDetailsPageTop970x90 => (string)this["GamesDetailsPageTop970x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_GamesDetailsPage_Top_728x90")]
	public string GamesDetailsPageTop728x90 => (string)this["GamesDetailsPageTop728x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Games_Details_Roadblock_160x600")]
	public string U13GamesDetailsRoadblock160x600 => (string)this["U13GamesDetailsRoadblock160x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Scan_728X90_")]
	public string Scan728X90 => (string)this["Scan728X90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Scan_300x250_")]
	public string Scan300x250 => (string)this["Scan300x250"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Scan_160x600_")]
	public string Scan160x600 => (string)this["Scan160x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_Scan_970x90_")]
	public string Scan970x90 => (string)this["Scan970x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Home_Left_160x600")]
	public string U13HomeLeft160x600 => (string)this["U13HomeLeft160x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Home_Right_160x600")]
	public string U13HomeRight160x600 => (string)this["U13HomeRight160x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Games_Detail_728x90")]
	public string U13GamesDetail728x90 => (string)this["U13GamesDetail728x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Games_Detail_160x600")]
	public string U13GamesDetail160x600 => (string)this["U13GamesDetail160x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Games_ATF_1")]
	public string U13GamesATF1 => (string)this["U13GamesATF1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX_U13_Games_ATF_2")]
	public string U13GamesATF2 => (string)this["U13GamesATF2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Setting => (string)this["Setting"];

	internal AdSlotNamesSettings()
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
