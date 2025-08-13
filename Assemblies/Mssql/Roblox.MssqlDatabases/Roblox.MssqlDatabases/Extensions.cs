using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Instrumentation;
using Roblox.Mssql;
using Roblox.MssqlDatabases.Properties;

namespace Roblox.MssqlDatabases;

public static class Extensions
{
	private static readonly ConcurrentDictionary<RobloxDatabase, Func<string>> _ConnectionStringGetterCache = new ConcurrentDictionary<RobloxDatabase, Func<string>>();

	private static readonly DatabaseRegistry _DatabaseRegistry = new DatabaseRegistry(BuildDatabaseObserver);

	private static readonly Settings _Settings = Settings.Default;

	private static readonly Type _SettingsType = ((object)_Settings).GetType();

	private static readonly ConcurrentDictionary<RobloxDatabase, Func<TimeSpan>> _CommandTimeoutGetterCache = new ConcurrentDictionary<RobloxDatabase, Func<TimeSpan>>();

	private static readonly TimeoutSettings _TimeoutSettings = TimeoutSettings.Default;

	private static readonly Type _TimeoutSettingsType = ((object)_TimeoutSettings).GetType();

	private static readonly Func<TimeSpan> _DefaultDatabaseTimeoutGetter = () => _TimeoutSettings.DefaultCommandTimeout;

	public static Func<string> GetConnectionStringGetter(this RobloxDatabase robloxDatabase)
	{
		return _ConnectionStringGetterCache.GetOrAdd(robloxDatabase, delegate(RobloxDatabase db)
		{
			string text = db.ToString();
			PropertyInfo? property = _SettingsType.GetProperty(text);
			if (property == null)
			{
				throw new Exception("ConnectionString for database " + text + " is not defined.");
			}
			MethodInfo getMethod = property.GetGetMethod();
			Func<Settings, string> rawDelegate = (Func<Settings, string>)getMethod.CreateDelegate(typeof(Func<Settings, string>));
			return () => rawDelegate(_Settings);
		});
	}

	public static Func<TimeSpan> GetCommandTimeoutGetter(this RobloxDatabase robloxDatabase)
	{
		return _CommandTimeoutGetterCache.GetOrAdd(robloxDatabase, delegate(RobloxDatabase db)
		{
			string name = db.ToString();
			PropertyInfo property = _TimeoutSettingsType.GetProperty(name);
			if (property == null)
			{
				return _DefaultDatabaseTimeoutGetter;
			}
			MethodInfo getMethod = property.GetGetMethod();
			Func<TimeoutSettings, TimeSpan> rawDelegate = (Func<TimeoutSettings, TimeSpan>)getMethod.CreateDelegate(typeof(Func<TimeoutSettings, TimeSpan>));
			return () => rawDelegate(_TimeoutSettings);
		});
	}

	public static void ValidateDatabase(this RobloxDatabase robloxDatabase)
	{
		_DatabaseRegistry.GetDatabase(robloxDatabase);
	}

	public static int ExecuteNonQuery(this RobloxDatabase robloxDatabase, string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return _DatabaseRegistry.GetDatabase(robloxDatabase).ExecuteNonQuery(commandText, sqlParameters, commandType, commandTimeout, applicationIntent);
	}

	public static Task<int> ExecuteNonQueryAsync(this RobloxDatabase robloxDatabase, string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return _DatabaseRegistry.GetDatabase(robloxDatabase).ExecuteNonQueryAsync(commandText, sqlParameters, commandType, cancellationToken, commandTimeout, applicationIntent);
	}

	public static IEnumerable<IDictionary<string, object>> ExecuteReader(this RobloxDatabase robloxDatabase, string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return _DatabaseRegistry.GetDatabase(robloxDatabase).ExecuteReader(commandText, sqlParameters, commandType, commandTimeout, applicationIntent);
	}

	public static Task<IEnumerable<IDictionary<string, object>>> ExecuteReaderAsync(this RobloxDatabase robloxDatabase, string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return _DatabaseRegistry.GetDatabase(robloxDatabase).ExecuteReaderAsync(commandText, sqlParameters, commandType, cancellationToken, commandTimeout, applicationIntent);
	}

	public static object ExecuteScalar(this RobloxDatabase robloxDatabase, string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return _DatabaseRegistry.GetDatabase(robloxDatabase).ExecuteScalar(commandText, sqlParameters, commandType, commandTimeout, applicationIntent);
	}

	public static Task<object> ExecuteScalarAsync(this RobloxDatabase robloxDatabase, string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return _DatabaseRegistry.GetDatabase(robloxDatabase).ExecuteScalarAsync(commandText, sqlParameters, commandType, cancellationToken, commandTimeout, applicationIntent);
	}

	public static string GetConnectionString(this RobloxDatabase robloxDatabase)
	{
		return _DatabaseRegistry.GetDatabase(robloxDatabase).ConnectionString;
	}

	public static string GetConnectionStringForAsync(this RobloxDatabase robloxDatabase)
	{
		return _DatabaseRegistry.GetDatabase(robloxDatabase).ConnectionStringAsync;
	}

	public static TimeSpan GetCommandTimeout(this RobloxDatabase robloxDatabase)
	{
		return _DatabaseRegistry.GetDatabase(robloxDatabase).CommandTimeout;
	}

	public static string GetUtilizedConnectionString(this RobloxDatabase robloxDatabase, ApplicationIntent? applicationIntent)
	{
		return _DatabaseRegistry.GetDatabase(robloxDatabase).GetUtilizedConnectionString(applicationIntent);
	}

	public static string GetUtilizedConnectionStringForAsync(this RobloxDatabase robloxDatabase, ApplicationIntent? applicationIntent)
	{
		return _DatabaseRegistry.GetDatabase(robloxDatabase).GetUtilizedConnectionStringAsync(applicationIntent);
	}

	private static IDatabaseObserver BuildDatabaseObserver(IDatabase database)
	{
		return new DatabaseObserver(database, StaticCounterRegistry.Instance);
	}
}
