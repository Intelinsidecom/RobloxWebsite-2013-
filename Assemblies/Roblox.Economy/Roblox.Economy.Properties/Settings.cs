using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Economy.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PriceGraphEnabled => (bool)this["PriceGraphEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("08:00:00")]
	public TimeSpan PriceGraphUpdateFrequencyTimeSpan => (TimeSpan)this["PriceGraphUpdateFrequencyTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool MarketPlaceEnabled => (bool)this["MarketPlaceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ItemsXchangeEnabled => (bool)this["ItemsXchangeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool LoginBonusEnabled => (bool)this["LoginBonusEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool TrafficBonusEnabled => (bool)this["TrafficBonusEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int DailyLoginBonusAward => (int)this["DailyLoginBonusAward"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SolrCatalogCollectibleEnabled => (bool)this["SolrCatalogCollectibleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SolrCatalogRobloxProductsEnabled => (bool)this["SolrCatalogRobloxProductsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ItemResaleEnabled => (bool)this["ItemResaleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool NonRobloxSalesEnabled => (bool)this["NonRobloxSalesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("-1")]
	public int NewProductDuration => (int)this["NewProductDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumRobuxPriceForUserSales => (long)this["MinimumRobuxPriceForUserSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumTicketsPriceForUserSales => (long)this["MinimumTicketsPriceForUserSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumRobuxFeeForUserSales => (long)this["MinimumRobuxFeeForUserSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumTicketsFeeForUserSales => (long)this["MinimumTicketsFeeForUserSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public long MaximumRobuxPriceForPlaceSales => (long)this["MaximumRobuxPriceForPlaceSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public long MinimumRobuxPriceForPlaceSales => (long)this["MinimumRobuxPriceForPlaceSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumRobuxPriceForTShirtSales => (long)this["MinimumRobuxPriceForTShirtSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumTicketsPriceForTShirtSales => (long)this["MinimumTicketsPriceForTShirtSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumRobuxPriceForShirtSales => (long)this["MinimumRobuxPriceForShirtSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumTicketsPriceForShirtSales => (long)this["MinimumTicketsPriceForShirtSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumRobuxPriceForPantSales => (long)this["MinimumRobuxPriceForPantSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public long MinimumTicketsPriceForPantSales => (long)this["MinimumTicketsPriceForPantSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("999999999")]
	public long MaximumRobuxPriceForUserSales => (long)this["MaximumRobuxPriceForUserSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan UpdateStatsLockDuration => (TimeSpan)this["UpdateStatsLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUpdateStatsLockEnabled => (bool)this["IsUpdateStatsLockEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAssetSaleHistoryRemoteCacheEnabled => (bool)this["IsAssetSaleHistoryRemoteCacheEnabled"];

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
