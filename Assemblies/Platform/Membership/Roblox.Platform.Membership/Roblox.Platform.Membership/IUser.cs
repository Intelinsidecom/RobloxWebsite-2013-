using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Membership;

/// <summary>
/// A platform object representing a user.
/// </summary>
public interface IUser : IVisitor, IVisitorIdentifier, IUserIdentifier
{
	/// <summary>
	/// The current UserName of the User.
	/// Maps to Account.Name in older code.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// The User's description of themselves. AKA their "blurb".
	/// </summary>
	string Description { get; }

	/// <summary>
	/// ID of the Account associated with the User.
	/// </summary>
	long AccountId { get; }

	/// <summary>
	/// The date and time the User was created.
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Membership.IUser.AccountStatus" /> of this IUser.
	/// </summary>
	AccountStatus AccountStatus { get; }

	/// <summary>
	/// User's Age Bracket based on the Birthdate they have configured.
	/// </summary>
	AgeBracket AgeBracket { get; }

	/// <summary>
	/// Conversation safety settings. When true this user's conversation should be COPPA compliant.
	/// </summary>
	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	bool UseSuperSafeConversationMode { get; }

	/// <summary>
	/// Privacy safety settings. When true we should limit outside interactions with the user.
	/// </summary>
	[Obsolete("This always returns true if AgeBracket is AgeUnder13.")]
	bool UseSuperSafePrivacyMode { get; }

	/// <summary>
	/// Birthdate of the User.
	/// May be null if they are coming from platforms that do not implement our default flow.
	/// GVP 2016-06-05 May also be null if not loaded from GetUserForEdit (temporary)
	/// </summary>
	DateTime? Birthdate { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Membership.IUser.GenderType" /> of the User, as selected at sign-up or from their account settings.
	/// May be Unknown in cases where User originated from another platform.
	/// </summary>
	GenderType GenderType { get; }

	/// <summary>
	/// Does the current User have BC at the given level?
	/// </summary>
	/// <param name="bcMembershipLevel"></param>
	/// <returns></returns>
	bool IsBCMember(MembershipLevels.BCMembershipLevel? bcMembershipLevel = null);

	/// <summary>
	/// Is this user a Builder's Club Member?  Meaning, exactly BC (not OBC or TBC)
	/// </summary>
	/// <returns></returns>
	bool IsBuildersClubMember();

	/// <summary>
	/// Is this user a Turbo Builder's Club Member?
	/// </summary>
	/// <returns></returns>
	bool IsTurboBuildersClubMember();

	/// <summary>
	/// Is this user an Outrageous Builder's Club Member?
	/// </summary>
	/// <returns></returns>
	bool IsOutrageousBuildersClubMember();

	/// <summary>
	/// Is this user a member of BC, TBC, or OBC?
	/// </summary>
	/// <returns></returns>
	bool IsAnyBuildersClubMember();
}
