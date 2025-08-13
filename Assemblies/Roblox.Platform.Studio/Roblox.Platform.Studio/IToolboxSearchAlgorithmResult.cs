namespace Roblox.Platform.Studio;

/// <summary>
/// Provides a common interface for ToolboxSearchAlgorithmResult.
/// </summary>
public interface IToolboxSearchAlgorithmResult
{
	/// <summary>
	/// Get the Id.
	/// </summary>
	long Id { get; }

	/// <summary>
	/// Get the AlgorithmId.
	/// </summary>
	int AlgorithmId { get; }

	/// <summary>
	/// Get the Keyword.
	/// </summary>
	string Keyword { get; }

	/// <summary>
	/// Get the Results.
	/// </summary>
	long[] Results { get; }
}
