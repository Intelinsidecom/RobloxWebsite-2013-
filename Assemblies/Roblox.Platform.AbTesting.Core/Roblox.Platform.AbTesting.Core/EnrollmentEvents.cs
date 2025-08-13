using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Contains static events related to enrollment.
/// </summary>
public static class EnrollmentEvents
{
	/// <summary>
	/// Represents a handler for the <see cref="E:Roblox.Platform.AbTesting.Core.EnrollmentEvents.EnrollmentSucceeded" /> event.
	/// </summary>
	/// <param name="enrollment">The resulting <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" />.</param>
	public delegate void EnrollmentSucceededEventHandler(IEnrollment enrollment);

	/// <summary>
	/// Occurs after a subject successfully enrolled in an experiment.
	/// </summary>
	public static event EnrollmentSucceededEventHandler EnrollmentSucceeded;

	/// <summary>
	/// Occurs before a subject attempts to enroll in an experiment.
	/// </summary>
	public static event Action EnrollmentAttempting;

	/// <summary>
	/// Occurs after a subject was declined from enrolling in an experiment.
	/// </summary>
	public static event Action EnrollmentDeclined;

	/// <summary>
	/// Occurs after a subject has checked its enrollment in an experiment.
	/// </summary>
	public static event Action EnrollmentChecked;

	/// <summary>
	/// Invokes the <see cref="E:Roblox.Platform.AbTesting.Core.EnrollmentEvents.EnrollmentSucceeded" /> event with the given <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" />.
	/// </summary>
	/// <param name="enrollment">The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> to invoke the <see cref="E:Roblox.Platform.AbTesting.Core.EnrollmentEvents.EnrollmentSucceeded" /> event for.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="enrollment" /> is null.</exception>
	internal static void InvokeEnrollmentSucceeded(IEnrollment enrollment)
	{
		if (enrollment == null)
		{
			throw new PlatformArgumentNullException("enrollment");
		}
		if (EnrollmentEvents.EnrollmentSucceeded != null)
		{
			EnrollmentEvents.EnrollmentSucceeded(enrollment);
		}
	}

	/// <summary>
	/// Invokes the <see cref="E:Roblox.Platform.AbTesting.Core.EnrollmentEvents.EnrollmentAttempting" /> event.
	/// </summary>
	internal static void InvokeEnrollmentAttempting()
	{
		if (EnrollmentEvents.EnrollmentAttempting != null)
		{
			EnrollmentEvents.EnrollmentAttempting();
		}
	}

	/// <summary>
	/// Invokes the <see cref="E:Roblox.Platform.AbTesting.Core.EnrollmentEvents.EnrollmentDeclined" /> event.
	/// </summary>
	internal static void InvokeEnrollmentDeclined()
	{
		if (EnrollmentEvents.EnrollmentDeclined != null)
		{
			EnrollmentEvents.EnrollmentDeclined();
		}
	}

	/// <summary>
	/// Invokes the <see cref="E:Roblox.Platform.AbTesting.Core.EnrollmentEvents.EnrollmentChecked" /> event.
	/// </summary>
	internal static void InvokeEnrollmentChecked()
	{
		if (EnrollmentEvents.EnrollmentChecked != null)
		{
			EnrollmentEvents.EnrollmentChecked();
		}
	}
}
