using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Roblox.Diagnostics;

internal static class CounterHelpers
{
	internal static Action<T> GetSetter<T>(string counterName, object container, Type containerType)
	{
		return delegate(T performanceCounter)
		{
			PropertyInfo property = containerType.GetProperty(counterName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (property != null)
			{
				property.SetValue(container, performanceCounter);
			}
			else
			{
				FieldInfo field = containerType.GetField(counterName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (!(field != null))
				{
					throw new ArgumentException($"Unable to find field or attribute {counterName} in container object of Type {containerType.FullName}");
				}
				field.SetValue(container, performanceCounter);
			}
		};
	}

	internal static string GetPropertyName<T>(Expression<Func<T>> exp)
	{
		return ((MemberExpression)exp.Body).Member.Name;
	}
}
