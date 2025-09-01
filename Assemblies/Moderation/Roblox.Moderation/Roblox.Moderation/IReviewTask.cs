using System;
using Roblox.Localization.Core;
using Roblox.Platform.MembershipCore;
namespace Roblox.Moderation {
    public interface IReviewTask

{
	/// <summary>
	/// The Id
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Membership.Core.IUserIdentifier" /> who handles the review task.
	/// </summary>
	IUserIdentifier Moderator { get; }

	/// <summary>
	/// The time the review task is reviewed (moderated).
	/// </summary>
	DateTime? Reviewed { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Localization.Core.ISupportedLocaleIdentifier">identifier</see> of the task's (supported) locale
	/// </summary>
	ISupportedLocaleIdentifier LocaleIdentifier { get; }
}


}
