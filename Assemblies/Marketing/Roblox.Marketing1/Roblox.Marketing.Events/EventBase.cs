using System.Web;
using System.Web.Script.Serialization;

namespace Roblox.Marketing.Events;

public abstract class EventBase
{
	private bool _IsValid;

	[ScriptIgnore]
	public bool IsValid => _IsValid;

	public long guid { get; set; }

	public EventBase(HttpContext context, string name)
	{
		long? guid = MarketingHelper.GetBrowserTrackerID(context);
		if (guid.HasValue)
		{
			_IsValid = true;
			this.guid = guid.Value;
		}
		else
		{
			_IsValid = false;
			this.guid = 0L;
		}
	}

	internal EventBase(long guid, string name)
	{
		_IsValid = true;
		this.guid = guid;
	}
}
