using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Roblox.Diagnostics.Properties;

namespace Roblox.Diagnostics;

/// <inheritdoc cref="T:Roblox.Diagnostics.ICounterBuilder" />
[Obsolete("Use Roblox.Instrumentation instead of Windows Perfmon counters")]
public class CounterBuilder : ICounterBuilder
{
	private static readonly HashSet<int> _DefaultPercentiles = new HashSet<int> { 1, 5, 10, 25, 50, 75, 90, 95, 99 };

	private readonly string _PerformanceCategory;

	private readonly string _InstanceName;

	private readonly TimeSpan _UpdateInterval;

	private object _Container;

	private static HashSet<int> _Percentiles;

	private readonly List<CustomCounterDescriptor<PercentileValueCounter>> _PercentileCounterDescriptors = new List<CustomCounterDescriptor<PercentileValueCounter>>();

	private readonly List<CounterDescriptor> _CounterDescriptors = new List<CounterDescriptor>();

	private readonly Dictionary<string, Dictionary<int, PerformanceCounter>> _InternalPercentileCounters = new Dictionary<string, Dictionary<int, PerformanceCounter>>();

	private readonly HashSet<string> _ExistingPercentileGroupNames = new HashSet<string>();

	private readonly PerformanceCounterCategoryType _InstanceType;

	private bool _CountersCreated;

	/// <inheritdoc cref="P:Roblox.Diagnostics.ICounterBuilder.Container" />
	public object Container
	{
		get
		{
			return _Container;
		}
		set
		{
			if (_CounterDescriptors.Any())
			{
				throw new CannotUpdateContainerException();
			}
			_Container = value;
		}
	}

	private Type ContainerType => Container?.GetType();

	/// <summary>
	/// This is the constructor for the multi-instance counters.
	/// </summary>
	[Obsolete("Please use other constructor.")]
	public CounterBuilder(string performanceCategory, string instanceName, TimeSpan updateInterval, object container, HashSet<int> percentiles = null)
		: this(performanceCategory, container, () => updateInterval, instanceName, percentiles)
	{
	}

	/// <summary>
	/// This is the constructor for the single instance counters.
	/// </summary>
	[Obsolete("Please use other constructor.")]
	public CounterBuilder(string performanceCategory, TimeSpan updateInterval, object container, HashSet<int> percentiles = null)
		: this(performanceCategory, container, () => updateInterval, null, percentiles)
	{
	}

	/// <summary>
	/// Initializes a <see cref="T:Roblox.Diagnostics.CounterBuilder" />
	/// </summary>
	/// <remarks>
	/// Arguments that are null will go to their defaults with the exceptions of:
	/// <paramref name="performanceCounterCategory" />: This argument is required.
	/// <paramref name="instanceName" />: If this is null the category type becomes <see cref="F:System.Diagnostics.PerformanceCounterCategoryType.SingleInstance" />
	/// </remarks>
	/// <param name="performanceCounterCategory">The performance counter category.</param>
	/// <param name="container">The container for the performance counters being created. If this is not specified or is null <see cref="!:SetContainer" /> must be called separately.</param>
	/// <param name="updateInterval">The update interval to be used for <see cref="T:Roblox.Diagnostics.IAverageValueCounter" />s.</param>
	/// <param name="instanceName">The instance name for multi instance counters. If not provided counter category type is <see cref="F:System.Diagnostics.PerformanceCounterCategoryType.SingleInstance" />.</param>
	/// <param name="percentiles">A hashset of percentiles for <see cref="T:Roblox.Diagnostics.IPercentileValueCounter" />s.</param>
	public CounterBuilder(string performanceCounterCategory, object container = null, Func<TimeSpan> updateInterval = null, string instanceName = null, HashSet<int> percentiles = null)
	{
		if (string.IsNullOrWhiteSpace(performanceCounterCategory))
		{
			throw new ArgumentException("Performance counter category must not be null or whitespace.", "performanceCounterCategory");
		}
		_PerformanceCategory = performanceCounterCategory;
		Container = container;
		_UpdateInterval = updateInterval?.Invoke() ?? Settings.Default.DefaultUpdateInterval;
		if (instanceName != null)
		{
			_InstanceName = instanceName;
			_InstanceType = PerformanceCounterCategoryType.MultiInstance;
		}
		else
		{
			_InstanceType = PerformanceCounterCategoryType.SingleInstance;
		}
		_Percentiles = percentiles ?? _DefaultPercentiles;
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.AddPercentileCounter(System.Linq.Expressions.Expression{System.Func{Roblox.Diagnostics.IPercentileValueCounter}})" />
	public void AddPercentileCounter(Expression<Func<IPercentileValueCounter>> expression)
	{
		if (ContainerType == null)
		{
			throw new ContainerNotSetException();
		}
		string percentileGroupName = ((MemberExpression)expression.Body).Member.Name;
		CheckName($"{percentileGroupName}.Percentile");
		CustomCounterDescriptor<PercentileValueCounter> percentileValueDescriptor = new CustomCounterDescriptor<PercentileValueCounter>(percentileGroupName, Container, ContainerType);
		_PercentileCounterDescriptors.Add(percentileValueDescriptor);
		_InternalPercentileCounters[percentileValueDescriptor.GroupName] = new Dictionary<int, PerformanceCounter>();
		List<CounterDescriptor> counterDescriptors = new List<CounterDescriptor>();
		foreach (int percentile in _Percentiles.OrderBy((int el) => el))
		{
			CounterDescriptor cd = new CounterDescriptor($"{percentileValueDescriptor.GroupName}.Percentile.{percentile:D2}", delegate(PerformanceCounter pc)
			{
				_InternalPercentileCounters[percentileValueDescriptor.GroupName][percentile] = pc;
			}, PerformanceCounterType.NumberOfItems32);
			counterDescriptors.Add(cd);
		}
		_CounterDescriptors.AddRange(counterDescriptors);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.AddPercentileCounter(System.String,System.Action{Roblox.Diagnostics.IPercentileValueCounter})" />
	public void AddPercentileCounter(string counterPrefix, Action<IPercentileValueCounter> onCreatedFunc)
	{
		if (ContainerType == null)
		{
			throw new ContainerNotSetException();
		}
		CheckName($"{counterPrefix}.Percentile");
		CustomCounterDescriptor<PercentileValueCounter> percentileValueDescriptor = new CustomCounterDescriptor<PercentileValueCounter>(counterPrefix, onCreatedFunc);
		_PercentileCounterDescriptors.Add(percentileValueDescriptor);
		_InternalPercentileCounters[percentileValueDescriptor.GroupName] = new Dictionary<int, PerformanceCounter>();
		List<CounterDescriptor> counterDescriptors = new List<CounterDescriptor>();
		foreach (int percentile in _Percentiles.OrderBy((int el) => el))
		{
			CounterDescriptor cd = new CounterDescriptor($"{percentileValueDescriptor.GroupName}.Percentile.{percentile:D2}", delegate(PerformanceCounter pc)
			{
				_InternalPercentileCounters[percentileValueDescriptor.GroupName][percentile] = pc;
			}, PerformanceCounterType.NumberOfItems32);
			counterDescriptors.Add(cd);
		}
		_CounterDescriptors.AddRange(counterDescriptors);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.AddAverageCounter(System.Linq.Expressions.Expression{System.Func{Roblox.Diagnostics.IAverageValueCounter}})" />
	public void AddAverageCounter(Expression<Func<IAverageValueCounter>> expression)
	{
		if (ContainerType == null)
		{
			throw new ContainerNotSetException();
		}
		string counterName = ((MemberExpression)expression.Body).Member.Name;
		string averageName = $"{counterName}.Average";
		CheckName(averageName);
		CustomCounterDescriptor<AverageValueCounter> averageDescriptor = new CustomCounterDescriptor<AverageValueCounter>(counterName, Container, ContainerType);
		Action<PerformanceCounter> newSetter = delegate(PerformanceCounter cd)
		{
			averageDescriptor.Setter(new AverageValueCounter(cd, _UpdateInterval));
		};
		CounterDescriptor averageInternal = new CounterDescriptor(averageName, newSetter, PerformanceCounterType.NumberOfItems64);
		_CounterDescriptors.Add(averageInternal);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.AddAverageCounter(System.String,System.Action{Roblox.Diagnostics.IAverageValueCounter})" />
	public void AddAverageCounter(string counterName, Action<IAverageValueCounter> onCreatedFunc)
	{
		if (ContainerType == null)
		{
			throw new ContainerNotSetException();
		}
		CheckName(counterName);
		Action<PerformanceCounter> newSetter = delegate(PerformanceCounter cd)
		{
			onCreatedFunc(new AverageValueCounter(cd, _UpdateInterval));
		};
		CounterDescriptor averageInternal = new CounterDescriptor(counterName, newSetter, PerformanceCounterType.NumberOfItems64);
		_CounterDescriptors.Add(averageInternal);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.AddRateOfCountsPerSecond32Counter(System.Linq.Expressions.Expression{System.Func{System.Diagnostics.PerformanceCounter}})" />
	public void AddRateOfCountsPerSecond32Counter(Expression<Func<PerformanceCounter>> expression)
	{
		AddCounter(expression, PerformanceCounterType.RateOfCountsPerSecond32);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.AddRateOfCountsPerSecond32Counter(System.String,System.Action{Roblox.Diagnostics.IPerformanceCounter})" />
	public void AddRateOfCountsPerSecond32Counter(string counterName, Action<IPerformanceCounter> onCreatedFunc)
	{
		AddCounter(counterName, onCreatedFunc, PerformanceCounterType.RateOfCountsPerSecond32);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.AddCounter(System.Linq.Expressions.Expression{System.Func{System.Diagnostics.PerformanceCounter}},System.Diagnostics.PerformanceCounterType)" />
	public void AddCounter(Expression<Func<PerformanceCounter>> expression, PerformanceCounterType counterType)
	{
		if (Container == null)
		{
			throw new ContainerNotSetException();
		}
		string counterName = ((MemberExpression)expression.Body).Member.Name;
		CheckName(counterName);
		CounterDescriptor cd = new CounterDescriptor(counterName, Container, counterType);
		_CounterDescriptors.Add(cd);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.AddCounter(System.String,System.Action{Roblox.Diagnostics.IPerformanceCounter},System.Diagnostics.PerformanceCounterType)" />
	public void AddCounter(string counterName, Action<IPerformanceCounter> onCreatedFunc, PerformanceCounterType counterType)
	{
		if (Container == null)
		{
			throw new ContainerNotSetException();
		}
		CheckName(counterName);
		CounterDescriptor cd = new CounterDescriptor(counterName, delegate(PerformanceCounter pc)
		{
			onCreatedFunc(new PerformanceCounterWrapper(pc));
		}, counterType);
		_CounterDescriptors.Add(cd);
	}

	/// <inheritdoc cref="M:Roblox.Diagnostics.ICounterBuilder.Create" />
	public void Create()
	{
		if (_CountersCreated)
		{
			throw new CountersAlreadyCreatedException("Attempt to call 'Create' on a CounterBuilder whose counters have already been created.");
		}
		_CountersCreated = true;
		if (_InstanceType == PerformanceCounterCategoryType.MultiInstance)
		{
			CounterCreator.InitializeMultiInstance(_PerformanceCategory, _InstanceName, _CounterDescriptors.ToArray());
		}
		else if (_InstanceType == PerformanceCounterCategoryType.SingleInstance)
		{
			CounterCreator.InitializeSingleInstance(_PerformanceCategory, _CounterDescriptors.ToArray());
		}
		foreach (CustomCounterDescriptor<PercentileValueCounter> descriptor in _PercentileCounterDescriptors)
		{
			PercentileValueCounter pvc = new PercentileValueCounter(_InternalPercentileCounters[descriptor.GroupName], _UpdateInterval);
			descriptor.Setter(pvc);
		}
	}

	private void CheckName(string counterName)
	{
		if (string.IsNullOrWhiteSpace(counterName))
		{
			throw new ArgumentNullException(string.Format("Invalid {0}: '{1}'", "counterName", counterName));
		}
		if (_ExistingPercentileGroupNames.Contains(counterName))
		{
			throw new ArgumentException($"Cannot create more than one percentile collector with the same name.  Duplicate name = {counterName}");
		}
		_ExistingPercentileGroupNames.Add(counterName);
	}
}
