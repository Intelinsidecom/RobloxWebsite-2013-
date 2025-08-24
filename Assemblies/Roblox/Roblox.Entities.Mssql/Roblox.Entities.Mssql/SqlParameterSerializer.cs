using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Roblox.Entities.Mssql;

public class SqlParameterSerializer
{
	private static readonly IDictionary<Type, SqlDbType> _SqlTypeMap = new Dictionary<Type, SqlDbType>
	{
		{
			typeof(long),
			(SqlDbType)0
		},
		{
			typeof(int),
			(SqlDbType)8
		},
		{
			typeof(short),
			(SqlDbType)16
		},
		{
			typeof(byte),
			(SqlDbType)20
		}
	};

	private readonly KeyValuePair<string, Func<object, object>>[] _Getters;

	private readonly SqlDbType? _PrimaryKeySqlType;

	public SqlParameterSerializer(Type type)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		Dictionary<string, Func<object, object>> getters = new Dictionary<string, Func<object, object>>();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo property in array)
		{
			if (property.Name == "ID")
			{
				_PrimaryKeySqlType = _SqlTypeMap[property.PropertyType];
			}
			Func<object, object> getter = CreateGetter(type, property);
			getters[property.Name] = getter;
		}
		_Getters = getters.ToArray();
	}

	public SqlParameter[] GetSqlParameters(object queryParametersObject)
	{
		return PerformSerialization(queryParametersObject, SqlOperatonType.Normal);
	}

	public SqlParameter[] GetSqlParametersForGetOrCreate(object queryParametersObject)
	{
		return PerformSerialization(queryParametersObject, SqlOperatonType.GetOrCreate);
	}

	public SqlParameter[] GetSqlParametersForInsert(object queryParametersObject)
	{
		return PerformSerialization(queryParametersObject, SqlOperatonType.Insert);
	}

	private SqlParameter[] PerformSerialization(object queryParametersObject, SqlOperatonType mode)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		SqlParameter[] sqlParameters;
		int pos;
		if (mode == SqlOperatonType.GetOrCreate)
		{
			sqlParameters = (SqlParameter[])(object)new SqlParameter[_Getters.Length + 1];
			sqlParameters[0] = new SqlParameter("@CreatedNewEntity", (SqlDbType)2)
			{
				Direction = (ParameterDirection)2
			};
			pos = 1;
		}
		else
		{
			sqlParameters = (SqlParameter[])(object)new SqlParameter[_Getters.Length];
			pos = 0;
		}
		bool idPropertyFound = false;
		KeyValuePair<string, Func<object, object>>[] getters = _Getters;
		for (int i = 0; i < getters.Length; i++)
		{
			KeyValuePair<string, Func<object, object>> kvp = getters[i];
			string propertyName = kvp.Key;
			SqlParameter parameter;
			if (!idPropertyFound && mode == SqlOperatonType.Insert && propertyName == "ID")
			{
				if (!_PrimaryKeySqlType.HasValue)
				{
					throw new ArgumentException("Unable to find the correct SqlDbType for ID property");
				}
				parameter = new SqlParameter("@ID", _PrimaryKeySqlType.Value)
				{
					Direction = (ParameterDirection)2
				};
				idPropertyFound = true;
			}
			else
			{
				object value = kvp.Value(queryParametersObject);
				parameter = new SqlParameter("@" + propertyName, value);
			}
			sqlParameters[pos] = parameter;
			pos++;
		}
		return sqlParameters;
	}

	internal Func<object, object> CreateGetter(Type type, PropertyInfo property)
	{
		MethodInfo propertyGetMethod = property.GetGetMethod(nonPublic: true);
		ParameterExpression parameter = Expression.Parameter(typeof(object));
		return Expression.Lambda<Func<object, object>>(Expression.TypeAs(Expression.Call(Expression.TypeAs(parameter, type), propertyGetMethod), typeof(object)), new ParameterExpression[1] { parameter }).Compile();
	}
}
public class SqlParameterSerializer<T> : SqlParameterSerializer
{
	public SqlParameterSerializer()
		: base(typeof(T))
	{
	}
}
