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
public sealed class CatalogMachineLearningSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static CatalogMachineLearningSettings defaultInstance = (CatalogMachineLearningSettings)SettingsBase.Synchronized(new CatalogMachineLearningSettings());

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

	public static CatalogMachineLearningSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("UserItemMlModel")]
	public string SortByUserItemMlModelAlgorithmName => (string)this["SortByUserItemMlModelAlgorithmName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("default")]
	public string CatalogSortBaseAlgorithmName => (string)this["CatalogSortBaseAlgorithmName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public double SortByUserItemMlModelRevenueMultiplier => (double)this["SortByUserItemMlModelRevenueMultiplier"];

	internal CatalogMachineLearningSettings()
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
