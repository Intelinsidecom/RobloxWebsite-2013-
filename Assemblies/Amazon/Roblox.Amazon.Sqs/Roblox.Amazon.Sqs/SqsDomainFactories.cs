using System;
using Roblox.Amazon.Sqs.Properties;
using Roblox.EventLog;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// The domain factories class for holding reference of all factory objects needed for Sqs.
/// </summary>
public class SqsDomainFactories
{
	internal virtual ISettings Settings { get; }

	internal virtual ILogger Logger { get; }

	internal virtual ISqsClientFactory SqsClientFactory { get; }

	internal virtual IBatchDeleterFactory BatchDeleterFactory { get; }

	internal virtual ISqsReadWriteDeleteClientFactory SqsReadWriteDeleteClientFactory { get; }

	internal virtual ISqsPerformanceMonitorFactory SqsPerformanceMonitorFactory { get; }

	/// <summary>
	/// <see cref="T:Roblox.Amazon.Sqs.ISqsReceiptFactory" />
	/// </summary>
	public ISqsReceiptFactory SqsReceiptFactory { get; }

	/// <summary>
	/// <see cref="T:Roblox.Amazon.Sqs.ISqsConfigSettingsFactory" />
	/// </summary>
	public ISqsConfigSettingsFactory SqsConfigSettingsFactory { get; }

	/// <summary>
	/// <see cref="T:Roblox.Amazon.Sqs.ISqsConsumerFactory" />
	/// </summary>
	public ISqsConsumerFactory SqsConsumerFactory { get; }

	/// <summary>
	/// Default constructor for <see cref="T:Roblox.Amazon.Sqs.SqsDomainFactories" />.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Throws when logger or settings is null.</exception>
	public SqsDomainFactories(ILogger logger)
		: this(logger, Roblox.Amazon.Sqs.Properties.Settings.Default)
	{
	}

	internal SqsDomainFactories(ILogger logger, ISettings settings)
	{
		Settings = settings ?? throw new ArgumentNullException("settings");
		Logger = logger ?? throw new ArgumentNullException("logger");
		SqsClientFactory = new SqsClientFactory();
		BatchDeleterFactory = new BatchDeleterFactory();
		SqsReadWriteDeleteClientFactory = new SqsReadWriteDeleteClientFactory(this);
		SqsPerformanceMonitorFactory = new SqsPerformanceMonitorFactory();
		SqsReceiptFactory = new SqsReceiptFactory();
		SqsConfigSettingsFactory = new SqsConfigSettingsFactory();
		SqsConsumerFactory = new SqsConsumerFactory(this);
	}
}
