namespace Roblox.Web;

/// <summary>
/// Records machine level metrics for rates of requests and throttled requests.
/// </summary>
public interface IThrottlingPerformanceMonitor
{
	/// <summary>
	/// Records a request of a particular type as throttled for a particular actionName.
	/// </summary>
	/// <param name="requester"></param>
	/// <param name="actionName"></param>
	void IncrementThrottledRequests(RequesterType requester, string actionName);

	/// <summary>
	/// Records a request of a particualr type for an actionName.
	/// </summary>
	/// <param name="requester"></param>
	/// <param name="actionName"></param>
	void IncrementTotalRequests(RequesterType requester, string actionName);
}
