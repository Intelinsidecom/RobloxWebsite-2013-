using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Instrumentation;

namespace Roblox.Web.Metrics;

/// <inheritdoc cref="T:Roblox.Web.Metrics.IEndpointFailurePerformanceCounter" />
internal class EndpointFailurePerformanceCounter : IEndpointFailurePerformanceCounter
{
	internal IRateOfCountsPerSecondCounter EndpointFailuresPerSecond { get; set; }

	internal IAverageValueCounter EndpointExecutionTime { get; set; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.EndpointFailurePerformanceCounter" />
	/// </summary>
	/// <remarks>
	/// This constructor is non-unittestable because it initializes a new instance
	/// and we don't want the implementation of that instance to run with our tests.
	/// </remarks>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="performanceCounterCategory">The performance counter category.</param>
	/// <param name="controllerName">The controller name the endpoint lives on.</param>
	/// <param name="actionName">The action name of the endpoint from the controller.</param>
	[ExcludeFromCodeCoverage]
	internal EndpointFailurePerformanceCounter(ICounterRegistry counterRegistry, string performanceCounterCategory, string controllerName, string actionName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		EndpointFailuresPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCounterCategory, "EndpointFailuresPerSecond", $"{controllerName}:{actionName}");
		EndpointExecutionTime = counterRegistry.GetAverageValueCounter(performanceCounterCategory, string.Format("{0}.Average", "EndpointExecutionTime"), $"{controllerName}:{actionName}");
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IEndpointFailurePerformanceCounter.Increment(System.TimeSpan)" />
	public void Increment(TimeSpan executionTime)
	{
		long sample = Convert.ToInt64(Math.Floor(executionTime.TotalMilliseconds));
		EndpointFailuresPerSecond.Increment();
		EndpointExecutionTime.Sample(sample);
	}
}
