using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Mssql;

public class MonitoredGuardedDatabase : GuardedDatabase
{
	private readonly Func<IDatabase, IDatabaseObserver> _DatabaseObserverBuilder;

	private bool _IsDisposed;

	private bool _IsMonitoring;

	private IDatabaseObserver _DatabaseObserver;

	private SemaphoreSlim _Semaphore = new SemaphoreSlim(1, 1);

	public MonitoredGuardedDatabase(string name, Func<string> connectionStringGetter, Func<TimeSpan> commandTimeoutGetter, TimeSpan retryInterval, Func<IDatabase, IDatabaseObserver> databaseObserverBuilder)
		: base(name, connectionStringGetter, commandTimeoutGetter, retryInterval)
	{
		_DatabaseObserverBuilder = databaseObserverBuilder ?? throw new ArgumentNullException("databaseObserverBuilder");
	}

	protected override void Dispose(bool disposing)
	{
		if (_IsDisposed)
		{
			return;
		}
		if (disposing)
		{
			StopMonitoring();
			if (_Semaphore != null)
			{
				_Semaphore.Dispose();
				_Semaphore = null;
			}
		}
		_IsDisposed = true;
	}

	protected override void OnExecutionStarting()
	{
		StartMonitoring();
	}

	protected override Task OnExecutionStartingAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return StartMonitoringAsync(cancellationToken);
	}

	public void StartMonitoring()
	{
		if (_IsDisposed)
		{
			throw new ObjectDisposedException(GetType().ToString());
		}
		if (_IsMonitoring)
		{
			return;
		}
		try
		{
			_Semaphore.Wait();
			if (_IsMonitoring)
			{
				return;
			}
			_IsMonitoring = true;
		}
		finally
		{
			_Semaphore.Release();
		}
		_DatabaseObserver = _DatabaseObserverBuilder(this);
		_DatabaseObserver.Register();
	}

	public async Task StartMonitoringAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (_IsDisposed)
		{
			throw new ObjectDisposedException(GetType().ToString());
		}
		if (_IsMonitoring)
		{
			return;
		}
		try
		{
			await _Semaphore.WaitAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (_IsMonitoring)
			{
				return;
			}
			_IsMonitoring = true;
		}
		finally
		{
			_Semaphore.Release();
		}
		_DatabaseObserver = _DatabaseObserverBuilder(this);
		_DatabaseObserver.Register();
	}

	public void StopMonitoring()
	{
		if (!_IsMonitoring)
		{
			return;
		}
		try
		{
			_Semaphore.Wait();
			if (!_IsMonitoring)
			{
				return;
			}
			_IsMonitoring = false;
		}
		finally
		{
			_Semaphore.Release();
		}
		_DatabaseObserver.Dispose();
		_DatabaseObserver = null;
	}

	public async Task StopMonitoringAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!_IsMonitoring)
		{
			return;
		}
		try
		{
			await _Semaphore.WaitAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (!_IsMonitoring)
			{
				return;
			}
			_IsMonitoring = false;
		}
		finally
		{
			_Semaphore.Release();
		}
		_DatabaseObserver.Dispose();
		_DatabaseObserver = null;
	}
}
