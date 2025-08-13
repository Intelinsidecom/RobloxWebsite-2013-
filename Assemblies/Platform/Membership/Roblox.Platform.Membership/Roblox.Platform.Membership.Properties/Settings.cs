using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Membership.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int RobloxUserId => (int)this["RobloxUserId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7C4A8D09CA3762AF61E59520943DC26494F8941B,7110EDA4D09E062AA5E4A390B0A572AC0D2C0220,5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8,F7C3BC1D808E04732ADF679965CCC34CA7AE3441,8CB2237D0679CA88DB6464EAC60DA96345513964,38BAA6F6F9BE736B3D5B46EEC0636736A1F07F17,C05E0CAFDD73DEC4CCCF30461D084811A94A7617,3DA541559918A808C2402BBA5012F6C60B27661C,DF70F9B975B42116EE6C0231A7E6EAD0BBB283AA,81B06FACD90FE7A6E9BBD9CEE59736A79105B7BE")]
	public string BadPasswordHashes => (string)this["BadPasswordHashes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BadPasswords => (string)this["BadPasswords"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int PrivilegedUserRolesetRankThreshold => (int)this["PrivilegedUserRolesetRankThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUsersTableAuditingEnabled => (bool)this["IsUsersTableAuditingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AccountAgeChangeEventsSnsAwsAccessKeyAndSecretCSV => (string)this["AccountAgeChangeEventsSnsAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AccountAgeChangeEventsSnsTopicArn => (string)this["AccountAgeChangeEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishAccountAgeChangeEventsEnabled => (bool)this["PublishAccountAgeChangeEventsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100000")]
	public int MaxCountToAppendToUsername => (int)this["MaxCountToAppendToUsername"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int MaxAllowedUsernameLength => (int)this["MaxAllowedUsernameLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int MinAllowedUsernameLength => (int)this["MinAllowedUsernameLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int UserDescriptionMaxCharacterCount => (int)this["UserDescriptionMaxCharacterCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserFactoryReturnsNullForForgottenUsers => (bool)this["UserFactoryReturnsNullForForgottenUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCheckAccountsForUsernameEnabled => (bool)this["IsCheckAccountsForUsernameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Robloxian")]
	public string ReservedUsernamePrefix => (string)this["ReservedUsernamePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("9")]
	public int MaxGeneratedUsernameSuffixLength => (int)this["MaxGeneratedUsernameSuffixLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MinGeneratedUsernameSuffixLength => (int)this["MinGeneratedUsernameSuffixLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ValidateUserDataIntegrityEnabled => (bool)this["ValidateUserDataIntegrityEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserFactoryReadByIdViaUsersServiceEnabledPermyriad => (int)this["UserFactoryReadByIdViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserFactoryReadByMultiGetViaUsersServiceEnabledPermyriad => (int)this["UserFactoryReadByMultiGetViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserFactoryReadByNameViaUsersServiceEnabledPermyriad => (int)this["UserFactoryReadByNameViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserFactoryReadByAccountIdViaUsersServiceEnabledPermyriad => (int)this["UserFactoryReadByAccountIdViaUsersServiceEnabledPermyriad"];

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
