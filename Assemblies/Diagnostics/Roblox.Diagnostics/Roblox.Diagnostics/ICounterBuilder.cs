using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Roblox.Diagnostics;

/// <summary>
/// A class to build performance counters
/// </summary>
/// <remarks>
/// How to use this:
/// Any class created will, at runtime, call this to make sure the local machine counter setup is done.
/// In code: Create a CounterBuilder.
/// Use the public methods to create percentileValue counters, averageValue counters, and regular counters.
/// Then call .Create();
/// If you include instanceName it will be multi-instance.
/// </remarks>
public interface ICounterBuilder
{
	/// <summary>
	/// The class the performance counter properties live in.
	/// </summary>
	/// <remarks>
	/// This must be set before adding any counters.
	/// </remarks>
	/// <exception cref="T:Roblox.Diagnostics.CannotUpdateContainerException">Attempt to set when counters have already started being added.</exception>
	object Container { get; set; }

	/// <summary>
	/// Call this like: AddPercentileCounter(() =&gt; your object of class PercentileValueCounter)
	/// A PercentileCounter will be assigned to your object.
	/// </summary>
	/// <param name="expression">The expression used to initialize the counter after <see cref="M:Roblox.Diagnostics.ICounterBuilder.Create" /> is called.</param>
	void AddPercentileCounter(Expression<Func<IPercentileValueCounter>> expression);

	/// <summary>
	/// Adds percentile counter with given name
	/// </summary>
	/// <param name="counterName">The counter name.</param>
	/// <param name="onCreatedFunc">The function that returns the counter after <see cref="M:Roblox.Diagnostics.ICounterBuilder.Create" /> is called.</param>
	/// <exception cref="T:Roblox.Diagnostics.ContainerNotSetException"><see cref="P:Roblox.Diagnostics.ICounterBuilder.Container" /> is null.</exception>
	void AddPercentileCounter(string counterName, Action<IPercentileValueCounter> onCreatedFunc);

	/// <summary>
	/// Call this like: AddAverageCounter(() =&gt; your object of class AverageValueCounter)
	/// An internal auto-updating counter will be created, started, and assigned to your counter.
	/// </summary>
	/// <param name="expression">The expression used to initialize the counter after <see cref="M:Roblox.Diagnostics.ICounterBuilder.Create" /> is called.</param>
	void AddAverageCounter(Expression<Func<IAverageValueCounter>> expression);

	/// <summary>
	/// Adds average counter with given name
	/// </summary>
	/// <param name="counterName">The counter name.</param>
	/// <param name="onCreatedFunc">The function that returns the counter after <see cref="M:Roblox.Diagnostics.ICounterBuilder.Create" /> is called.</param>
	/// <exception cref="T:Roblox.Diagnostics.ContainerNotSetException"><see cref="P:Roblox.Diagnostics.ICounterBuilder.Container" /> is null.</exception>
	void AddAverageCounter(string counterName, Action<IAverageValueCounter> onCreatedFunc);

	[Obsolete("Please use interface version instead.")]
	void AddRateOfCountsPerSecond32Counter(Expression<Func<PerformanceCounter>> expression);

	/// <summary>
	/// Adds a counters per second counter to the builder.
	/// </summary>
	/// <remarks>
	/// This is the counter to use to track increments per second.
	/// </remarks>
	/// <param name="counterName">The counter name.</param>
	/// <param name="onCreatedFunc">The function that returns the counter after <see cref="M:Roblox.Diagnostics.ICounterBuilder.Create" /> is called.</param>
	/// <exception cref="T:Roblox.Diagnostics.ContainerNotSetException"><see cref="P:Roblox.Diagnostics.ICounterBuilder.Container" /> is null.</exception>
	void AddRateOfCountsPerSecond32Counter(string counterName, Action<IPerformanceCounter> onCreatedFunc);

	/// <summary>
	/// Call this like: AddCounter(() =&gt; PerformanceCounter)
	/// The CounterBuilder will create the counters and assign them to what you send in.
	/// </summary>
	/// <param name="expression">The expression used to initialize the counter after <see cref="M:Roblox.Diagnostics.ICounterBuilder.Create" /> is called.</param>
	/// <param name="counterType">The type of the counter.</param>
	void AddCounter(Expression<Func<PerformanceCounter>> expression, PerformanceCounterType counterType);

	/// <summary>
	/// Adds counter with given name.
	/// </summary>
	/// <param name="counterName">The counter name.</param>
	/// <param name="onCreatedFunc">The function that returns the counter after <see cref="M:Roblox.Diagnostics.ICounterBuilder.Create" /> is called.</param>
	/// <param name="counterType">The type of the counter.</param>
	/// <exception cref="T:Roblox.Diagnostics.ContainerNotSetException"><see cref="P:Roblox.Diagnostics.ICounterBuilder.Container" /> is null.</exception>
	void AddCounter(string counterName, Action<IPerformanceCounter> onCreatedFunc, PerformanceCounterType counterType);

	/// <summary>
	/// Creates the performance counters that were added.
	/// </summary>
	void Create();
}
