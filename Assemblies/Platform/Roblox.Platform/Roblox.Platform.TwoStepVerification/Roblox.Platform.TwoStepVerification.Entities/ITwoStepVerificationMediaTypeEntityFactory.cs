namespace Roblox.Platform.TwoStepVerification.Entities;

internal interface ITwoStepVerificationMediaTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationMediaTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationMediaTypeEntity" /> with the given ID, or null if none existed.</returns>
	ITwoStepVerificationMediaTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationMediaTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationMediaTypeEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	ITwoStepVerificationMediaTypeEntity GetByValue(string value);
}
