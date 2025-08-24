using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Presence;

public interface IPresenceSessionProvider
{
	string GetWebSessionIdForCurrentUser(IVisitorIdentifier visitorIdentifier);

	string GetWebSessionIdForCurrentUserSession(IVisitorIdentifier visitorIdentifier, string currentWebSessionId);

	string GetGameSessionIdForCurrentUser(IVisitorIdentifier visitorIdentifier);

	string GetStudioSessionIdForCurrentUser(IVisitorIdentifier visitorIdentifier);
}
