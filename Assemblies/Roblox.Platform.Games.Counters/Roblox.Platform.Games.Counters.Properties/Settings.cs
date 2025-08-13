using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Games.Counters.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
public sealed class Settings : ApplicationSettingsBase, ISettings
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
	[DefaultSettingValue("00:00:30")]
	public TimeSpan BufferedTimeBucketedGameCounterCommitInterval => (TimeSpan)this["BufferedTimeBucketedGameCounterCommitInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan BufferedAllTimeGameCounterCommitInterval => (TimeSpan)this["BufferedAllTimeGameCounterCommitInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("-1")]
	public int BufferedTimeBucketedGameCounterCommitMaxDegreeOfParallelism => (int)this["BufferedTimeBucketedGameCounterCommitMaxDegreeOfParallelism"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("-1")]
	public int BufferedAllTimeGameCounterCommitMaxDegreeOfParallelism => (int)this["BufferedAllTimeGameCounterCommitMaxDegreeOfParallelism"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan CounterCommitInterval => (TimeSpan)this["CounterCommitInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("-1")]
	public int MaxDegreeOfParallelism => (int)this["MaxDegreeOfParallelism"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan GameJoinFromVRCounterCommitInterval => (TimeSpan)this["GameJoinFromVRCounterCommitInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("-1")]
	public int GameJoinFromVRCounterMaxDegreeOfParallelism => (int)this["GameJoinFromVRCounterMaxDegreeOfParallelism"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MaxPlaySessionLength => (int)this["MaxPlaySessionLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SkipRecordingMaxLengthPlaySessions => (bool)this["SkipRecordingMaxLengthPlaySessions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("UserGameplay_TimeInGame")]
	public string TimeInGameCounterPrefix => (string)this["TimeInGameCounterPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("UserGameplay_TimeInGameForMonth")]
	public string TimeInGameMonthlyCounterPrefix => (string)this["TimeInGameMonthlyCounterPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreAggregatedCounterTypesForPlaceVisitsEnabled => (bool)this["AreAggregatedCounterTypesForPlaceVisitsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TimeInGameOverflowCorrectionEnabled => (bool)this["TimeInGameOverflowCorrectionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2017-11-01")]
	public DateTime TimeInGameOverflowCorrectStartDate => (DateTime)this["TimeInGameOverflowCorrectStartDate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("02:00:00")]
	public TimeSpan TimeInGameCacheCorrectedExpirationTime => (TimeSpan)this["TimeInGameCacheCorrectedExpirationTime"];

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
