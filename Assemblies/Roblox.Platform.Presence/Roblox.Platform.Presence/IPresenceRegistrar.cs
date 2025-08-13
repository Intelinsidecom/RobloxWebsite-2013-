using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Presence;

/// <summary>
/// An Interface for PresenceRegistrar
/// </summary>
public interface IPresenceRegistrar
{
	void PingFromLogin(IUserIdentifier user, string location, string platformName);

	void PingFromInGame(IVisitorIdentifier visitor, long placeId, Guid? gameId, string platformName, long universeId);

	void PingFromInCloudEdit(IVisitorIdentifier visitor, long placeId, Guid? gameId, string platformName, long universeId);

	void PingFromInStudio(IVisitorIdentifier visitor, long placeId, string platformName);

	void PingFromWebsite(IVisitorIdentifier visitor, string location, string platformName);

	void PingFromMobileWebsite(IVisitorIdentifier visitor, string location, string platformName);

	void PingFromXbox(IVisitorIdentifier visitor, string location, string platformName);

	void PingFromIos(IVisitorIdentifier visitor, string location, string platformName);

	void PingFromAndroid(IVisitorIdentifier visitor, string location, string platformName);

	void RegisterAbsenceFromGame(IVisitorIdentifier visitor);

	void RegisterAbsenceFromWebsite(IVisitorIdentifier visitor);

	void RegisterAbsenceFromWebsiteSession(IVisitorIdentifier visitor, string currentWebSessionId);

	void RegisterAbsenceFromStudio(IVisitorIdentifier visitor);

	[Obsolete("Use platform name")]
	void PingFromLogin(IUserIdentifier user, string location, byte platformTypeId);

	[Obsolete("Use platform name")]
	void PingFromInGame(IVisitorIdentifier visitor, long placeId, Guid? gameId, byte platformTypeId);

	[Obsolete("Use platform name")]
	void PingFromInCloudEdit(IVisitorIdentifier visitor, long placeId, Guid? gameId, byte platformTypeId);

	[Obsolete("Use platform name")]
	void PingFromInStudio(IVisitorIdentifier visitor, long placeId, byte platformTypeId);

	[Obsolete("Use platform name")]
	void PingFromWebsite(IVisitorIdentifier visitor, string location, byte platformTypeId);

	[Obsolete("Use platform name")]
	void PingFromMobileWebsite(IVisitorIdentifier visitor, string location, byte platformTypeId);

	[Obsolete("Use platform name")]
	void PingFromXbox(IVisitorIdentifier visitor, string location, byte platformTypeId);

	[Obsolete("Use platform name")]
	void PingFromIos(IVisitorIdentifier visitor, string location, byte platformTypeId);

	[Obsolete("Use platform name")]
	void PingFromAndroid(IVisitorIdentifier visitor, string location, byte platformTypeId);
}
