namespace Roblox.Platform.AbTesting.Core;

public interface IVariationSelector
{
	/// <summary>
	/// Selects an <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" /> for a version of an experiment.
	/// </summary>
	/// <param name="experimentVersion">The <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> to select the <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" /> for.</param>
	/// <returns>The selected <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentVersion" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the desired <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" /> could not be selected because it does not exist.</exception>
	IVariation Select(IVersion experimentVersion);
}
