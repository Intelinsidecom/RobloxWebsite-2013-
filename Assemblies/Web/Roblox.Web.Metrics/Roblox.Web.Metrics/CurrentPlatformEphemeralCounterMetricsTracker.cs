using System;
using System.Diagnostics.CodeAnalysis;
using System.Web;
using Roblox.EphemeralCounters;
using Roblox.Platform.Devices;
using Roblox.Web.Devices;

namespace Roblox.Web.Metrics;

/// <summary>
/// Class for writing metrics to EphemeralCounters for the current request's <see cref="T:Roblox.Platform.Devices.IPlatform" />.
/// </summary>
/// <remarks>
/// DO NOT USE THIS IN A CHILD THREAD
/// Doing so will result in the HttpContext used below to be null.
/// </remarks>
public class CurrentPlatformEphemeralCounterMetricsTracker : ICurrentPlatformEphemeralCounterMetricsTracker
{
	private const string _GlobalCounterSuffix = "Global";

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Web.Metrics.CurrentPlatformEphemeralCounterMetricsTracker" />.
	/// </summary>
	/// <param name="ephemeralCounterFactory">An instance of <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="clientDeviceIdentifer" /> or <paramref name="ephemeralCounterFactory" /> is null.</exception>
	public CurrentPlatformEphemeralCounterMetricsTracker(IClientDeviceIdentifier clientDeviceIdentifier, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		if (clientDeviceIdentifier == null)
		{
			throw new ArgumentNullException("clientDeviceIdentifier");
		}
		if (ephemeralCounterFactory == null)
		{
			throw new ArgumentNullException("ephemeralCounterFactory");
		}
		_ClientDeviceIdentifier = clientDeviceIdentifier;
		_EphemeralCounterFactory = ephemeralCounterFactory;
	}

	/// <inheritdoc cref="T:Roblox.Web.Metrics.ICurrentPlatformEphemeralCounterMetricsTracker"></inheritdoc>
	public void IncrementCountersForCurrentPlatform(string prefix, string suffix = null)
	{
		if (TryGetUserAgent(out var userAgent))
		{
			IPlatform platform = _ClientDeviceIdentifier.GetPlatformByUserAgent(userAgent);
			if (!string.IsNullOrEmpty(suffix))
			{
				suffix = $"_{suffix}";
			}
			IncrementCounter($"{prefix}_{platform.DeviceType}{suffix}");
			IncrementCounter($"{prefix}_{platform.OperatingSystemType}{suffix}");
		}
	}

	/// <inheritdoc cref="T:Roblox.Web.Metrics.ICurrentPlatformEphemeralCounterMetricsTracker"></inheritdoc>
	public void IncrementCountersForCurrentPlatformAndGlobalCounter(string prefix, string suffix = null)
	{
		IncrementCountersForCurrentPlatform(prefix, suffix);
		string globalCounterName = (string.IsNullOrWhiteSpace(suffix) ? string.Format("{0}_{1}", prefix, "Global") : string.Format("{0}_{1}_{2}", prefix, "Global", suffix));
		IncrementCounter(globalCounterName);
	}

	/// <summary>
	/// Increments the <see cref="T:Roblox.EphemeralCounters.ICounter" /> indicated by <paramref name="counterName" />.
	/// </summary>
	/// <param name="counterName">The counter to increment.</param>
	private void IncrementCounter(string counterName)
	{
		_EphemeralCounterFactory.GetCounter(counterName).Increment();
	}

	/// <summary>
	/// Tries to get the current <see cref="T:System.Web.HttpRequest" />'s UserAgent.
	/// </summary>
	/// <remarks>This method should be private but is protected virtual for testing purposes.</remarks>
	/// <param name="userAgent">The </param>
	/// <returns><c>True</c> if fetching the UserAgent from <see cref="T:System.Web.HttpContext" /> was successful, <c>False</c> otherwise.</returns>
	[ExcludeFromCodeCoverage]
	protected virtual bool TryGetUserAgent(out string userAgent)
	{
		userAgent = null;
		HttpContext currentContext = HttpContext.Current;
		if (currentContext == null)
		{
			return false;
		}
		userAgent = currentContext.Request.UserAgent;
		return true;
	}
}
