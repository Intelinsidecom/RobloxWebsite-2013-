namespace Roblox.Platform.AbTesting.Core;

internal interface ILockedOnExperimentSettingFactory
{
	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.AbTesting.Core.ILockedOnExperimentSetting" /> by its experiment ID.
	/// </summary>
	/// <param name="experimentId">The ID of the experiment that the setting belongs to.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.ILockedOnExperimentSetting" /> belonging to the experiment with the given ID.</returns>
	ILockedOnExperimentSetting GetOrCreateByExperimentId(int experimentId);
}
