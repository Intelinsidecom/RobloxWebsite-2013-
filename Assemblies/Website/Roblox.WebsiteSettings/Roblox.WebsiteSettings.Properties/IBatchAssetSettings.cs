namespace Roblox.WebsiteSettings.Properties;

public interface IBatchAssetSettings
{
	bool PlaceScriptInsertForbidden { get; }

	int TrackClientSideInsertsInEphemeralCountersPercentage { get; }

	bool CheckAssetTypeInAssetHandler { get; }

	bool IgnoreAssetTypeHeaderCheckForRobloxCreatedAssets { get; }

	bool AllowCreatorsToAccessInReviewAssets { get; }

	double StatisticalMetricsDatasetPercent { get; }

	bool LogRequestBody { get; }

	bool IsAudioAssetContentRestrictedAccessEnabled { get; }

	bool IsAudioAssetContentRestrictedAccessLoggingEnabled { get; }

	bool IsAudioAssetContentRestrictedAccessCounterEnabled { get; }

	string HashRequestBlacklistedAssetTypesCsv { get; }

	bool AdditionalChecksForAssetRequestsByHashEnabled { get; }

	/// <summary>
	/// Rollout percentage for whether audio which has been determined to contain copyrighted music should be replaced and marked.
	/// </summary>
	int AudioAssetCopyrightHeaderAndReplacementRolloutPercentage { get; }

	bool UsePlaceIdHeaderInsteadOfQueryString { get; }

	bool RobloxProxiedForHeaderForAssetDeliveryEnabled { get; }

	/// <summary>
	/// Whether or not the asset should be checked on retrieval for whether or not it is archived.
	/// </summary>
	bool ArchivedAssetCheckEnabled { get; }

	/// <summary>
	/// If the asset is archived this flag decides whether or not a location should be available.
	/// </summary>
	/// <remarks>
	/// Dependent on <see cref="P:Roblox.WebsiteSettings.Properties.IBatchAssetSettings.ArchivedAssetCheckEnabled" /> being <c>true</c>.
	/// </remarks>
	bool ArchivedAssetLocationEnabled { get; }

	/// <summary>
	/// Roll out % loading asset versions using assets platform to prevent load on db. 
	/// </summary>
	int AssetVersionReadFromPlatformRolloutPercentage { get; }

	bool UserGeneratedContentRenderingEnabledForCatalog { get; }

	bool UserGeneratedContentRenderingEnabledForCatalogItemCreators { get; }

	bool UserGeneratedContentRenderingEnabledForAll { get; }

	string UserGeneratedContentRenderingAssetTypeIdCsv { get; }
}
