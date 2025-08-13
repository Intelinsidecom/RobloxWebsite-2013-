using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Instrumentation;

namespace Roblox.Web.Metrics;

/// <inheritdoc cref="T:Roblox.Web.Metrics.IEndpointResponsePerformanceCounter" />
internal class EndpointResponsePerformanceCounter : IEndpointResponsePerformanceCounter
{
	internal IRateOfCountsPerSecondCounter EndpointResponsesPerSecond { get; set; }

	internal IAverageValueCounter EndpointExecutionTime { get; set; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.EndpointResponsePerformanceCounter" />
	/// </summary>
	/// <remarks>
	/// This constructor is non-unittestable because it initializes a new instance
	/// and we don't want the implementation of that instance to run with our tests.
	/// </remarks>
	/// <param name="performanceCounterCategory">The performance counter category.</param>
	/// <param name="controllerName">The controller name the endpoint lives on.</param>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="actionName">The action name of the endpoint from the controller.</param>
	[ExcludeFromCodeCoverage]
	internal EndpointResponsePerformanceCounter(ICounterRegistry counterRegistry, string performanceCounterCategory, string controllerName, string actionName)
	{
		EndpointResponsesPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCounterCategory, "EndpointResponsesPerSecond", $"{controllerName}:{actionName}");
		EndpointExecutionTime = counterRegistry.GetAverageValueCounter(performanceCounterCategory, string.Format("{0}.Average", "EndpointExecutionTime"), $"{controllerName}:{actionName}");
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IEndpointResponsePerformanceCounter.Increment(System.TimeSpan)" />
	public void Increment(TimeSpan executionTime)
	{
		long sample = Convert.ToInt64(Math.Floor(executionTime.TotalMilliseconds));
		EndpointResponsesPerSecond.Increment();
		EndpointExecutionTime.Sample(sample);
	}
}
