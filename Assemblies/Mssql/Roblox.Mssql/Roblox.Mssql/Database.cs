using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Mssql;

public class Database : IDatabase, IDisposable
{
	private readonly Func<string> _ConnectionStringGetter;

	private readonly Func<TimeSpan> _CommandTimeoutGetter;

	private long _RequestCounter;

	private int _CommandTimeoutInSeconds => (int)Math.Ceiling(CommandTimeout.TotalSeconds);

	public string ConnectionString => _ConnectionStringGetter();

	public string ConnectionStringAsync => _ConnectionStringGetter() + ";Asynchronous Processing=True";

	public TimeSpan CommandTimeout => _CommandTimeoutGetter();

	public string Name { get; }

	public event ExecutionFailedEventHandler ExecutionFailed;

	public event ExecutionFinishedEventHandler ExecutionFinished;

	public event ExecutionStartedEventHandler ExecutionStarted;

	public event ExecutionSucceededEventHandler ExecutionSucceeded;

	public string GetUtilizedConnectionString(ApplicationIntent? applicationIntent)
	{
		return GetUtilizedConnectionString(ConnectionString, applicationIntent);
	}

	public string GetUtilizedConnectionStringAsync(ApplicationIntent? applicationIntent)
	{
		return GetUtilizedConnectionString(ConnectionStringAsync, applicationIntent);
	}

	public Database(string name, Func<string> connectionStringGetter, Func<TimeSpan> commandTimeoutGetter)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("Invalid value for argument name", "name");
		}
		Name = name;
		_ConnectionStringGetter = connectionStringGetter ?? throw new ArgumentNullException("connectionStringGetter");
		_CommandTimeoutGetter = commandTimeoutGetter ?? throw new ArgumentNullException("commandTimeoutGetter");
	}

	~Database()
	{
		Dispose(disposing: false);
	}

	private void OnExecutionFailed(DatabaseExecutionEventArgs e)
	{
		this.ExecutionFailed?.Invoke(this, e);
	}

	private void OnExecutionFinished(DatabaseExecutionEventArgs e)
	{
		this.ExecutionFinished?.Invoke(this, e);
	}

	private void OnExecutionStarted(DatabaseExecutionEventArgs e)
	{
		this.ExecutionStarted?.Invoke(this, e);
	}

	private void OnExecutionSucceeded(DatabaseExecutionEventArgs e)
	{
		this.ExecutionSucceeded?.Invoke(this, e);
	}

	protected virtual void Execute(CommandType commandType, string commandText, SqlParameter[] sqlParameters, Action<SqlCommand> action, int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(commandText))
		{
			throw new ArgumentException("Invalid value for argument commandText", "commandText");
		}
		OnExecutionStarting();
		long requestCounter = Interlocked.Increment(ref _RequestCounter);
		DatabaseExecutionEventArgs eventArgs = new DatabaseExecutionEventArgs(this, commandType, commandText, sqlParameters, requestCounter);
		OnExecutionStarted(eventArgs);
		try
		{
			SqlConnection sqlConnection = new SqlConnection(GetUtilizedConnectionString(applicationIntent));
			try
			{
				SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
				try
				{
					((DbCommand)sqlCommand).CommandType = commandType;
					((DbCommand)sqlCommand).CommandTimeout = commandTimeout ?? _CommandTimeoutInSeconds;
					if (sqlParameters != null)
					{
						sqlCommand.Parameters.AddRange(sqlParameters);
					}
					((DbConnection)sqlConnection).Open();
					action(sqlCommand);
				}
				finally
				{
					((IDisposable)sqlCommand)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)sqlConnection)?.Dispose();
			}
			OnExecutionSucceeded(eventArgs);
		}
		catch (Exception ex)
		{
			eventArgs.Exception = ex;
			OnExecutionFailed(eventArgs);
			throw;
		}
		finally
		{
			OnExecutionFinished(eventArgs);
		}
	}

	protected virtual async Task ExecuteAsync(CommandType commandType, string commandText, SqlParameter[] sqlParameters, Func<SqlCommand, CancellationToken, Task> action, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(commandText))
		{
			throw new ArgumentException("Invalid value for argument commandText", "commandText");
		}
		await OnExecutionStartingAsync(cancellationToken);
		long requestCounter = Interlocked.Increment(ref _RequestCounter);
		DatabaseExecutionEventArgs eventArgs = new DatabaseExecutionEventArgs(this, commandType, commandText, sqlParameters, requestCounter);
		OnExecutionStarted(eventArgs);
		try
		{
			SqlConnection sqlConnection = new SqlConnection(GetUtilizedConnectionStringAsync(applicationIntent));
			try
			{
				SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
				try
				{
					((DbCommand)sqlCommand).CommandType = commandType;
					((DbCommand)sqlCommand).CommandTimeout = commandTimeout ?? _CommandTimeoutInSeconds;
					if (sqlParameters != null)
					{
						sqlCommand.Parameters.AddRange(sqlParameters);
					}
					await ((DbConnection)sqlConnection).OpenAsync(cancellationToken);
					await action(sqlCommand, cancellationToken);
				}
				finally
				{
					((IDisposable)sqlCommand)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)sqlConnection)?.Dispose();
			}
			OnExecutionSucceeded(eventArgs);
		}
		catch (Exception ex)
		{
			eventArgs.Exception = ex;
			OnExecutionFailed(eventArgs);
			throw;
		}
		finally
		{
			OnExecutionFinished(eventArgs);
		}
	}

	protected virtual void OnExecutionStarting()
	{
	}

	protected virtual Task OnExecutionStartingAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return Task.FromResult(result: true);
	}

	public int ExecuteNonQuery(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		int numberOfRecordsAffected = 0;
		Execute(commandType, commandText, sqlParameters, delegate(SqlCommand sqlCommand)
		{
			numberOfRecordsAffected = ((DbCommand)sqlCommand).ExecuteNonQuery();
		}, commandTimeout, applicationIntent);
		return numberOfRecordsAffected;
	}

	public async Task<int> ExecuteNonQueryAsync(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		int numberOfRecordsAffected = 0;
		await ExecuteAsync(commandType, commandText, sqlParameters, async delegate(SqlCommand sqlCommand, CancellationToken innerCancellationToken)
		{
			numberOfRecordsAffected = await ((DbCommand)sqlCommand).ExecuteNonQueryAsync(innerCancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}, cancellationToken, commandTimeout, applicationIntent).ConfigureAwait(continueOnCapturedContext: false);
		return numberOfRecordsAffected;
	}

	public IEnumerable<IDictionary<string, object>> ExecuteReader(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<IDictionary<string, object>> records = null;
		Execute(commandType, commandText, sqlParameters, delegate(SqlCommand sqlCommand)
		{
			records = Read(sqlCommand);
		}, commandTimeout, applicationIntent);
		return records;
	}

	public async Task<IEnumerable<IDictionary<string, object>>> ExecuteReaderAsync(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<IDictionary<string, object>> records = null;
		await ExecuteAsync(commandType, commandText, sqlParameters, async delegate(SqlCommand sqlCommand, CancellationToken innerCancellationToken)
		{
			records = await ReadAsync(sqlCommand, innerCancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}, cancellationToken, commandTimeout, applicationIntent).ConfigureAwait(continueOnCapturedContext: false);
		return records;
	}

	public object ExecuteScalar(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		Execute(commandType, commandText, sqlParameters, delegate(SqlCommand sqlCommand)
		{
			result = ((DbCommand)sqlCommand).ExecuteScalar();
		}, commandTimeout, applicationIntent);
		return result;
	}

	public async Task<object> ExecuteScalarAsync(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		await ExecuteAsync(commandType, commandText, sqlParameters, async delegate(SqlCommand sqlCommand, CancellationToken innerCancellationToken)
		{
			result = await ((DbCommand)sqlCommand).ExecuteScalarAsync(innerCancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}, cancellationToken, commandTimeout, applicationIntent).ConfigureAwait(continueOnCapturedContext: false);
		return result;
	}

	private static string GetUtilizedConnectionString(string baseConnectionString, ApplicationIntent? applicationIntent)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (!applicationIntent.HasValue)
		{
			return baseConnectionString;
		}
		return string.Format("{0}{1}applicationintent={2}", baseConnectionString, baseConnectionString.EndsWith(";") ? string.Empty : ";", applicationIntent.Value);
	}

	private static IEnumerable<IDictionary<string, object>> Read(SqlCommand sqlCommand)
	{
		List<IDictionary<string, object>> records = new List<IDictionary<string, object>>();
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		try
		{
			int fieldCount = ((DbDataReader)sqlDataReader).FieldCount;
			string[] fieldNames = new string[fieldCount];
			for (int j = 0; j < fieldCount; j++)
			{
				fieldNames[j] = ((DbDataReader)sqlDataReader).GetName(j);
			}
			while (((DbDataReader)sqlDataReader).Read())
			{
				Dictionary<string, object> fieldsDictionary = new Dictionary<string, object>(fieldCount);
				for (int i = 0; i < fieldCount; i++)
				{
					object fieldValue = ((DbDataReader)sqlDataReader)[i];
					if (fieldValue == DBNull.Value)
					{
						fieldValue = null;
					}
					fieldsDictionary[fieldNames[i]] = fieldValue;
				}
				records.Add(fieldsDictionary);
			}
			return records;
		}
		finally
		{
			((IDisposable)sqlDataReader)?.Dispose();
		}
	}

	private static async Task<IEnumerable<IDictionary<string, object>>> ReadAsync(SqlCommand sqlCommand, CancellationToken cancellationToken = default(CancellationToken))
	{
		List<IDictionary<string, object>> records = new List<IDictionary<string, object>>();
		SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync(cancellationToken);
		try
		{
			int fieldCount = ((DbDataReader)sqlDataReader).FieldCount;
			string[] fieldNames = new string[fieldCount];
			for (int j = 0; j < fieldCount; j++)
			{
				fieldNames[j] = ((DbDataReader)sqlDataReader).GetName(j);
			}
			while (await ((DbDataReader)sqlDataReader).ReadAsync(cancellationToken))
			{
				Dictionary<string, object> fieldsDictionary = new Dictionary<string, object>(fieldCount);
				for (int i = 0; i < fieldCount; i++)
				{
					object fieldValue = await ((DbDataReader)sqlDataReader).GetFieldValueAsync<object>(i, cancellationToken);
					if (fieldValue == DBNull.Value)
					{
						fieldValue = null;
					}
					fieldsDictionary[fieldNames[i]] = fieldValue;
				}
				records.Add(fieldsDictionary);
			}
		}
		finally
		{
			((IDisposable)sqlDataReader)?.Dispose();
		}
		return records;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
