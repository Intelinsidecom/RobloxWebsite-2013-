using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

public class EnrollmentPerformanceMonitor : IEnrollmentPerformanceMonitor
{
	private const string _PerformanceCategory = "Roblox.Platform.AbTesting.Core Enrollments";

	private const string _EnrollmentAttemptPerformanceCounterName = "A|B Enrollment Attempts";

	private const string _EnrollmentSuccessPerformanceCounterName = "A|B Enrollment Successes";

	private const string _EnrollmentDeclinationPerformanceCounterName = "A|B Enrollment Declinations";

	private const string _EnrollmentCheckPerformanceCounterName = "A|B Enrollment Checks";

	private IRateOfCountsPerSecondCounter _EnrollmentAttemptPerformanceCounter;

	private IRateOfCountsPerSecondCounter _EnrollmentSuccessPerformanceCounter;

	private IRateOfCountsPerSecondCounter _EnrollmentDeclinationPerformanceCounter;

	private IRateOfCountsPerSecondCounter _EnrollmentCheckPerformanceCounter;

	private readonly ILogger _Logger;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.EnrollmentPerformanceMonitor" /> class.
	/// </summary>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /> used to log errors.</param>
	/// <exception cref="T:System.ComponentModel.Win32Exception">A call to an underlying system API failed.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
	public EnrollmentPerformanceMonitor(ICounterRegistry counterRegistry, ILogger logger)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_EnrollmentAttemptPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.AbTesting.Core Enrollments", "A|B Enrollment Attempts");
		_EnrollmentSuccessPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.AbTesting.Core Enrollments", "A|B Enrollment Successes");
		_EnrollmentDeclinationPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.AbTesting.Core Enrollments", "A|B Enrollment Declinations");
		_EnrollmentCheckPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.AbTesting.Core Enrollments", "A|B Enrollment Checks");
	}

	public void IncrementEnrollmentAttemptCounter()
	{
		try
		{
			_EnrollmentAttemptPerformanceCounter.Increment();
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void IncrementEnrollmentSuccessCounter()
	{
		try
		{
			_EnrollmentSuccessPerformanceCounter.Increment();
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void IncrementEnrollmentDeclinationCounter()
	{
		try
		{
			_EnrollmentDeclinationPerformanceCounter.Increment();
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void IncrementEnrollmentCheckCounter()
	{
		try
		{
			_EnrollmentCheckPerformanceCounter.Increment();
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}
}
