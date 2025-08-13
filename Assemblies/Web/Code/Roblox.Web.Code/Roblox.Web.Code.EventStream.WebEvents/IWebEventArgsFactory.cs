using System.Web;
using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Web.Code.EventStream.WebEvents;

/// <summary>
/// An interface for WebEventArgsFactory.
/// </summary>
public interface IWebEventArgsFactory
{
	/// <summary>
	/// Creates a WebEventArgs object and also creates a GuestId cookie and Browser Tracker cookie if they do not exist.
	/// </summary>
	/// <remarks>Do not call this method to create WebEventArgs if WebEventArgs are being created after a Response.Redirect call with endResponse parameter value set to False or 
	/// if WebEventArgs are being created in an HttpModule's OnEndRequest method.</remarks>
	/// <typeparam name="TWebEventArgs">The type of the web event arguments.</typeparam>
	/// <param name="httpContext">The <see cref="T:System.Web.HttpContext" /> to create the <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" /> from.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="httpContext" /> is null.</exception>
	TWebEventArgs Create<TWebEventArgs>(HttpContext httpContext) where TWebEventArgs : WebEventArgs, new();

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" /> without updating GuestId and BrowserTracker cookie.
	/// </summary>
	/// <typeparam name="TWebEventArgs">The type of the web event arguments.</typeparam>
	/// <param name="httpContext">The HTTP context.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="httpContext" /> is null.</exception>
	TWebEventArgs CreateWithoutUpdatingGuestIdCookieAndBtCookie<TWebEventArgs>(HttpContext httpContext) where TWebEventArgs : WebEventArgs, new();
}
