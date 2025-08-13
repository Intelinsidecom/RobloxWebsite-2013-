using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Produces <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" />
/// </summary>
internal interface ITwoStepVerificationSettingFactory
{
	/// <summary>
	/// Event fired when an <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" /> is instantiated.
	/// </summary>
	event Action<ITwoStepVerificationSetting> OnSettingInstantiated;

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" /> for <paramref name="user" />
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /></param>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" /> for <paramref name="user" />, or null if none exists.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	ITwoStepVerificationSetting GetByUser(IUserIdentifier user);

	/// <summary>
	/// Gets or creates the <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" /> for <paramref name="user" />
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /></param>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" /> for <paramref name="user" />, creating one if none existed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	ITwoStepVerificationSetting GetOrCreateByUser(IUserIdentifier user);
}
