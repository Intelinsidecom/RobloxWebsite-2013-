using System;

namespace Roblox.Common.Properties;

public interface ISettings
{
	object this[string propertyName] { get; set; }

	string AccessKey { get; }

	string AlternateAccessKey { get; }

	string ApplicationURL { get; }

	string BetaFeaturePlaceIds { get; }

	string BillingConnectionString { get; }

	string CacheReplicatorAddress { get; }

	int CacheReplicatorBatchSize { get; }

	string CacheReplicatorNicPrefix { get; }

	int CacheReplicatorPort { get; }

	string CacheReplicatorSendTimeout { get; }

	string CacheReplicatorWaitTime { get; }

	string ClientMacInstallUrl { get; }

	int ClientPresenceUpdateIntervalInSeconds { get; }

	string ClientVersion { get; }

	string CrawlerUserAgentRegex { get; }

	int DatabaseBulkQueryLimit { get; }

	bool EnableDosArrestRealIpHeaderForOriginIP { get; }

	bool EnableXForwardedForOriginIp { get; }

	bool EnableXForwardedProtoOriginProtocol { get; }

	bool EnableSecureIpHeadersForOriginIp { get; }

	bool EnableSecureIpHeadersHashCheck { get; }

	bool EnableWhitelistProxiedIpHeadersForOriginIp { get; }

	string SecureIpEdgeProxySecretKey { get; }

	string SecureIpCnProxySecretKey { get; }

	string SecureIpCnProxySecretKey2 { get; }

	int EnvironmentId { get; }

	string EnvironmentIdentifier { get; }

	bool FacebookDescriptionEnabled { get; }

	bool FacebookUploadEnabled { get; }

	bool IncludeTestEmailIdentifiers { get; }

	int MaxMemorySizeForImageUploadingInMB { get; }

	uint PgmWindowSizeInMB { get; }

	TimeSpan PgmWindowSizeTimeSpan { get; }

	string PlaceVisitAccessKey { get; }

	bool ReplicateLocalCache { get; }

	bool ReuseCrawlerUserAgentRegex { get; }

	bool VerifyBothGameServerIpAndAccessKey { get; }

	bool EnableProxyUrlDetection { get; }

	string ProxyUrlDomainsCsv { get; }

	bool EntityHelperUsesCacheMultigetV4 { get; }
}
