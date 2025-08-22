using System.Web;

namespace Roblox.Marketing.Events;

internal class CookieDropEvent : EventBase
{
	private static string eventName = "CookieDrop";

	public int? userId;

	public long browserTrackerId;

	public CookieDropEvent(int? userId, long guid)
		: base(guid, eventName)
	{
		this.userId = userId;
	}

	public CookieDropEvent(HttpContext context, long browserTrackerId)
		: base(browserTrackerId, eventName)
	{
		#pragma warning disable CS0618 // Suppress obsolete API usage until WebAuthenticator available
		User user = User.GetCurrent(context);
		#pragma warning restore CS0618
		userId = ((user == null) ? null : new int?((int)user.ID));
		this.browserTrackerId = browserTrackerId;
	}
}
