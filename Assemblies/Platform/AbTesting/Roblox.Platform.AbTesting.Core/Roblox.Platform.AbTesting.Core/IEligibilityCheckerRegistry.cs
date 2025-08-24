namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Provides a common interface for a registry of <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCheckerFactory" />s used to construct <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" />s.
/// </summary>
public interface IEligibilityCheckerRegistry
{
	/// <summary>
	/// Registers an eligibility checker name with the given <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCheckerFactory" />.
	/// </summary>
	/// <param name="eligibilityCheckerName">The name of the <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" /> to register <paramref name="factory" /> under.</param>
	/// <param name="factory">The <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCheckerFactory" /> to register.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="eligibilityCheckerName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="factory" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <paramref name="eligibilityCheckerName" /> is already registered.</exception>
	void Register(string eligibilityCheckerName, IEligibilityCheckerFactory factory);

	/// <summary>
	/// Constructs an <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" /> using the <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCheckerFactory" /> under the given name.
	/// </summary>
	/// <param name="eligibilityCheckerName">The registered name of the <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" /> to construct.</param>
	/// <returns>The constructed <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" />, or null if <paramref name="eligibilityCheckerName" /> was not registered or was unsupported by its registered <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCheckerFactory" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="eligibilityCheckerName" /> is null.</exception>
	IEligibilityChecker Construct(string eligibilityCheckerName);
}
