using System;
using System.Web;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;
using Roblox.Properties;
using Roblox.Users.Properties;
using Roblox.Web.Authentication.Properties;
using Roblox.Web.ElevatedActions.Base;
using Roblox.Web.ElevatedActions.BLL;
using Roblox.Web.ElevatedActions.Properties;

namespace Roblox.Web.Authentication.ElevatedActions;

public class ImpersonateUserElevatedAction : RobloxElevatedActionBase
{
	private readonly IUser _TargetUser;

	private readonly IUser _CurrentUser;

	private const string _EmailType = "ImpersonateNonRegularUserElevatedAction";

	private readonly IWebAuthenticator _WebAuthenticator;

	private readonly ILogger _Logger;

	private readonly IEmailSender _EmailSender;

	protected override ElevatedAction ElevatedAction => ElevatedAction.Get("ImpersonateUser");

	public ImpersonateUserElevatedAction(IElevatedActionFactories factories, IUser currentUser, IUser targetUser, IWebAuthenticator webAuthenticator, ILogger logger, IEmailSender emailSender)
		: base(factories, currentUser.Id, targetUser.Id, floodCheckEnabled: true, Roblox.Web.Authentication.Properties.Settings.Default.ImpersonationFloodCheckLimit, Roblox.Web.Authentication.Properties.Settings.Default.ImpersonationFloodCheckExpiry)
	{
		_TargetUser = targetUser;
		_CurrentUser = currentUser;
		_WebAuthenticator = webAuthenticator ?? throw new ArgumentNullException("webAuthenticator");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_EmailSender = emailSender ?? throw new ArgumentNullException("emailSender");
	}

	protected override string _DoExecuteAction()
	{
		_WebAuthenticator.Impersonate(_TargetUser, HttpContext.Current.GetOriginIP());
		string log = $"{_CurrentUser.Name} ({base._CurrentUserID}) impersonated target user {base._TargetUserID}";
		if (!_TargetUser.IsRegularUser())
		{
			if (!Roblox.Properties.Settings.Default.IsTestingSite)
			{
				Email email = new Email("alerts@roblox.com", Roblox.Web.ElevatedActions.Properties.Settings.Default.Wak3m3upWarningEmailTarget, "Warning: Someone impersonated a moderator, CS, or admin level user", EmailBodyType.Plain, "ImpersonateNonRegularUserElevatedAction", "ElevatedActionLog: " + log);
				_EmailSender.SendEmail(email);
			}
			else
			{
				_Logger.Error("Wake me up warning: someone impersonated a moderator, CS, or admin!");
			}
		}
		return log;
	}

	protected override bool _DoCanPerformAction()
	{
		if (base._TargetUserID == base._CurrentUserID)
		{
			return false;
		}
		return _TargetUser.AccountId != Roblox.Users.Properties.Settings.Default.RobloxUserId;
	}
}
