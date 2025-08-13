using System.Web;

namespace Roblox.Marketing.Events;

public class SignupEvent : EventBase
{
	private static string eventName = "Signup";

	public long userId;

	public SignupEvent(HttpContext context)
		: base(context, eventName)
	{
		User user = User.GetCurrent(context);
		userId = user.ID;
	}
}
