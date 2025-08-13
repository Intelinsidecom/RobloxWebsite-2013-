namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Produces <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendor" />s for specified <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />s.
/// </summary>
internal interface ITwoStepVerificationCodeVendorFactory
{
	/// <summary>
	/// Produces an <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendor" /> appropriate for the given <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />.
	/// </summary>
	/// <param name="mediaType">A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" /></param>
	/// <returns>An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendor" /></returns>
	ITwoStepVerificationCodeVendor GetCodeVendor(TwoStepVerificationMediaType mediaType);
}
