namespace Roblox.Platform.Studio;

/// <summary>
/// Provides a common interface for ToolboxSearchAlgorithm.
/// </summary>
public interface IToolboxSearchAlgorithm
{
	/// <summary>
	/// Get the Id.
	/// </summary>
	int Id { get; }

	/// <summary>
	/// Get the name of alorithm.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Get the description of algorithm.
	/// </summary>
	string Description { get; }
}
