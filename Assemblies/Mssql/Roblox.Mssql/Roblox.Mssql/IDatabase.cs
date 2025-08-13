using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Mssql;

public interface IDatabase : IDisposable
{
	string ConnectionString { get; }

	string ConnectionStringAsync { get; }

	string Name { get; }

	event ExecutionFailedEventHandler ExecutionFailed;

	event ExecutionFinishedEventHandler ExecutionFinished;

	event ExecutionStartedEventHandler ExecutionStarted;

	event ExecutionSucceededEventHandler ExecutionSucceeded;

	string GetUtilizedConnectionString(ApplicationIntent? applicationIntent);

	string GetUtilizedConnectionStringAsync(ApplicationIntent? applicationIntent);

	int ExecuteNonQuery(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null);

	Task<int> ExecuteNonQueryAsync(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null);

	IEnumerable<IDictionary<string, object>> ExecuteReader(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null);

	Task<IEnumerable<IDictionary<string, object>>> ExecuteReaderAsync(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null);

	object ExecuteScalar(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, int? commandTimeout = null, ApplicationIntent? applicationIntent = null);

	Task<object> ExecuteScalarAsync(string commandText, SqlParameter[] sqlParameters, CommandType commandType = 4, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null);
}
