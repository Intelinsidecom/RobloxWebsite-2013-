using System;
using System.Web;
using System.Web.Mvc;
using Roblox.Web.Code;

namespace Roblox.Web.Mvc.FilterAttributes;

/// <summary>
/// A handler/FilterAttribute for collecting per-endpoint metrics for MVC sites
/// </summary>
/// <remarks>
/// Ideally (as the namespace suggests) this would live in Roblox.Web.MVC as it is
/// an MVC specific FilterAttribute.
/// Unfortunately Roblox.Web.Code relies on Roblox.Web.MVC, and this FilterAttribute
/// requires the <see cref="T:Roblox.Web.Code.IWebApplicationLifeCycleManager" /> from Roblox.Web.Code
/// </remarks>
public class RequestBeginMetricsTrackingHandler : ActionFilterAttribute
{
	private readonly IWebApplicationLifeCycleManager _WebApplicationLifeCycleManager;

	private readonly Func<bool> _IsEnabled;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Mvc.FilterAttributes.RequestBeginMetricsTrackingHandler" />
	/// </summary>
	/// <param name="webApplicationLifeCycleManager">An <see cref="T:Roblox.Web.Code.IWebApplicationLifeCycleManager" />.</param>
	/// <param name="isEnabledFunc">A function that decides whether or not to record metrics, primary used for rollouts of new sites implementing this handler.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	public RequestBeginMetricsTrackingHandler(IWebApplicationLifeCycleManager webApplicationLifeCycleManager, Func<bool> isEnabledFunc)
	{
		_WebApplicationLifeCycleManager = webApplicationLifeCycleManager ?? throw new ArgumentNullException("webApplicationLifeCycleManager");
		_IsEnabled = isEnabledFunc ?? throw new ArgumentNullException("isEnabledFunc");
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		if (_IsEnabled())
		{
			string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
			string actionName = filterContext.ActionDescriptor.ActionName;
			HttpContextBase httpContextBase = ((ControllerContext)filterContext).HttpContext;
			if (!string.IsNullOrWhiteSpace(controllerName) && !string.IsNullOrWhiteSpace(actionName) && httpContextBase != null)
			{
				_WebApplicationLifeCycleManager.ActionChosen(httpContextBase, controllerName, actionName);
			}
		}
	}
}
