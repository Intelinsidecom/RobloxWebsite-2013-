namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Provides a common interface for a factory that constructs <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" />s.
/// </summary>
public interface IEligibilityCheckerFactory
{
	/// <summary>
	/// Constructs an <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" /> by its name.
	/// </summary>
	/// <param name="name">The name of the <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" /> to construct.</param>
	/// <returns>The constructed <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" /> with the given name, or null if it was not supported.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="name" /> is null.</exception>
	IEligibilityChecker ConstructByName(string name);
}
