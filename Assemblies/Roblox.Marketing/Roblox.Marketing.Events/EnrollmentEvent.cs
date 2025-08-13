using System.Web;

namespace Roblox.Marketing.Events;

internal class EnrollmentEvent : EventBase
{
	private static string eventName = "Enrollment";

	public int? userId;

	public string experiment;

	public int variation;

	public EnrollmentEvent(HttpContext context, string experiment, int variation)
		: base(context, eventName)
	{
		User user = User.GetCurrent(context);
		userId = ((user == null) ? null : new int?((int)user.ID));
		this.experiment = experiment;
		this.variation = variation;
	}
}
