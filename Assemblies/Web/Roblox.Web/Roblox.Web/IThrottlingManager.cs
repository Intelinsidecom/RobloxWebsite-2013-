using System;
using System.Collections.Generic;
using System.Web;
using Roblox.Platform.Throttling;

namespace Roblox.Web;

/// <summary>
/// Class that manages recording requests based on multiple identifiers (e.g. IP Address, User ID)
/// and determines whether or not those requests are throttled based on the counts respective to those identifiers.
/// </summary>
public interface IThrottlingManager
{
	/// <summary>
	/// Returns a list of <see cref="T:Roblox.Platform.Throttling.IRequest">IRequests</see> representing the throttling contexts that apply to this request.
	/// </summary>
	/// <param name="requester"></param>
	/// <param name="requestBase"></param>
	/// <param name="originIp"></param>
	/// <param name="actionName"></param>
	/// <returns></returns>
	List<IRequest> GetRequestListForCurrentContext(RequesterType requester, HttpRequestBase requestBase, string originIp, string actionName);

	/// <summary>
	/// Controls whether throttling through this class is enabled or not.
	/// </summary>
	/// <returns></returns>
	bool IsLocalThrottlingEnabled();

	/// <summary>
	/// Applies each <see cref="T:Roblox.Platform.Throttling.IRequest">IRequest</see> to determine if the request is throttled according to any of the contexts.
	/// Returns false if the request is throttled for one or more IRequest contexts. If a request is not throttled, this method
	/// records the request for each IRequest based on the <see cref="M:Roblox.Platform.Throttling.IRequest.GetKey">key</see> for that context.
	/// </summary>
	/// <param name="requestsForCurrentContext"></param>
	/// <param name="executionDateTime"></param>
	/// <param name="requester"></param>
	/// <param name="actionName"></param>
	/// <returns></returns>
	bool IsRequestAllowed(List<IRequest> requestsForCurrentContext, DateTime executionDateTime, RequesterType requester, string actionName);
}
