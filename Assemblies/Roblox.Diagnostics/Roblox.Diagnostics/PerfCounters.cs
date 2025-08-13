using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Roblox.Diagnostics;

/// <summary>
/// Use this class to initialize performance counter fields declared on your class.
/// For this to work, you must decorate your class with a CounterCategory attribute
/// and decoreate each PerformanceCounter field with a Counter attribute. The fields can be
/// public or non-public. They fields may be readonly.
/// </summary>
public static class PerfCounters
{
	private static readonly object Sync = new object();

	/// <summary>
	/// Use this function to initialize a SingleInstance set of PerformanceCounters
	/// </summary>
	/// <param name="obj">The object that is decorated with Counter attributes</param>
	public static void Initialize(object obj)
	{
		Initialize(obj, PerformanceCounterCategoryType.SingleInstance, null);
	}

	/// <summary>
	/// Use this function to initialize a MultiInstance set of PerformanceCounters
	/// </summary>
	/// <param name="obj">The object that is decorated with Counter attributes</param>
	/// <param name="instanceName">The name of the counter (for multi-instance counters)</param>
	public static void Initialize(object obj, string instanceName)
	{
		Initialize(obj, PerformanceCounterCategoryType.MultiInstance, instanceName);
	}

	private static IEnumerable<FieldInfo> GetCounterFields(object obj)
	{
		FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo field in fields)
		{
			if (field.FieldType == typeof(PerformanceCounter))
			{
				yield return field;
			}
		}
	}

	private static void Initialize(object obj, PerformanceCounterCategoryType type, string instanceName)
	{
		CounterCategory attr = (CounterCategory)obj.GetType().GetCustomAttributes(typeof(CounterCategory), inherit: false)[0];
		CounterCreationDataCollection collection = new CounterCreationDataCollection();
		foreach (FieldInfo counterField in GetCounterFields(obj))
		{
			Counter fieldAttr2 = (Counter)counterField.GetCustomAttributes(typeof(Counter), inherit: true)[0];
			collection.Add(new CounterCreationData(fieldAttr2.Name, fieldAttr2.Help, fieldAttr2.Type));
		}
		string hash = (attr.IsAutoUpdateEnabled ? ComputeHash(collection, attr.CategoryHelp, type) : string.Empty);
		lock (Sync)
		{
			bool needToCreate = !PerformanceCounterCategory.Exists(attr.CategoryName);
			if (attr.IsAutoUpdateEnabled && !needToCreate)
			{
				PerformanceCounterCategory[] categories = PerformanceCounterCategory.GetCategories();
				foreach (PerformanceCounterCategory category in categories)
				{
					if (category.CategoryName == attr.CategoryName)
					{
						if (!category.CategoryHelp.Contains(hash))
						{
							PerformanceCounterCategory.Delete(attr.CategoryName);
							needToCreate = true;
						}
						break;
					}
				}
			}
			if (needToCreate)
			{
				string help = (string.IsNullOrEmpty(attr.CategoryHelp) ? "No help defined." : attr.CategoryHelp);
				string helpString = (attr.IsAutoUpdateEnabled ? $"{help} (hash: {hash})" : help);
				PerformanceCounterCategory.Create(attr.CategoryName, helpString, type, collection);
			}
		}
		foreach (FieldInfo counterField2 in GetCounterFields(obj))
		{
			Counter fieldAttr = (Counter)counterField2.GetCustomAttributes(typeof(Counter), inherit: true)[0];
			PerformanceCounter counter = ((instanceName == null) ? new PerformanceCounter(attr.CategoryName, fieldAttr.Name, readOnly: false)
			{
				RawValue = 0L
			} : new PerformanceCounter(attr.CategoryName, fieldAttr.Name, instanceName, readOnly: false)
			{
				RawValue = 0L
			});
			counterField2.SetValue(obj, counter);
		}
	}

	private static string ComputeHash(params object[] objectsToSerialize)
	{
		using MemoryStream ms = new MemoryStream();
		new BinaryFormatter().Serialize(ms, objectsToSerialize);
		using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
		return md5.ComputeHash(ms.ToArray()).Aggregate("", (string current, byte b) => current + b.ToString("x"));
	}

	public static void Dispose(object obj)
	{
		foreach (FieldInfo counterField in GetCounterFields(obj))
		{
			((PerformanceCounter)counterField.GetValue(obj))?.Dispose();
		}
	}
}
