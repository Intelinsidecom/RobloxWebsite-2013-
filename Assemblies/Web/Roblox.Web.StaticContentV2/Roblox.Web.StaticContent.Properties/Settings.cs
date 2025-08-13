using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Networking;

namespace Roblox.Web.StaticContent.Properties;

/// <inheritdoc cref="T:Roblox.Web.StaticContent.Properties.IStaticContentSettings" />
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, IStaticContentSettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	/// <inheritdoc cref="P:Roblox.Web.StaticContent.Properties.IStaticContentSettings.IpAddressBypassRanges" />
	public IReadOnlyCollection<IpAddressRange> IpAddressBypassRanges { get; private set; }

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
	public bool MinifyCss => (bool)this["MinifyCss"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MinifyJavaScript => (bool)this["MinifyJavaScript"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MinifyAngularTemplates => (bool)this["MinifyAngularTemplates"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMetricsApiBundleDetectionForAllEnabled => (bool)this["IsMetricsApiBundleDetectionForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMetricsApiBundleDetectionForSoothsayersEnabled => (bool)this["IsMetricsApiBundleDetectionForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MetricsApiBundleDetectionRolloutPercentage => (int)this["MetricsApiBundleDetectionRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCookieBasedComponentSuffixEnabled => (bool)this["IsCookieBasedComponentSuffixEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ValidationIpAddressRangeCsv => (string)this["ValidationIpAddressRangeCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ComponentDependencyLoadingEnabled => (bool)this["ComponentDependencyLoadingEnabled"];

	private void SetIpAddressBypassRanges(string ipRangesCsv)
	{
		IpAddressBypassRanges = IpAddressRange.ParseStringList(ipRangesCsv);
	}

	internal Settings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
		this.ReadValueAndMonitorChanges((Settings s) => s.ValidationIpAddressRangeCsv, delegate(string ipRangesCsv)
		{
			IpAddressBypassRanges = IpAddressRange.ParseStringList(ipRangesCsv);
		});
	}

	/// <inheritdoc cref="M:System.Configuration.ApplicationSettingsBase.OnSettingsLoaded(System.Object,System.Configuration.SettingsLoadedEventArgs)" />
	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}
}
