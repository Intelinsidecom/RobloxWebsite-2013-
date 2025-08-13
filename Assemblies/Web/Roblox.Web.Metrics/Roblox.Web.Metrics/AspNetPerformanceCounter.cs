using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Instrumentation;

namespace Roblox.Web.Metrics;

/// <inheritdoc cref="T:Roblox.Web.Metrics.IAspNetPerformanceCounter" />
internal class AspNetPerformanceCounter : IAspNetPerformanceCounter
{
	internal IRateOfCountsPerSecondCounter AspNetRequestsPerSecond { get; set; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.AspNetPerformanceCounter" />
	/// </summary>
	/// <remarks>
	/// This constructor is non-unittestable because it initializes a new instance
	/// and we don't want the implementation of that instance to run with our tests.
	/// </remarks>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="performanceCounterCategory">The performance counter category.</param>
	/// <param name="pageType">The <see cref="T:Roblox.Web.Metrics.AspNetPageType" />.</param>
	/// <param name="pageName">The page name for the AspNet file.</param>
	[ExcludeFromCodeCoverage]
	internal AspNetPerformanceCounter(ICounterRegistry counterRegistry, string performanceCounterCategory, AspNetPageType pageType, string pageName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		AspNetRequestsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCounterCategory, "AspNetRequestsPerSecond", $"{pageType}:{pageName}");
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IAspNetPerformanceCounter.IncrementRequest" />
	public void IncrementRequest()
	{
		AspNetRequestsPerSecond.Increment();
	}
}
