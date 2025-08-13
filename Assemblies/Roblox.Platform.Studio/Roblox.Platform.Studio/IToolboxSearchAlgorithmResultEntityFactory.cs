using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

internal interface IToolboxSearchAlgorithmResultEntityFactory : IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmResultEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmResultEntity" /> with the given ID, or null if none existed.</returns>
	IToolboxSearchAlgorithmResultEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmResultEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmResultEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IToolboxSearchAlgorithmResultEntity GetByAlgorithmIdAndKeyword(int algorithmID, string keyword);

	/// <summary>
	///
	/// </summary>
	/// <param name="algorithmId"></param>
	/// <param name="keyword"></param>
	/// <param name="result"></param>
	/// <returns></returns>
	IToolboxSearchAlgorithmResultEntity Create(int algorithmId, string keyword, long[] result);
}
