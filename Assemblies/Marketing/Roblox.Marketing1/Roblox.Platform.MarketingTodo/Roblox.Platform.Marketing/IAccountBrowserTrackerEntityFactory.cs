namespace Roblox.Platform.Marketing;

internal interface IAccountBrowserTrackerEntityFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Marketing.IAccountBrowserTrackerEntity" /> with the given account ID and browser tracker ID
	/// </summary>
	/// <param name="accountId">Account ID to check the association of.</param>
	/// <param name="browserTrackerId">Browser Tracker ID of the browser to check association of</param>
	/// <returns>The <see cref="T:Roblox.Platform.Marketing.IAccountBrowserTrackerEntity" /> with the given account ID and browser tracker ID if one exists or returns null.</returns>
	IAccountBrowserTrackerEntity GetByAccountIdAndBrowserTrackerId(long accountId, long browserTrackerId);
}
