using System;
using System.Collections.Generic;
using System.Threading;
using Roblox.Instrumentation.Infrastructure;
using Roblox.Instrumentation.PrometheusListener;

namespace Roblox.Instrumentation;

public sealed class CounterReporter : IDisposable, ICounterReporter
{
	internal static readonly TimeSpan SubmissionInterval = TimeSpan.FromSeconds(30.0);

	private static readonly CounterKey _NumberOfDataPointsSentCounterKey = new CounterKey("Roblox.Instrumentation", "NumberOfDataPointsSent", null);

	private readonly ICounterRegistry _CounterRegistry;

	private readonly Action<Exception> _ExceptionHandler;

	private readonly IConfigurationProvider _ConfigurationProvider;

	private readonly Timer _Timer;

	private readonly InfluxWriter _InfluxWriter;

	public CounterReporter(ICounterRegistry counterRegistry, Action<Exception> exceptionHandler, string machineName = null)
		: this(counterRegistry, exceptionHandler, new InfrastructureServiceConfigurationProvider(machineName, exceptionHandler))
	{
		PrometheusServerWrapper.Instance.MachineName = machineName ?? "null";
	}

	public CounterReporter(ICounterRegistry counterRegistry, Action<Exception> exceptionHandler, IConfigurationProvider configurationProvider)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_ExceptionHandler = exceptionHandler ?? throw new ArgumentNullException("exceptionHandler");
		_ConfigurationProvider = configurationProvider ?? throw new ArgumentNullException("configurationProvider");
		_InfluxWriter = new InfluxWriter(exceptionHandler);
		_Timer = new Timer(delegate
		{
			PersistCounterValues();
		});
	}

	public void Start()
	{
		_Timer.Change(SubmissionInterval, SubmissionInterval);
	}

	public void Dispose()
	{
		if (_ConfigurationProvider is IDisposable disposable)
		{
			disposable.Dispose();
		}
		_Timer.Dispose();
	}

	public static CounterReporter CreateAndStart(ICounterRegistry counterRegistry, Action<Exception> exceptionHandler)
	{
		CounterReporter counterReporter = new CounterReporter(counterRegistry, exceptionHandler);
		counterReporter.Start();
		return counterReporter;
	}

	public static CounterReporter CreateAndStart(ICounterRegistry counterRegistry, Action<Exception> exceptionHandler, IConfigurationProvider configurationProvider)
	{
		CounterReporter counterReporter = new CounterReporter(counterRegistry, exceptionHandler, configurationProvider);
		counterReporter.Start();
		return counterReporter;
	}

	internal void PersistCounterValues()
	{
		try
		{
			ICollectionConfiguration configuration = _ConfigurationProvider.GetConfiguration();
			if (configuration != null)
			{
				IReadOnlyCollection<KeyValuePair<CounterKey, double>> readOnlyCollection = _CounterRegistry.FlushCounters();
				List<KeyValuePair<CounterKey, double>> list = new List<KeyValuePair<CounterKey, double>>(readOnlyCollection.Count + 1);
				list.AddRange(readOnlyCollection);
				list.Add(new KeyValuePair<CounterKey, double>(_NumberOfDataPointsSentCounterKey, list.Count));
				_InfluxWriter.Persist(configuration, list);
				PrometheusServerWrapper.Instance.HostIdentifier = configuration.HostIdentifier ?? "null";
				PrometheusServerWrapper.Instance.ServerFarmIdentifier = configuration.FarmIdentifier ?? "null";
				PrometheusServerWrapper.Instance.SuperFarmIdentifier = configuration.SuperFarmIdentifier ?? "null";
			}
		}
		catch (Exception obj)
		{
			try
			{
				_ExceptionHandler(obj);
			}
			catch
			{
			}
		}
	}
}
