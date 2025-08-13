using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.UniverseDisplayInformation.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : ApplicationSettingsBase, IGameDisplayInformationProviderSettings, IUniverseDisplayInformationAccessorSettings, IUniverseDisplayInformationBuilderSettings, IUniverseDisplayInformationChangeEventsPublisherSettings, IGameNameDescriptionChangeEventStreamerSettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

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
	public bool IsUniverseDescriptionInsteadOfPlaceDescriptionEnabled => (bool)this["IsUniverseDescriptionInsteadOfPlaceDescriptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccessingTranslationsEnabled => (bool)this["IsAccessingTranslationsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReturningTranslationsEnabled => (bool)this["IsReturningTranslationsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ShadowRolloutPercentage => (int)this["ShadowRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsModifyingOrDeletingTranslationsEnabled => (bool)this["IsModifyingOrDeletingTranslationsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int UniverseNameMaxLength => (int)this["UniverseNameMaxLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int UniverseDescriptionMaxLength => (int)this["UniverseDescriptionMaxLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniverseDisplayInformationChangeTopicAccessKeyIdAndSecretCsv => (string)this["UniverseDisplayInformationChangeTopicAccessKeyIdAndSecretCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniverseDisplayInformationChangeSnsTopicArn => (string)this["UniverseDisplayInformationChangeSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishToUniverseDisplayInformationChangeTopicEnabled => (bool)this["IsPublishToUniverseDisplayInformationChangeTopicEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStreamingGameNameDescriptionChangeEventEnabled => (bool)this["IsStreamingGameNameDescriptionChangeEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAllowingNullOrWhitespaceNameEnabled => (bool)this["IsAllowingNullOrWhitespaceNameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccessingLocalizedIconsEnabled => (bool)this["IsAccessingLocalizedIconsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReturningLocalizedIconsEnabled => (bool)this["IsReturningLocalizedIconsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IconLocalizationShadowRolloutPercentage => (int)this["IconLocalizationShadowRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ImageApprovalStatusGetterRolloutPercentage => (int)this["ImageApprovalStatusGetterRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReturningNonApprovedLocalizedIconEnabled => (bool)this["IsReturningNonApprovedLocalizedIconEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccessingLocalizedThumbnailsEnabled => (bool)this["IsAccessingLocalizedThumbnailsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReturningLocalizedThumbnailsEnabled => (bool)this["IsReturningLocalizedThumbnailsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ThumbnailLocalizationShadowRolloutPercentage => (int)this["ThumbnailLocalizationShadowRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReturningPartialNonApprovedLocalizedThumbnailsEnabled => (bool)this["IsReturningPartialNonApprovedLocalizedThumbnailsEnabled"];

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
