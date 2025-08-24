using System;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Presence;

public static class MembershipExtensions
{
	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void PingFromLogin(this IUserIdentifier user, IPresenceRegistrar registrar, string location, byte platformTypeId)
	{
		user.VerifyIsNotNull();
		registrar.PingFromLogin(user, location, platformTypeId);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void PingFromInGame(this IVisitorIdentifier visitor, IPresenceRegistrar registrar, long placeId, Guid? gameId, byte platformTypeId)
	{
		visitor.VerifyIsNotNull();
		registrar.PingFromInGame(visitor, placeId, gameId, platformTypeId);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void PingFromInCloudEdit(this IVisitorIdentifier visitor, IPresenceRegistrar registrar, long placeId, Guid? gameId, byte platformTypeId)
	{
		visitor.VerifyIsNotNull();
		registrar.PingFromInCloudEdit(visitor, placeId, gameId, platformTypeId);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void PingFromInStudio(this IVisitor visitor, IPresenceRegistrar registrar, long placeId, byte platformTypeId)
	{
		visitor.VerifyIsNotNull();
		registrar.PingFromInStudio(visitor, placeId, platformTypeId);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void PingFromWebsite(this IVisitor visitor, IPresenceRegistrar registrar, string location, byte platformTypeId)
	{
		visitor.VerifyIsNotNull();
		registrar.PingFromWebsite(visitor, location, platformTypeId);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void PingFromMobileWebsite(this IVisitor visitor, IPresenceRegistrar registrar, string location, byte platformTypeId)
	{
		visitor.VerifyIsNotNull();
		registrar.PingFromMobileWebsite(visitor, location, platformTypeId);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void PingFromXbox(this IVisitor visitor, IPresenceRegistrar registrar, string location, byte platformTypeId)
	{
		visitor.VerifyIsNotNull();
		registrar.PingFromXbox(visitor, location, platformTypeId);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void RegisterAbsenceFromGame(this IVisitor visitor, IPresenceRegistrar registrar)
	{
		visitor.VerifyIsNotNull();
		registrar.RegisterAbsenceFromGame(visitor);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void RegisterAbsenceFromWebsite(this IVisitor visitor, IPresenceRegistrar registrar)
	{
		visitor.VerifyIsNotNull();
		registrar.RegisterAbsenceFromWebsite(visitor);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void RegisterAbsenceFromWebsiteSession(this IVisitor visitor, IPresenceRegistrar registrar, string currentWebSessionId)
	{
		visitor.VerifyIsNotNull();
		registrar.RegisterAbsenceFromWebsiteSession(visitor, currentWebSessionId);
	}

	[Obsolete("Should use IPresenceRegistrar directly.")]
	public static void RegisterAbsenceFromStudio(this IVisitor visitor, IPresenceRegistrar registrar)
	{
		visitor.VerifyIsNotNull();
		registrar.RegisterAbsenceFromStudio(visitor);
	}
}
