using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Roblox.EventLog;
using StackExchange.Redis;

namespace Roblox.Redis;

public class RedisListConfigurationBuffer : IRedisListConfigurationBuffer
{
	private const string _CertificateAbsolutePathPropertyName = "RedisBufferCertPath";

	private const string _CertificatePasswordPropertyName = "RedisBufferCertPassword";

	private readonly HashSet<string> _PropertiesRecreateConnection;

	private readonly ILogger _BackupLogger;

	private readonly Func<string> _RedisEndpointGetter;

	private readonly Func<string> _RedisListKeyGetter;

	private readonly Func<string> _RedisPasswordGetter;

	private readonly Func<bool> _RedisAbortConnectOnFailGetter;

	private readonly Func<int> _RedisConnectTimeoutGetter;

	private readonly Func<int> _RedisConnectRetryGetter;

	private readonly Func<string> _CertificateAbsolutePathGetter;

	private readonly Func<string> _CertificatePasswordGetter;

	public string RedisListKey => _RedisListKeyGetter();

	public RedisListConfigurationBuffer(string redisEndpointPropertyName, string redisPasswordPropertyName, string redisListKeyPropertyName, string redisAbortOnConnectFailPropertyName, string redisConnectTimeoutPropertyName, string redisConnectRetryPropertyName, ILogger backupLogger, Func<string> redisEndpointGetter, Func<string> redisListKeyGetter, Func<bool> redisAbortConnectOnFailGetter, Func<int> redisConnectTimeoutGetter, Func<int> redisConnectRetryGetter, Func<string> certificateAbsolutePathGetter, Func<string> certificatePasswordGetter, Func<string> redisPasswordGetter = null)
	{
		_PropertiesRecreateConnection = new HashSet<string> { redisEndpointPropertyName, redisPasswordPropertyName, redisListKeyPropertyName, redisAbortOnConnectFailPropertyName, redisConnectTimeoutPropertyName, redisConnectRetryPropertyName, "RedisBufferCertPath", "RedisBufferCertPassword" };
		_BackupLogger = backupLogger;
		_RedisEndpointGetter = redisEndpointGetter;
		_RedisListKeyGetter = redisListKeyGetter;
		_RedisPasswordGetter = redisPasswordGetter;
		_RedisAbortConnectOnFailGetter = redisAbortConnectOnFailGetter;
		_RedisConnectTimeoutGetter = redisConnectTimeoutGetter;
		_RedisConnectRetryGetter = redisConnectRetryGetter;
		_CertificateAbsolutePathGetter = certificateAbsolutePathGetter;
		_CertificatePasswordGetter = certificatePasswordGetter;
	}

	public X509Certificate OptionsOnCertificateSelection(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers)
	{
		try
		{
			return new X509Certificate2(_CertificateAbsolutePathGetter(), _CertificatePasswordGetter());
		}
		catch (CryptographicException arg)
		{
			_BackupLogger.Error($"There was a CryptographicException while trying to read a certificate from {_CertificateAbsolutePathGetter()}: {arg}");
			throw;
		}
		catch (Exception arg2)
		{
			_BackupLogger.Error($"There was an general exception thrown while trying to read certificates: {arg2}");
			throw;
		}
	}

	public ConfigurationOptions GetConfigurationOptions()
	{
		ConfigurationOptions configurationOptions = new ConfigurationOptions
		{
			EndPoints = { _RedisEndpointGetter() },
			Ssl = true,
			AbortOnConnectFail = _RedisAbortConnectOnFailGetter(),
			ConnectTimeout = _RedisConnectTimeoutGetter(),
			ConnectRetry = _RedisConnectRetryGetter()
		};
		if (!string.IsNullOrEmpty(_RedisPasswordGetter?.Invoke()))
		{
			configurationOptions.Password = _RedisPasswordGetter();
		}
		configurationOptions.CertificateSelection += OptionsOnCertificateSelection;
		return configurationOptions;
	}

	public bool NeedsReCreation(string propertyName)
	{
		return _PropertiesRecreateConnection.Contains(propertyName);
	}
}
