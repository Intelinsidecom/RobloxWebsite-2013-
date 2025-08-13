using System;
using System.Collections.Generic;
using Roblox.Mssql;

namespace Roblox.MssqlDatabases;

public sealed class DatabaseRegistry : IDisposable
{
	private readonly Func<IDatabase, IDatabaseObserver> _DatabaseObserverBuilder;

	private readonly Dictionary<RobloxDatabase, Lazy<MonitoredGuardedDatabase>> _Databases = new Dictionary<RobloxDatabase, Lazy<MonitoredGuardedDatabase>>();

	private bool _IsDisposed;

	private static readonly TimeSpan _DefaultRetryInterval = TimeSpan.FromMilliseconds(100.0);

	public DatabaseRegistry(Func<IDatabase, IDatabaseObserver> databaseObserverBuilder)
	{
		_DatabaseObserverBuilder = databaseObserverBuilder ?? throw new ArgumentNullException("databaseObserverBuilder");
		RobloxDatabase[] array = (RobloxDatabase[])Enum.GetValues(typeof(RobloxDatabase));
		foreach (RobloxDatabase robloxDatabase in array)
		{
			RobloxDatabase rd = robloxDatabase;
			Lazy<MonitoredGuardedDatabase> lazyDatabase = new Lazy<MonitoredGuardedDatabase>(() => BuildDatabase(rd));
			_Databases.Add(robloxDatabase, lazyDatabase);
		}
	}

	public void Dispose()
	{
		if (_IsDisposed)
		{
			return;
		}
		foreach (KeyValuePair<RobloxDatabase, Lazy<MonitoredGuardedDatabase>> database in _Databases)
		{
			Lazy<MonitoredGuardedDatabase> lazy = database.Value;
			if (lazy.IsValueCreated)
			{
				lazy.Value?.Dispose();
			}
		}
		_IsDisposed = true;
	}

	public Database GetDatabase(RobloxDatabase robloxDatabase)
	{
		if (!_Databases.TryGetValue(robloxDatabase, out var lazyDatabase))
		{
			throw new KeyNotFoundException("Unknown database: " + robloxDatabase);
		}
		return lazyDatabase.Value;
	}

	private MonitoredGuardedDatabase BuildDatabase(RobloxDatabase robloxDatabase)
	{
		string name = robloxDatabase.ToString();
		Func<string> connectionStringGetter = robloxDatabase.GetConnectionStringGetter();
		Func<TimeSpan> commandTimeoutGetter = robloxDatabase.GetCommandTimeoutGetter();
		return new MonitoredGuardedDatabase(name, connectionStringGetter, commandTimeoutGetter, _DefaultRetryInterval, _DatabaseObserverBuilder);
	}
}
