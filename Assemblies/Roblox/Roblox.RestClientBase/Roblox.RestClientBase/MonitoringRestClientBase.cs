using Roblox.Instrumentation;
using Roblox.RestClientBase.Monitoring;

namespace Roblox.RestClientBase;

/// <summary>
/// A client base which enables monitoring.
/// </summary>
/// <seealso cref="T:Roblox.RestClientBase.RestClientBase" />
public abstract class MonitoringRestClientBase : RestClientBase
{
	private bool _IsMonitoring;

	private readonly EventMonitoringListener _Listener;

	private readonly object _Sync = new object();

	protected MonitoringRestClientBase(ICounterRegistry counterRegistry)
	{
		_Listener = new EventMonitoringListener(counterRegistry, this);
	}

	protected override void OnRequestStarting()
	{
		StartMonitoring();
	}

	public void StartMonitoring()
	{
		if (_IsMonitoring)
		{
			return;
		}
		lock (_Sync)
		{
			if (_IsMonitoring)
			{
				return;
			}
			_IsMonitoring = true;
		}
		_Listener.Register();
	}

	public void StopMonitoring()
	{
		if (!_IsMonitoring)
		{
			return;
		}
		lock (_Sync)
		{
			if (!_IsMonitoring)
			{
				return;
			}
			_IsMonitoring = false;
		}
		_Listener.Unregister();
	}
}
