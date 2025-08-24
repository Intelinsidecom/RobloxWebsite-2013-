using System.Web;

namespace Roblox.Marketing.Events;

public class SignupEvent : EventBase
{
	private static string eventName = "Signup";

	public long userId;

	public SignupEvent(HttpContext context)
		: base(context, eventName)
	{
		#pragma warning disable CS0618 // Suppress obsolete API usage until WebAuthenticator available
		User user = User.GetCurrent(context);
		#pragma warning restore CS0618
		userId = user.ID;
	}
}
