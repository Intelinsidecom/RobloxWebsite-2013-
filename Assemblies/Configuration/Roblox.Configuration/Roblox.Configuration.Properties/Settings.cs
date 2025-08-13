using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Roblox.Configuration.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\ConfigurationDatabase.mdf;Integrated Security=True;User Instance=True")]
	public string BasicConfigSource => (string)((SettingsBase)this)["BasicConfigSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\ConfigurationDatabase.mdf;Integrated Security=True;User Instance=True")]
	public string ConfigurationDatabaseConnectionString => (string)((SettingsBase)this)["ConfigurationDatabaseConnectionString"];
}
