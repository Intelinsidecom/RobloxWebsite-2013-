using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Roblox.Data;

public struct DbInfo
{
	public string ConnectionString { get; }

	public string StoredProcedure { get; }

	public SqlParameter OutputParameter { get; }

	public ICollection<SqlParameter> QueryParameters { get; }

	public DbInfo(string connectionString, string storedProcedure)
		: this(connectionString, storedProcedure, null, new List<SqlParameter>())
	{
	}

	public DbInfo(string connectionString, string storedProcedure, ICollection<SqlParameter> queryParameters)
		: this(connectionString, storedProcedure, null, queryParameters)
	{
	}

	public DbInfo(string connectionString, string storedProcedure, SqlParameter outputParameter, ICollection<SqlParameter> queryParameters)
	{
		ConnectionString = connectionString;
		StoredProcedure = storedProcedure;
		OutputParameter = outputParameter;
		QueryParameters = queryParameters;
		if (OutputParameter != null)
		{
			((DbParameter)OutputParameter).Direction = (ParameterDirection)2;
		}
	}
}
