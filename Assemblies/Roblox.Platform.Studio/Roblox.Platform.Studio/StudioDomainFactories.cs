using Roblox.EventLog;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

/// <summary>
/// Represents an object that contains the factories of the studio search algorithm domain.
/// </summary>
public class StudioDomainFactories : DomainFactoriesBase
{
	internal virtual IToolboxSearchAlgorithmEntityFactory ToolboxSearchAlgorithmEntityFactory { get; }

	internal virtual IToolboxSearchAlgorithmResultEntityFactory ToolboxSearchAlgorithmResultEntityFactory { get; }

	internal virtual IAssetSearchKeywordStatisticEntityFactory AssetSearchKeywordStatisticEntityFactory { get; }

	/// <summary>
	/// Provbides factory instance to access methods to insert and get an instance of <seealso cref="T:Roblox.Platform.Studio.AssetSearchKeywordStatistic" />  
	/// </summary>
	public virtual IAssetSearchKeywordStatisticFactory AssetSearchKeywordStatisticFactory { get; }

	/// <summary>
	/// Provbides factory instance to access methods related to merging and sorting of assets list.
	/// </summary>
	public virtual IStudioSearchAssetsSortFactory StudioSearchAssetsSortFactory { get; }

	/// <summary>
	/// Provides factory instance to access methods to insert and get an instance of <seealso cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithm" />
	/// </summary>
	public virtual IToolboxSearchAlgorithmFactory ToolboxSearchAlgorithmFactory { get; }

	/// <summary>
	/// Provides factory instance to access methods to insert and get an instance of <seealso cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmResult" />
	/// </summary>
	public virtual IToolboxSearchAlgorithmResultFactory ToolboxSearchAlgorithmResultFactory { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Studio.StudioDomainFactories" /> class.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" /> that the factories should use to log issues.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="logger" />
	/// </exception>
	public StudioDomainFactories(ILogger logger)
	{
		if (logger == null)
		{
			throw new PlatformArgumentNullException("logger");
		}
		ToolboxSearchAlgorithmEntityFactory = new ToolboxSearchAlgorithmEntityFactory(this);
		ToolboxSearchAlgorithmResultEntityFactory = new ToolboxSearchAlgorithmResultEntityFactory(this);
		AssetSearchKeywordStatisticEntityFactory = new AssetSearchKeywordStatisticEntityFactory(this);
		AssetSearchKeywordStatisticFactory = new AssetSearchKeywordStatisticFactory(this);
		StudioSearchAssetsSortFactory = new StudioSearchAssetsSortFactory(this);
		ToolboxSearchAlgorithmFactory = new ToolboxSearchAlgorithmFactory(this);
		ToolboxSearchAlgorithmResultFactory = new ToolboxSearchAlgorithmResultFactory(this);
	}
}
