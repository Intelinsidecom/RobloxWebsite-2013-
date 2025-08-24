using System;
using Roblox.EventLog;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Presence;

public class PresenceSessionProvider : IPresenceSessionProvider
{
	private readonly Func<string> _SessionTokenProvider;

	private readonly ILogger _Logger;

	public const string WebSessionIdPrefix = "WebSession";

	public const string GameSessionIdPrefix = "GameSession";

	public const string StudioSessionIdPrefix = "StudioSession";

	public PresenceSessionProvider(ILogger logger, Func<string> sessionTokenProvider)
	{
		_Logger = logger;
		_SessionTokenProvider = sessionTokenProvider;
	}

	public string GetWebSessionIdForCurrentUser(IVisitorIdentifier visitor)
	{
		return GetSessionIdForVisitor(visitor, "WebSession", GetSessionToken());
	}

	public string GetWebSessionIdForCurrentUserSession(IVisitorIdentifier visitor, string webSessionToken)
	{
		return GetSessionIdForVisitor(visitor, "WebSession", webSessionToken);
	}

	public string GetGameSessionIdForCurrentUser(IVisitorIdentifier visitor)
	{
		return VisitorIdBasedSessionId(visitor, "GameSession");
	}

	public string GetStudioSessionIdForCurrentUser(IVisitorIdentifier visitor)
	{
		return VisitorIdBasedSessionId(visitor, "StudioSession");
	}

	private string GetSessionIdForVisitor(IVisitorIdentifier visitor, string sessionIdPrefix, string sessionToken)
	{
		if (visitor != null && visitor.Id > 0 && sessionToken != null)
		{
			return $"{sessionIdPrefix}_{sessionToken}";
		}
		return VisitorIdBasedSessionId(visitor, sessionIdPrefix);
	}

	private string VisitorIdBasedSessionId(IVisitorIdentifier visitor, string sessionIdPrefix)
	{
		if (visitor == null || visitor.Id <= 0)
		{
			return null;
		}
		return $"{sessionIdPrefix}_{visitor.Id}";
	}

	private string GetSessionToken()
	{
		try
		{
			return _SessionTokenProvider();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return null;
		}
	}
}
