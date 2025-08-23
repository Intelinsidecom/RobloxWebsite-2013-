using System.Net;
using System.Web;
using System.Web.Mvc;
using Roblox.FloodCheckers;
using Roblox.Web.Devices;

namespace Roblox.Web.Code;

/// <summary>
/// Copies any existing device handle header from a header into the current context.
/// </summary>
public abstract class DeviceHandleFloodCheckAttributeBase : ActionFilterAttribute
{
	/// <summary>
	/// This is for endpoints that handle multiple actions, where we want to not flood based on the
	/// presence of a parameter. e.g. Send message endpoint handles replies, we don't want to stop
	/// users from replying.
	/// </summary>
	public string SkipOnNonNullParameter;

	public UserActionType UserActionType;

	protected abstract IWebDeviceHandleInspector DeviceHandleInspector { get; }

	protected abstract IClientDeviceIdentifier ClientDeviceIdentifier { get; }

	private DeviceHandleFloodCheckerFactory DeviceHandleFloodCheckerFactory { get; set; }

	protected abstract long GetBrowserTrackerId(HttpContext context);

	protected DeviceHandleFloodCheckAttributeBase()
	{
		DeviceHandleFloodCheckerFactory = new DeviceHandleFloodCheckerFactory();
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		HttpContext applicationContext = ((ControllerContext)filterContext).HttpContext.ApplicationInstance.Context;
		ulong browserTrackerId = (ulong)GetBrowserTrackerId(applicationContext);
		if (ClientDeviceIdentifier.IsRobloxApp(applicationContext.Request.UserAgent) && DeviceHandleInspector.IsValidDeviceHandleRequest(applicationContext.Request, browserTrackerId) && !SkipFloodCheck(filterContext))
		{
			DeviceHandleUserActionFloodChecker floodChecker = DeviceHandleFloodCheckerFactory.GetFloodChecker(browserTrackerId, UserActionType);
			if (floodChecker.IsFlooded())
			{
				filterContext.Result = (ActionResult)new HttpStatusCodeResult((HttpStatusCode)429, "Too many attempts");
			}
			else
			{
				floodChecker.UpdateCount();
			}
		}
	}

	private bool SkipFloodCheck(ActionExecutingContext context)
	{
		if (!string.IsNullOrWhiteSpace(SkipOnNonNullParameter))
		{
			return context.ActionParameters[SkipOnNonNullParameter] != null;
		}
		return false;
	}
}
