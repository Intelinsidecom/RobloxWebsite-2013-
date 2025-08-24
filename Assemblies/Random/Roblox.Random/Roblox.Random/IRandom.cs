namespace Roblox.Random;

/// <summary>
/// Provides a common interface for an object that generates random information safely in a multi-threaded environment.
/// </summary>
public interface IRandom
{
	/// <summary>
	/// Returns a nonnegative random number.
	/// </summary>
	/// <returns>A 32-bit signed integer that is greater than or equal to 0 and less than <see cref="F:System.Int32.MaxValue" />.</returns>
	int Next();

	/// <summary>
	/// Returns a nonnegative random number less than the specified maximum.
	/// </summary>
	/// <param name="maxValue">The exclusive upper bound of the random number to be generated. <paramref name="maxValue" /> must be greater than or equal to 0.</param>
	/// <returns>A 32-bit signed integer that is greater than or equal to 0, and less than <paramref name="maxValue" />; that is, the range of return values 
	/// ordinarily includes 0 but not <paramref name="maxValue" />. However, if <paramref name="maxValue" /> equals 0, <paramref name="maxValue" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxValue" /> is less than 0.</exception>
	int Next(int maxValue);

	/// <summary>
	/// Returns a random number within a specified range.
	/// </summary>
	/// <param name="minValue">The inclusive lower bound of the random number to be returned.</param>
	/// <param name="maxValue">The exclusive upper bound of the random number to be returned. <paramref name="maxValue" /> must be greater than or equal 
	/// to <paramref name="minValue" />.</param>
	/// <returns>A 32-bit signed integer greater than or equal to <paramref name="minValue" /> and less than <paramref name="maxValue" />; that is, the range of return 
	/// values includes <paramref name="minValue" /> but not <paramref name="maxValue" />. If <paramref name="minValue" /> equals <paramref name="maxValue" />,
	///  <paramref name="minValue" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="minValue" /> is greater than <paramref name="maxValue" />.</exception>
	int Next(int minValue, int maxValue);

	/// <summary>
	/// Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.
	/// </summary>
	/// <returns>A double-precision floating point number that is greater than or equal to 0.0, and less than 1.0.</returns>
	double NextDouble();

	/// <summary>
	/// Fills the elements of a specified array of bytes with random numbers.
	/// </summary>
	/// <param name="buffer">An array of bytes to contain random numbers.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is <c>null</c>.</exception>
	void NextBytes(byte[] buffer);

	/// <summary>
	/// Returns a nonnegative random number.
	/// </summary>
	/// <returns>A 64-bit signed integer that is greater than or equal to 0 and less than <see cref="F:System.Int64.MaxValue" />.</returns>
	long NextLong();

	/// <summary>
	/// Returns a nonnegative random number less than the specified maximum.
	/// </summary>
	/// <param name="maxValue">The exclusive upper bound of the random number to be generated. <paramref name="maxValue" /> must be greater than or equal to 0.</param>
	/// <returns>A 64-bit signed integer that is greater than or equal to 0, and less than <paramref name="maxValue" />; that is, the range of return values 
	/// ordinarily includes 0 but not <paramref name="maxValue" />. However, if <paramref name="maxValue" /> equals 0, <paramref name="maxValue" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxValue" /> is less than 0.</exception>
	long NextLong(long maxValue);

	/// <summary>
	/// Returns a random number within a specified range.
	/// </summary>
	/// <param name="minValue">The inclusive lower bound of the random number to be returned.</param>
	/// <param name="maxValue">The exclusive upper bound of the random number to be returned. <paramref name="maxValue" /> must be greater than or equal 
	/// to <paramref name="minValue" />.</param>
	/// <returns>A 64-bit signed integer greater than or equal to <paramref name="minValue" /> and less than <paramref name="maxValue" />; that is, the range of return 
	/// values includes <paramref name="minValue" /> but not <paramref name="maxValue" />. If <paramref name="minValue" /> equals <paramref name="maxValue" />,
	///  <paramref name="minValue" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="minValue" /> is greater than <paramref name="maxValue" />.</exception>
	long NextLong(long minValue, long maxValue);
}
