using Roblox.Entities;

namespace Roblox.Platform.Marketing;

internal interface IAccountBrowserTrackerEntity : IUpdateableEntity<long>, IEntity<long>
{
	long AccountId { get; set; }

	long BrowserTrackerId { get; set; }
}
