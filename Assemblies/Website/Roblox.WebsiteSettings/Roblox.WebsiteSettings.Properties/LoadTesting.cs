using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class LoadTesting : ApplicationSettingsBase
{
	private static LoadTesting defaultInstance = (LoadTesting)SettingsBase.Synchronized(new LoadTesting());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static LoadTesting Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LoadTestingConfigurationUrl => (string)this["LoadTestingConfigurationUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoadTestingFrontEndBundleForAllEnabled => (bool)this["IsLoadTestingFrontEndBundleForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoadTestingFrontEndBundleForSoothsayerEnabled => (bool)this["IsLoadTestingFrontEndBundleForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LoadTestingFrontEndBundleRolloutPercentage => (int)this["LoadTestingFrontEndBundleRolloutPercentage"];

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

	internal LoadTesting()
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
