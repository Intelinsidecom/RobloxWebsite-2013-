using System;
using Roblox.EphemeralCounters;
using Roblox.EventLog;

namespace Roblox.Web.Thumbnails.Metrics;

/// <summary>
/// A class for tracking thumbnail upload metrics.
/// </summary>
public class ThumbnailUploadMetricsTracker
{
	private readonly ILogger _Logger;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private const string _ThumbnailUploadSuccessCounterName = "ThumbnailUploadSucceeded";

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Web.Thumbnails.Metrics.ThumbnailUploadMetricsTracker" />.
	/// </summary>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="ephemeralCounterFactory">An <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="logger" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="ephemeralCounterFactory" /></exception>
	public ThumbnailUploadMetricsTracker(ILogger logger, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_EphemeralCounterFactory = ephemeralCounterFactory ?? throw new ArgumentNullException("ephemeralCounterFactory");
	}

	/// <summary>
	/// Tracks a thumbnail upload success using EphemeralCounters.
	/// </summary>
	public void IncrementCounterForSuccess()
	{
		try
		{
			_EphemeralCounterFactory.GetCounter("ThumbnailUploadSucceeded").IncrementInBackground();
		}
		catch (Exception ex)
		{
			_Logger.Error(string.Format("Failed incrementing the counter for {0} because {1}", "ThumbnailUploadSucceeded", ex));
		}
	}
}
