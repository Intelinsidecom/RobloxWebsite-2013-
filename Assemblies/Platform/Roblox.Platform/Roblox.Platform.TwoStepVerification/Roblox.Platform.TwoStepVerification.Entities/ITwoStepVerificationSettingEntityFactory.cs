namespace Roblox.Platform.TwoStepVerification.Entities;

internal interface ITwoStepVerificationSettingEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntity" /> with the given ID, or null if none existed.</returns>
	ITwoStepVerificationSettingEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntity" /> with the given <see cref="T:Roblox.Platform.Membership.IUser">user</see> id
	/// </summary>
	ITwoStepVerificationSettingEntity GetByUserId(long userId);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntity" /> with the given <see cref="T:Roblox.Platform.Membership.IUser">user</see> id
	/// </summary>
	ITwoStepVerificationSettingEntity GetOrCreate(long userId);

	/// <summary>
	/// Clones an existing <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntity" />.
	/// </summary>
	/// <param name="entity">An <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntity" /></param>
	/// <returns>An <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntity" /> with the identical values to <paramref name="entity" />.</returns>
	ITwoStepVerificationSettingEntity Clone(ITwoStepVerificationSettingEntity entity);
}
