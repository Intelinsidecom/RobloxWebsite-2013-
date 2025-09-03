using Roblox.Entities;
namespace Roblox.Marketing {
    interface IAccountBrowserTrackerEntity : IUpdateableEntity<long>, IEntity<long>

{
	long AccountId { get; set; }

	long BrowserTrackerId { get; set; }
}


}
