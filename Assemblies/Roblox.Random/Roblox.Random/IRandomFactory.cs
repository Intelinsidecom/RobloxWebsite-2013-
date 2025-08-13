namespace Roblox.Random;

/// <summary>
/// Represents a factory to create <see cref="T:Roblox.Random.IRandom" /> objects.
/// </summary>
public interface IRandomFactory
{
	/// <summary>
	/// Gets the default <see cref="T:Roblox.Random.IRandom" /> implementation.
	/// </summary>
	/// <remarks>
	///     The default random uses an <see cref="T:Roblox.Random.ThreadLocalRandom" /> implementation
	///     with a crypto based seed provided by <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" />.
	/// </remarks>
	/// <returns>An <see cref="T:Roblox.Random.IRandom" /> object.</returns>
	IRandom GetDefaultRandom();
}
