using System.Web;
using System.Web.UI;

namespace Roblox.Web.Metrics;

/// <summary>
/// A statistics tracker for ASP.NET pages
/// </summary>
public interface IAspNetStatisticsTracker
{
	/// <summary>
	/// Tracks requests per second for aspx pages.
	/// </summary>
	/// <param name="page">The ASPX <see cref="T:System.Web.UI.Page" />.</param>
	/// <param name="methodName">Used to distinguish between WebMethods (if there is a need).</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="page" />
	/// </exception>
	void OnAspxPageChosen(Page page);

	/// <summary>
	/// Tracks requests per second for aspx pages.
	/// </summary>
	/// <param name="pageName">The ASPX page name.</param>
	/// <param name="methodName">Used to distinguish between WebMethods (if there is a need).</param>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="pageName" /> is <c>null</c> or whitespace.
	/// </exception>
	void OnAspxPageChosen(string pageName, string methodName);

	/// <summary>
	/// Tracks requests per second for ashx pages.
	/// </summary>
	/// <param name="page">The ASHX <see cref="T:System.Web.IHttpHandler" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="page" /></exception>
	void OnAshxPageChosen(IHttpHandler page);

	/// <summary>
	/// Tracks requests per second for ascx controls.
	/// </summary>
	/// <param name="userControl">The ASCX <see cref="T:System.Web.UI.UserControl" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="userControl" /></exception>
	void OnAscxPageChosen(UserControl userControl);

	/// <summary>
	/// Tracks requests per second for asmx service methods.
	/// </summary>
	/// <param name="serviceName">The service name.</param>
	/// <param name="methodName">The method name.</param>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="serviceName" /> is <c>null</c> or whitespace.
	/// - <paramref name="methodName" /> is <c>null</c> or whitespace.
	/// </exception>
	void OnAsmxServiceMethodChosen(string serviceName, string methodName);
}
