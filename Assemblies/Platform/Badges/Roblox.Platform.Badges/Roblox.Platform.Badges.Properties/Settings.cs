using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using Roblox.Economy;

namespace Roblox.Platform.Badges.Properties;

/// <summary>
/// Settings for badges that aren't actual web settings
/// </summary>
/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
/// Temporary public (need to share temporary settings for switches) todo has to be internal after verification 
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	/// <inheritdoc cref="P:Roblox.Platform.Badges.Properties.ISettings.BadgePurchaseRobuxPrice" />
	public long BadgePurchaseRobuxPrice => Product.Badge.PriceInRobux ?? 100;

	/// <inheritdoc cref="P:Roblox.Platform.Badges.Properties.ISettings.BadgeMarketplaceProductId" />
	public long BadgeMarketplaceProductId => Product.Badge.ID;

	/// <inheritdoc cref="P:Roblox.Platform.Badges.Properties.ISettings.MaxBadgeNameLength" />
	public int MaxBadgeNameLength { get; } = 50;


	/// <inheritdoc cref="P:Roblox.Platform.Badges.Properties.ISettings.MaxBadgeDescriptionLength" />
	public int MaxBadgeDescriptionLength { get; } = 1000;


	/// <inheritdoc cref="P:Roblox.Platform.Badges.Properties.ISettings.MaxBadgeIconNameLength" />
	public int MaxBadgeIconNameLength { get; } = 50;


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
	public bool IsBadgeWithFullyModeratedTextBlocked => (bool)this["IsBadgeWithFullyModeratedTextBlocked"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int BadgeReaderGetBadgesPerCallLimit => (int)this["BadgeReaderGetBadgesPerCallLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public double BadgeRarityUniquenessCorrectionFactor => (double)this["BadgeRarityUniquenessCorrectionFactor"];

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
