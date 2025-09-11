using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class GameSearchPage : ApplicationSettingsBase
{
	private static GameSearchPage defaultInstance = (GameSearchPage)SettingsBase.Synchronized(new GameSearchPage());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static GameSearchPage Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchKeywordSuggestionEnabled => (bool)this["GameSearchKeywordSuggestionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("production_V1")]
	public string GameSearchKeywordSuggestionAlgorithmName => (string)this["GameSearchKeywordSuggestionAlgorithmName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("default")]
	public string GameSearchKeywordSuggestionControlGroupAlgorithmName => (string)this["GameSearchKeywordSuggestionControlGroupAlgorithmName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameSearchBucketBoostRolloutPercentage => (int)this["GameSearchBucketBoostRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchBucketBoostRolloutEnabled => (bool)this["GameSearchBucketBoostRolloutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool GenreFilterEnabled => (bool)this["GenreFilterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDisplayingPlaceholderForNullThumbnailGameCardEnabled => (bool)this["IsDisplayingPlaceholderForNullThumbnailGameCardEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGamesThumbnailAsyncEnabledForAll => (bool)this["IsGamesThumbnailAsyncEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGamesThumbnailAsyncEnabledForSoothsayers => (bool)this["IsGamesThumbnailAsyncEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameSearchSortFilterPerformanceCounterEnabled => (bool)this["IsGameSearchSortFilterPerformanceCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameSearchUseContentFreshnessQueryPercentage => (int)this["GameSearchUseContentFreshnessQueryPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchUseContentFreshnessQueryEnabled => (bool)this["GameSearchUseContentFreshnessQueryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchFilterOutInactiveGamesEnabled => (bool)this["GameSearchFilterOutInactiveGamesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchFilterOutInactiveGamesForSoothsayersEnabled => (bool)this["GameSearchFilterOutInactiveGamesForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchFilterOutInactiveGamesForAllUsersEnabled => (bool)this["GameSearchFilterOutInactiveGamesForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameSearchFilterOutInactiveGamesRolloutPercentage => (int)this["GameSearchFilterOutInactiveGamesRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByGlobalScoreEnabled => (bool)this["IsPlacesSortByGlobalScoreEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByGlobalScoreForAllUsersEnabled => (bool)this["IsPlacesSortByGlobalScoreForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByGlobalScoreForSoothsayersEnabled => (bool)this["IsPlacesSortByGlobalScoreForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsPlacesSortByGlobalScoreRolloutPercentage => (int)this["IsPlacesSortByGlobalScoreRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllGamesElasticSearchIndexEnabled => (bool)this["AllGamesElasticSearchIndexEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBoostGamesWithGoodThumbnailImageEnabled => (bool)this["IsBoostGamesWithGoodThumbnailImageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBoostGamesWithGoodGameDetailImageEnabled => (bool)this["IsBoostGamesWithGoodGameDetailImageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBoostGamesHavingGoodDescriptionEnabled => (bool)this["IsBoostGamesHavingGoodDescriptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBoostGamesHavingGoodTitleEnabled => (bool)this["IsBoostGamesHavingGoodTitleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUseGoodDescriptionEnabled => (bool)this["IsUseGoodDescriptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllGamesElasticSearchIndexEnabledAllUsersEnabled => (bool)this["AllGamesElasticSearchIndexEnabledAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllGamesElasticSearchIndexEnabledForSoothsayersEnabled => (bool)this["AllGamesElasticSearchIndexEnabledForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AllGamesElasticSearchIndexEnabledRolloutPercentage => (int)this["AllGamesElasticSearchIndexEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FilterGamesByDeviceTypeForAllUsersEnabled => (bool)this["FilterGamesByDeviceTypeForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FilterGamesByDeviceTypeForSoothsayersEnabled => (bool)this["FilterGamesByDeviceTypeForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FilterGamesByDeviceTypeRolloutPercentage => (int)this["FilterGamesByDeviceTypeRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FilterGamesByDeviceTypeEnabled => (bool)this["FilterGamesByDeviceTypeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularSortUnder13PlayersEnabled => (bool)this["GameSearchPopularSortUnder13PlayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularSortUnder13PlayersForAllUsersEnabled => (bool)this["GameSearchPopularSortUnder13PlayersForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularSortUnder13PlayersForSoothsayersEnabled => (bool)this["GameSearchPopularSortUnder13PlayersForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularInCountrySortUnder13PlayersEnabled => (bool)this["GameSearchPopularInCountrySortUnder13PlayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularInCountrySortUnder13PlayersForAllUsersEnabled => (bool)this["GameSearchPopularInCountrySortUnder13PlayersForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularInCountrySortUnder13PlayersForSoothsayersEnabled => (bool)this["GameSearchPopularInCountrySortUnder13PlayersForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularSortOver13PlayersEnabled => (bool)this["GameSearchPopularSortOver13PlayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularSortOver13PlayersForAllUsersEnabled => (bool)this["GameSearchPopularSortOver13PlayersForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularSortOver13PlayersForSoothsayersEnabled => (bool)this["GameSearchPopularSortOver13PlayersForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularInCountrySortOver13PlayersEnabled => (bool)this["GameSearchPopularInCountrySortOver13PlayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularInCountrySortOver13PlayersForAllUsersEnabled => (bool)this["GameSearchPopularInCountrySortOver13PlayersForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchPopularInCountrySortOver13PlayersForSoothsayersEnabled => (bool)this["GameSearchPopularInCountrySortOver13PlayersForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFeaturedSearchEnabled => (bool)this["IsFeaturedSearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFeaturedSearchForSoothsayersEnabled => (bool)this["IsFeaturedSearchForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FeaturedSearchRolloutPercentage => (int)this["FeaturedSearchRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFeaturedGameThumbnailEnabled => (bool)this["IsFeaturedGameThumbnailEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFeaturedGameThumbnailForSoothsayersEnabled => (bool)this["IsFeaturedGameThumbnailForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FeaturedGameThumbnailRolloutPercentage => (int)this["FeaturedGameThumbnailRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchTopRatedSortUnder13PlayersEnabled => (bool)this["GameSearchTopRatedSortUnder13PlayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchTopRatedSortOver13PlayersEnabled => (bool)this["GameSearchTopRatedSortOver13PlayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageReferrerWhitelist => (string)this["GamesPageReferrerWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("obby,tycoon,simulator")]
	public string GameSearchQueriesForPlaySessions => (string)this["GameSearchQueriesForPlaySessions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByPlaySessionsEnabled => (bool)this["IsPlacesSortByPlaySessionsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByPlaySessionsForAllUsersEnabled => (bool)this["IsPlacesSortByPlaySessionsForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByPlaySessionsForSoothsayersEnabled => (bool)this["IsPlacesSortByPlaySessionsForSoothsayersEnabled"];

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PlacesSortByPlaySessionsRolloutPercentage
	{
		get
		{
			return (int)this["PlacesSortByPlaySessionsRolloutPercentage"];
		}
		set
		{
			this["PlacesSortByPlaySessionsRolloutPercentage"] = value;
		}
	}

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByPlaySessionsRolloutEnabled => (bool)this["IsPlacesSortByPlaySessionsRolloutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameSortsLoadMoreGamesEnabled => (bool)this["IsGameSortsLoadMoreGamesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPolicyFilterLabelingForGameSearchEnabled => (bool)this["IsPolicyFilterLabelingForGameSearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByQualitySignalFunctionEnabled => (bool)this["IsPlacesSortByQualitySignalFunctionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByQualitySignalFunctionForAllUsersEnabled => (bool)this["IsPlacesSortByQualitySignalFunctionForAllUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByQualitySignalFunctionForSoothsayersEnabled => (bool)this["IsPlacesSortByQualitySignalFunctionForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlacesSortByQualitySignalFunctionRolloutEnabled => (bool)this["IsPlacesSortByQualitySignalFunctionRolloutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PlacesSortByQualitySignalFunctionRolloutPercentage => (int)this["PlacesSortByQualitySignalFunctionRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChinaWhiteListLabel => (string)this["ChinaWhiteListLabel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFloodCheckDisabledForGameSortsMoreResultsEndpoints => (bool)this["IsFloodCheckDisabledForGameSortsMoreResultsEndpoints"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisableKeywordStatsForQualitySignalFunction => (bool)this["DisableKeywordStatsForQualitySignalFunction"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPolicyFilterLabelingForRunningGamesEnabled => (bool)this["IsPolicyFilterLabelingForRunningGamesEnabled"];

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

	internal GameSearchPage()
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
