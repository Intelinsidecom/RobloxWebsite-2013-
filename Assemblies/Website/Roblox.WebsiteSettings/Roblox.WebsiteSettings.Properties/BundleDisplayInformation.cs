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
public sealed class BundleDisplayInformation : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static BundleDisplayInformation defaultInstance = (BundleDisplayInformation)SettingsBase.Synchronized(new BundleDisplayInformation());

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

	public static BundleDisplayInformation Default => defaultInstance;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShouldUseBundleDisplayInformation
	{
		get
		{
			return (bool)this["ShouldUseBundleDisplayInformation"];
		}
		set
		{
			this["ShouldUseBundleDisplayInformation"] = value;
		}
	}

	internal BundleDisplayInformation()
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
