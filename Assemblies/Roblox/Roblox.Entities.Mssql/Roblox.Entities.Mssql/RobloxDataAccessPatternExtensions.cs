using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Roblox.Common;
using Roblox.MssqlDatabases;

namespace Roblox.Entities.Mssql;

public static class RobloxDataAccessPatternExtensions
{
	private static readonly SqlParameter[] _EmptySqlParameters = (SqlParameter[])(object)new SqlParameter[0];

	public static void Delete<TIndex>(this RobloxDatabase database, string storedProcedureName, TIndex id, int? commandTimeout = null, bool includeApplicationIntent = false) where TIndex : struct
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		if (EqualityComparer<TIndex>.Default.Equals(id, default(TIndex)))
		{
			throw new ArgumentException("Required value not specified: ID.", "id");
		}
		database.ExecuteNonQuery(storedProcedureName, (SqlParameter[])(object)new SqlParameter[1]
		{
			new SqlParameter("@ID", (object)id)
		}, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)0) : null);
	}

	public static TDal Get<TDal, TIndex>(this RobloxDatabase database, string storedProcedureName, TIndex id, Func<IDictionary<string, object>, TDal> dalBuilder, int? commandTimeout = null, bool includeApplicationIntent = false) where TDal : class where TIndex : struct
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		if (EqualityComparer<TIndex>.Default.Equals(id, default(TIndex)))
		{
			return null;
		}
		return BuildDALFromRecords(database.ExecuteReader(storedProcedureName, (SqlParameter[])(object)new SqlParameter[1]
		{
			new SqlParameter("@ID", (object)id)
		}, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)1) : null), dalBuilder);
	}

	public static EntityHelper.GetOrCreateDALWrapper<TDal> GetOrCreate<TDal>(this RobloxDatabase database, string storedProcedurename, Func<IDictionary<string, object>, TDal> dalBuilder, params SqlParameter[] queryParameters) where TDal : class
	{
		return database.GetOrCreate(storedProcedurename, dalBuilder, null, includeApplicationIntent: false, queryParameters);
	}

	public static EntityHelper.GetOrCreateDALWrapper<TDal> GetOrCreate<TDal>(this RobloxDatabase database, string storedProcedurename, Func<IDictionary<string, object>, TDal> dalBuilder, int? commandTimeout = null, bool includeApplicationIntent = false, params SqlParameter[] queryParameters) where TDal : class
	{
		SqlParameter obj = FindOutputSqlParameter(queryParameters, "@CreatedNewEntity");
		return new EntityHelper.GetOrCreateDALWrapper<TDal>(dal: BuildDALFromRecords(database.ExecuteReader(storedProcedurename, queryParameters, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)0) : null), dalBuilder), createdNewEntity: (bool)((DbParameter)obj).Value);
	}

	public static ICollection<TIndex> GetIDCollection<TIndex>(this RobloxDatabase database, string storedProcedureName, params SqlParameter[] queryParameters) where TIndex : struct
	{
		return database.GetIDCollection<TIndex>(storedProcedureName, null, includeApplicationIntent: false, queryParameters);
	}

	public static ICollection<TIndex> GetIDCollection<TIndex>(this RobloxDatabase database, string storedProcedureName, int? commandTimeout = null, bool includeApplicationIntent = false, params SqlParameter[] queryParameters) where TIndex : struct
	{
		return (from record in database.ExecuteReader(storedProcedureName, queryParameters, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)1) : null)
			select (TIndex)Convert.ChangeType(record["ID"], typeof(TIndex))).ToList();
	}

	public static TCount GetCount<TCount>(this RobloxDatabase database, string storedProcedureName, params SqlParameter[] queryParameters) where TCount : struct
	{
		return database.GetCount<TCount>(storedProcedureName, null, includeApplicationIntent: false, queryParameters);
	}

	public static TCount GetCount<TCount>(this RobloxDatabase database, string storedProcedureName, int? commandTimeout = null, bool includeApplicationIntent = false, params SqlParameter[] queryParameters) where TCount : struct
	{
		return (TCount)database.ExecuteScalar(storedProcedureName, queryParameters, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)1) : null);
	}

	public static TIndex Insert<TIndex>(this RobloxDatabase database, string storedProcedureName, params SqlParameter[] queryParameters) where TIndex : struct
	{
		return database.Insert<TIndex>(storedProcedureName, null, includeApplicationIntent: false, queryParameters);
	}

	public static TIndex Insert<TIndex>(this RobloxDatabase database, string storedProcedureName, int? commandTimeout = null, bool includeApplicationIntent = false, params SqlParameter[] queryParameters) where TIndex : struct
	{
		SqlParameter obj = FindOutputSqlParameter(queryParameters, "@ID");
		database.ExecuteNonQuery(storedProcedureName, queryParameters, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)0) : null);
		return (TIndex)((DbParameter)obj).Value;
	}

	public static TDal Lookup<TDal>(this RobloxDatabase database, string storedProcedureName, Func<IDictionary<string, object>, TDal> dalBuilder, params SqlParameter[] queryParameters) where TDal : class
	{
		return database.Lookup(storedProcedureName, dalBuilder, null, includeApplicationIntent: false, queryParameters);
	}

	public static TDal Lookup<TDal>(this RobloxDatabase database, string storedProcedureName, Func<IDictionary<string, object>, TDal> dalBuilder, int? commandTimeout = null, bool includeApplicationIntent = false, params SqlParameter[] queryParameters) where TDal : class
	{
		return BuildDALFromRecords(database.ExecuteReader(storedProcedureName, queryParameters, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)1) : null), dalBuilder);
	}

	public static ICollection<TDal> MultiGet<TDal, TIndex>(this RobloxDatabase database, string storedProcedureName, IEnumerable<TIndex> ids, Func<IDictionary<string, object>, TDal> dalBuilder, int? commandTimeout = null, bool includeApplicationIntent = false) where TDal : class where TIndex : struct
	{
		if (ids == null)
		{
			throw new ArgumentException("Null was supplied for 'ids' parameter", "ids");
		}
		SqlParameter[] queryParameters = EntityHelper.GetMultiGetIDsSqlParameters(ids);
		return database.ExecuteReader(storedProcedureName, queryParameters, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)1) : null).Select(dalBuilder).ToList();
	}

	public static void Update(this RobloxDatabase database, string storedProcedureName, params SqlParameter[] queryParameters)
	{
		database.Update(storedProcedureName, null, includeApplicationIntent: false, queryParameters);
	}

	public static void Update(this RobloxDatabase database, string storedProcedureName, int? commandTimeout = null, bool includeApplicationIntent = false, params SqlParameter[] queryParameters)
	{
		database.ExecuteNonQuery(storedProcedureName, queryParameters, (CommandType)4, commandTimeout, includeApplicationIntent ? new ApplicationIntent?((ApplicationIntent)0) : null);
	}

	private static TDal BuildDALFromRecords<TDal>(IEnumerable<IDictionary<string, object>> records, Func<IDictionary<string, object>, TDal> dalBuilder) where TDal : class
	{
		IDictionary<string, object> record = records.LastOrDefault();
		if (record == null)
		{
			return null;
		}
		return dalBuilder(record);
	}

	private static SqlParameter FindOutputSqlParameter(IEnumerable<SqlParameter> queryParameters, string parameterName)
	{
		return queryParameters.FirstOrDefault((SqlParameter p) => (int)((DbParameter)p).Direction == 2 && ((DbParameter)p).ParameterName == parameterName) ?? throw new ArgumentException("Output SqlParameter " + parameterName + " not found in queryParameters", "queryParameters");
	}
}
