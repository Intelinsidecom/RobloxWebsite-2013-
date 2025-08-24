using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Gets and sets 2SV configuration for an <see cref="T:Roblox.Platform.Membership.IUser" />
/// </summary>
public interface ITwoStepVerificationConfigurationProvider
{
	/// <summary>
	/// Gets the 2SV configuration for <paramref name="user" />, or a suitable default.
	/// </summary>
	/// <remarks>
	/// For privileged users the default is Enabled + SMS.
	/// For everyone else it is Disabled + Email.
	/// </remarks>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <returns>A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSettingDTO" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	TwoStepVerificationSettingDTO GetTwoStepSettingForUser(IUser user);

	/// <summary>
	/// Sets the 2SV configuration for <paramref name="user" />.
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="isEnabled"><c>True</c> enabled, <c>False</c> otherwise.</param>
	/// <param name="mediaType">The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" /> through which to send 2SV codes. This is always optional.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSetNotAllowedException">Thrown when a privileged user attempts to set 2SV to an invalid state.</exception>
	/// <exception cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationUnverifiedMediaTypeException">Thrown when attempting to set <paramref name="mediaType" /> for a media type that <paramref name="user" /> has not yet verified.</exception>
	void SetTwoStepSettingForUser(IUser user, bool isEnabled, TwoStepVerificationMediaType? mediaType = null);
}
