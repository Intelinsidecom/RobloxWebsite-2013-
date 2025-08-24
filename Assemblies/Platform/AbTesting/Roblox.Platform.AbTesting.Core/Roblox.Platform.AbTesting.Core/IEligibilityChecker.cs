namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Provides a common interface to check whether or not a subject is eligible to enroll in an experiment.
/// </summary>
/// <example>
/// <code>
/// private class AgeEligibilityChecker : IEligibilityChecker
/// {
///     private int _Age;
///
///     public AgeOver13EligibilityChecker(int age)
///     {
///         _Age = age;
///     }
///
///     public bool IsEligible()
///     {
///         return _Age &gt; 13;
///     }
/// }
/// </code>
/// </example>
public interface IEligibilityChecker
{
	/// <summary>
	/// Returns whether or not a subject is eligible to enroll in an experiment.
	/// </summary>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" />'s subject is eligible to enroll in an experiment.</returns>
	bool IsEligible();
}
