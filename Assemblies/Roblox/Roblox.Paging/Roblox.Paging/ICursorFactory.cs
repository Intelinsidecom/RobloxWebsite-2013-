namespace Roblox.Paging;

/// <summary>
/// A factory for building request cursors.
/// </summary>
/// <remarks>
/// We want to use cursors for paging requests for a few reasons:
/// - If we change the paging method the consumer will not have to update.
///     e.g. Going from start index paging -&gt; exclusive start key paging the consumer only deals
///     with a cursor string representing a page in both cases. They know no start index, or exclusive start key.
///
/// - Preserving caching.
///     By not allowing consumers to specify their own exclusive start key, start index, etc.
///     we can more easily cache collections (even if not now, in the future).
///     It enforces that, for example, paging could always be on a multiplication of 25 for start index paging.
///     Assuming the count is 25 for the first request and we don't let a user specify a start index
///     we will know there won't be any cached pages for start index 26 -&gt; 49 that may not be accessed again.
/// </remarks>
public interface ICursorFactory
{
	/// <summary>
	/// Creates a cursor string that represents paging information.
	/// </summary>
	/// <typeparam name="TCursorInformation">The class type holding cursor information.</typeparam>
	/// <param name="cursorInformation">The <typeparamref name="TCursorInformation" />.</param>
	/// <returns>A cursor string to be exposed for requests.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="cursorInformation" />
	/// </exception>
	string CreateCursor<TCursorInformation>(TCursorInformation cursorInformation) where TCursorInformation : CursorBase;

	/// <summary>
	/// Parses a <typeparamref name="TCursorInformation" /> from a cursor string.
	/// </summary>
	/// <typeparam name="TCursorInformation">The class type holding cursor information.</typeparam>
	/// <param name="cursor">The cursor string.</param>
	/// <param name="discriminator">The discriminator for verification (<see cref="P:Roblox.Paging.CursorBase.Discriminator" />).</param>
	/// <returns>The <typeparamref name="TCursorInformation" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="cursor" /> is invalid.
	/// </exception>
	TCursorInformation ParseCursor<TCursorInformation>(string cursor, string discriminator = "") where TCursorInformation : CursorBase;

	/// <summary>
	/// Tries to parse a <typeparamref name="TCursorInformation" /> from a cursor string.
	/// </summary>
	/// <typeparam name="TCursorInformation">The class type holding cursor information.</typeparam>
	/// <param name="cursor">The cursor string.</param>
	/// <param name="cursorInformation">The <typeparamref name="TCursorInformation" />.</param>
	/// <param name="discriminator">The discriminator for verification (<see cref="P:Roblox.Paging.CursorBase.Discriminator" />).</param>
	/// <returns><c>true</c> if the cursor was valid and parsed.</returns>
	bool TryParseCursor<TCursorInformation>(string cursor, out TCursorInformation cursorInformation, string discriminator = "") where TCursorInformation : CursorBase;
}
