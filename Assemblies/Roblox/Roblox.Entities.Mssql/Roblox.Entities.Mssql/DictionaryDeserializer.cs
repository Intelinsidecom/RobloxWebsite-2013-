using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Roblox.Entities.Mssql;

public class DictionaryDeserializer<T> where T : class, new()
{
	private readonly KeyValuePair<string, Action<T, object>>[] _Setters;

	public DictionaryDeserializer()
	{
		PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		Dictionary<string, Action<T, object>> setters = new Dictionary<string, Action<T, object>>();
		PropertyInfo[] array = properties;
		foreach (PropertyInfo property in array)
		{
			Action<T, object> setter = CreateSetter(property);
			setters[property.Name] = setter;
		}
		_Setters = setters.ToArray();
	}

	public T Deserialize(IDictionary<string, object> dictionary)
	{
		if (dictionary == null)
		{
			return null;
		}
		T obj = new T();
		KeyValuePair<string, Action<T, object>>[] setters = _Setters;
		for (int i = 0; i < setters.Length; i++)
		{
			KeyValuePair<string, Action<T, object>> kvp = setters[i];
			if (dictionary.TryGetValue(kvp.Key, out var value))
			{
				kvp.Value(obj, value);
			}
		}
		return obj;
	}

	private static Action<T, object> CreateSetter(PropertyInfo property)
	{
		MethodInfo setMethod = property.GetSetMethod(nonPublic: true);
		Type propertyType = property.PropertyType;
		ParameterExpression instance = Expression.Parameter(typeof(T));
		ParameterExpression value = Expression.Parameter(typeof(object));
		UnaryExpression valueCast = (propertyType.IsValueType ? Expression.Convert(value, propertyType) : Expression.TypeAs(value, propertyType));
		return Expression.Lambda<Action<T, object>>(Expression.Call(instance, setMethod, valueCast), new ParameterExpression[2] { instance, value }).Compile();
	}
}
