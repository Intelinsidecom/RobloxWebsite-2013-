using System;
using System.Net.Http;
using System.Web.Mvc;
using Roblox.EventLog;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence;
using Roblox.Web.Authentication;
using Roblox.Web.Devices;
using Roblox.Web.Presence.Properties;

namespace Roblox.Web.Presence;

public class PresenceUpdateActionFilter : ActionFilterAttribute
{
	private readonly ILogger _Logger;

	private readonly WebAuthenticator _WebAuthenticator;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly PresenceRegistrar _PresenceRegistrar;

	public PresenceUpdateActionFilter(ILogger logger, WebAuthenticator webAuthenticator, IClientDeviceIdentifier clientDeviceIdentifier, PresenceRegistrar presenceRegistrar)
	{
		_Logger = logger;
		_WebAuthenticator = webAuthenticator;
		_ClientDeviceIdentifier = clientDeviceIdentifier;
		_PresenceRegistrar = presenceRegistrar;
	}

	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		try
		{
			if (Settings.Default.IsPresenceUpdateActionFilterEnabled && filterContext != null && !((ControllerContext)filterContext).IsChildAction && ((ControllerContext)filterContext).HttpContext.Request.HttpMethod == HttpMethod.Post.ToString() && !filterContext.ActionDescriptor.IsDefined(typeof(SkipPresenceUpdateAttribute), false) && ((ControllerContext)filterContext).HttpContext.Response != null && ((ControllerContext)filterContext).HttpContext.Response.StatusCode == 200)
			{
				IUser authenticatedUser = _WebAuthenticator.GetAuthenticatedUser();
				if (authenticatedUser != null)
				{
					string location = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "_" + filterContext.ActionDescriptor.ActionName;
					IPlatform platform = _ClientDeviceIdentifier.GetPlatformByUserAgent(((ControllerContext)filterContext).HttpContext.Request.UserAgent);
					string defaultPlatformName = _ClientDeviceIdentifier.GetPlatformNameByPlatformType(PlatformType.PC);
					_PresenceRegistrar.PingFromWebsite(authenticatedUser, location, platform?.PlatformName ?? defaultPlatformName);
				}
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		((ActionFilterAttribute)this).OnActionExecuted(filterContext);
	}
}
