using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Consul;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.ServiceDiscovery.Properties;

namespace Roblox.ServiceDiscovery;

public class ConsulHttpServiceResolver : IServiceResolver, INotifyPropertyChanged, IDisposable
{
	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly ISingleSetting<string> _ServiceNameSetting;

	private readonly IConsulClientProvider _ConsulClientProvider;

	private readonly string _EnvironmentName;

	private readonly Thread _Thread;

	private CancellationTokenSource _CancellationTokenSource;

	public ISet<IPEndPoint> EndPoints { get; private set; }

	public event PropertyChangedEventHandler PropertyChanged;

	[ExcludeFromCodeCoverage]
	public ConsulHttpServiceResolver(ILogger logger, IConsulClientProvider consulClientProvider, ISingleSetting<string> serviceNameSetting)
		: this(Settings.Default, logger, consulClientProvider, serviceNameSetting, RobloxEnvironment.Name)
	{
	}

	internal ConsulHttpServiceResolver(ISettings settings, ILogger logger, IConsulClientProvider consulClientProvider, ISingleSetting<string> serviceNameSetting, string environmentName)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_ServiceNameSetting = serviceNameSetting ?? throw new ArgumentNullException("serviceNameSetting");
		_ConsulClientProvider = consulClientProvider ?? throw new ArgumentNullException("consulClientProvider");
		_EnvironmentName = environmentName ?? throw new ArgumentNullException("environmentName");
		EndPoints = new HashSet<IPEndPoint>();
		_ServiceNameSetting.PropertyChanged += delegate
		{
			_CancellationTokenSource?.Cancel();
		};
		_ConsulClientProvider.PropertyChanged += delegate
		{
			_CancellationTokenSource?.Cancel();
		};
		_Thread = StartRefreshThread();
	}

	public void Dispose()
	{
		_Thread?.Abort();
	}

	private Thread StartRefreshThread()
	{
		Thread thread = new Thread(RefreshThread);
		thread.IsBackground = true;
		thread.Start();
		return thread;
	}

	private async void RefreshThread()
	{
		ulong? lastIndex = null;
		string lastServiceName = null;
		int failures = 0;
		while (true)
		{
			_CancellationTokenSource = new CancellationTokenSource();
			try
			{
				string newServiceName = _ServiceNameSetting.Value;
				if (newServiceName != lastServiceName)
				{
					_Logger.Info(() => $"ConsulHttpServiceResolver: Service name changed from {lastServiceName} to {newServiceName}.");
					lastServiceName = newServiceName;
					lastIndex = null;
				}
				lastIndex = await DoRefreshAsync(lastServiceName, lastIndex, _CancellationTokenSource.Token).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (TaskCanceledException)
			{
				_Logger.Debug(() => "ConsulHttpServiceResolver: TaskCanceledException in resolving thread.");
			}
			catch (Exception arg)
			{
				_Logger.Error($"ConsulHttpServiceResolver: Exception while resolving {lastServiceName}. There have been {failures} continuous failures. {arg}");
				lastIndex = null;
				await Task.Delay(DetermineBackoffDelayTime(failures, _Settings.ConsulBackoffBase, _Settings.MaximumConsulBackoff)).ConfigureAwait(continueOnCapturedContext: false);
				failures++;
				continue;
			}
			failures = 0;
		}
	}

	private async Task<ulong?> DoRefreshAsync(string serviceName, ulong? lastIndex, CancellationToken cancellationToken)
	{
		QueryOptions queryOptions = new QueryOptions();
		if (lastIndex.HasValue)
		{
			queryOptions.WaitTime = _Settings.ConsulLongPollingMaxWaitTime;
			queryOptions.WaitIndex = lastIndex.Value;
		}
		QueryResult<ServiceEntry[]> queryResult = await _ConsulClientProvider.Client.Health.Service(serviceName, _EnvironmentName, passingOnly: true, queryOptions, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (queryResult.StatusCode != HttpStatusCode.OK)
		{
			throw new Exception($"StatusCode while retrieving service endpoints: {queryResult.StatusCode}");
		}
		cancellationToken.ThrowIfCancellationRequested();
		IEnumerable<IPEndPoint> endpoints = ParseCatalogServiceResults(queryResult.Response);
		bool flag = UpdateEndpointsIfChanged(endpoints);
		_Logger.Info(flag ? ((Func<string>)(() => string.Format("Fetched new endpoints for {0}: {1}", serviceName, string.Join(", ", endpoints)))) : ((Func<string>)(() => $"Endpoints for {serviceName} have not changed.")));
		return queryResult.LastIndex;
	}

	private IEnumerable<IPEndPoint> ParseCatalogServiceResults(IEnumerable<ServiceEntry> catalogServices)
	{
		return catalogServices.Select((ServiceEntry s) => new IPEndPoint(IPAddress.Parse(s.Node.Address), s.Service.Port));
	}

	private TimeSpan DetermineBackoffDelayTime(int failures, TimeSpan backoffBase, TimeSpan maxBackoff)
	{
		return TimeSpan.FromTicks(Math.Min(backoffBase.Ticks * failures, maxBackoff.Ticks));
	}

	private bool UpdateEndpointsIfChanged(IEnumerable<IPEndPoint> newEndPoints)
	{
		HashSet<IPEndPoint> hashSet = new HashSet<IPEndPoint>(newEndPoints);
		if (EndPoints.SetEquals(hashSet))
		{
			return false;
		}
		EndPoints = hashSet;
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EndPoints"));
		return true;
	}
}
