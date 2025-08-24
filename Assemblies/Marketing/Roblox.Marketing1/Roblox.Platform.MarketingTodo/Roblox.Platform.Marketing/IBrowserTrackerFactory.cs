namespace Roblox.Platform.Marketing;

/// <summary>
/// An interface for a BrowserTracker factory.
/// </summary>
public interface IBrowserTrackerFactory
{
	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Marketing.IBrowserTracker" />.
	/// </summary>
	/// <param name="requestUrl">The URL. Only used for firing an event to EventStream.</param>
	/// <param name="accountId">The account identifier.</param>
	/// <returns>
	/// A newly created <see cref="T:Roblox.Platform.Marketing.IBrowserTracker" />.
	/// </returns>
	IBrowserTracker CreateNew(string requestUrl, long? accountId = null);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Marketing.IBrowserTracker" /> from the specified identifier.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>
	/// An instance of <see cref="T:Roblox.Platform.Marketing.IBrowserTracker" />.
	/// </returns>
	IBrowserTracker Get(long id);
}
