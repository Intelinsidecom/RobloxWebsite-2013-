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
public sealed class ChinaWebsite : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static ChinaWebsite defaultInstance = (ChinaWebsite)SettingsBase.Synchronized(new ChinaWebsite());

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

	public static ChinaWebsite Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRedirectEnabledInsideChina => (bool)this["IsRedirectEnabledInsideChina"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRedirectEnabledOutsideChina => (bool)this["IsRedirectEnabledOutsideChina"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AllowedWeChatLoginRedirectUrlsCsv => (string)this["AllowedWeChatLoginRedirectUrlsCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AllowedTencentLoginRedirectUrlsCsv => (string)this["AllowedTencentLoginRedirectUrlsCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsWeChatAuthOptimizedLayoutEnabled => (bool)this["IsWeChatAuthOptimizedLayoutEnabled"];

	internal ChinaWebsite()
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
