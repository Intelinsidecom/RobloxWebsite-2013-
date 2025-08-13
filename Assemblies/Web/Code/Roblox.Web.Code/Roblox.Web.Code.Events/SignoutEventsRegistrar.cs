using System;
using System.Threading.Tasks;
using Roblox.EventLog;
using Roblox.Gigya;
using Roblox.Platform.Authentication;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Interface;
using Roblox.Platform.Presence;
using Roblox.RealTimeNotifications.Authentication;
using Roblox.Web.Authentication;

namespace Roblox.Web.Code.Events;

public class SignoutEventsRegistrar
{
	private readonly IPresenceRegistrar _PresenceRegistrar;

	private readonly IUserPartyBuilder _UserPartyBuilder;

	private readonly WebAuthenticator _WebAuthenticator;

	private readonly ILogger _Logger;

	private readonly IAuthenticationNotificationsPublisher _AuthenticationNotificationsPublisher;

	private readonly IFacebookAccountConnector _FacebookAccountConnector;

	private readonly IGigyaClient _GigyaClient;

	public SignoutEventsRegistrar(IPresenceRegistrar presenceRegistrar, WebAuthenticator webAuthenticator, ILogger logger, IAuthenticationNotificationsPublisher authenticationNotificationsPublisher, IFacebookAccountConnector facebookAccountConnector, IGigyaClient gigyaClient, IUserPartyBuilder userPartyBuilder)
	{
		_PresenceRegistrar = presenceRegistrar ?? throw new ArgumentNullException("presenceRegistrar");
		_WebAuthenticator = webAuthenticator ?? throw new ArgumentNullException("webAuthenticator");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_AuthenticationNotificationsPublisher = authenticationNotificationsPublisher ?? throw new ArgumentNullException("authenticationNotificationsPublisher");
		_FacebookAccountConnector = facebookAccountConnector ?? throw new ArgumentNullException("facebookAccountConnector");
		_GigyaClient = gigyaClient ?? throw new ArgumentNullException("gigyaClient");
		_UserPartyBuilder = userPartyBuilder ?? throw new ArgumentNullException("userPartyBuilder");
	}

	public void RegisterEventsOnUserSigningout()
	{
		_WebAuthenticator.OnUserSignedOut += OnUserSignedout;
	}

	private void OnUserSignedout(IUser user, IPlatform platform, ISessionToken currentSessionToken)
	{
		string currentWebSessionId = currentSessionToken?.Value;
		Task.Factory.StartNew(delegate
		{
			try
			{
				user.RegisterAbsenceFromWebsiteSession(_PresenceRegistrar, currentWebSessionId);
			}
			catch (Exception ex)
			{
				_Logger.Error(ex);
			}
			try
			{
				if (platform != null)
				{
					_UserPartyBuilder.OnUserSignout(user, platform);
				}
			}
			catch (Exception ex2)
			{
				_Logger.Error(ex2);
			}
			try
			{
				_AuthenticationNotificationsPublisher.PublishSignOutNotification(user.Id);
			}
			catch (Exception ex3)
			{
				_Logger.Error(ex3);
			}
			try
			{
				if (_FacebookAccountConnector.GetConnectedFacebookAccountIdentifier(user.AccountId) != null)
				{
					_GigyaClient.Logout(user);
				}
			}
			catch (Exception ex4)
			{
				_Logger.Error(ex4);
			}
		});
	}
}
