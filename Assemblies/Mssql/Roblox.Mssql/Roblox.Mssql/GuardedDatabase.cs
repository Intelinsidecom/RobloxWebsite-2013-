using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Mssql;

public class GuardedDatabase : Database
{
	private readonly MssqlCircuitBreaker _CircuitBreaker;

	public GuardedDatabase(string name, Func<string> connectionStringGetter, Func<TimeSpan> commandTimeoutGetter, TimeSpan retryInterval)
		: base(name, connectionStringGetter, commandTimeoutGetter)
	{
		_CircuitBreaker = new MssqlCircuitBreaker(this, retryInterval);
	}

	protected override void Execute(CommandType commandType, string commandText, SqlParameter[] sqlParameters, Action<SqlCommand> action, int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_CircuitBreaker.Execute(delegate
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			base.Execute(commandType, commandText, sqlParameters, action, commandTimeout, applicationIntent);
		});
	}

	protected override Task ExecuteAsync(CommandType commandType, string commandText, SqlParameter[] sqlParameters, Func<SqlCommand, CancellationToken, Task> action, CancellationToken cancellationToken = default(CancellationToken), int? commandTimeout = null, ApplicationIntent? applicationIntent = null)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return _CircuitBreaker.ExecuteAsync((CancellationToken ct) => base.ExecuteAsync(commandType, commandText, sqlParameters, action, cancellationToken, commandTimeout, applicationIntent), cancellationToken);
	}
}
