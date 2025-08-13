using System;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using Roblox.EventLog;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// DynamoRepositoryBase
/// </summary>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IDynamoRepositoryBase" />
[Obsolete("Use DynamoRepository instead.")]
public class DynamoRepositoryBase : IDynamoRepositoryBase, IDisposable
{
	private readonly ILogger _Logger;

	/// <summary>
	/// Gets the AWS DynamoDB client configuration.
	/// </summary>
	private DynamoRepositoryConfig _RepositoryConfig;

	private readonly IRobloxDynamoDbClientFactory _DynamoDbClientFactory;

	private bool _Disposed;

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepositoryBase" />
	public string TableName { get; }

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepositoryBase" />
	public string ClientName { get; }

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepositoryBase" />
	public IAmazonDynamoDB Client { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryBase" /> class.
	/// </summary>
	/// <param name="repositoryConfig">The AWS DynamoDB client configuration.</param>
	/// <param name="robloxEnvironmentAbbreviation">The roblox environment abbreviation.</param>
	/// <param name="pureTableName">The pure name of the DynamoDB table.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="T:System.ArgumentNullException">credentials
	/// or
	/// logger
	/// or
	/// repositoryConfig</exception>
	/// <exception cref="T:System.ArgumentException">Environment abbreviation must be specified - robloxEnvironmentAbbreviation
	/// or
	/// Table name must be specified - pureTableName</exception>
	public DynamoRepositoryBase(DynamoRepositoryConfig repositoryConfig, string robloxEnvironmentAbbreviation, string pureTableName, ILogger logger)
		: this(repositoryConfig, robloxEnvironmentAbbreviation, pureTableName, null, logger)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryBase" /> class.
	/// </summary>
	/// <param name="repositoryConfig">The AWS DynamoDB credentials.</param>
	/// <param name="robloxEnvironmentAbbreviation">The roblox environment abbreviation.</param>
	/// <param name="pureTableName">The pure name of the DynamoDB table.</param>
	/// <param name="dynamoDbClientFactory">The dynamo database client factory.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="T:System.ArgumentException">Environment abbreviation must be specified - robloxEnvironmentAbbreviation
	/// or
	/// Table name must be specified - pureTableName</exception>
	/// <exception cref="T:System.ArgumentNullException">
	/// credentials
	/// or
	/// logger
	/// or
	/// repositoryConfig
	/// </exception>
	internal DynamoRepositoryBase(DynamoRepositoryConfig repositoryConfig, string robloxEnvironmentAbbreviation, string pureTableName, IRobloxDynamoDbClientFactory dynamoDbClientFactory, ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		if (string.IsNullOrWhiteSpace(robloxEnvironmentAbbreviation))
		{
			throw new ArgumentException("Environment abbreviation must be specified", "robloxEnvironmentAbbreviation");
		}
		if (string.IsNullOrWhiteSpace(pureTableName))
		{
			throw new ArgumentException("Table name must be specified", "pureTableName");
		}
		_RepositoryConfig = repositoryConfig ?? throw new ArgumentNullException("repositoryConfig");
		TableName = $"{robloxEnvironmentAbbreviation}_{pureTableName}";
		ClientName = $"DynamoRepository_{pureTableName}";
		_DynamoDbClientFactory = dynamoDbClientFactory ?? RobloxDynamoDbClientFactory.Instance;
		Client = CreateClient(_RepositoryConfig, ClientName, _DynamoDbClientFactory.GetDefaultSettings());
		_DynamoDbClientFactory.DefaultClientSettingsChanged += RebuildClientOnDefaultSettingsChange;
	}

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepositoryBase" />
	public void Refresh(string awsAccessKey, string awsSecretKey)
	{
		DynamoRepositoryConfig newConfig = new DynamoRepositoryConfig(awsAccessKey, awsSecretKey, _RepositoryConfig.RegionEndpoint);
		Refresh(newConfig);
	}

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepositoryBase" />
	public void Refresh(DynamoRepositoryConfig repositoryConfig)
	{
		if (repositoryConfig == null)
		{
			throw new ArgumentNullException("repositoryConfig");
		}
		if (_RepositoryConfig.Equals(repositoryConfig))
		{
			return;
		}
		_RepositoryConfig = repositoryConfig;
		try
		{
			Client = CreateClient(_RepositoryConfig, ClientName, _DynamoDbClientFactory.GetDefaultSettings());
		}
		catch (Exception ex2)
		{
			Exception ex3 = ex2;
			Exception ex = ex3;
			_Logger.Error(() => $"Fatal exception: DynamoDb client creation is failed on repository config refresh. Ex: {ex}.");
		}
	}

	private void RebuildClientOnDefaultSettingsChange(RobloxDynamoDbClientDefaultSettings defaultSettings)
	{
		try
		{
			Client = CreateClient(_RepositoryConfig, ClientName, defaultSettings);
		}
		catch (Exception ex2)
		{
			Exception ex3 = ex2;
			Exception ex = ex3;
			_Logger.Error(() => $"Fatal exception: DynamoDb client creation is failed on default client settings update. Ex: {ex}.");
		}
	}

	private IAmazonDynamoDB CreateClient(DynamoRepositoryConfig repositoryConfig, string clientInstanceName, RobloxDynamoDbClientDefaultSettings defaultSettings)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		RobloxDynamoDbClientConfig robloxDynamoDbClientConfig = new RobloxDynamoDbClientConfig(clientInstanceName);
		((ClientConfig)robloxDynamoDbClientConfig).MaxErrorRetry = repositoryConfig.MaxErrorRetry ?? defaultSettings.MaxErrorRetry;
		((ClientConfig)robloxDynamoDbClientConfig).RegionEndpoint = repositoryConfig.RegionEndpoint;
		robloxDynamoDbClientConfig.IsCircuitBreakerEnabled = defaultSettings.IsCircuitBreakerEnabled;
		((ClientConfig)robloxDynamoDbClientConfig).ThrottleRetries = repositoryConfig.IsThrottleRetriesEnabled ?? defaultSettings.IsThrottleRetriesEnabled;
		RobloxDynamoDbClientConfig config = robloxDynamoDbClientConfig;
		config.CircuitBreakerPolicyConfig.RetryInterval = defaultSettings.CircuitBreakerRetryInterval;
		config.CircuitBreakerPolicyConfig.FailuresAllowedBeforeTrip = defaultSettings.FailuresAllowedBeforeCircuitBreakerTrip;
		config.IsAsyncRequestTimeoutEnabled = defaultSettings.IsAsyncRequestTimeoutEnabled;
		((ClientConfig)config).ReadWriteTimeout = defaultSettings.ReadWriteTimeout;
		((ClientConfig)config).Timeout = repositoryConfig.RequestTimeout ?? defaultSettings.RequestTimeout;
		BasicAWSCredentials awsCredentials = new BasicAWSCredentials(repositoryConfig.AwsAccessKey, repositoryConfig.AwsSecretKey);
		return _DynamoDbClientFactory.Create((AWSCredentials)(object)awsCredentials, config);
	}

	/// <summary>
	/// Disposes the current instance.
	/// </summary>
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!_Disposed)
		{
			if (_DynamoDbClientFactory != null)
			{
				_DynamoDbClientFactory.DefaultClientSettingsChanged -= RebuildClientOnDefaultSettingsChange;
			}
			_Disposed = true;
		}
	}
}
