using Roblox.ApiClientBase.Monitoring;
using Roblox.Instrumentation;

namespace Roblox.ApiClientBase;

public abstract class MonitoringApiClientBase : ApiClientBase
{
	private bool _IsMonitoring;

	private readonly EventMonitoringListener _Listener;

	private readonly object _Sync = new object();

	protected MonitoringApiClientBase(ICounterRegistry counterRegistry)
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
