using System.Data.SqlClient;

namespace Roblox.Entities.Mssql;

public static class SqlParameterFactory
{
	public static SqlParameter[] GetSqlParameters<T>(T queryParametersObject)
	{
		return SqlParameterSerializerCache<T>.Default.GetSqlParameters(queryParametersObject);
	}

	public static SqlParameter[] GetSqlParametersForInsert<T>(T queryParametersObject)
	{
		return SqlParameterSerializerCache<T>.Default.GetSqlParametersForInsert(queryParametersObject);
	}

	public static SqlParameter[] GetSqlParametersForGetOrCreate<T>(T queryParametersObject)
	{
		return SqlParameterSerializerCache<T>.Default.GetSqlParametersForGetOrCreate(queryParametersObject);
	}
}
