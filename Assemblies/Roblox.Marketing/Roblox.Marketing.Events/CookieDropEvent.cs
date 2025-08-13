using System.Web;

namespace Roblox.Marketing.Events;

internal class CookieDropEvent : EventBase
{
	private static string eventName = "CookieDrop";

	public int? userId;

	public CookieDropEvent(int? userId, long guid)
		: base(guid, eventName)
	{
		this.userId = userId;
	}

	public CookieDropEvent(HttpContext context, long guid)
		: base(guid, eventName)
	{
		User user = User.GetCurrent(context);
		userId = ((user == null) ? null : new int?((int)user.ID));
	}
}
