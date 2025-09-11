using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Groups : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Groups defaultInstance = (Groups)SettingsBase.Synchronized(new Groups());

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

	public static Groups Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobileGroupsListPageStaticContentForAllEnabled => (bool)this["IsMobileGroupsListPageStaticContentForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MobileGroupsListPageStaticContentRolloutPercentage => (int)this["MobileGroupsListPageStaticContentRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobileGroupsListPageStaticContentForSoothsayersEnabled => (bool)this["IsMobileGroupsListPageStaticContentForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int SocialLinksLimit => (int)this["SocialLinksLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupsWebAppNgModulesEnabled => (bool)this["IsGroupsWebAppNgModulesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupJoinEndpointEnabled => (bool)this["IsGroupJoinEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupAssetsHidingForStrangersEnabled => (bool)this["IsGroupAssetsHidingForStrangersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ShouldReturnLockedGroups => (bool)this["ShouldReturnLockedGroups"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2147483647")]
	public long MaxLegitimateGroupId => (long)this["MaxLegitimateGroupId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGetPrimaryGroupEndpointEnabled => (bool)this["IsGetPrimaryGroupEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SummaryViaEconomyApiForSoothsayersEnabled => (bool)this["SummaryViaEconomyApiForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SummaryViaEconomyApiRolloutPercentage => (int)this["SummaryViaEconomyApiRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGetGroupUniversesUsingUniverseFactoryEnabled => (bool)this["IsGetGroupUniversesUsingUniverseFactoryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsChangeGroupOwnerNewEndpointEnabled => (bool)this["IsChangeGroupOwnerNewEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupSearchWebAppNgModulesEnabled => (bool)this["IsGroupSearchWebAppNgModulesEnabled"];

	internal Groups()
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
