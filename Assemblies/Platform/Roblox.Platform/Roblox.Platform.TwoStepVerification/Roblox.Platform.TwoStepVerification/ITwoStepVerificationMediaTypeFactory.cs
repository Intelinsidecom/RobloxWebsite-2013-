namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Translates between <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />s and primitives.
/// </summary>
internal interface ITwoStepVerificationMediaTypeFactory
{
	/// <summary>
	/// Gets the primitive ID of <paramref name="twoStepVerificationMediaType" />.
	/// </summary>
	/// <param name="twoStepVerificationMediaType">A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />.</param>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />'s ID.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if <paramref name="twoStepVerificationMediaType" /> is not found in the database.</exception>
	byte GetIdByValue(TwoStepVerificationMediaType twoStepVerificationMediaType);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" /> by its primative ID.
	/// </summary>
	/// <param name="id">The primative ID of the <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" /> that matches the value for <paramref name="id" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if there is no record for <paramref name="id" />, or if the record for <paramref name="id" /> does not map to <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />.</exception>
	TwoStepVerificationMediaType GetValueById(byte id);
}
