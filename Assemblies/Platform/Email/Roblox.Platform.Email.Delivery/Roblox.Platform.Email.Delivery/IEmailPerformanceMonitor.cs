using System;

namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// Provides a common interface for an object that can record email service performance using PerfMon counters.
/// </summary>
internal interface IEmailPerformanceMonitor
{
	/// <summary>
	/// Increments the PerfMon counters when an <see cref="T:Roblox.Platform.Email.Delivery.IEmail" /> has been successfully sent.
	/// </summary>
	/// <param name="email">The IEmail sent.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown when the input email is null.</exception>
	void RecordEmailSent(IEmail email);

	/// <summary>
	/// Increments the PerfMon counters when an error occurred during the sending of an <see cref="T:Roblox.Platform.Email.Delivery.IEmail" />.
	/// </summary>
	/// <param name="email">The IEmail being sent.</param>
	/// <param name="exception">The exception thrown.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown when the input email is null.</exception>
	void RecordEmailException(IEmail email, Exception exception);
}
