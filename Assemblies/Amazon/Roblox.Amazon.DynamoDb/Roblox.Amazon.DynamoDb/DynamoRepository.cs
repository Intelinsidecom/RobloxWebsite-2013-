using System;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using Roblox.EventLog;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Represents a configurable Dynamo repository.
/// </summary>
/// <seealso cref="T:Roblox.Amazon.DynamoDb.IDynamoRepository" />
public class DynamoRepository : IDynamoRepository, IDisposable
{
	private readonly ILogger _Logger;

	private readonly IRobloxDynamoDbClientFactory _DynamoDbClientFactory;

	private DynamoRepositoryConfig _RepositoryConfig;

	private bool _Disposed;

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepository" />
	public IAmazonDynamoDB Client { get; private set; }

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepository" />
	public string ClientName { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryBase" /> class.
	/// </summary>
	/// <param name="repositoryConfig">The AWS DynamoDB credentials.</param>
	/// <param name="clientName">The name of the repository's client.</param>
	/// <param name="dynamoDbClientFactory">The <see cref="T:Roblox.Amazon.DynamoDb.IRobloxDynamoDbClientFactory" /> used to build the repository's client.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" /> used to log errors.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="repositoryConfig" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="clientName" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="dynamoDbClientFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="logger" /></exception>
	public DynamoRepository(DynamoRepositoryConfig repositoryConfig, string clientName, IRobloxDynamoDbClientFactory dynamoDbClientFactory, ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		ClientName = clientName ?? throw new ArgumentNullException("clientName");
		_RepositoryConfig = repositoryConfig ?? throw new ArgumentNullException("repositoryConfig");
		_DynamoDbClientFactory = dynamoDbClientFactory ?? RobloxDynamoDbClientFactory.Instance;
		Client = CreateClient(_RepositoryConfig, ClientName, _DynamoDbClientFactory.GetDefaultSettings());
		_DynamoDbClientFactory.DefaultClientSettingsChanged += RebuildClientOnDefaultSettingsChange;
	}

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepository" />
	public void Refresh(string awsAccessKey, string awsSecretKey)
	{
		DynamoRepositoryConfig newConfig = new DynamoRepositoryConfig(awsAccessKey, awsSecretKey, _RepositoryConfig.RegionEndpoint);
		Refresh(newConfig);
	}

	/// <inheritdoc cref="T:Roblox.Amazon.DynamoDb.IDynamoRepository" />
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
