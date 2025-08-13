using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Roblox.Instrumentation;

namespace Roblox.Web.Metrics;

internal class HttpStatusCodePerformanceCounter : IHttpStatusCodePerformanceCounter
{
	internal IRateOfCountsPerSecondCounter HttpStatusCodes { get; set; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.HttpStatusCodePerformanceCounter" />
	/// </summary>
	/// <remarks>
	/// This constructor is non-unittestable because it initializes a new instance
	/// and we don't want the implementation of that instance to run with our tests.
	/// </remarks>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="performanceCounterCategory">The performance counter category.</param>
	/// <param name="statusCode">The status code for the counter.</param>
	[ExcludeFromCodeCoverage]
	public HttpStatusCodePerformanceCounter(ICounterRegistry counterRegistry, string performanceCounterCategory, HttpStatusCode statusCode)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		HttpStatusCodes = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCounterCategory, "HttpStatusCodes", statusCode.ToString());
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IHttpStatusCodePerformanceCounter.Increment" />
	public void Increment()
	{
		HttpStatusCodes.Increment();
	}
}
