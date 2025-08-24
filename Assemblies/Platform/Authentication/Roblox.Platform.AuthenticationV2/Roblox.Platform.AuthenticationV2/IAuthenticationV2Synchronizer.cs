using System.Web;

namespace Roblox.AuthenticationV2;

/// <summary>
/// Synchronizes AuthenticationV1 sessions with AuthenticationV2
/// </summary>
public interface IAuthenticationV2Synchronizer
{
	/// <summary>
	/// Handler to run at during Application_PreSendRequestHeaders
	/// Ensures that if an AuthenticationV1 session exist it is synchronized with AuthenticationV2 in the cases when the AuthenticationV1 session is not modified.
	/// </summary>
	/// <param name="request">The <see cref="T:System.Web.HttpRequestBase" /></param>
	/// <param name="response">The <see cref="T:System.Web.HttpResponseBase" /></param>
	void PreSendRequestHeaders(HttpRequestBase request, HttpResponseBase response);
}
