using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.UniverseSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PlayerChoice")]
	public string DefaultUniverseAvatarType => (string)this["DefaultUniverseAvatarType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllScales")]
	public string DefaultUniverseScaleType => (string)this["DefaultUniverseScaleType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PlayerChoice")]
	public string DefaultUniverseAvatarAnimationType => (string)this["DefaultUniverseAvatarAnimationType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("OuterBox")]
	public string DefaultUniverseAvatarCollisionType => (string)this["DefaultUniverseAvatarCollisionType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsUniverseSettingsChangeSnsTopicArn => (string)this["AwsUniverseSettingsChangeSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AwsUniverseSettingsChangeTopicAccessKeyIdAndSecretCsv => (string)this["AwsUniverseSettingsChangeTopicAccessKeyIdAndSecretCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishToUniverseSettingsChangeTopicEnabled => (bool)this["IsPublishToUniverseSettingsChangeTopicEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Standard")]
	public string DefaultUniverseAvatarBodyType => (string)this["DefaultUniverseAvatarBodyType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Standard")]
	public string DefaultUniverseAvatarJointPositioningType => (string)this["DefaultUniverseAvatarJointPositioningType"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableRemoteCacheForUniverseAvatarSettingsEntity => (bool)this["EnableRemoteCacheForUniverseAvatarSettingsEntity"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PlayerChoice")]
	public string DefaultUniverseAvatarTypeForUnknownPlace => (string)this["DefaultUniverseAvatarTypeForUnknownPlace"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishToPlaceActiveDeactiveEnabled => (bool)this["IsPublishToPlaceActiveDeactiveEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PlayerChoice")]
	public string DefaultUniverseBodyTypeForUnknownPlace => (string)this["DefaultUniverseBodyTypeForUnknownPlace"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaxAvatarAssetOverridesPerUniverse => (int)this["MaxAvatarAssetOverridesPerUniverse"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Face,Head,Torso,LeftArm,RightArm,LeftLeg,RightLeg,TShirt,Shirt,Pants")]
	public string AllowedAssetOverrides => (string)this["AllowedAssetOverrides"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.90")]
	public decimal UniverseAvatarMinHeightDefault => (decimal)this["UniverseAvatarMinHeightDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.05")]
	public decimal UniverseAvatarMaxHeightDefault => (decimal)this["UniverseAvatarMaxHeightDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.70")]
	public decimal UniverseAvatarMinWidthDefault => (decimal)this["UniverseAvatarMinWidthDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal UniverseAvatarMaxWidthDefault => (decimal)this["UniverseAvatarMaxWidthDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.95")]
	public decimal UniverseAvatarMinHeadDefault => (decimal)this["UniverseAvatarMinHeadDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00")]
	public decimal UniverseAvatarMaxHeadDefault => (decimal)this["UniverseAvatarMaxHeadDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal UniverseAvatarMinBodyTypeDefault => (decimal)this["UniverseAvatarMinBodyTypeDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal UniverseAvatarMaxBodyTypeDefault => (decimal)this["UniverseAvatarMaxBodyTypeDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal UniverseAvatarMinProportionDefault => (decimal)this["UniverseAvatarMinProportionDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal UniverseAvatarMaxProportionDefault => (decimal)this["UniverseAvatarMaxProportionDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGameShutdownByDeveloperEnabled => (bool)this["IsGameShutdownByDeveloperEnabled"];

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
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
