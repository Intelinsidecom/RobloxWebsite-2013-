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
		User user = User.GetCurrent(context);
		userId = ((user == null) ? null : new int?((int)user.ID));
		AcquisitionHelper.GetAcquisitionDataFromCookie(context, out medium, out source, out campaign);
	}

	public NewUserAcquiredEvent(HttpContext context, User user)
		: base(context, eventName)
	{
		userId = ((user == null) ? null : new int?((int)user.ID));
		AcquisitionHelper.GetAcquisitionDataFromCookie(context, out medium, out source, out campaign);
	}
}
