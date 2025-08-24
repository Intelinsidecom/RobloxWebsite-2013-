using System.Web;
using Roblox.Marketing.Tracking;

namespace Roblox.Marketing.Events;

public class NewUserAcquiredEvent : EventBase
{
	private static string eventName = "NewUserAcquired";

	public int? userId;

	public string source;

	public string campaign;

	public string medium;

	public NewUserAcquiredEvent(HttpContext context)
		: base(context, eventName)
	{
		#pragma warning disable CS0618 // Suppress obsolete API usage until WebAuthenticator available
		User user = User.GetCurrent(context);
		#pragma warning restore CS0618
		userId = ((user == null) ? null : new int?((int)user.ID));
		AcquisitionHelper.GetAcquisitionDataFromCookie(context, out medium, out source, out campaign);
	}

	public NewUserAcquiredEvent(HttpContext context, User user)
		: base(context, eventName)
	{
		#pragma warning disable CS0618 // Suppress obsolete API usage until WebAuthenticator available
		userId = ((user == null) ? null : new int?((int)user.ID));
		#pragma warning restore CS0618
		AcquisitionHelper.GetAcquisitionDataFromCookie(context, out medium, out source, out campaign);
	}
}
