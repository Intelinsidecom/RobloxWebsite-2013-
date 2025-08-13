using System;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Moderation;

public interface IReviewTask
{
	/// <summary>
	/// The Id
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> who handles the review task.
	/// </summary>
	IUserIdentifier Moderator { get; }

	/// <summary>
	/// The time the review task is reviewed (moderated).
	/// </summary>
	DateTime? Reviewed { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleIdentifier">identifier</see> of the task's (supported) locale
	/// </summary>
	ISupportedLocaleIdentifier LocaleIdentifier { get; }
}
