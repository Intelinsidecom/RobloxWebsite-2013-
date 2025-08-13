using System;
using System.Data;
using System.Data.SqlClient;

namespace Roblox.Mssql;

public class DatabaseExecutionEventArgs : EventArgs
{
	public string CommandText { get; }

	public CommandType CommandType { get; }

	public Database Database { get; }

	public Exception Exception { get; set; }

	public long RequestId { get; }

	public SqlParameter[] SqlParameters { get; }

	public DatabaseExecutionEventArgs(Database database, CommandType commandType, string commandText, SqlParameter[] sqlParameters, long requestId)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Database = database;
		CommandType = commandType;
		CommandText = commandText;
		SqlParameters = sqlParameters;
		RequestId = requestId;
	}
}
