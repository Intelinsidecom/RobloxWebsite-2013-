using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence;
using Roblox.Platform.Social;
using Roblox.Platform.Social.Follow;
using Roblox.TranslationResources.Common;
using Roblox.Web.Authentication;

namespace Roblox.Web.Presence;

public class PresenceResponseFilter
{
	private readonly IWebAuthenticator _WebAuthenticator;

	private readonly IUserFactory _UserFactory;

	private readonly ILogger _Logger;

	private readonly FollowDomainFactories _FollowFactories;

	public PresenceResponseFilter(IWebAuthenticator webAuthenticator, IUserFactory userFactory, FollowDomainFactories followFactories, ILogger logger)
	{
		_WebAuthenticator = webAuthenticator ?? throw new ArgumentException(string.Format("{0}", "webAuthenticator"));
		_UserFactory = userFactory ?? throw new ArgumentException(string.Format("{0}", "userFactory"));
		_Logger = logger ?? throw new ArgumentException(string.Format("{0}", "logger"));
		_FollowFactories = followFactories ?? throw new ArgumentException(string.Format("{0}", "followFactories"));
	}

	public IEnumerable<IPresence> FilterInGamePresences(IEnumerable<IPresence> presences, IPresenceResources presenceResources = null)
	{
		return presences.Select((IPresence presence) => FilterInGamePresence(presence, presenceResources));
	}

	public IPresence FilterInGamePresence(IPresence presence, IPresenceResources presenceResources = null)
	{
		FilteredPresence filteredPresence = new FilteredPresence(presence, presenceResources);
		bool canView = false;
		if (presence != null && presence.PlaceId.HasValue)
		{
			try
			{
				canView = CanCurrentUserViewFullPresence(presence);
			}
			catch (FriendshipOperationUnavailableException e)
			{
				_Logger.Error(e);
			}
		}
		if (canView)
		{
			filteredPresence.AddPlaceInfoToPresence(presence, presenceResources);
		}
		return filteredPresence;
	}

	public bool CanCurrentUserViewFullPresence(IPresence presence)
	{
		IUser currentUser = _WebAuthenticator.GetAuthenticatedUser();
		IUser presenceUser = _UserFactory.GetUser(presence.VisitorId);
		if (currentUser == null || presenceUser == null)
		{
			return false;
		}
		if (currentUser.Id == presenceUser.Id)
		{
			return true;
		}
		return _FollowFactories.FollowValidator.CanFollow(currentUser, presenceUser);
	}
}
