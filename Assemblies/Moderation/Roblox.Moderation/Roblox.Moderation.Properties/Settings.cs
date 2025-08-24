using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Moderation.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
public sealed class Settings : ApplicationSettingsBase, ISettings
{
    private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

    private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

    public static Settings Default => defaultInstance;

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public int UserCrispPercentage => (int)this["UserCrispPercentage"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    public string ModerationNewConnectionString => (string)this["ModerationNewConnectionString"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public int RegularExpressionPerformanceThresholdInMillisecond => (int)this["RegularExpressionPerformanceThresholdInMillisecond"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool CommunitySiftTextFilteringEnabled => (bool)this["CommunitySiftTextFilteringEnabled"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool CommunitySiftTextFilteringWhitelistOnly => (bool)this["CommunitySiftTextFilteringWhitelistOnly"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string ModerationAgnosticAssetRequestSecretKey => (string)this["ModerationAgnosticAssetRequestSecretKey"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("2")]
    public int GetOrCreateUnexpiredEntityAttempts => (int)this["GetOrCreateUnexpiredEntityAttempts"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    public string dbConnectionString_RobloxModeration => (string)this["dbConnectionString_RobloxModeration"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    public bool EnableAutoModeration => (bool)this["EnableAutoModeration"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string WebSiteApiKey => (string)this["WebSiteApiKey"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    public string dbConnectionString_RobloxUsers => (string)this["dbConnectionString_RobloxUsers"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("2")]
    public int NumberOfThreads => (int)this["NumberOfThreads"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("1")]
    public byte HighPriorityReportThreshold => (byte)this["HighPriorityReportThreshold"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool ReportAbuseCategoryEnabled => (bool)this["ReportAbuseCategoryEnabled"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public double HighPriorityAbuseQueueUsagePercentage => (double)this["HighPriorityAbuseQueueUsagePercentage"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool ChatReportFilterEnabled => (bool)this["ChatReportFilterEnabled"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Bullying, Harassment, Hate Speech")]
    public string HarassmentReportCategoryInternalName => (string)this["HarassmentReportCategoryInternalName"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("7")]
    public byte InappropriateContentReportCategoryID => (byte)this["InappropriateContentReportCategoryID"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool CalculateReportProbabilities => (bool)this["CalculateReportProbabilities"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool EnableReportFilteringBasedOnReportProbabilities => (bool)this["EnableReportFilteringBasedOnReportProbabilities"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("200")]
    public double MaximumReportsPerModerator => (double)this["MaximumReportsPerModerator"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("10")]
    public int MinimumSubmitterRankForHighPriority => (int)this["MinimumSubmitterRankForHighPriority"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public double HighPriorityPunishmentQueueUsagePercentage => (double)this["HighPriorityPunishmentQueueUsagePercentage"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool IsRemoteCacheForItemStatusEnabled => (bool)this["IsRemoteCacheForItemStatusEnabled"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("1")]
    public long AssetArchiveOwnerUserId => (long)this["AssetArchiveOwnerUserId"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public long DefaultTShirtId => (long)this["DefaultTShirtId"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public long DefaultShirtId => (long)this["DefaultShirtId"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public long DefaultPantsId => (long)this["DefaultPantsId"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public long DefaultDecalId => (long)this["DefaultDecalId"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public long DefaultAudioId => (long)this["DefaultAudioId"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public long DefaultMeshPartId => (long)this["DefaultMeshPartId"];

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool IsGetByHashUnicodeEnabled => (bool)this["IsGetByHashUnicodeEnabled"];

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
