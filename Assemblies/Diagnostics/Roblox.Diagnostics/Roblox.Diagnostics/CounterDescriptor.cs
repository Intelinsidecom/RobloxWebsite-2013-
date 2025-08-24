using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Roblox.Diagnostics;

/// <summary>
/// A descriptor for creating counters.
/// </summary>
public class CounterDescriptor : ICounterDescriptor
{
	/// <summary>
	/// The function that returns the performance counter once it's created.
	/// </summary>
	public Action<PerformanceCounter> Setter { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Diagnostics.CounterDescriptor.CounterCreationData" /> to create the counter with.
	/// </summary>
	public CounterCreationData CounterCreationData { get; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Diagnostics.CounterDescriptor" />
	/// </summary>
	/// <param name="counterName">The <see cref="P:System.Diagnostics.CounterCreationData.CounterName" />.</param>
	/// <param name="setter">The <see cref="P:Roblox.Diagnostics.CounterDescriptor.Setter" /></param>
	/// <param name="counterType">The <see cref="P:System.Diagnostics.CounterCreationData.CounterType" />.</param>
	/// <param name="counterHelp">The <see cref="P:System.Diagnostics.CounterCreationData.CounterHelp" />.</param>
	public CounterDescriptor(string counterName, Action<PerformanceCounter> setter, PerformanceCounterType counterType, string counterHelp = "")
	{
		CounterCreationData = new CounterCreationData(counterName, counterHelp, counterType);
		Setter = setter;
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Diagnostics.CounterDescriptor" />
	/// </summary>
	/// <param name="counterName">The <see cref="P:System.Diagnostics.CounterCreationData.CounterName" />.</param>
	/// <param name="container">The container for the <see cref="P:Roblox.Diagnostics.CounterDescriptor.Setter" />.</param>
	/// <param name="counterType">The <see cref="P:System.Diagnostics.CounterCreationData.CounterType" />.</param>
	/// <param name="containerType">The type of <paramref name="container" />.</param>
	/// <param name="counterHelp">The <see cref="P:System.Diagnostics.CounterCreationData.CounterHelp" />.</param>
	public CounterDescriptor(string counterName, object container, PerformanceCounterType counterType, Type containerType, string counterHelp = "")
		: this(counterName, CounterHelpers.GetSetter<PerformanceCounter>(counterName, container, containerType), counterType, counterHelp)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Diagnostics.CounterDescriptor" />
	/// </summary>
	/// <param name="nameExpression">The <see cref="T:System.Linq.Expressions.Expression" /> that gets the <see cref="P:System.Diagnostics.CounterCreationData.CounterName" />.</param>
	/// <param name="setter">The <see cref="P:Roblox.Diagnostics.CounterDescriptor.Setter" /></param>
	/// <param name="counterType">The <see cref="P:System.Diagnostics.CounterCreationData.CounterType" />.</param>
	/// <param name="counterHelp">The <see cref="P:System.Diagnostics.CounterCreationData.CounterHelp" />.</param>
	public CounterDescriptor(Expression<Func<object>> nameExpression, Action<PerformanceCounter> setter, PerformanceCounterType counterType, string counterHelp = "")
		: this(CounterHelpers.GetPropertyName(nameExpression), setter, counterType, counterHelp)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Diagnostics.CounterDescriptor" />
	/// </summary>
	/// <param name="nameExpression">The <see cref="T:System.Linq.Expressions.Expression" /> that gets the <see cref="P:System.Diagnostics.CounterCreationData.CounterName" />.</param>
	/// <param name="container">The container for the <see cref="P:Roblox.Diagnostics.CounterDescriptor.Setter" />.</param>
	/// <param name="counterType">The <see cref="P:System.Diagnostics.CounterCreationData.CounterType" />.</param>
	/// <param name="counterHelp">The <see cref="P:System.Diagnostics.CounterCreationData.CounterHelp" />.</param>
	public CounterDescriptor(Expression<Func<object>> nameExpression, object container, PerformanceCounterType counterType, string counterHelp = "")
		: this(CounterHelpers.GetPropertyName(nameExpression), container, counterType, counterHelp)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Diagnostics.CounterDescriptor" />
	/// </summary>
	/// <param name="counterName">The <see cref="P:System.Diagnostics.CounterCreationData.CounterName" />.</param>
	/// <param name="container">The container for the <see cref="P:Roblox.Diagnostics.CounterDescriptor.Setter" />.</param>
	/// <param name="counterType">The <see cref="P:System.Diagnostics.CounterCreationData.CounterType" />.</param>
	/// <param name="counterHelp">The <see cref="P:System.Diagnostics.CounterCreationData.CounterHelp" />.</param>
	public CounterDescriptor(string counterName, object container, PerformanceCounterType counterType, string counterHelp = "")
		: this(counterName, container, counterType, container.GetType(), counterHelp)
	{
	}
}
