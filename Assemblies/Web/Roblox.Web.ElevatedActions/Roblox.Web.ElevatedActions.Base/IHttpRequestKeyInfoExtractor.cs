using System.Web;

namespace Roblox.Web.ElevatedActions.Base;

public interface IHttpRequestKeyInfoExtractor
{
	string GetIpAddress(HttpRequestBase request);

	int GetBrowserTrackerId(HttpRequestBase request);

	string GetIpAddress(HttpRequest request);

	int GetBrowserTrackerId(HttpRequest request);
}
