using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

/// <summary>
/// Provides a common interface for factory class to get the IToolboxSearchAlgorithmResultFactory.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.IDomainFactory`1" />
public interface IToolboxSearchAlgorithmResultFactory : IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	/// <summary>
	/// Get an instance of <seealso cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmResult" /> by algorithm name and search keyword.
	/// </summary>
	/// <param name="algorithmName"></param>
	/// <param name="keyword"></param>
	/// <returns>Instance of type IToolboxSearchAlgorithmResult</returns>
	IToolboxSearchAlgorithmResult GetByAlgorithmNameAndKeyword(string algorithmName, string keyword);

	/// <summary>
	/// Create an instance of <seealso cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmResult" />.
	/// </summary>
	/// <param name="algorithmName"></param>
	/// <param name="keyword"></param>
	/// <param name="ids"></param>
	/// <returns>Instance of type IToolboxSearchAlgorithmResult</returns>
	IToolboxSearchAlgorithmResult Create(string algorithmName, string keyword, long[] ids);

	/// <summary>
	/// Get an instance of <seealso cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmResult" /> by algorithm Id and keyword.
	/// </summary>
	/// <param name="algorithmId"></param>
	/// <param name="keyword"></param>
	/// <returns>Instance of type IToolboxSearchAlgorithmResult</returns>
	IToolboxSearchAlgorithmResult GetByAlgorithmIdAndKeyword(int algorithmId, string keyword);
}
