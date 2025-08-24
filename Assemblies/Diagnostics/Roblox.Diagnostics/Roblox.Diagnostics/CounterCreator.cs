using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Roblox.Diagnostics;

[Obsolete("Use Roblox.Instrumentation instead of Windows Perfmon counters")]
public static class CounterCreator
{
	public static event EventHandler<InstanceNameTruncatedEventArgs> OnInstanceNameTruncated;

	public static void InitializeSingleInstance(string categoryName, params CounterDescriptor[] counterDescriptors)
	{
		EnsureCategoryCreated(categoryName, PerformanceCounterCategoryType.SingleInstance, (IReadOnlyCollection<ICounterDescriptor>)(object)counterDescriptors);
		if (ShouldRecreate(categoryName, (IReadOnlyCollection<CounterDescriptor>)(object)counterDescriptors))
		{
			DeleteCategory(categoryName, (IReadOnlyCollection<CounterDescriptor>)(object)counterDescriptors);
			EnsureCategoryCreated(categoryName, PerformanceCounterCategoryType.SingleInstance, (IReadOnlyCollection<ICounterDescriptor>)(object)counterDescriptors);
		}
		foreach (CounterDescriptor counterDescriptor in counterDescriptors)
		{
			PerformanceCounter counter = new PerformanceCounter(categoryName, counterDescriptor.CounterCreationData.CounterName, readOnly: false)
			{
				RawValue = 0L
			};
			counterDescriptor.Setter(counter);
		}
	}

	public static void InitializeMultiInstance(string categoryName, string instanceName, params CounterDescriptor[] counterDescriptors)
	{
		EnsureCategoryCreated(categoryName, PerformanceCounterCategoryType.MultiInstance, (IReadOnlyCollection<ICounterDescriptor>)(object)counterDescriptors);
		CheckAndRaiseInstanceTruncatedEvent(categoryName, ref instanceName, (IReadOnlyCollection<string>)(object)counterDescriptors.Select((CounterDescriptor cd) => cd.CounterCreationData.CounterName).ToArray());
		foreach (CounterDescriptor counterDescriptor in counterDescriptors)
		{
			PerformanceCounter counter = new PerformanceCounter(categoryName, counterDescriptor.CounterCreationData.CounterName, instanceName, readOnly: false)
			{
				RawValue = 0L
			};
			counterDescriptor.Setter(counter);
		}
	}

	public static void InitializeMultiInstance(string categoryName, string instanceName, params CounterDescriptorForICounter[] counterDescriptors)
	{
		EnsureCategoryCreated(categoryName, PerformanceCounterCategoryType.MultiInstance, (IReadOnlyCollection<ICounterDescriptor>)(object)counterDescriptors);
		CheckAndRaiseInstanceTruncatedEvent(categoryName, ref instanceName, (IReadOnlyCollection<string>)(object)counterDescriptors.Select((CounterDescriptorForICounter cd) => cd.CounterCreationData.CounterName).ToArray());
		foreach (CounterDescriptorForICounter counterDescriptor in counterDescriptors)
		{
			PerformanceCounterWrapper wrapper = new PerformanceCounterWrapper(new PerformanceCounter(categoryName, counterDescriptor.CounterCreationData.CounterName, instanceName, readOnly: false)
			{
				RawValue = 0L
			});
			counterDescriptor.Setter(wrapper);
		}
	}

	private static bool ShouldRecreate(string categoryName, IReadOnlyCollection<CounterDescriptor> counterDescriptors)
	{
		PerformanceCounter[] existingCounters = new PerformanceCounterCategory(categoryName).GetCounters();
		string text = string.Join("\r\n", counterDescriptors.Select((CounterDescriptor c) => $"{c.CounterCreationData.CounterName}:{c.CounterCreationData.CounterType}"));
		string existingCountersAsString = string.Join("\r\n", existingCounters.Select((PerformanceCounter c) => $"{c.CounterName}:{c.CounterType}"));
		return text != existingCountersAsString;
	}

	private static void DeleteCategory(string categoryName, IReadOnlyCollection<CounterDescriptor> counterDescriptors)
	{
		if (!PerformanceCounterCategory.Exists(categoryName) || !ShouldRecreate(categoryName, counterDescriptors))
		{
			return;
		}
		Mutex i = new Mutex(initiallyOwned: false, $"CounterCreator:PerfmonCategoryDeletion:{categoryName}");
		i.WaitOne();
		try
		{
			if (PerformanceCounterCategory.Exists(categoryName) && ShouldRecreate(categoryName, counterDescriptors))
			{
				PerformanceCounterCategory.Delete(categoryName);
			}
		}
		finally
		{
			i.ReleaseMutex();
		}
	}

	private static void EnsureCategoryCreated(string categoryName, PerformanceCounterCategoryType categoryType, IReadOnlyCollection<ICounterDescriptor> counterDescriptors)
	{
		if (PerformanceCounterCategory.Exists(categoryName))
		{
			return;
		}
		Mutex i = new Mutex(initiallyOwned: false, $"CounterCreator:PerfmonCategoryCreation:{categoryName}");
		i.WaitOne();
		try
		{
			if (!PerformanceCounterCategory.Exists(categoryName))
			{
				CounterCreationDataCollection counterCreationDataCollection = new CounterCreationDataCollection(counterDescriptors.Select((ICounterDescriptor c) => c.CounterCreationData).ToArray());
				PerformanceCounterCategory.Create(categoryName, string.Empty, categoryType, counterCreationDataCollection);
			}
		}
		finally
		{
			i.ReleaseMutex();
		}
	}

	private static void CheckAndRaiseInstanceTruncatedEvent(string categoryName, ref string instanceName, IReadOnlyCollection<string> counterNames)
	{
		if (instanceName.Length > 127)
		{
			string newInstanceName = instanceName.Substring(0, 127 - "_TRUNCATED".Length) + "_TRUNCATED";
			CounterCreator.OnInstanceNameTruncated?.Invoke(null, new InstanceNameTruncatedEventArgs(categoryName, instanceName, newInstanceName, counterNames));
			instanceName = newInstanceName;
		}
	}
}
